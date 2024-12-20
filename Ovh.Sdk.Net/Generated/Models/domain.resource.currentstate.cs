//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _domain_resource_currentState {
    
    
    // Id: AdditionalStatesEnum Namespace: domain.resource.currentState
    public enum AdditionalStatesEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DISPUTE")]
        DISPUTE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TECHNICAL_SUSPENDED")]
        TECHNICAL_SUSPENDED,
    }
    
    // Id: DnsConfiguration Namespace: domain.resource.currentState
    public class DnsConfiguration {
        
        // Key: configurationType Type: domain.resource.currentState.dnsConfiguration.NameServerTypeEnum FullType: domain.resource.currentState.dnsConfiguration.NameServerTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configurationType")]
        public required _domain_resource_currentState_dnsConfiguration.NameServerTypeEnum ConfigurationType { get; set; }//;
        
        // Key: glueRecordIPv6Supported Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("glueRecordIPv6Supported")]
        public required System.Boolean GlueRecordIPv6Supported { get; set; }//;
        
        // Key: hostSupported Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostSupported")]
        public required System.Boolean HostSupported { get; set; }//;
        
        // Key: maxDNS Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxDNS")]
        public required System.Int64 MaxDNS { get; set; }//;
        
        // Key: minDNS Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minDNS")]
        public required System.Int64 MinDNS { get; set; }//;
        
        // Key: nameServers Type: domain.resource.currentState.dnsConfiguration.NameServer[] FullType: domain.resource.currentState.dnsConfiguration.NameServer[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nameServers")]
        public required _domain_resource_currentState_dnsConfiguration.NameServer[] NameServers { get; set; }//;
    }
    
    // Id: MainStateEnum Namespace: domain.resource.currentState
    public enum MainStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXPIRED")]
        EXPIRED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OK")]
        OK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING_CREATE")]
        PENDING_CREATE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING_DELETE")]
        PENDING_DELETE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING_INTERNAL_TRANSFER")]
        PENDING_INTERNAL_TRANSFER,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING_OUTGOING_TRANSFER")]
        PENDING_OUTGOING_TRANSFER,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESTORABLE")]
        RESTORABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TO_DELETE")]
        TO_DELETE,
    }
    
    // Id: SuspensionStateEnum Namespace: domain.resource.currentState
    public enum SuspensionStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NOT_SUSPENDED")]
        NOT_SUSPENDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
    }
}
