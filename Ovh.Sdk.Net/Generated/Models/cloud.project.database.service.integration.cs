//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_service_integration {
    
    
    // Id: StatusEnum Namespace: cloud.project.database.service.integration
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
    }
    
    // Id: TypeEnum Namespace: cloud.project.database.service.integration
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grafanaDashboard")]
        grafanaDashboard,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grafanaDatasource")]
        grafanaDatasource,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kafkaConnect")]
        kafkaConnect,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kafkaLogs")]
        kafkaLogs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kafkaMirrorMaker")]
        kafkaMirrorMaker,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("m3aggregator")]
        m3aggregator,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("m3dbMetrics")]
        m3dbMetrics,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("opensearchLogs")]
        opensearchLogs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("postgresqlMetrics")]
        postgresqlMetrics,
    }
}
