//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicatedCloud_disasterRecovery {
    
    
    // Id: DrpTypeEnum Namespace: dedicatedCloud.disasterRecovery
    public enum DrpTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("onPremise")]
        onPremise,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovh")]
        ovh,
    }
    
    // Id: LocalSiteDetails Namespace: dedicatedCloud.disasterRecovery
    public class LocalSiteDetails {
        
        // Key: endpointPublicIp Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpointPublicIp")]
        public System.String? EndpointPublicIp { get; set; }//;
        
        // Key: role Type: dedicatedCloud.disasterRecovery.SiteRoleEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public _dedicatedCloud_disasterRecovery.SiteRoleEnum Role { get; set; }//;
        
        // Key: state Type: dedicatedCloud.StateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _dedicatedCloud.StateEnum? State { get; set; }//;
        
        // Key: type Type: dedicatedCloud.disasterRecovery.SiteTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _dedicatedCloud_disasterRecovery.SiteTypeEnum Type { get; set; }//;
        
        // Key: zertoVersion Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zertoVersion")]
        public string ZertoVersion { get; set; }//;
        
        // Key: zvmIp Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zvmIp")]
        public System.String? ZvmIp { get; set; }//;
    }
    
    // Id: Profile Namespace: dedicatedCloud.disasterRecovery
    public class Profile {
        
        // Key: drpType Type: dedicatedCloud.disasterRecovery.DrpTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("drpType")]
        public _dedicatedCloud_disasterRecovery.DrpTypeEnum? DrpType { get; set; }//;
        
        // Key: localSiteInformation Type: dedicatedCloud.disasterRecovery.LocalSiteDetails FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSiteInformation")]
        public _dedicatedCloud_disasterRecovery.LocalSiteDetails? LocalSiteInformation { get; set; }//;
        
        // Key: remoteSiteInformation Type: dedicatedCloud.disasterRecovery.RemoteSiteDetails FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteSiteInformation")]
        public _dedicatedCloud_disasterRecovery.RemoteSiteDetails? RemoteSiteInformation { get; set; }//;
        
        // Key: state Type: dedicatedCloud.StateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _dedicatedCloud.StateEnum State { get; set; }//;
        
        // Key: systemVersion Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("systemVersion")]
        public string SystemVersion { get; set; }//;
    }
    
    // Id: RemoteSiteDetails Namespace: dedicatedCloud.disasterRecovery
    public class RemoteSiteDetails {
        
        // Key: datacenterId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenterId")]
        public System.Int64? DatacenterId { get; set; }//;
        
        // Key: datacenterName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenterName")]
        public System.String? DatacenterName { get; set; }//;
        
        // Key: lastVpnConfig Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastVpnConfig")]
        public System.DateTime? LastVpnConfig { get; set; }//;
        
        // Key: remoteEndpointInternalIp Type: ipv4 FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteEndpointInternalIp")]
        public System.String? RemoteEndpointInternalIp { get; set; }//;
        
        // Key: remoteEndpointPublicIp Type: ipv4 FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteEndpointPublicIp")]
        public System.String? RemoteEndpointPublicIp { get; set; }//;
        
        // Key: remoteZvmInternalIp Type: ipv4 FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteZvmInternalIp")]
        public System.String? RemoteZvmInternalIp { get; set; }//;
        
        // Key: role Type: dedicatedCloud.disasterRecovery.SiteRoleEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public _dedicatedCloud_disasterRecovery.SiteRoleEnum? Role { get; set; }//;
        
        // Key: serviceName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public System.String? ServiceName { get; set; }//;
        
        // Key: state Type: dedicatedCloud.StateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _dedicatedCloud.StateEnum? State { get; set; }//;
        
        // Key: type Type: dedicatedCloud.disasterRecovery.SiteTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _dedicatedCloud_disasterRecovery.SiteTypeEnum Type { get; set; }//;
        
        // Key: vpnConfigState Type: dedicatedCloud.disasterRecovery.VpnConfigStateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vpnConfigState")]
        public _dedicatedCloud_disasterRecovery.VpnConfigStateEnum? VpnConfigState { get; set; }//;
        
        // Key: zertoVersion Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zertoVersion")]
        public System.String? ZertoVersion { get; set; }//;
    }
    
    // Id: SiteRoleEnum Namespace: dedicatedCloud.disasterRecovery
    public enum SiteRoleEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("primary")]
        primary,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secondary")]
        secondary,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("single")]
        single,
    }
    
    // Id: SiteTypeEnum Namespace: dedicatedCloud.disasterRecovery
    public enum SiteTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("onPremise")]
        onPremise,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhPrivateCloud")]
        ovhPrivateCloud,
    }
    
    // Id: VpnConfigStateEnum Namespace: dedicatedCloud.disasterRecovery
    public enum VpnConfigStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configured")]
        configured,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configuring")]
        configuring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notConfigured")]
        notConfigured,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tunnelError")]
        tunnelError,
    }
    
    // Id: ZertoProtectedVm Namespace: dedicatedCloud.disasterRecovery
    public class ZertoProtectedVm {
        
        // Key: fromDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromDate")]
        public System.DateTime FromDate { get; set; }//;
        
        // Key: protectedSite Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protectedSite")]
        public string ProtectedSite { get; set; }//;
        
        // Key: recoverySite Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("recoverySite")]
        public string RecoverySite { get; set; }//;
        
        // Key: vmId Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vmId")]
        public string VmId { get; set; }//;
        
        // Key: vmName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vmName")]
        public string VmName { get; set; }//;
        
        // Key: vpgName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vpgName")]
        public string VpgName { get; set; }//;
    }
    
    // Id: ZertoRemoteVra Namespace: dedicatedCloud.disasterRecovery
    public class ZertoRemoteVra {
        
        // Key: id Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: label Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public string Label { get; set; }//;
        
        // Key: remoteEndpointPublicIp Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteEndpointPublicIp")]
        public string RemoteEndpointPublicIp { get; set; }//;
        
        // Key: remoteVraNetwork Type: ipBlock FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteVraNetwork")]
        public string RemoteVraNetwork { get; set; }//;
        
        // Key: remoteZvmInternalIp Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteZvmInternalIp")]
        public string RemoteZvmInternalIp { get; set; }//;
    }
}