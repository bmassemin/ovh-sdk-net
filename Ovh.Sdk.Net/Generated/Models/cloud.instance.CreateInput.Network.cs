//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_instance_CreateInput_Network {
    
    
    // Id: Private Namespace: cloud.instance.CreateInput.Network
    public class Private {
        
        // Key: floatingIp Type: cloud.instance.CreateInput.Network.Private.FloatingIp FullType: cloud.instance.CreateInput.Network.Private.FloatingIp
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("floatingIp")]
        public _cloud_instance_CreateInput_Network_Private.FloatingIp FloatingIp { get; set; }//;
        
        // Key: floatingIpCreate Type: cloud.instance.CreateInput.Network.Private.FloatingIpCreate FullType: cloud.instance.CreateInput.Network.Private.FloatingIpCreate
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("floatingIpCreate")]
        public _cloud_instance_CreateInput_Network_Private.FloatingIpCreate FloatingIpCreate { get; set; }//;
        
        // Key: gateway Type: cloud.instance.CreateInput.Network.Private.Gateway FullType: cloud.instance.CreateInput.Network.Private.Gateway
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public _cloud_instance_CreateInput_Network_Private.Gateway Gateway { get; set; }//;
        
        // Key: gatewayCreate Type: cloud.instance.CreateInput.Network.Private.GatewayCreate FullType: cloud.instance.CreateInput.Network.Private.GatewayCreate
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gatewayCreate")]
        public _cloud_instance_CreateInput_Network_Private.GatewayCreate GatewayCreate { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: network Type: cloud.instance.CreateInput.Network.Private.Network FullType: cloud.instance.CreateInput.Network.Private.Network
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public _cloud_instance_CreateInput_Network_Private.Network Network { get; set; }//;
        
        // Key: networkCreate Type: cloud.instance.CreateInput.Network.Private.NetworkCreate FullType: cloud.instance.CreateInput.Network.Private.NetworkCreate
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkCreate")]
        public _cloud_instance_CreateInput_Network_Private.NetworkCreate NetworkCreate { get; set; }//;
    }
}
