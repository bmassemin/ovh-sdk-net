//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _license_sqlserver {
    
    
    // Id: SqlServer Namespace: license.sqlserver
    public class SqlServer {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.SqlServerVersionEnum FullType: license.SqlServerVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.SqlServerVersionEnum Version { get; set; }//;
    }
    
    // Id: SqlServer Namespace: license.sqlserver
    public class SqlServerWithIAM {
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata Iam { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.SqlServerVersionEnum FullType: license.SqlServerVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.SqlServerVersionEnum Version { get; set; }//;
    }
}
