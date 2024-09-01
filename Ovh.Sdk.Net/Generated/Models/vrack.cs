//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vrack {
    
    
    // Id: Task Namespace: vrack
    public class Task {
        
        // Key: function Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("function")]
        public required System.String Function { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime? LastUpdate { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public System.Int64? OrderId { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public System.String? ServiceName { get; set; }//;
        
        // Key: status Type: vrack.TaskStatusEnum FullType: vrack.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _vrack.TaskStatusEnum Status { get; set; }//;
        
        // Key: targetDomain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetDomain")]
        public System.String? TargetDomain { get; set; }//;
        
        // Key: todoDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todoDate")]
        public System.DateTime? TodoDate { get; set; }//;
    }
    
    // Id: TaskStatusEnum Namespace: vrack
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("init")]
        init,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
    
    // Id: dedicatedServer Namespace: vrack
    public class dedicatedServer {
        
        // Key: dedicatedServer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        public required System.String _DedicatedServer { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: dedicatedCloud Namespace: vrack
    public class dedicatedCloud {
        
        // Key: dedicatedCloud Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloud")]
        public required System.String _DedicatedCloud { get; set; }//;
        
        // Key: vlanId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vlanId")]
        public System.Int64? VlanId { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: AllowedDedicatedServerInterfaces Namespace: vrack
    public class AllowedDedicatedServerInterfaces {
        
        // Key: dedicatedServer Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        public required System.String DedicatedServer { get; set; }//;
        
        // Key: dedicatedServerInterface Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        public required System.String DedicatedServerInterface { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: AllowedServiceEnum Namespace: vrack
    public enum AllowedServiceEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudProject")]
        cloudProject,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloud")]
        dedicatedCloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloudDatacenter")]
        dedicatedCloudDatacenter,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedConnect")]
        dedicatedConnect,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        dedicatedServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        dedicatedServerInterface,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        ip,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        ipLoadbalancing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        ipv6,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legacyVrack")]
        legacyVrack,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhCloudConnect")]
        ovhCloudConnect,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackServices")]
        vrackServices,
    }
    
    // Id: AllowedServices Namespace: vrack
    public class AllowedServices {
        
        // Key: cloudProject Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudProject")]
        public System.String[]? CloudProject { get; set; }//;
        
        // Key: dedicatedCloud Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloud")]
        public System.String[]? DedicatedCloud { get; set; }//;
        
        // Key: dedicatedCloudDatacenter Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloudDatacenter")]
        public System.String[]? DedicatedCloudDatacenter { get; set; }//;
        
        // Key: dedicatedConnect Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedConnect")]
        public System.String[]? DedicatedConnect { get; set; }//;
        
        // Key: dedicatedServer Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        public System.String[]? DedicatedServer { get; set; }//;
        
        // Key: dedicatedServerInterface Type: vrack.AllowedDedicatedServerInterfaces[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        public _vrack.AllowedDedicatedServerInterfaces[]? DedicatedServerInterface { get; set; }//;
        
        // Key: ip Type: ipBlock[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String[]? Ip { get; set; }//;
        
        // Key: ipLoadbalancing Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        public System.String[]? IpLoadbalancing { get; set; }//;
        
        // Key: ipv6 Type: ipv6Block[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String[]? Ipv6 { get; set; }//;
        
        // Key: legacyVrack Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legacyVrack")]
        public System.String[]? LegacyVrack { get; set; }//;
        
        // Key: ovhCloudConnect Type: uuid[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhCloudConnect")]
        public System.Guid[]? OvhCloudConnect { get; set; }//;
        
        // Key: vrackServices Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackServices")]
        public System.String[]? VrackServices { get; set; }//;
    }
    
    // Id: EligibleDedicatedServerInterfaces Namespace: vrack
    public class EligibleDedicatedServerInterfaces {
        
        // Key: dedicatedServer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        public required System.String DedicatedServer { get; set; }//;
        
        // Key: dedicatedServerInterface Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        public required System.String DedicatedServerInterface { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: EligibleServices Namespace: vrack
    public class EligibleServices {
        
        // Key: cloudProject Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudProject")]
        public System.String[]? CloudProject { get; set; }//;
        
        // Key: dedicatedCloud Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloud")]
        public System.String[]? DedicatedCloud { get; set; }//;
        
        // Key: dedicatedCloudDatacenter Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloudDatacenter")]
        public System.String[]? DedicatedCloudDatacenter { get; set; }//;
        
        // Key: dedicatedConnect Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedConnect")]
        public System.String[]? DedicatedConnect { get; set; }//;
        
        // Key: dedicatedServer Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServer")]
        public System.String[]? DedicatedServer { get; set; }//;
        
        // Key: dedicatedServerInterface Type: vrack.EligibleDedicatedServerInterfaces[] FullType: vrack.EligibleDedicatedServerInterfaces[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        public _vrack.EligibleDedicatedServerInterfaces[]? DedicatedServerInterface { get; set; }//;
        
        // Key: ip Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String[]? Ip { get; set; }//;
        
        // Key: ipLoadbalancing Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        public System.String[]? IpLoadbalancing { get; set; }//;
        
        // Key: ipv6 Type: ipv6Block[] FullType: ipv6Block[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String[]? Ipv6 { get; set; }//;
        
        // Key: legacyVrack Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legacyVrack")]
        public System.String[]? LegacyVrack { get; set; }//;
        
        // Key: ovhCloudConnect Type: uuid[] FullType: uuid[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhCloudConnect")]
        public System.Guid[]? OvhCloudConnect { get; set; }//;
        
        // Key: vrackServices Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackServices")]
        public System.String[]? VrackServices { get; set; }//;
    }
    
    // Id: EligibleServicesResponse Namespace: vrack
    public class EligibleServicesResponse {
        
        // Key: createdAt Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.String CreatedAt { get; set; }//;
        
        // Key: errors Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("errors")]
        public required System.String[] Errors { get; set; }//;
        
        // Key: result Type: vrack.EligibleServices FullType: vrack.EligibleServices
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("result")]
        public required _vrack.EligibleServices Result { get; set; }//;
        
        // Key: status Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required System.String Status { get; set; }//;
    }
    
    // Id: SlaacEnum Namespace: vrack
    public enum SlaacEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        enabled,
    }
    
    // Id: VrackZoneEnum Namespace: vrack
    public enum VrackZoneEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bhs")]
        bhs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fra1")]
        fra1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gra")]
        gra,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lon1")]
        lon1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pdx1")]
        pdx1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rbx")]
        rbx,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sbg")]
        sbg,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sgp1")]
        sgp1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syd1")]
        syd1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syd2")]
        syd2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("was1")]
        was1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waw")]
        waw,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("yyz")]
        yyz,
    }
    
    // Id: bridgedSubrange Namespace: vrack
    public class bridgedSubrange {
        
        // Key: bridgedSubrange Type: ipv6Block FullType: ipv6Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bridgedSubrange")]
        public required System.String _BridgedSubrange { get; set; }//;
        
        // Key: gateway Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public required System.String Gateway { get; set; }//;
        
        // Key: slaac Type: vrack.SlaacEnum FullType: vrack.SlaacEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("slaac")]
        public required _vrack.SlaacEnum Slaac { get; set; }//;
    }
    
    // Id: cloudProject Namespace: vrack
    public class cloudProject {
        
        // Key: project Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("project")]
        public required System.String Project { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: dedicatedConnect Namespace: vrack
    public class dedicatedConnect {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: dedicatedServerInterface Namespace: vrack
    public class dedicatedServerInterface {
        
        // Key: dedicatedServerInterface Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedServerInterface")]
        public required System.String _DedicatedServerInterface { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: ip Namespace: vrack
    public class ip {
        
        // Key: gateway Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public System.String? Gateway { get; set; }//;
        
        // Key: ip Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String _Ip { get; set; }//;
        
        // Key: zone Type: vrack.VrackZoneEnum FullType: vrack.VrackZoneEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public _vrack.VrackZoneEnum? Zone { get; set; }//;
    }
    
    // Id: iplb Namespace: vrack
    public class iplb {
        
        // Key: ipLoadbalancing Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        public required System.String IpLoadbalancing { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: ipv6 Namespace: vrack
    public class ipv6 {
        
        // Key: ipv6 Type: ipv6Block FullType: ipv6Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public required System.String _Ipv6 { get; set; }//;
    }
    
    // Id: legacyVrack Namespace: vrack
    public class legacyVrack {
        
        // Key: legacyVrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legacyVrack")]
        public required System.String _LegacyVrack { get; set; }//;
        
        // Key: vlanId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vlanId")]
        public required System.Int64 VlanId { get; set; }//;
    }
    
    // Id: ovhCloudConnect Namespace: vrack
    public class ovhCloudConnect {
        
        // Key: ovhCloudConnect Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhCloudConnect")]
        public required System.Guid _OvhCloudConnect { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: pccDatacenter Namespace: vrack
    public class pccDatacenter {
        
        // Key: datacenter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public required System.String Datacenter { get; set; }//;
        
        // Key: dedicatedCloud Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedCloud")]
        public required System.String DedicatedCloud { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
    }
    
    // Id: publicRoutingOption Namespace: vrack
    public class publicRoutingOption {
        
        // Key: bandwidth Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public System.Int64? Bandwidth { get; set; }//;
    }
    
    // Id: routedSubrange Namespace: vrack
    public class routedSubrange {
        
        // Key: nexthop Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nexthop")]
        public required System.String Nexthop { get; set; }//;
        
        // Key: routedSubrange Type: ipv6Block FullType: ipv6Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("routedSubrange")]
        public required System.String _RoutedSubrange { get; set; }//;
    }
    
    // Id: vrack Namespace: vrack
    public class vrack {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: vrackServices Namespace: vrack
    public class vrackServices {
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public required System.String Vrack { get; set; }//;
        
        // Key: vrackServices Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackServices")]
        public required System.String _VrackServices { get; set; }//;
    }
    
    // Id: vrack Namespace: vrack
    public class vrackWithIAM {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
}
