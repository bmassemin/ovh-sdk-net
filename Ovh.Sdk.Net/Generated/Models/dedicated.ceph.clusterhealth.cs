//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _dedicated_ceph_clusterHealth {
    
    
    // Id: response Namespace: dedicated.ceph.clusterHealth
    public class response {
        
        // Key: availableBytes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableBytes")]
        public required System.Int64 AvailableBytes { get; set; }//;
        
        // Key: healthy Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("healthy")]
        public required System.Boolean Healthy { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: status Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required System.String Status { get; set; }//;
        
        // Key: totalBytes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalBytes")]
        public required System.Int64 TotalBytes { get; set; }//;
        
        // Key: usedBytes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usedBytes")]
        public required System.Int64 UsedBytes { get; set; }//;
    }
}
