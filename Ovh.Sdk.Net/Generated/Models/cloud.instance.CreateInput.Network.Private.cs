//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_instance_CreateInput_Network_Private {
    
    
    // Id: FloatingIp Namespace: cloud.instance.CreateInput.Network.Private
    public class FloatingIp {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
    }
    
    // Id: FloatingIpCreate Namespace: cloud.instance.CreateInput.Network.Private
    public class FloatingIpCreate {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
    }
    
    // Id: Gateway Namespace: cloud.instance.CreateInput.Network.Private
    public class Gateway {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
    }
    
    // Id: GatewayCreate Namespace: cloud.instance.CreateInput.Network.Private
    public class GatewayCreate {
        
        // Key: model Type: cloud.instance.CreateInput.Network.Private.GatewayCreate.ModelEnum FullType: cloud.instance.CreateInput.Network.Private.GatewayCreate.ModelEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public _cloud_instance_CreateInput_Network_Private_GatewayCreate.ModelEnum Model { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Network Namespace: cloud.instance.CreateInput.Network.Private
    public class Network {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: subnetId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnetId")]
        public System.Guid SubnetId { get; set; }//;
    }
    
    // Id: NetworkCreate Namespace: cloud.instance.CreateInput.Network.Private
    public class NetworkCreate {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: subnet Type: cloud.instance.CreateInput.Network.Private.NetworkCreate.Subnet FullType: cloud.instance.CreateInput.Network.Private.NetworkCreate.Subnet
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnet")]
        public _cloud_instance_CreateInput_Network_Private_NetworkCreate.Subnet Subnet { get; set; }//;
        
        // Key: vlanId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vlanId")]
        public long VlanId { get; set; }//;
    }
}
