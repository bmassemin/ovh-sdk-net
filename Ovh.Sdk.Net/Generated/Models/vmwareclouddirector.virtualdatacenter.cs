//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vmwareCloudDirector_virtualDataCenter {
    
    
    // Id: CurrentState Namespace: vmwareCloudDirector.virtualDataCenter
    public class CurrentState {
        
        // Key: commercialRange Type: vmwareCloudDirector.CommercialRangeEnum FullType: vmwareCloudDirector.CommercialRangeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("commercialRange")]
        public required _vmwareCloudDirector.CommercialRangeEnum CommercialRange { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: ipQuota Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipQuota")]
        public required System.Int64 IpQuota { get; set; }//;
        
        // Key: memoryQuota Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memoryQuota")]
        public required System.Int64 MemoryQuota { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: region Type: vmwareCloudDirector.RegionNameEnum FullType: vmwareCloudDirector.RegionNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required _vmwareCloudDirector.RegionNameEnum Region { get; set; }//;
        
        // Key: storageQuota Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storageQuota")]
        public required System.Int64 StorageQuota { get; set; }//;
        
        // Key: vCPUCount Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vCPUCount")]
        public required System.Int64 VCPUCount { get; set; }//;
        
        // Key: vCPUSpeed Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vCPUSpeed")]
        public required System.Double VCPUSpeed { get; set; }//;
    }
    
    // Id: TargetSpec Namespace: vmwareCloudDirector.virtualDataCenter
    public class TargetSpec {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: vCPUSpeed Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vCPUSpeed")]
        public required System.Double VCPUSpeed { get; set; }//;
    }
    
    // Id: Update Namespace: vmwareCloudDirector.virtualDataCenter
    public class Update {
        
        // Key: targetSpec Type: vmwareCloudDirector.virtualDataCenter.TargetSpec FullType: vmwareCloudDirector.virtualDataCenter.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_virtualDataCenter.TargetSpec TargetSpec { get; set; }//;
    }
}
