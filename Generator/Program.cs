using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Generator;
using Generator.Schemas;
using Microsoft.CSharp;

string[] reservedKeywords =
[
    "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const",
    "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern",
    "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface",
    "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
    "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
    "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint",
    "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while"
];

var service = new Service(new Client(new HttpClient
{
    BaseAddress = new Uri("https://api.ovh.com")
}));

const string rootPath = @"..\..\..\..\Ovh.Sdk.Net\Generated";
if (Directory.Exists(rootPath))
    Directory.Delete(rootPath, true);
Directory.CreateDirectory(rootPath);
Directory.CreateDirectory(Path.Combine(rootPath, "Models"));

var definitions = await service.GetApiDefinitionsAsync();

var namespaces = new Dictionary<string, CodeNamespace>();
var duplicates = new HashSet<string>();
var types = new Dictionary<string, (string ns, string type)>();

foreach (var apis in definitions)
{
    foreach (var pair in apis.Models)
    {
        var model = pair.Value;
        var fullName = pair.Key;
        var ns = model.Namespace;
        var typeName = fullName.Substring(ns.Length + 1);
        if (string.IsNullOrEmpty(typeName))
            typeName = fullName;
        if (pair.Key.Contains("<") && !pair.Key.Contains("<T>"))
            continue;
        var cleanNamespace = CleanNamespace(ns);
        var name = CleanModelId(typeName);
        types[fullName] = (cleanNamespace, name);
    }
}

foreach (var apis in definitions)
{
    foreach (var pair in apis.Models)
    {
        var model = pair.Value;
        var fullName = pair.Key;
        var ns = model.Namespace;
        var typeName = fullName.Substring(ns.Length + 1);

        if (string.IsNullOrEmpty(typeName))
            typeName = fullName;

        if (pair.Key.Contains("<") && !pair.Key.Contains("<T>"))
            continue;

        if (!duplicates.Add(pair.Key))
            continue;

        var cleanNamespace = CleanNamespace(ns);
        if (!namespaces.TryGetValue(ns, out var codeNs))
        {
            codeNs = new CodeNamespace(cleanNamespace);
            namespaces[ns] = codeNs;
        }

        var name = CleanModelId(typeName);

        if (model.EnumType == null)
        {
            var code = GenerateClass(model, name);
            codeNs.Types.Add(code);
        }
        else
        {
            var code = GenerateEnum(model, name);
            codeNs.Types.Add(code);
        }
    }
}

foreach (var codeNamespace in namespaces)
{
    var modelUnit = new CodeCompileUnit();
    modelUnit.Namespaces.Add(codeNamespace.Value);
    var modelProvider = new CSharpCodeProvider();
    var path = codeNamespace.Key;
    var fullPath = Path.Combine(rootPath, "Models", path);
    await using StreamWriter swModel = new StreamWriter($"{fullPath}.cs", true);
    modelProvider.GenerateCodeFromCompileUnit(modelUnit, swModel, new CodeGeneratorOptions());
}

var methodUnit = new CodeCompileUnit();
var methodNamespace = new CodeNamespace("Ovh.Sdk.Net.Client");
methodUnit.Namespaces.Add(methodNamespace);
var clientClass = new CodeTypeDeclaration("Client")
{
    IsClass = true,
    TypeAttributes = TypeAttributes.Public,
};
methodNamespace.Types.Add(clientClass);

foreach (var apis in definitions)
{
    foreach (var api in apis.Apis)
    {
        var path = GetMethodName(api.Path);
        foreach (var operation in api.Operations)
        {
            var code = new CodeMemberMethod
            {
                Name = operation.HttpMethod.ToLower().FirstCharToUpper() + path,
                Comments = { new CodeCommentStatement($"Path: {api.Path}") }
            };
            if (operation.ResponseType != null && operation.ResponseType != "void")
            {
                code.ReturnType = new CodeTypeReference("Task<" + GetCodeType(operation.ResponseType) + ">");
                var returnStatement = new CodeMethodReturnStatement(new CodeDefaultValueExpression(code.ReturnType));
                code.Statements.Add(returnStatement);
            }

            clientClass.Members.Add(code);
        }
    }
}

var methodProvider = new CSharpCodeProvider();
var methodPath = Path.Combine(rootPath, "Client");
await using StreamWriter swMethod = new StreamWriter($"{methodPath}.cs", true);
methodProvider.GenerateCodeFromCompileUnit(methodUnit, swMethod, new CodeGeneratorOptions());

string GetMethodName(string value)
{
    return string.Join("", value.Replace("{", "").Replace("}", "").Split("/", StringSplitOptions.RemoveEmptyEntries).Select(x => x.FirstCharToUpper())) + "Async";
}

string CleanNamespace(string value)
{
    var split = value.Split('.');
    for (var i = 0; i < split.Length; i++)
    {
        var s = split[i];
        if (char.IsDigit(s[0]))
            s = $"_{s}";
        split[i] = s;
    }

    return "_" + string.Join("_", split);
}

string CleanModelId(string value)
{
    return value
        .Replace(".", "_");
}

CodeTypeDeclaration GenerateClass(Model model, string className)
{
    var klass = new CodeTypeDeclaration(className)
    {
        IsClass = true,
        Comments = { new CodeCommentStatement($"Id: {model.Id} Namespace: {model.Namespace}") },
    };

    foreach (var prop in model.Properties!)
    {
        var type = GetCodeType(prop.Value.Type);

        var prefix = prop.Key.Equals(className, StringComparison.InvariantCultureIgnoreCase);
        var fieldName = CleanFieldName(prop.Key, prefix);

        var property = new CodeMemberField
        {
            Type = new CodeTypeReference(type),
            Name = fieldName + " { get; set; }//",
            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
            Attributes = MemberAttributes.Public | MemberAttributes.Final,
            Comments = { new CodeCommentStatement($"Key: {prop.Key} Type: {prop.Value.Type} FullType: {prop.Value.FullType}") },
        };
        property.CustomAttributes.Add(
            new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(JsonPropertyNameAttribute)),
                new CodeAttributeArgument(new CodePrimitiveExpression(prop.Key))
            )
        );
        klass.Members.Add(property);
    }

    return klass;
}

string GetCodeType(string strType)
{
    var match = Regex.Match(strType, @"map\[(.*)\](.*)");
    if (match.Success)
    {
        var type1 = CleanType(match.Groups[1].Value);
        var type2 = CleanType(match.Groups[2].Value);
        return $"Dictionary<{type1}, {type2}>";
    }

    return strType switch
    {
        "email.domain.DomainDiagnoseTraceStruct<email.domain.DomainDiagnoseResultEnum>[]" => "_email_domain.DomainDiagnoseTraceStruct<_email_domain.DomainDiagnoseResultEnum>[]",
        "coreTypes.AccountId:string" => typeof(string).FullName,
        "string" => typeof(string).FullName,
        "long" => typeof(long).FullName,
        "boolean" => typeof(bool).FullName,
        "date" => typeof(DateOnly).FullName,
        "date[]" => typeof(DateOnly[]).FullName,
        "datetime" => typeof(DateTime).FullName,
        "datetime[]" => typeof(DateTime[]).FullName,
        "time" => typeof(TimeOnly).FullName,
        "long[]" => typeof(long[]).FullName,
        "uuid" => typeof(Guid).FullName,
        "uuid[]" => typeof(Guid[]).FullName,
        "map[string]string" => typeof(Dictionary<string, string>).FullName,
        "map[string]long" => typeof(Dictionary<string, long>).FullName,
        "ipBlock" => typeof(IPNetwork).FullName,
        "ipBlock[]" => typeof(IPNetwork[]).FullName,
        "password" => typeof(string).FullName,
        "string[]" => typeof(string[]).FullName,
        "ipv4" => typeof(IPAddress).FullName,
        "ipv4[]" => typeof(IPAddress[]).FullName,
        "ipv6" => typeof(IPAddress).FullName,
        "ipv6[]" => typeof(IPAddress[]).FullName,
        "ipv4Block" => typeof(IPNetwork).FullName,
        "ipv4Block[]" => typeof(IPNetwork[]).FullName,
        "ipv6Block" => typeof(IPNetwork).FullName,
        "ipv6Block[]" => typeof(IPNetwork[]).FullName,
        "text" => typeof(string).FullName,
        "ip" => typeof(IPAddress).FullName,
        "ip[]" => typeof(IPAddress[]).FullName,
        "duration" => typeof(TimeSpan).FullName,
        "duration[]" => typeof(TimeSpan[]).FullName,
        "double" => typeof(double).FullName,
        "double[]" => typeof(double[]).FullName,
        "T" => "T",
        "T[]" => "T[]",
        "macAddress" => typeof(PhysicalAddress).FullName,
        "macAddress[]" => typeof(PhysicalAddress[]).FullName,
        "phoneNumber" => typeof(string).FullName,
        "phoneNumber[]" => typeof(string[]).FullName,
        "internationalPhoneNumber" => typeof(string).FullName,
        "internationalPhoneNumber[]" => typeof(string[]).FullName,
        _ => CleanType(strType)
    };
}

string CleanType(string value)
{
    if (value == "string")
        return "string";
    if (value == "long")
        return "long";
    if (value == "double")
        return "double";

    string type = value;
    var array = value.EndsWith("[]");
    if (array)
        type = value[..^2];
    var genPos = value.IndexOf('<');
    if (genPos > 0)
        type = value[..genPos] + "<T>";

    if (!types.TryGetValue(type, out (string ns, string type) tuple))
        throw new Exception("Unknown type");

    var temp = $"{tuple.ns}.{tuple.type}";
    if (genPos > 0 && array)
        temp = temp.Replace("<T>", "<" + CleanType(value[++genPos..^3]) + ">");
    else if (genPos > 0)
        temp = temp.Replace("<T>", "<" + CleanType(value[++genPos..^1]) + ">");
    else if (array)
        temp += "[]";

    return temp;
}

string CleanFieldName(string value, bool prefix)
{
    if (char.IsDigit(value[0]))
        return $"_{value}";

    if (reservedKeywords.Contains(value))
        return "@" + value;

    var result = value.FirstCharToUpper();
    if (prefix)
        result = "_" + result;

    return result.Replace("-", "_");
}

CodeTypeDeclaration GenerateEnum(Model model, string enumName)
{
    var @enum = new CodeTypeDeclaration(enumName)
    {
        IsEnum = true,
        Comments = { new CodeCommentStatement($"Id: {model.Id} Namespace: {model.Namespace}") }
    };

    foreach (var jsonValue in model.Enum!)
    {
        CodeMemberField field;
        switch (model.EnumType)
        {
            case "string":
            {
                if (!jsonValue.TryGetValue(out string? value))
                    throw new Exception("Enum value is missing");

                var cleanedValue = string.IsNullOrWhiteSpace(value) ? "_Empty" : CleanEnumValue(value);
                field = new CodeMemberField(typeof(int), cleanedValue);
                field.CustomAttributes.Add(
                    new CodeAttributeDeclaration(
                        new CodeTypeReference(typeof(JsonPropertyNameAttribute)),
                        new CodeAttributeArgument(new CodePrimitiveExpression(value))
                    )
                );
                break;
            }
            case "long" when jsonValue.TryGetValue(out string? strValue):
            {
                var value = long.Parse(strValue);
                field = new CodeMemberField(typeof(int), $"_{value} = {value}");
                break;
            }
            case "long" when jsonValue.TryGetValue(out long longValue):
                field = new CodeMemberField(typeof(int), $"_{longValue} = {longValue}");
                break;
            default:
                throw new Exception("Unknown enum type");
        }

        @enum.Members.Add(field);
    }

    return @enum;
}

string CleanEnumValue(string? value)
{
    if (char.IsDigit(value![0]))
        value = $"_{value}";

    return value
        .Replace("+", "_plus_")
        .Replace("-", "_")
        .Replace(":", "_")
        .Replace("/", "_")
        .Replace(".", "_")
        .Replace(" ", "_")
        .Replace("#", "_pound_sign_")
        .Replace("*", "_star_")
        .Replace("(", "_")
        .Replace(")", "_")
        .Replace("&", "_and_")
        .Replace("[]", "_array_");
}