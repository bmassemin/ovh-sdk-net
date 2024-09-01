//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _ovhcloudconnect {
    
    
    // Id: Datacenter Namespace: ovhcloudconnect
    public class Datacenter {
        
        // Key: available Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        public required System.Boolean Available { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: DatacenterConfig Namespace: ovhcloudconnect
    public class DatacenterConfig {
        
        // Key: datacenterId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenterId")]
        public required System.Int64 DatacenterId { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: ovhBgpArea Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhBgpArea")]
        public System.Int64? OvhBgpArea { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.popConfig.StatusEnum FullType: ovhcloudconnect.popConfig.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_popConfig.StatusEnum Status { get; set; }//;
        
        // Key: subnet Type: ipv4Block FullType: ipv4Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnet")]
        public System.String? Subnet { get; set; }//;
    }
    
    // Id: DatacenterExtraConfig Namespace: ovhcloudconnect
    public class DatacenterExtraConfig {
        
        // Key: bgpNeighborArea Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bgpNeighborArea")]
        public System.Int64? BgpNeighborArea { get; set; }//;
        
        // Key: bgpNeighborIp Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bgpNeighborIp")]
        public System.String? BgpNeighborIp { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: nextHop Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nextHop")]
        public System.String? NextHop { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.popConfig.StatusEnum FullType: ovhcloudconnect.popConfig.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_popConfig.StatusEnum Status { get; set; }//;
        
        // Key: subnet Type: ipv4Block FullType: ipv4Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnet")]
        public System.String? Subnet { get; set; }//;
        
        // Key: type Type: ovhcloudconnect.datacenterExtraConfig.TypeEnum FullType: ovhcloudconnect.datacenterExtraConfig.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _ovhcloudconnect_datacenterExtraConfig.TypeEnum Type { get; set; }//;
    }
    
    // Id: Diagnostic Namespace: ovhcloudconnect
    public class Diagnostic {
        
        // Key: function Type: ovhcloudconnect.diagnostic.FunctionEnum FullType: ovhcloudconnect.diagnostic.FunctionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("function")]
        public required _ovhcloudconnect_diagnostic.FunctionEnum Function { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: result Type: ovhcloudconnect.DiagnosticResult[] FullType: ovhcloudconnect.DiagnosticResult[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("result")]
        public _ovhcloudconnect.DiagnosticResult[]? Result { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.task.StatusEnum FullType: ovhcloudconnect.task.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_task.StatusEnum Status { get; set; }//;
    }
    
    // Id: DiagnosticConfiguration Namespace: ovhcloudconnect
    public class DiagnosticConfiguration {
        
        // Key: dcConfigId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dcConfigId")]
        public required System.Int64 DcConfigId { get; set; }//;
        
        // Key: diagnosticName Type: ovhcloudconnect.diagnostic.FunctionEnum FullType: ovhcloudconnect.diagnostic.FunctionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diagnosticName")]
        public required _ovhcloudconnect_diagnostic.FunctionEnum DiagnosticName { get; set; }//;
        
        // Key: diagnosticType Type: ovhcloudconnect.diagnostic.TypeEnum FullType: ovhcloudconnect.diagnostic.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diagnosticType")]
        public required _ovhcloudconnect_diagnostic.TypeEnum DiagnosticType { get; set; }//;
        
        // Key: extraConfigId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extraConfigId")]
        public required System.Int64 ExtraConfigId { get; set; }//;
        
        // Key: popConfigId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("popConfigId")]
        public required System.Int64 PopConfigId { get; set; }//;
    }
    
    // Id: DiagnosticResult Namespace: ovhcloudconnect
    public class DiagnosticResult {
        
        // Key: aspath Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("aspath")]
        public System.String? Aspath { get; set; }//;
        
        // Key: cmd Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cmd")]
        public System.String? Cmd { get; set; }//;
        
        // Key: localprefix Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localprefix")]
        public System.Int64? Localprefix { get; set; }//;
        
        // Key: mac Type: macAddress FullType: macAddress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mac")]
        public System.String? Mac { get; set; }//;
        
        // Key: med Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("med")]
        public System.Int64? Med { get; set; }//;
        
        // Key: output Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("output")]
        public System.String? Output { get; set; }//;
        
        // Key: prefix Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prefix")]
        public System.String? Prefix { get; set; }//;
        
        // Key: routermac Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("routermac")]
        public System.String? Routermac { get; set; }//;
        
        // Key: timestamp Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public System.DateTime? Timestamp { get; set; }//;
    }
    
    // Id: Incident Namespace: ovhcloudconnect
    public class Incident {
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public required System.DateTime StartDate { get; set; }//;
        
        // Key: type Type: ovhcloudconnect.incident.TypeEnum FullType: ovhcloudconnect.incident.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _ovhcloudconnect_incident.TypeEnum Type { get; set; }//;
    }
    
    // Id: Interface Namespace: ovhcloudconnect
    public class Interface {
        
        // Key: deviceDisplayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deviceDisplayName")]
        public System.String? DeviceDisplayName { get; set; }//;
        
        // Key: deviceRackDisplayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deviceRackDisplayName")]
        public System.String? DeviceRackDisplayName { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: incomingLightStatus Type: ovhcloudconnect.interface.LightStatusEnum FullType: ovhcloudconnect.interface.LightStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incomingLightStatus")]
        public required _ovhcloudconnect_interface.LightStatusEnum IncomingLightStatus { get; set; }//;
        
        // Key: incomingLightValue Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incomingLightValue")]
        public System.Double? IncomingLightValue { get; set; }//;
        
        // Key: interfaceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceName")]
        public System.String? InterfaceName { get; set; }//;
        
        // Key: interfaceStatus Type: ovhcloudconnect.interface.LightStatusEnum FullType: ovhcloudconnect.interface.LightStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceStatus")]
        public required _ovhcloudconnect_interface.LightStatusEnum InterfaceStatus { get; set; }//;
        
        // Key: interfaceStatusLastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceStatusLastUpdate")]
        public required System.DateTime InterfaceStatusLastUpdate { get; set; }//;
        
        // Key: interfaceTerminationType Type: ovhcloudconnect.interface.TerminationTypeEnum FullType: ovhcloudconnect.interface.TerminationTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceTerminationType")]
        public _ovhcloudconnect_interface.TerminationTypeEnum? InterfaceTerminationType { get; set; }//;
        
        // Key: lightLastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lightLastUpdate")]
        public required System.DateTime LightLastUpdate { get; set; }//;
        
        // Key: outgoingLightStatus Type: ovhcloudconnect.interface.LightStatusEnum FullType: ovhcloudconnect.interface.LightStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoingLightStatus")]
        public required _ovhcloudconnect_interface.LightStatusEnum OutgoingLightStatus { get; set; }//;
        
        // Key: outgoingLightValue Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoingLightValue")]
        public System.Double? OutgoingLightValue { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.interface.StatusEnum FullType: ovhcloudconnect.interface.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_interface.StatusEnum Status { get; set; }//;
    }
    
    // Id: Key Namespace: ovhcloudconnect
    public class Key {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public required System.String _Key { get; set; }//;
        
        // Key: provider Type: ovhcloudconnect.service.ProviderEnum FullType: ovhcloudconnect.service.ProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provider")]
        public required _ovhcloudconnect_service.ProviderEnum Provider { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.key.StatusEnum FullType: ovhcloudconnect.key.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_key.StatusEnum Status { get; set; }//;
    }
    
    // Id: Metrics Namespace: ovhcloudconnect
    public class Metrics {
        
        // Key: timestamp Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public required System.Int64 Timestamp { get; set; }//;
        
        // Key: value Type: ovhcloudconnect.MetricsValue FullType: ovhcloudconnect.MetricsValue
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public required _ovhcloudconnect.MetricsValue Value { get; set; }//;
    }
    
    // Id: MetricsValue Namespace: ovhcloudconnect
    public class MetricsValue {
        
        // Key: unit Type: ovhcloudconnect.interface.MetricsUnitEnum FullType: ovhcloudconnect.interface.MetricsUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit")]
        public required _ovhcloudconnect_interface.MetricsUnitEnum Unit { get; set; }//;
        
        // Key: value Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public required System.Double Value { get; set; }//;
    }
    
    // Id: Monitoring Namespace: ovhcloudconnect
    public class Monitoring {
        
        // Key: activated Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activated")]
        public required System.Boolean Activated { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: PopConfig Namespace: ovhcloudconnect
    public class PopConfig {
        
        // Key: customerBgpArea Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customerBgpArea")]
        public System.Int64? CustomerBgpArea { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: interfaceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceId")]
        public required System.Int64 InterfaceId { get; set; }//;
        
        // Key: ovhBgpArea Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhBgpArea")]
        public System.Int64? OvhBgpArea { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.popConfig.StatusEnum FullType: ovhcloudconnect.popConfig.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_popConfig.StatusEnum Status { get; set; }//;
        
        // Key: subnet Type: ipv4Block FullType: ipv4Block
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnet")]
        public System.String? Subnet { get; set; }//;
        
        // Key: type Type: ovhcloudconnect.popConfig.TypeEnum FullType: ovhcloudconnect.popConfig.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _ovhcloudconnect_popConfig.TypeEnum Type { get; set; }//;
    }
    
    // Id: SendKeyAnswer Namespace: ovhcloudconnect
    public class SendKeyAnswer {
        
        // Key: messageCode Type: ovhcloudconnect.messageCode.Enum FullType: ovhcloudconnect.messageCode.Enum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("messageCode")]
        public required _ovhcloudconnect_messageCode.Enum MessageCode { get; set; }//;
    }
    
    // Id: Service Namespace: ovhcloudconnect
    public class Service {
        
        // Key: bandwidth Type: ovhcloudconnect.service.BandwidthEnum FullType: ovhcloudconnect.service.BandwidthEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public required _ovhcloudconnect_service.BandwidthEnum Bandwidth { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: interfaceList Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceList")]
        public required System.Int64[] InterfaceList { get; set; }//;
        
        // Key: pop Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pop")]
        public required System.String Pop { get; set; }//;
        
        // Key: portQuantity Type: ovhcloudconnect.service.PortEnum FullType: ovhcloudconnect.service.PortEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portQuantity")]
        public required _ovhcloudconnect_service.PortEnum PortQuantity { get; set; }//;
        
        // Key: product Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("product")]
        public required System.String Product { get; set; }//;
        
        // Key: provider Type: ovhcloudconnect.service.ProviderEnum FullType: ovhcloudconnect.service.ProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provider")]
        public required _ovhcloudconnect_service.ProviderEnum Provider { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.service.StatusEnum FullType: ovhcloudconnect.service.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_service.StatusEnum Status { get; set; }//;
        
        // Key: uuid Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uuid")]
        public required System.Guid Uuid { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public System.String? Vrack { get; set; }//;
    }
    
    // Id: Service Namespace: ovhcloudconnect
    public class ServiceWithIAM {
        
        // Key: bandwidth Type: ovhcloudconnect.service.BandwidthEnum FullType: ovhcloudconnect.service.BandwidthEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public required _ovhcloudconnect_service.BandwidthEnum Bandwidth { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: interfaceList Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interfaceList")]
        public required System.Int64[] InterfaceList { get; set; }//;
        
        // Key: pop Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pop")]
        public required System.String Pop { get; set; }//;
        
        // Key: portQuantity Type: ovhcloudconnect.service.PortEnum FullType: ovhcloudconnect.service.PortEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portQuantity")]
        public required _ovhcloudconnect_service.PortEnum PortQuantity { get; set; }//;
        
        // Key: product Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("product")]
        public required System.String Product { get; set; }//;
        
        // Key: provider Type: ovhcloudconnect.service.ProviderEnum FullType: ovhcloudconnect.service.ProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provider")]
        public required _ovhcloudconnect_service.ProviderEnum Provider { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.service.StatusEnum FullType: ovhcloudconnect.service.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_service.StatusEnum Status { get; set; }//;
        
        // Key: uuid Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uuid")]
        public required System.Guid Uuid { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public System.String? Vrack { get; set; }//;
    }
    
    // Id: Subscriptions Namespace: ovhcloudconnect
    public class Subscriptions {
        
        // Key: subscriptions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subscriptions")]
        public required System.String[] _Subscriptions { get; set; }//;
    }
    
    // Id: Task Namespace: ovhcloudconnect
    public class Task {
        
        // Key: function Type: ovhcloudconnect.task.FunctionEnum FullType: ovhcloudconnect.task.FunctionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("function")]
        public required _ovhcloudconnect_task.FunctionEnum Function { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: resourceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceId")]
        public required System.Int64 ResourceId { get; set; }//;
        
        // Key: status Type: ovhcloudconnect.task.StatusEnum FullType: ovhcloudconnect.task.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _ovhcloudconnect_task.StatusEnum Status { get; set; }//;
    }
    
    // Id: To Namespace: ovhcloudconnect
    public class To {
        
        // Key: email Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("email")]
        public required System.String Email { get; set; }//;
    }
    
    // Id: Update Namespace: ovhcloudconnect
    public class Update {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
    }
}
