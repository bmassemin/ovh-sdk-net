//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_capabilities_integration {
    
    
    // Id: Parameter Namespace: cloud.project.database.capabilities.integration
    public class Parameter {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: type Type: cloud.project.database.capabilities.integration.parameter.TypeEnum FullType: cloud.project.database.capabilities.integration.parameter.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _cloud_project_database_capabilities_integration_parameter.TypeEnum Type { get; set; }//;
    }
}
