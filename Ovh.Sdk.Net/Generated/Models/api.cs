//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _api {
    
    
    // Id: Credential Namespace: api
    public class Credential {
        
        // Key: allowedIPs Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedIPs")]
        public string[] AllowedIPs { get; set; }//;
        
        // Key: applicationId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applicationId")]
        public long ApplicationId { get; set; }//;
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: credentialId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("credentialId")]
        public long CredentialId { get; set; }//;
        
        // Key: expiration Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expiration")]
        public System.DateTime Expiration { get; set; }//;
        
        // Key: lastUse Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUse")]
        public System.DateTime LastUse { get; set; }//;
        
        // Key: ovhSupport Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhSupport")]
        public bool OvhSupport { get; set; }//;
        
        // Key: rules Type: auth.AccessRule[] FullType: auth.AccessRule[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rules")]
        public _auth.AccessRule[] Rules { get; set; }//;
        
        // Key: status Type: auth.CredentialStateEnum FullType: auth.CredentialStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _auth.CredentialStateEnum Status { get; set; }//;
    }
    
    // Id: Application Namespace: api
    public class Application {
        
        // Key: applicationId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applicationId")]
        public long ApplicationId { get; set; }//;
        
        // Key: applicationKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applicationKey")]
        public string ApplicationKey { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: status Type: api.ApplicationStatusEnum FullType: api.ApplicationStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _api.ApplicationStatusEnum Status { get; set; }//;
    }
    
    // Id: ApplicationStatusEnum Namespace: api
    public enum ApplicationStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blocked")]
        blocked,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inactive")]
        inactive,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trusted")]
        trusted,
    }
    
    // Id: Log Namespace: api
    public class Log {
        
        // Key: account Type: string FullType: coreTypes.AccountId:string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("account")]
        public string Account { get; set; }//;
        
        // Key: date Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        public System.DateTime Date { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: logId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("logId")]
        public long LogId { get; set; }//;
        
        // Key: method Type: http.MethodEnum FullType: http.MethodEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("method")]
        public _http.MethodEnum Method { get; set; }//;
        
        // Key: path Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("path")]
        public string Path { get; set; }//;
        
        // Key: route Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("route")]
        public string Route { get; set; }//;
    }
}
