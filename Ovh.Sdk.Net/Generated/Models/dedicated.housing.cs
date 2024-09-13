//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicated_housing {
    
    
    // Id: ApcOrderable Namespace: dedicated.housing
    public class ApcOrderable {
        
        // Key: free Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("free")]
        public bool Free { get; set; }//;
        
        // Key: orderable Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderable")]
        public bool Orderable { get; set; }//;
    }
    
    // Id: DatacenterEnum Namespace: dedicated.housing
    public enum DatacenterEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gsw")]
        gsw,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pdc1")]
        pdc1,
    }
    
    // Id: HaRoutingOfferEnum Namespace: dedicated.housing
    public enum HaRoutingOfferEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ha2x2")]
        ha2x2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ha2x4")]
        ha2x4,
    }
    
    // Id: HaRoutingOrderable Namespace: dedicated.housing
    public class HaRoutingOrderable {
        
        // Key: offer Type: dedicated.housing.HaRoutingOfferEnum[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _dedicated_housing.HaRoutingOfferEnum[] Offer { get; set; }//;
        
        // Key: orderable Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderable")]
        public bool Orderable { get; set; }//;
    }
    
    // Id: Housing Namespace: dedicated.housing
    public class Housing {
        
        // Key: datacenter Type: dedicated.housing.DatacenterEnum FullType: dedicated.housing.DatacenterEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public _dedicated_housing.DatacenterEnum? Datacenter { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: network Type: dedicated.housing.NetworkInfo[] FullType: dedicated.housing.NetworkInfo[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public _dedicated_housing.NetworkInfo[] Network { get; set; }//;
        
        // Key: options Type: dedicated.housing.Options FullType: dedicated.housing.Options
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public _dedicated_housing.Options Options { get; set; }//;
        
        // Key: rack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rack")]
        public string Rack { get; set; }//;
        
        // Key: securityCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("securityCode")]
        public string SecurityCode { get; set; }//;
    }
    
    // Id: Housing Namespace: dedicated.housing
    public class HousingWithIAM {
        
        // Key: datacenter Type: dedicated.housing.DatacenterEnum FullType: dedicated.housing.DatacenterEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public _dedicated_housing.DatacenterEnum? Datacenter { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: network Type: dedicated.housing.NetworkInfo[] FullType: dedicated.housing.NetworkInfo[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public _dedicated_housing.NetworkInfo[] Network { get; set; }//;
        
        // Key: options Type: dedicated.housing.Options FullType: dedicated.housing.Options
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public _dedicated_housing.Options Options { get; set; }//;
        
        // Key: rack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rack")]
        public string Rack { get; set; }//;
        
        // Key: securityCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("securityCode")]
        public string SecurityCode { get; set; }//;
    }
    
    // Id: IpInfo Namespace: dedicated.housing
    public class IpInfo {
        
        // Key: gateway Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public System.String? Gateway { get; set; }//;
        
        // Key: network Type: ipBlock FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public string Network { get; set; }//;
        
        // Key: reservedAddresses Type: ip[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reservedAddresses")]
        public System.String[]? ReservedAddresses { get; set; }//;
    }
    
    // Id: LinkInfo Namespace: dedicated.housing
    public class LinkInfo {
        
        // Key: port Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public string Port { get; set; }//;
        
        // Key: router Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("router")]
        public string Router { get; set; }//;
    }
    
    // Id: NetworkInfo Namespace: dedicated.housing
    public class NetworkInfo {
        
        // Key: ipv4 Type: dedicated.housing.IpInfo FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public _dedicated_housing.IpInfo? Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: dedicated.housing.IpInfo FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public _dedicated_housing.IpInfo? Ipv6 { get; set; }//;
        
        // Key: link Type: dedicated.housing.LinkInfo FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("link")]
        public _dedicated_housing.LinkInfo? Link { get; set; }//;
    }
    
    // Id: Options Namespace: dedicated.housing
    public class Options {
        
        // Key: apcCount Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("apcCount")]
        public long ApcCount { get; set; }//;
        
        // Key: handsneyes Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("handsneyes")]
        public bool Handsneyes { get; set; }//;
        
        // Key: highAvailabilityRouting Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("highAvailabilityRouting")]
        public string HighAvailabilityRouting { get; set; }//;
    }
    
    // Id: Task Namespace: dedicated.housing
    public class Task {
        
        // Key: comment Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comment")]
        public System.String? Comment { get; set; }//;
        
        // Key: doneDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doneDate")]
        public System.DateTime? DoneDate { get; set; }//;
        
        // Key: function Type: dedicated.housing.TaskFunctionEnum FullType: dedicated.housing.TaskFunctionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("function")]
        public _dedicated_housing.TaskFunctionEnum Function { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime? LastUpdate { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateTime StartDate { get; set; }//;
        
        // Key: status Type: dedicated.TaskStatusEnum FullType: dedicated.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _dedicated.TaskStatusEnum Status { get; set; }//;
        
        // Key: taskId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskId")]
        public long TaskId { get; set; }//;
    }
    
    // Id: TaskFunctionEnum Namespace: dedicated.housing
    public enum TaskFunctionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applyBackupFtpAcls")]
        applyBackupFtpAcls,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applyBackupFtpQuota")]
        applyBackupFtpQuota,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("changePasswordBackupFTP")]
        changePasswordBackupFTP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createBackupFTP")]
        createBackupFTP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migrateBackupFTP")]
        migrateBackupFTP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removeBackupFTP")]
        removeBackupFTP,
    }
}
