//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _startup_startup_project {
    
    
    // Id: technicalNeed Namespace: startup.startup.project
    public class technicalNeed {
        
        // Key: infrastructureUsing Type: startup.infrastructureUsingEnum FullType: startup.infrastructureUsingEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infrastructureUsing")]
        public _startup.infrastructureUsingEnum InfrastructureUsing { get; set; }//;
        
        // Key: otherCloudProvider Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("otherCloudProvider")]
        public System.Boolean? OtherCloudProvider { get; set; }//;
        
        // Key: otherCloudProviderInfo Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("otherCloudProviderInfo")]
        public System.String? OtherCloudProviderInfo { get; set; }//;
        
        // Key: technicalNeeds Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("technicalNeeds")]
        public string TechnicalNeeds { get; set; }//;
    }
}
