using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Generator.Schemas
{
    public class ApiGroups
    {
        public required ApiGroup[] Apis { get; set; }
        public required string BasePath { get; set; }
    }

    public class ApiGroup
    {
        public required string Path { get; set; }
        public required string Schema { get; set; }
        public required Format[] Format { get; set; }
        public required string Description { get; set; }
    }

    public enum Format
    {
        Json,
        Yaml
    }

    public class ApiDescription
    {
        public required string Path { get; set; }
        public required string Description { get; set; }
        public required Operation[] Operations { get; set; }
    }

    public class ApiStatus
    {
        public string Description { get; set; }
        public string Value { get; set; }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string ParamType { get; set; }
        public string FullType { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }
    }

    public class Operation
    {
        public ApiStatus ApiStatus { get; set; }
        public string HttpMethod { get; set; }
        public Parameter[] Parameters { get; set; }
        public string? ResponseType { get; set; }
        public bool NoAuthentication { get; set; }
        public string Description { get; set; }
    }

    public class Property
    {
        public string Type { get; set; }
        public string FullType { get; set; }
        public bool CanBeNull { get; set; }
        public bool ReadOnly { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
    }

    public class Model
    {
        public string Id { get; set; }
        public string Namespace { get; set; }
        public string Description { get; set; }
        public JsonValue[]? Enum { get; set; }
        public string? EnumType { get; set; }
        public Dictionary<string, Property>? Properties { get; set; }
        public string[]? Generics { get; set; }
    }

    public class ApiList
    {
        public string ApiVersion { get; set; }
        public ApiDescription[] Apis { get; set; }
        public string ResourcePath { get; set; }
        public Dictionary<string, Model> Models { get; set; }
    }

    public class ApiMerged
    {
        public ApiDescription[] Apis { get; set; }
        public Dictionary<string, Model> Models { get; set; }
    }
}