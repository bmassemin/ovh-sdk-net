//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _xdsl_modem_portMappings {
    
    
    // Id: post Namespace: xdsl.modem.portMappings
    public class post {
        
        // Key: allowedRemoteIp Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedRemoteIp")]
        public required System.String AllowedRemoteIp { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: externalPortEnd Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("externalPortEnd")]
        public required System.Int64 ExternalPortEnd { get; set; }//;
        
        // Key: externalPortStart Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("externalPortStart")]
        public required System.Int64 ExternalPortStart { get; set; }//;
        
        // Key: internalClient Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalClient")]
        public required System.String InternalClient { get; set; }//;
        
        // Key: internalPort Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalPort")]
        public required System.Int64 InternalPort { get; set; }//;
        
        // Key: internalPortEnd Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalPortEnd")]
        public required System.Int64 InternalPortEnd { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: protocol Type: xdsl.xdslModemConfig.ProtocolTypeEnum FullType: xdsl.xdslModemConfig.ProtocolTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protocol")]
        public required _xdsl_xdslModemConfig.ProtocolTypeEnum Protocol { get; set; }//;
    }
}
