//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _xdsl_templateModem {
    
    
    // Id: DHCP Namespace: xdsl.templateModem
    public class DHCP {
        
        // Key: defaultGateway Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultGateway")]
        public string DefaultGateway { get; set; }//;
        
        // Key: dhcpName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dhcpName")]
        public string DhcpName { get; set; }//;
        
        // Key: domainName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domainName")]
        public string DomainName { get; set; }//;
        
        // Key: endAddress Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endAddress")]
        public string EndAddress { get; set; }//;
        
        // Key: leaseTime Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("leaseTime")]
        public long LeaseTime { get; set; }//;
        
        // Key: primaryDNS Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("primaryDNS")]
        public string PrimaryDNS { get; set; }//;
        
        // Key: secondaryDNS Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secondaryDNS")]
        public System.String? SecondaryDNS { get; set; }//;
        
        // Key: serverEnabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverEnabled")]
        public bool ServerEnabled { get; set; }//;
        
        // Key: startAddress Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startAddress")]
        public string StartAddress { get; set; }//;
        
        // Key: subnetMask Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnetMask")]
        public string SubnetMask { get; set; }//;
    }
    
    // Id: LAN Namespace: xdsl.templateModem
    public class LAN {
        
        // Key: IPAddress Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IPAddress")]
        public string IPAddress { get; set; }//;
        
        // Key: addressingType Type: xdsl.xdslModemConfig.AddressingTypeEnum FullType: xdsl.xdslModemConfig.AddressingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addressingType")]
        public _xdsl_xdslModemConfig.AddressingTypeEnum AddressingType { get; set; }//;
        
        // Key: lanName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lanName")]
        public string LanName { get; set; }//;
        
        // Key: subnetMask Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnetMask")]
        public string SubnetMask { get; set; }//;
    }
    
    // Id: ParametersToIgnore Namespace: xdsl.templateModem
    public class ParametersToIgnore {
        
        // Key: LANandDHCP Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LANandDHCP")]
        public System.Boolean? LANandDHCP { get; set; }//;
        
        // Key: WLANList Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WLANList")]
        public System.String[]? WLANList { get; set; }//;
        
        // Key: dmzIP Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dmzIP")]
        public System.Boolean? DmzIP { get; set; }//;
        
        // Key: mtuSize Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mtuSize")]
        public System.Boolean? MtuSize { get; set; }//;
        
        // Key: portMappingList Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portMappingList")]
        public System.String[]? PortMappingList { get; set; }//;
    }
    
    // Id: PortMapping Namespace: xdsl.templateModem
    public class PortMapping {
        
        // Key: allowedRemoteIp Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedRemoteIp")]
        public System.String? AllowedRemoteIp { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: externalPortEnd Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("externalPortEnd")]
        public System.Int64? ExternalPortEnd { get; set; }//;
        
        // Key: externalPortStart Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("externalPortStart")]
        public long ExternalPortStart { get; set; }//;
        
        // Key: internalClient Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalClient")]
        public string InternalClient { get; set; }//;
        
        // Key: internalPort Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalPort")]
        public long InternalPort { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: protocol Type: xdsl.xdslModemConfig.ProtocolTypeEnum FullType: xdsl.xdslModemConfig.ProtocolTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protocol")]
        public _xdsl_xdslModemConfig.ProtocolTypeEnum Protocol { get; set; }//;
    }
    
    // Id: SecurityTypeEnum Namespace: xdsl.templateModem
    public enum SecurityTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("None")]
        None,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WPA")]
        WPA,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WPA2")]
        WPA2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WPA2andWPA3")]
        WPA2andWPA3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WPA3")]
        WPA3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WPAandWPA2")]
        WPAandWPA2,
    }
    
    // Id: WLAN Namespace: xdsl.templateModem
    public class WLAN {
        
        // Key: SSID Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SSID")]
        public string SSID { get; set; }//;
        
        // Key: SSIDAdvertisementEnabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SSIDAdvertisementEnabled")]
        public bool SSIDAdvertisementEnabled { get; set; }//;
        
        // Key: bandSteering Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandSteering")]
        public bool BandSteering { get; set; }//;
        
        // Key: channel Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("channel")]
        public long Channel { get; set; }//;
        
        // Key: channelMode Type: xdsl.xdslModemConfig.ChannelModeEnum FullType: xdsl.xdslModemConfig.ChannelModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("channelMode")]
        public _xdsl_xdslModemConfig.ChannelModeEnum ChannelMode { get; set; }//;
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: frequency Type: xdsl.xdslModemConfig.FrequencyEnum FullType: xdsl.xdslModemConfig.FrequencyEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frequency")]
        public _xdsl_xdslModemConfig.FrequencyEnum Frequency { get; set; }//;
        
        // Key: guest Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("guest")]
        public bool Guest { get; set; }//;
        
        // Key: securityKey Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("securityKey")]
        public string SecurityKey { get; set; }//;
        
        // Key: securityType Type: xdsl.templateModem.SecurityTypeEnum FullType: xdsl.templateModem.SecurityTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("securityType")]
        public _xdsl_templateModem.SecurityTypeEnum SecurityType { get; set; }//;
        
        // Key: wifiName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("wifiName")]
        public string WifiName { get; set; }//;
    }
    
    // Id: post Namespace: xdsl.templateModem
    public class post {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
    }
}
