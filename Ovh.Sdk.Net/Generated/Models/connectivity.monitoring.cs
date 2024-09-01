//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _connectivity_monitoring {
    
    
    // Id: GenericIncident Namespace: connectivity.monitoring
    public class GenericIncident {
        
        // Key: comment Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comment")]
        public System.String? Comment { get; set; }//;
        
        // Key: creationDate Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.String CreationDate { get; set; }//;
        
        // Key: default Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public System.String? @default { get; set; }//;
        
        // Key: departments Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("departments")]
        public required System.String[] Departments { get; set; }//;
        
        // Key: endDate Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.String? EndDate { get; set; }//;
        
        // Key: estimatedResolutionDate Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("estimatedResolutionDate")]
        public System.String? EstimatedResolutionDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: isNational Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isNational")]
        public System.Boolean? IsNational { get; set; }//;
        
        // Key: nature Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nature")]
        public System.String? Nature { get; set; }//;
        
        // Key: nra Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nra")]
        public required System.String[] Nra { get; set; }//;
        
        // Key: operators Type: connectivity.OperatorEnum[] FullType: connectivity.OperatorEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operators")]
        public required _connectivity.OperatorEnum[] Operators { get; set; }//;
        
        // Key: status Type: connectivity.monitoring.GenericIncidentStatusEnum FullType: connectivity.monitoring.GenericIncidentStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _connectivity_monitoring.GenericIncidentStatusEnum Status { get; set; }//;
        
        // Key: taskId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskId")]
        public System.Int64? TaskId { get; set; }//;
        
        // Key: taskReference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskReference")]
        public System.String? TaskReference { get; set; }//;
        
        // Key: technologies Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("technologies")]
        public required System.String[] Technologies { get; set; }//;
    }
    
    // Id: GenericIncidentStatusEnum Namespace: connectivity.monitoring
    public enum GenericIncidentStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("closed")]
        closed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("detected")]
        detected,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validated")]
        validated,
    }
}
