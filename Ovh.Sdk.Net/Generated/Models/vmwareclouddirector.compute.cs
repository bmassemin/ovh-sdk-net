//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vmwareCloudDirector_compute {
    
    
    // Id: CurrentState Namespace: vmwareCloudDirector.compute
    public class CurrentState {
        
        // Key: billingType Type: vmwareCloudDirector.BillingTypeEnum FullType: vmwareCloudDirector.BillingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingType")]
        public required _vmwareCloudDirector.BillingTypeEnum BillingType { get; set; }//;
        
        // Key: memoryQuota Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memoryQuota")]
        public required System.Int64 MemoryQuota { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: profile Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("profile")]
        public required System.String Profile { get; set; }//;
        
        // Key: vCPUCount Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vCPUCount")]
        public required System.Int64 VCPUCount { get; set; }//;
    }
}
