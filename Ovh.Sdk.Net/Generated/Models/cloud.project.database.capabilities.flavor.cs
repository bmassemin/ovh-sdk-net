//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_database_capabilities_flavor {
    
    
    // Id: Specifications Namespace: cloud.project.database.capabilities.flavor
    public class Specifications {
        
        // Key: core Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("core")]
        public long Core { get; set; }//;
        
        // Key: memory Type: complexType.UnitAndValue<long> FullType: complexType.UnitAndValue<long>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memory")]
        public _complexType.UnitAndValue<long> Memory { get; set; }//;
        
        // Key: storage Type: complexType.UnitAndValue<long> FullType: complexType.UnitAndValue<long>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public _complexType.UnitAndValue<long> Storage { get; set; }//;
    }
}
