//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vip {
    
    
    // Id: SupportVip Namespace: vip
    public class SupportVip {
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: universe Type: vip.UniverseEnum[] FullType: vip.UniverseEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("universe")]
        public required _vip.UniverseEnum[] Universe { get; set; }//;
    }
    
    // Id: SupportVip Namespace: vip
    public class SupportVipWithIAM {
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: universe Type: vip.UniverseEnum[] FullType: vip.UniverseEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("universe")]
        public required _vip.UniverseEnum[] Universe { get; set; }//;
    }
    
    // Id: UniverseEnum Namespace: vip
    public enum UniverseEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloud")]
        cloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicated")]
        dedicated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("telecom")]
        telecom,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web")]
        web,
    }
}
