//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicated_networkInterfaceController {
    
    
    // Id: NetworkInterfaceController Namespace: dedicated.networkInterfaceController
    public class NetworkInterfaceController {
        
        // Key: linkType Type: dedicated.networkInterfaceController.NetworkInterfaceControllerLinkTypeEnum FullType: dedicated.networkInterfaceController.NetworkInterfaceControllerLinkTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkType")]
        public _dedicated_networkInterfaceController.NetworkInterfaceControllerLinkTypeEnum LinkType { get; set; }//;
        
        // Key: mac Type: macAddress FullType: macAddress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mac")]
        public string Mac { get; set; }//;
        
        // Key: virtualNetworkInterface Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("virtualNetworkInterface")]
        public System.Guid VirtualNetworkInterface { get; set; }//;
    }
    
    // Id: NetworkInterfaceControllerLinkTypeEnum Namespace: dedicated.networkInterfaceController
    public enum NetworkInterfaceControllerLinkTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isolated")]
        isolated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("private")]
        @private,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("private_lag")]
        private_lag,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisioning")]
        provisioning,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisioning_lag")]
        provisioning_lag,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("public")]
        @public,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("public_lag")]
        public_lag,
    }
}
