//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _domain_nameServer {
    
    
    // Id: CreatePayload Namespace: domain.nameServer
    public class CreatePayload {
        
        // Key: nameServer Type: domain.nameServer.NameServerInput[] FullType: domain.nameServer.NameServerInput[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nameServer")]
        public _domain_nameServer.NameServerInput[] NameServer { get; set; }//;
    }
    
    // Id: FullNameServer Namespace: domain.nameServer
    public class FullNameServer {
        
        // Key: host Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        public string Host { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: isUsed Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isUsed")]
        public bool IsUsed { get; set; }//;
        
        // Key: toDelete Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toDelete")]
        public bool ToDelete { get; set; }//;
    }
    
    // Id: NameServer Namespace: domain.nameServer
    public class NameServer {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public System.Net.IPAddress Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.Net.IPAddress Ipv6 { get; set; }//;
        
        // Key: nameServer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nameServer")]
        public string _NameServer { get; set; }//;
        
        // Key: nameServerType Type: domain.nameServer.NameServerTypeEnum FullType: domain.nameServer.NameServerTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nameServerType")]
        public _domain_nameServer.NameServerTypeEnum NameServerType { get; set; }//;
    }
    
    // Id: NameServerInput Namespace: domain.nameServer
    public class NameServerInput {
        
        // Key: host Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        public string Host { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
    }
    
    // Id: NameServerStateEnum Namespace: domain.nameServer
    public enum NameServerStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ko")]
        ko,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
    }
    
    // Id: NameServerStatus Namespace: domain.nameServer
    public class NameServerStatus {
        
        // Key: state Type: domain.nameServer.NameServerStateEnum FullType: domain.nameServer.NameServerStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _domain_nameServer.NameServerStateEnum State { get; set; }//;
        
        // Key: type Type: domain.nameServer.NameServerTypeEnum FullType: domain.nameServer.NameServerTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _domain_nameServer.NameServerTypeEnum Type { get; set; }//;
        
        // Key: usedSince Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usedSince")]
        public System.DateTime UsedSince { get; set; }//;
    }
    
    // Id: NameServerTypeEnum Namespace: domain.nameServer
    public enum NameServerTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("anycast")]
        anycast,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicated")]
        dedicated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("empty")]
        empty,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("external")]
        external,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hold")]
        hold,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosted")]
        hosted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting")]
        hosting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mixed")]
        mixed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parking")]
        parking,
    }
    
    // Id: UpdatePayload Namespace: domain.nameServer
    public class UpdatePayload {
        
        // Key: nameServers Type: domain.nameServer.NameServerInput[] FullType: domain.nameServer.NameServerInput[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nameServers")]
        public _domain_nameServer.NameServerInput[] NameServers { get; set; }//;
    }
}
