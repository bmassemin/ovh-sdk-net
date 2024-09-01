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
        public required string Description { get; set; }
        public required string Value { get; set; }
    }

    public class Parameter
    {
        public string? Name { get; set; }
        public required string DataType { get; set; }
        public required string ParamType { get; set; }
        public string? FullType { get; set; }
        public bool Required { get; set; }
        public required string Description { get; set; }
    }

    public class Operation
    {
        public required ApiStatus ApiStatus { get; set; }
        public required string HttpMethod { get; set; }
        public required Parameter[] Parameters { get; set; }
        public string? ResponseType { get; set; }
        public bool NoAuthentication { get; set; }
        public string? Description { get; set; }
    }

    public class Property
    {
        public required string Type { get; set; }
        public string? FullType { get; set; }
        public bool CanBeNull { get; set; }
        public bool ReadOnly { get; set; }
        public string? Description { get; set; }
        public bool Required { get; set; }
    }

    public class Model
    {
        public required string Id { get; set; }
        public required string Namespace { get; set; }
        public string? Description { get; set; }
        public JsonValue[]? Enum { get; set; }
        public string? EnumType { get; set; }
        public Dictionary<string, Property>? Properties { get; set; }
        public string[]? Generics { get; set; }
    }

    public class ApiList
    {
        public required string ApiVersion { get; set; }
        public ApiDescription[]? Apis { get; set; }
        public required string ResourcePath { get; set; }
        public required Dictionary<string, Model> Models { get; set; }
    }
}