//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _license_plesk {
    
    
    // Id: Plesk Namespace: license.plesk
    public class Plesk {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public bool DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: domainNumber Type: license.DomainNumberEnum FullType: license.DomainNumberEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domainNumber")]
        public _license.DomainNumberEnum DomainNumber { get; set; }//;
        
        // Key: informationKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("informationKey")]
        public string InformationKey { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public string Key { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: productKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productKey")]
        public string ProductKey { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.PleskVersionEnum FullType: license.PleskVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.PleskVersionEnum Version { get; set; }//;
    }
    
    // Id: Plesk Namespace: license.plesk
    public class PleskWithIAM {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public bool DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: domainNumber Type: license.DomainNumberEnum FullType: license.DomainNumberEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domainNumber")]
        public _license.DomainNumberEnum DomainNumber { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata Iam { get; set; }//;
        
        // Key: informationKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("informationKey")]
        public string InformationKey { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public string Key { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: productKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productKey")]
        public string ProductKey { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.PleskVersionEnum FullType: license.PleskVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.PleskVersionEnum Version { get; set; }//;
    }
}
