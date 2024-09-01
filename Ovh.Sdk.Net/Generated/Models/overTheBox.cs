//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _overTheBox {
    
    
    // Id: ShippingMethodEnum Namespace: overTheBox
    public enum ShippingMethodEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dhl")]
        dhl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mondialRelay")]
        mondialRelay,
    }
    
    // Id: ActionStatusEnum Namespace: overTheBox
    public enum ActionStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
    
    // Id: AvailableDeviceAction Namespace: overTheBox
    public class AvailableDeviceAction {
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: AvailableMigrationOffer Namespace: overTheBox
    public class AvailableMigrationOffer {
        
        // Key: currentOfferPrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentOfferPrice")]
        public required _order.Price CurrentOfferPrice { get; set; }//;
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: engagementMonths Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engagementMonths")]
        public required System.Int64 EngagementMonths { get; set; }//;
        
        // Key: hardwareAvailable Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwareAvailable")]
        public required System.Boolean HardwareAvailable { get; set; }//;
        
        // Key: hardwareName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwareName")]
        public System.String? HardwareName { get; set; }//;
        
        // Key: hardwarePrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwarePrice")]
        public _order.Price? HardwarePrice { get; set; }//;
        
        // Key: hardwares Type: overTheBox.HardwareDetails[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwares")]
        public required _overTheBox.HardwareDetails[] Hardwares { get; set; }//;
        
        // Key: offer Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public required System.String Offer { get; set; }//;
        
        // Key: price Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
    }
    
    // Id: AvailableStatusEnum Namespace: overTheBox
    public enum AvailableStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        enabled,
    }
    
    // Id: Backup Namespace: overTheBox
    public class Backup {
        
        // Key: backupId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backupId")]
        public required System.String BackupId { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.DateTime CreatedAt { get; set; }//;
        
        // Key: deviceActionId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deviceActionId")]
        public System.String? DeviceActionId { get; set; }//;
    }
    
    // Id: Device Namespace: overTheBox
    public class Device {
        
        // Key: activated Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activated")]
        public required System.Boolean Activated { get; set; }//;
        
        // Key: availableUpdate Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableUpdate")]
        public required System.Boolean AvailableUpdate { get; set; }//;
        
        // Key: deviceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deviceId")]
        public required System.String DeviceId { get; set; }//;
        
        // Key: lastSeen Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastSeen")]
        public required System.DateTime LastSeen { get; set; }//;
        
        // Key: networkInterfaces Type: overTheBox.DeviceInterface[] FullType: overTheBox.DeviceInterface[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkInterfaces")]
        public required _overTheBox.DeviceInterface[] NetworkInterfaces { get; set; }//;
        
        // Key: publicIp Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicIp")]
        public required System.String PublicIp { get; set; }//;
        
        // Key: system Type: overTheBox.DeviceSystem FullType: overTheBox.DeviceSystem
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("system")]
        public _overTheBox.DeviceSystem? System { get; set; }//;
        
        // Key: systemVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("systemVersion")]
        public required System.String SystemVersion { get; set; }//;
        
        // Key: version Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public required System.String Version { get; set; }//;
    }
    
    // Id: DeviceAction Namespace: overTheBox
    public class DeviceAction {
        
        // Key: actionId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("actionId")]
        public required System.String ActionId { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.DateTime CreatedAt { get; set; }//;
        
        // Key: details Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public required System.String Details { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: status Type: overTheBox.ActionStatusEnum FullType: overTheBox.ActionStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _overTheBox.ActionStatusEnum Status { get; set; }//;
        
        // Key: todoDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todoDate")]
        public required System.DateTime TodoDate { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: DeviceForRegistration Namespace: overTheBox
    public class DeviceForRegistration {
        
        // Key: activated Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activated")]
        public required System.Boolean Activated { get; set; }//;
        
        // Key: deviceId Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deviceId")]
        public required System.String DeviceId { get; set; }//;
        
        // Key: lastSeen Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastSeen")]
        public required System.DateTime LastSeen { get; set; }//;
    }
    
    // Id: DeviceInterface Namespace: overTheBox
    public class DeviceInterface {
        
        // Key: device Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("device")]
        public System.String? Device { get; set; }//;
        
        // Key: dnsServers Type: ip[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dnsServers")]
        public System.String[]? DnsServers { get; set; }//;
        
        // Key: gateway Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public System.String? Gateway { get; set; }//;
        
        // Key: ip Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: multipathStatus Type: overTheBox.MultipathStatusEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("multipathStatus")]
        public required _overTheBox.MultipathStatusEnum MultipathStatus { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: netmask Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("netmask")]
        public System.String? Netmask { get; set; }//;
        
        // Key: publicIp Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicIp")]
        public System.String? PublicIp { get; set; }//;
    }
    
    // Id: DeviceSystem Namespace: overTheBox
    public class DeviceSystem {
        
        // Key: cpu Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cpu")]
        public System.String? Cpu { get; set; }//;
        
        // Key: hostname Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostname")]
        public System.String? Hostname { get; set; }//;
        
        // Key: kernel Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kernel")]
        public System.String? Kernel { get; set; }//;
        
        // Key: mac Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mac")]
        public System.String? Mac { get; set; }//;
        
        // Key: model Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public System.String? Model { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: offerName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerName")]
        public System.String? OfferName { get; set; }//;
        
        // Key: ovhName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhName")]
        public System.String? OvhName { get; set; }//;
    }
    
    // Id: GraphEndpoint Namespace: overTheBox
    public class GraphEndpoint {
        
        // Key: host Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        public required System.String Host { get; set; }//;
        
        // Key: readToken Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readToken")]
        public required System.String ReadToken { get; set; }//;
        
        // Key: readTokenID Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readTokenID")]
        public required System.String ReadTokenID { get; set; }//;
    }
    
    // Id: Hardware Namespace: overTheBox
    public class Hardware {
        
        // Key: canBeLinkedToService Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("canBeLinkedToService")]
        public required System.Boolean CanBeLinkedToService { get; set; }//;
        
        // Key: mac Type: macAddress FullType: macAddress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mac")]
        public System.String? Mac { get; set; }//;
        
        // Key: model Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public required System.String Model { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: prettyModelName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prettyModelName")]
        public required System.String PrettyModelName { get; set; }//;
        
        // Key: serial Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serial")]
        public required System.String Serial { get; set; }//;
    }
    
    // Id: HardwareDetails Namespace: overTheBox
    public class HardwareDetails {
        
        // Key: hardwareDisplayName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwareDisplayName")]
        public System.String? HardwareDisplayName { get; set; }//;
        
        // Key: hardwareName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwareName")]
        public System.String? HardwareName { get; set; }//;
        
        // Key: hardwarePrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardwarePrice")]
        public _order.Price? HardwarePrice { get; set; }//;
    }
    
    // Id: Hardware Namespace: overTheBox
    public class HardwareWithIAM {
        
        // Key: canBeLinkedToService Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("canBeLinkedToService")]
        public required System.Boolean CanBeLinkedToService { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: mac Type: macAddress FullType: macAddress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mac")]
        public System.String? Mac { get; set; }//;
        
        // Key: model Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public required System.String Model { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: prettyModelName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prettyModelName")]
        public required System.String PrettyModelName { get; set; }//;
        
        // Key: serial Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serial")]
        public required System.String Serial { get; set; }//;
    }
    
    // Id: MultipathStatusEnum Namespace: overTheBox
    public enum MultipathStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backup")]
        backup,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("handover")]
        handover,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("master")]
        master,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("off")]
        off,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("on")]
        on,
    }
    
    // Id: OrderMigration Namespace: overTheBox
    public class OrderMigration {
        
        // Key: orderId Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public required System.String OrderId { get; set; }//;
        
        // Key: orderUrl Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderUrl")]
        public required System.String OrderUrl { get; set; }//;
    }
    
    // Id: RemoteAccess Namespace: overTheBox
    public class RemoteAccess {
        
        // Key: accepted Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accepted")]
        public required System.Boolean Accepted { get; set; }//;
        
        // Key: askDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("askDate")]
        public required System.DateTime AskDate { get; set; }//;
        
        // Key: authorizedBy Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("authorizedBy")]
        public System.String? AuthorizedBy { get; set; }//;
        
        // Key: connectionInfos Type: overTheBox.RemoteAccessConnectionInfos FullType: overTheBox.RemoteAccessConnectionInfos
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connectionInfos")]
        public required _overTheBox.RemoteAccessConnectionInfos ConnectionInfos { get; set; }//;
        
        // Key: deletedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deletedAt")]
        public System.DateTime? DeletedAt { get; set; }//;
        
        // Key: dockerVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dockerVersion")]
        public required System.String DockerVersion { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public required System.DateTime ExpirationDate { get; set; }//;
        
        // Key: exposedPort Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exposedPort")]
        public required System.Int64 ExposedPort { get; set; }//;
        
        // Key: remoteAccessId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteAccessId")]
        public required System.String RemoteAccessId { get; set; }//;
        
        // Key: remoteUserInfos Type: overTheBox.RemoteAccessUserInfos FullType: overTheBox.RemoteAccessUserInfos
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteUserInfos")]
        public required _overTheBox.RemoteAccessUserInfos RemoteUserInfos { get; set; }//;
        
        // Key: status Type: overTheBox.RemoteAccessStatusEnum FullType: overTheBox.RemoteAccessStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _overTheBox.RemoteAccessStatusEnum Status { get; set; }//;
    }
    
    // Id: RemoteAccessConnectionInfos Namespace: overTheBox
    public class RemoteAccessConnectionInfos {
        
        // Key: ip Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: port Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public System.Int64? Port { get; set; }//;
    }
    
    // Id: RemoteAccessStatusEnum Namespace: overTheBox
    public enum RemoteAccessStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pendingValidation")]
        pendingValidation,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("recreating")]
        recreating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toDelete")]
        toDelete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toRecreate")]
        toRecreate,
    }
    
    // Id: RemoteAccessUserInfos Namespace: overTheBox
    public class RemoteAccessUserInfos {
        
        // Key: ip Type: ipBlock FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String Ip { get; set; }//;
        
        // Key: publicKey Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicKey")]
        public System.String? PublicKey { get; set; }//;
        
        // Key: user Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
    }
    
    // Id: Service Namespace: overTheBox
    public class Service {
        
        // Key: SOCKSProxyEnabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SOCKSProxyEnabled")]
        public required System.Boolean SOCKSProxyEnabled { get; set; }//;
        
        // Key: autoMTU Type: overTheBox.AvailableStatusEnum FullType: overTheBox.AvailableStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoMTU")]
        public required _overTheBox.AvailableStatusEnum AutoMTU { get; set; }//;
        
        // Key: autoUpgrade Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoUpgrade")]
        public required System.Boolean AutoUpgrade { get; set; }//;
        
        // Key: bandwidth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public required System.Int64 Bandwidth { get; set; }//;
        
        // Key: configurationMode Type: overTheBox.ServiceConfigurationModeEnum FullType: overTheBox.ServiceConfigurationModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configurationMode")]
        public required _overTheBox.ServiceConfigurationModeEnum ConfigurationMode { get; set; }//;
        
        // Key: customerDescription Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customerDescription")]
        public System.String? CustomerDescription { get; set; }//;
        
        // Key: graphEndpoint Type: overTheBox.GraphEndpoint FullType: overTheBox.GraphEndpoint
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("graphEndpoint")]
        public _overTheBox.GraphEndpoint? GraphEndpoint { get; set; }//;
        
        // Key: offer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public required System.String Offer { get; set; }//;
        
        // Key: prettyOfferName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prettyOfferName")]
        public required System.String PrettyOfferName { get; set; }//;
        
        // Key: releaseChannel Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("releaseChannel")]
        public required System.String ReleaseChannel { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: status Type: overTheBox.ServiceStatusEnum FullType: overTheBox.ServiceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _overTheBox.ServiceStatusEnum Status { get; set; }//;
        
        // Key: tunnelMode Type: overTheBox.TunnelModeEnum FullType: overTheBox.TunnelModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tunnelMode")]
        public required _overTheBox.TunnelModeEnum TunnelMode { get; set; }//;
    }
    
    // Id: ServiceConfigurationModeEnum Namespace: overTheBox
    public enum ServiceConfigurationModeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoconfigure")]
        autoconfigure,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("local")]
        local,
    }
    
    // Id: ServiceStatusEnum Namespace: overTheBox
    public enum ServiceStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("suspended")]
        suspended,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toCreate")]
        toCreate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toDelete")]
        toDelete,
    }
    
    // Id: Service Namespace: overTheBox
    public class ServiceWithIAM {
        
        // Key: SOCKSProxyEnabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SOCKSProxyEnabled")]
        public required System.Boolean SOCKSProxyEnabled { get; set; }//;
        
        // Key: autoMTU Type: overTheBox.AvailableStatusEnum FullType: overTheBox.AvailableStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoMTU")]
        public required _overTheBox.AvailableStatusEnum AutoMTU { get; set; }//;
        
        // Key: autoUpgrade Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoUpgrade")]
        public required System.Boolean AutoUpgrade { get; set; }//;
        
        // Key: bandwidth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public required System.Int64 Bandwidth { get; set; }//;
        
        // Key: configurationMode Type: overTheBox.ServiceConfigurationModeEnum FullType: overTheBox.ServiceConfigurationModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configurationMode")]
        public required _overTheBox.ServiceConfigurationModeEnum ConfigurationMode { get; set; }//;
        
        // Key: customerDescription Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customerDescription")]
        public System.String? CustomerDescription { get; set; }//;
        
        // Key: graphEndpoint Type: overTheBox.GraphEndpoint FullType: overTheBox.GraphEndpoint
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("graphEndpoint")]
        public _overTheBox.GraphEndpoint? GraphEndpoint { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: offer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public required System.String Offer { get; set; }//;
        
        // Key: prettyOfferName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prettyOfferName")]
        public required System.String PrettyOfferName { get; set; }//;
        
        // Key: releaseChannel Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("releaseChannel")]
        public required System.String ReleaseChannel { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: status Type: overTheBox.ServiceStatusEnum FullType: overTheBox.ServiceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _overTheBox.ServiceStatusEnum Status { get; set; }//;
        
        // Key: tunnelMode Type: overTheBox.TunnelModeEnum FullType: overTheBox.TunnelModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tunnelMode")]
        public required _overTheBox.TunnelModeEnum TunnelMode { get; set; }//;
    }
    
    // Id: Task Namespace: overTheBox
    public class Task {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: status Type: overTheBox.TaskStatusEnum FullType: overTheBox.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _overTheBox.TaskStatusEnum Status { get; set; }//;
        
        // Key: taskId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskId")]
        public required System.String TaskId { get; set; }//;
    }
    
    // Id: TaskStatusEnum Namespace: overTheBox
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
    
    // Id: TemporaryLogsLink Namespace: overTheBox
    public class TemporaryLogsLink {
        
        // Key: expirationDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public required System.DateTime ExpirationDate { get; set; }//;
        
        // Key: url Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: TunnelModeEnum Namespace: overTheBox
    public enum TunnelModeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("glorytun")]
        glorytun,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("glorytun_hybrid")]
        glorytun_hybrid,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("glorytun_mud")]
        glorytun_mud,
    }
}
