//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_backendHttpCustomerServer {
    
    
    // Id: BackendHTTPServer Namespace: ipLoadbalancing.backendHttpCustomerServer
    public class BackendHTTPServer {
        
        // Key: address Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public string Address { get; set; }//;
        
        // Key: backendId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendId")]
        public long BackendId { get; set; }//;
        
        // Key: backup Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backup")]
        public bool Backup { get; set; }//;
        
        // Key: chain Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("chain")]
        public System.String? Chain { get; set; }//;
        
        // Key: cookie Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cookie")]
        public System.String? Cookie { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: onMarkedDown Type: ipLoadbalancing.OnMarkedDownEnum FullType: ipLoadbalancing.OnMarkedDownEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("onMarkedDown")]
        public _ipLoadbalancing.OnMarkedDownEnum? OnMarkedDown { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public System.Int64? Port { get; set; }//;
        
        // Key: probe Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("probe")]
        public bool Probe { get; set; }//;
        
        // Key: proxyProtocolVersion Type: ipLoadbalancing.ProxyProtocolVersionEnum FullType: ipLoadbalancing.ProxyProtocolVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("proxyProtocolVersion")]
        public _ipLoadbalancing.ProxyProtocolVersionEnum? ProxyProtocolVersion { get; set; }//;
        
        // Key: serverId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverId")]
        public long ServerId { get; set; }//;
        
        // Key: serverState Type: ipLoadbalancing.ServerState[] FullType: ipLoadbalancing.ServerState[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverState")]
        public _ipLoadbalancing.ServerState[] ServerState { get; set; }//;
        
        // Key: ssl Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssl")]
        public bool Ssl { get; set; }//;
        
        // Key: status Type: ipLoadbalancing.BackendCustomerServerStatusEnum FullType: ipLoadbalancing.BackendCustomerServerStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _ipLoadbalancing.BackendCustomerServerStatusEnum Status { get; set; }//;
        
        // Key: weight Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("weight")]
        public System.Int64? Weight { get; set; }//;
    }
}