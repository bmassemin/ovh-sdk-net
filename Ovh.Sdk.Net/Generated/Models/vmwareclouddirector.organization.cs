//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vmwareCloudDirector_organization {
    
    
    // Id: CurrentState Namespace: vmwareCloudDirector.organization
    public class CurrentState {
        
        // Key: apiUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("apiUrl")]
        public required System.String ApiUrl { get; set; }//;
        
        // Key: billingType Type: vmwareCloudDirector.BillingTypeEnum FullType: vmwareCloudDirector.BillingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingType")]
        public required _vmwareCloudDirector.BillingTypeEnum BillingType { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: fullName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fullName")]
        public required System.String FullName { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: region Type: vmwareCloudDirector.RegionNameEnum FullType: vmwareCloudDirector.RegionNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required _vmwareCloudDirector.RegionNameEnum Region { get; set; }//;
        
        // Key: spla Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spla")]
        public required System.Boolean Spla { get; set; }//;
        
        // Key: webInterfaceUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("webInterfaceUrl")]
        public required System.String WebInterfaceUrl { get; set; }//;
    }
    
    // Id: TargetSpec Namespace: vmwareCloudDirector.organization
    public class TargetSpec {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: fullName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fullName")]
        public required System.String FullName { get; set; }//;
    }
    
    // Id: Update Namespace: vmwareCloudDirector.organization
    public class Update {
        
        // Key: targetSpec Type: vmwareCloudDirector.organization.TargetSpec FullType: vmwareCloudDirector.organization.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_organization.TargetSpec TargetSpec { get; set; }//;
    }
}
