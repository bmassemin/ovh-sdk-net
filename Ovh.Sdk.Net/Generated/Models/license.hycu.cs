//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _license_hycu {
    
    
    // Id: Hycu Namespace: license.hycu
    public class Hycu {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public required System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public required System.Boolean DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public required System.String Domain { get; set; }//;
        
        // Key: license Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("license")]
        public required System.String License { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public required System.String LicenseId { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _license.StateEnum Status { get; set; }//;
    }
    
    // Id: Hycu Namespace: license.hycu
    public class HycuWithIAM {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public required System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public required System.Boolean DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public required System.String Domain { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: license Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("license")]
        public required System.String License { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public required System.String LicenseId { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _license.StateEnum Status { get; set; }//;
    }
}
