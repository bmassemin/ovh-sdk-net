//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_backendUdpCustomerServer {
    
    
    // Id: BackendUDPServer Namespace: ipLoadbalancing.backendUdpCustomerServer
    public class BackendUDPServer {
        
        // Key: address Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public System.Net.IPAddress Address { get; set; }//;
        
        // Key: backendId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendId")]
        public long BackendId { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public long Port { get; set; }//;
        
        // Key: serverId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverId")]
        public long ServerId { get; set; }//;
        
        // Key: status Type: ipLoadbalancing.BackendCustomerServerStatusEnum FullType: ipLoadbalancing.BackendCustomerServerStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _ipLoadbalancing.BackendCustomerServerStatusEnum Status { get; set; }//;
    }
}
