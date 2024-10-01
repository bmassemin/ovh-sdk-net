using System.CodeDom;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
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
var mapRegex = new Regex(@"map\[(.*?)\](.*)");

var service = new Service(new Client(new HttpClient
{
    BaseAddress = new Uri("https://api.ovh.com")
}));


string rootPath;
if (Debugger.IsAttached)
{
    rootPath = Path.Combine("..", "..", "..", "..", "Ovh.Sdk.Net", "Generated");
}
else
{
    rootPath = Path.Combine("Ovh.Sdk.Net", "Generated");
}

if (Directory.Exists(rootPath))
    Directory.Delete(rootPath, true);
Directory.CreateDirectory(rootPath);
Directory.CreateDirectory(Path.Combine(rootPath, "Models"));

var definitions = await service.GetApiDefinitionsAsync("v1");
definitions = definitions.Concat(await service.GetApiDefinitionsAsync("v2")).ToList();

var namespaces = new Dictionary<string, CodeNamespace>();
var duplicates = new HashSet<string>();
var types = new Dictionary<string, (string ns, string type)>();

foreach (var apis in definitions)
foreach (var pair in apis.Models)
{
    var model = pair.Value;
    var fullName = pair.Key;
    var ns = model.Namespace;
    var typeName = fullName.Substring(ns.Length + 1);
    if (string.IsNullOrEmpty(typeName))
        typeName = fullName;
    if (pair.Key.Contains('<') && !pair.Key.Contains("<T>"))
        continue;
    var cleanNamespace = CleanNamespace(ns);
    var name = CleanModelId(typeName);
    types[fullName] = (cleanNamespace, name);
}

foreach (var apis in definitions)
foreach (var pair in apis.Models)
{
    var model = pair.Value;
    var fullName = pair.Key;
    var ns = model.Namespace;
    var typeName = fullName.Substring(ns.Length + 1);

    if (string.IsNullOrEmpty(typeName))
        typeName = fullName;

    if (pair.Key.Contains('<') && !pair.Key.Contains("<T>"))
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

foreach (var codeNamespace in namespaces)
{
    var modelUnit = new CodeCompileUnit();
    modelUnit.Namespaces.Add(codeNamespace.Value);
    var modelProvider = new CSharpCodeProvider();
    var path = codeNamespace.Key;
    var fullPath = Path.Combine(rootPath, "Models", path.ToLower());
    await using (var swModel = new StreamWriter($"{fullPath}.cs", true))
    {
        modelProvider.GenerateCodeFromCompileUnit(modelUnit, swModel, new CodeGeneratorOptions());
    }

    var content = await File.ReadAllTextAsync($"{fullPath}.cs");
    content = content.Replace("namespace _", $"#nullable enable{Environment.NewLine}namespace _");
    while (true)
    {
        try
        {
            await File.WriteAllTextAsync($"{fullPath}.cs", content);
            break;
        }
        catch
        {
            await Task.Delay(100);
        }
    }
}

var methodUnit = new CodeCompileUnit();
var methodNamespace = new CodeNamespace("Ovh.Sdk.Net");
methodNamespace.Imports.Add(new CodeNamespaceImport("System.Net.Http"));
methodNamespace.Imports.Add(new CodeNamespaceImport("System.Net.Http.Json"));
methodUnit.Namespaces.Add(methodNamespace);
var clientClass = new CodeTypeDeclaration("Client")
{
    IsClass = true,
    IsPartial = true,
    TypeAttributes = TypeAttributes.Public
};
methodNamespace.Types.Add(clientClass);

foreach (var apis in definitions.Where(x => x.Apis != null))
foreach (var api in apis.Apis!)
{
    var path = GetMethodName("/" + apis.ApiVersion + api.Path);
    foreach (var operation in api.Operations)
    {
        string innerCodeType = null!;
        var code = new CodeMemberMethod
        {
            Name = operation.HttpMethod.ToLower().FirstCharToUpper() + path,
            Comments = { new CodeCommentStatement($"Path: {"/" + apis.ApiVersion + api.Path}") },
            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
            Attributes = MemberAttributes.Public | MemberAttributes.Final
        };
        var nonVoid = operation.ResponseType != null && operation.ResponseType != "void";
        if (nonVoid)
        {
            innerCodeType = GetCodeType(operation.ResponseType!);
            code.ReturnType = new CodeTypeReference("Task<" + innerCodeType + ">");
        }
        else
        {
            code.ReturnType = new CodeTypeReference("Task");
        }

        const string objectBodyParamName = "_body";
        const string objectHeadersParamName = "headers";

        foreach (var parameter in operation.Parameters.OrderBy(x => !x.Required))
        {
            var paramName = parameter.Name ?? objectBodyParamName;
            var param = new CodeParameterDeclarationExpression(GetCodeType(parameter.DataType) + (parameter.Required ? "" : "?"), CleanParamName(paramName));
            if (!parameter.Required)
            {
                param.CustomAttributes.Add(new CodeAttributeDeclaration(new CodeTypeReference(typeof(OptionalAttribute))));
            }

            code.Parameters.Add(param);
        }

        var finalPath = "/" + apis.ApiVersion + api.Path;
        var queryParameters = operation.Parameters.Where(x => x.ParamType == "query").ToArray();
        if (queryParameters.Length > 0)
        {
            finalPath += "{queryParameters}";
            code.Statements.AddRange(ParametersToMap(operation.Parameters.Where(x => x.ParamType == "query").Select(x => x).ToArray(), "queryParameters", "CreateQueryParams"));
        }

        CodeExpression bodyParam = new CodePrimitiveExpression(null);
        if (operation.Parameters.Any(x => x.ParamType == "body" && x.Name == null))
        {
            bodyParam = new CodeVariableReferenceExpression(objectBodyParamName);
        }
        else if (operation.Parameters.Any(x => x.ParamType == "body"))
        {
            var bodyParameters = operation.Parameters.Where(x => x.ParamType == "body").Select(x => (x.Name!, CleanParamName(x.Name!))).ToList();
            var bodyDic = CreateDictionary(objectBodyParamName, bodyParameters);
            code.Statements.AddRange(bodyDic);
            bodyParam = new CodeVariableReferenceExpression(objectBodyParamName);
        }

        CodeExpression headersParam = new CodePrimitiveExpression(null);
        if (operation.Parameters.Any(x => x.ParamType == "header"))
        {
            code.Statements.AddRange(ParametersToMap(operation.Parameters.Where(x => x.ParamType == "header").Select(x => x).ToArray(), objectHeadersParamName, "CreateHeaders"));
            headersParam = new CodeVariableReferenceExpression(objectHeadersParamName);
        }

        code.Statements.Add(new CodeVariableDeclarationStatement(typeof(string), "uri", new CodeSnippetExpression("$\"" + finalPath + "\"")));

        var parameters = new List<CodeExpression>
        {
            new CodePrimitiveExpression(operation.HttpMethod),
            new CodeVariableReferenceExpression("uri"),
            headersParam,
            bodyParam,
            new CodePrimitiveExpression(!operation.NoAuthentication)
        };

        CodeMethodReferenceExpression methodRef;

        if (nonVoid)
            methodRef = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "SendAsync", new CodeTypeReference(innerCodeType));
        else
            methodRef = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "SendAsync");

        var call = new CodeMethodInvokeExpression(
            methodRef,
            parameters.ToArray()
        );
        code.Statements.Add(new CodeMethodReturnStatement(call));


        clientClass.Members.Add(code);
    }
}

var methodProvider = new CSharpCodeProvider();
var methodPath = Path.Combine(rootPath, "Client");
await using (var swMethod = new StreamWriter($"{methodPath}.cs", true))
{
    methodProvider.GenerateCodeFromCompileUnit(methodUnit, swMethod, new CodeGeneratorOptions());
}

var clientContent = await File.ReadAllTextAsync($"{methodPath}.cs");
clientContent = clientContent.Replace("namespace Ovh.Sdk.Net", $"#nullable enable{Environment.NewLine}namespace Ovh.Sdk.Net");
while (true)
{
    try
    {
        await File.WriteAllTextAsync($"{methodPath}.cs", clientContent);
        break;
    }
    catch
    {
        await Task.Delay(100);
    }
}

CodeStatement[] ParametersToMap(Parameter[] parameters, string varName, string methodName)
{
    var statements = new List<CodeStatement>();
    var values = parameters.Select(x => (x.Name!, CleanParamName(x.Name!))).ToList();
    var dictionary = CreateDictionary(varName + "Temp", values);
    statements.AddRange(dictionary);

    var methodInvoke =
        new CodeMethodInvokeExpression(new CodeThisReferenceExpression(), methodName, new CodeVariableReferenceExpression(varName + "Temp"));

    var queryParametersVariable = new CodeVariableDeclarationStatement(
        new CodeTypeReference("var"),
        varName,
        methodInvoke
    );
    statements.Add(queryParametersVariable);

    return statements.ToArray();
}

CodeStatement[] CreateDictionary(string varName, List<(string keyName, string varRef)> values)
{
    var statements = new List<CodeStatement>();
    var createDictionary = new CodeObjectCreateExpression(
        new CodeTypeReference(typeof(Dictionary<string, object>))
    );
    var dictionaryVariable = new CodeVariableDeclarationStatement(
        new CodeTypeReference("Dictionary", new CodeTypeReference("System.String"), new CodeTypeReference("System.Object")),
        varName,
        createDictionary
    );
    statements.Add(dictionaryVariable);
    foreach (var parameter in values)
    {
        var add = new CodeMethodInvokeExpression(
            new CodeVariableReferenceExpression(varName),
            "Add", new CodePrimitiveExpression(parameter.keyName), new CodeVariableReferenceExpression(parameter.varRef));
        statements.Add(new CodeExpressionStatement(add));
    }

    return statements.ToArray();
}

string CleanParamName(string value)
{
    var split = value.Split('.');
    return split[0].Replace("-", "_") + string.Join("", split[1..].Select(x => x.FirstCharToUpper()));
}

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
        Comments = { new CodeCommentStatement($"Id: {model.Id} Namespace: {model.Namespace}") }
    };

    foreach (var prop in model.Properties!)
    {
        var type = GetCodeType(prop.Value.Type);
        if (prop.Value.CanBeNull)
            type += "?";
        else
            type = $"required {type}";

        var prefix = prop.Key.Equals(className, StringComparison.InvariantCultureIgnoreCase);
        var fieldName = CleanFieldName(prop.Key, prefix);

        var property = new CodeMemberField
        {
            Type = new CodeTypeReference(type),
            Name = fieldName + " { get; set; }//",
            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
            Attributes = MemberAttributes.Public | MemberAttributes.Final,
            Comments = { new CodeCommentStatement($"Key: {prop.Key} Type: {prop.Value.Type} FullType: {prop.Value.FullType}") }
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
    var match = mapRegex.Match(strType);
    if (match.Success)
    {
        var type1 = CleanType(match.Groups[1].Value);
        var type2 = CleanType(match.Groups[2].Value);
        return $"Dictionary<{type1}, {type2}>";
    }

    return (strType switch
    {
        "email.domain.DomainDiagnoseTraceStruct<email.domain.DomainDiagnoseResultEnum>[]" => "_email_domain.DomainDiagnoseTraceStruct<_email_domain.DomainDiagnoseResultEnum>[]",
        "coreTypes.AccountId:string" => typeof(string).FullName,
        "string" => typeof(string).FullName,
        "long" => typeof(long).FullName,
        "boolean" => typeof(bool).FullName,
        "boolean[]" => typeof(bool[]).FullName,
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
        "ipBlock" => typeof(string).FullName,
        "ipBlock[]" => typeof(string[]).FullName,
        "password" => typeof(string).FullName,
        "string[]" => typeof(string[]).FullName,
        "ipv4" => typeof(string).FullName,
        "ipv4[]" => typeof(string[]).FullName,
        "ipv6" => typeof(string).FullName,
        "ipv6[]" => typeof(string[]).FullName,
        "ipv4Block" => typeof(string).FullName,
        "ipv4Block[]" => typeof(string[]).FullName,
        "ipv6Block" => typeof(string).FullName,
        "ipv6Block[]" => typeof(string[]).FullName,
        "text" => typeof(string).FullName,
        "ip" => typeof(string).FullName,
        "ip[]" => typeof(string[]).FullName,
        "duration" => typeof(TimeSpan).FullName,
        "duration[]" => typeof(TimeSpan[]).FullName,
        "double" => typeof(double).FullName,
        "double[]" => typeof(double[]).FullName,
        "T" => "T",
        "T[]" => "T[]",
        "macAddress" => typeof(string).FullName,
        "macAddress[]" => typeof(string[]).FullName,
        "phoneNumber" => typeof(string).FullName,
        "phoneNumber[]" => typeof(string[]).FullName,
        "internationalPhoneNumber" => typeof(string).FullName,
        "internationalPhoneNumber[]" => typeof(string[]).FullName,
        _ => CleanType(strType)
    })!;
}

string CleanType(string value)
{
    if (value == "string")
        return "string";
    if (value == "long")
        return "long";
    if (value == "double")
        return "double";

    var type = value;
    var array = value.EndsWith("[]");
    if (array)
        type = value[..^2];
    var golangArray = value.StartsWith("[]");
    if (golangArray)
    {
        type = value[2..];
        array = true;
    }

    var genPos = value.IndexOf('<');
    if (genPos > 0)
        type = value[..genPos] + "<T>";

    if (!types.TryGetValue(type, out var tuple))
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