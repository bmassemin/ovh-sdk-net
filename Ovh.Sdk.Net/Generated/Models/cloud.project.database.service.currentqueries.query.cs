//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_service_currentqueries_query {
    
    
    // Id: CancelRequest Namespace: cloud.project.database.service.currentqueries.query
    public class CancelRequest {
        
        // Key: pid Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pid")]
        public required System.Int64 Pid { get; set; }//;
        
        // Key: terminate Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("terminate")]
        public required System.Boolean Terminate { get; set; }//;
    }
    
    // Id: CancelResponse Namespace: cloud.project.database.service.currentqueries.query
    public class CancelResponse {
        
        // Key: success Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("success")]
        public required System.Boolean Success { get; set; }//;
    }
}
