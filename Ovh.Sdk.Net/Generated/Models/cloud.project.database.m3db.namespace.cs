//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_m3db_namespace {
    
    
    // Id: Retention Namespace: cloud.project.database.m3db.namespace
    public class Retention {
        
        // Key: blockDataExpirationDuration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blockDataExpirationDuration")]
        public System.TimeSpan? BlockDataExpirationDuration { get; set; }//;
        
        // Key: blockSizeDuration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blockSizeDuration")]
        public System.TimeSpan? BlockSizeDuration { get; set; }//;
        
        // Key: bufferFutureDuration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bufferFutureDuration")]
        public System.TimeSpan? BufferFutureDuration { get; set; }//;
        
        // Key: bufferPastDuration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bufferPastDuration")]
        public System.TimeSpan? BufferPastDuration { get; set; }//;
        
        // Key: periodDuration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodDuration")]
        public required System.TimeSpan PeriodDuration { get; set; }//;
    }
    
    // Id: TypeEnum Namespace: cloud.project.database.m3db.namespace
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("aggregated")]
        aggregated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unaggregated")]
        unaggregated,
    }
}
