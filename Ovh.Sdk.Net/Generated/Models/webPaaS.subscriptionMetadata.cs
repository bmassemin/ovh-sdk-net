//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _webPaaS_subscriptionMetadata {
    
    
    // Id: Project Namespace: webPaaS.subscriptionMetadata
    public class Project {
        
        // Key: availableEnvironments Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableEnvironments")]
        public long AvailableEnvironments { get; set; }//;
        
        // Key: availableUserLicenses Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableUserLicenses")]
        public long AvailableUserLicenses { get; set; }//;
        
        // Key: environment Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("environment")]
        public long Environment { get; set; }//;
        
        // Key: region Type: webPaaS.RegionEnum FullType: webPaaS.RegionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public _webPaaS.RegionEnum Region { get; set; }//;
        
        // Key: renewDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renewDate")]
        public System.DateTime? RenewDate { get; set; }//;
        
        // Key: storage Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public System.Int64? Storage { get; set; }//;
        
        // Key: storageUnit Type: webPaaS.StorageUnitEnum FullType: webPaaS.StorageUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storageUnit")]
        public _webPaaS.StorageUnitEnum? StorageUnit { get; set; }//;
        
        // Key: userLicenses Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userLicenses")]
        public System.Int64? UserLicenses { get; set; }//;
        
        // Key: vcpu Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vcpu")]
        public long Vcpu { get; set; }//;
    }
}
