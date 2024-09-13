//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _nutanix {
    
    
    // Id: AvailabilitiesRaw Namespace: nutanix
    public class AvailabilitiesRaw {
        
        // Key: datacenters Type: nutanix.AvailabilitiesRawDatacenter[] FullType: nutanix.AvailabilitiesRawDatacenter[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public _nutanix.AvailabilitiesRawDatacenter[] Datacenters { get; set; }//;
        
        // Key: deploymentType Type: nutanix.DeploymentTypeEnum FullType: nutanix.DeploymentTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deploymentType")]
        public _nutanix.DeploymentTypeEnum? DeploymentType { get; set; }//;
        
        // Key: erasureCoding Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("erasureCoding")]
        public System.Boolean? ErasureCoding { get; set; }//;
        
        // Key: fqn Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fqn")]
        public string Fqn { get; set; }//;
        
        // Key: memory Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memory")]
        public string Memory { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: redundancyFactor Type: nutanix.RedundancyFactorEnum FullType: nutanix.RedundancyFactorEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redundancyFactor")]
        public _nutanix.RedundancyFactorEnum? RedundancyFactor { get; set; }//;
        
        // Key: server Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("server")]
        public string Server { get; set; }//;
        
        // Key: storage Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public string Storage { get; set; }//;
        
        // Key: systemStorage Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("systemStorage")]
        public System.String? SystemStorage { get; set; }//;
    }
    
    // Id: AvailabilitiesRawDatacenter Namespace: nutanix
    public class AvailabilitiesRawDatacenter {
        
        // Key: availability Type: nutanix.AvailabilityEnum FullType: nutanix.AvailabilityEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availability")]
        public _nutanix.AvailabilityEnum Availability { get; set; }//;
        
        // Key: datacenter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public string Datacenter { get; set; }//;
        
        // Key: lastRule Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastRule")]
        public System.String? LastRule { get; set; }//;
        
        // Key: parentAvailable Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parentAvailable")]
        public long ParentAvailable { get; set; }//;
        
        // Key: trueAvailable Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trueAvailable")]
        public long TrueAvailable { get; set; }//;
    }
    
    // Id: AvailabilityEnum Namespace: nutanix
    public enum AvailabilityEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("1440H")]
        _1440H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("240H")]
        _240H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2880H")]
        _2880H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("480H")]
        _480H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("720H")]
        _720H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("72H")]
        _72H,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comingSoon")]
        comingSoon,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unavailable")]
        unavailable,
    }
    
    // Id: DatacenterAvailability Namespace: nutanix
    public class DatacenterAvailability {
        
        // Key: availability Type: nutanix.AvailabilityEnum FullType: nutanix.AvailabilityEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availability")]
        public _nutanix.AvailabilityEnum Availability { get; set; }//;
        
        // Key: datacenter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public string Datacenter { get; set; }//;
    }
    
    // Id: DeploymentTypeEnum Namespace: nutanix
    public enum DeploymentTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NodeAwareness")]
        NodeAwareness,
    }
    
    // Id: RedundancyFactorEnum Namespace: nutanix
    public enum RedundancyFactorEnum {
        
        _2 = 2,
        
        _3 = 3,
    }
    
    // Id: Requirements Namespace: nutanix
    public class Requirements {
        
        // Key: maxNodes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxNodes")]
        public long MaxNodes { get; set; }//;
        
        // Key: minNodes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minNodes")]
        public long MinNodes { get; set; }//;
        
        // Key: scaleFactor Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scaleFactor")]
        public long ScaleFactor { get; set; }//;
    }
    
    // Id: availability Namespace: nutanix
    public class availability {
        
        // Key: datacenters Type: nutanix.DatacenterAvailability[] FullType: nutanix.DatacenterAvailability[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public _nutanix.DatacenterAvailability[] Datacenters { get; set; }//;
        
        // Key: deploymentType Type: nutanix.DeploymentTypeEnum FullType: nutanix.DeploymentTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deploymentType")]
        public _nutanix.DeploymentTypeEnum? DeploymentType { get; set; }//;
        
        // Key: erasureCoding Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("erasureCoding")]
        public System.Boolean? ErasureCoding { get; set; }//;
        
        // Key: fqn Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fqn")]
        public string Fqn { get; set; }//;
        
        // Key: memory Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memory")]
        public string Memory { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: redundancyFactor Type: nutanix.RedundancyFactorEnum FullType: nutanix.RedundancyFactorEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redundancyFactor")]
        public _nutanix.RedundancyFactorEnum? RedundancyFactor { get; set; }//;
        
        // Key: server Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("server")]
        public string Server { get; set; }//;
        
        // Key: storage Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public string Storage { get; set; }//;
        
        // Key: systemStorage Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("systemStorage")]
        public System.String? SystemStorage { get; set; }//;
    }
    
    // Id: cluster Namespace: nutanix
    public class cluster {
        
        // Key: controlPanelURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("controlPanelURL")]
        public string ControlPanelURL { get; set; }//;
        
        // Key: erasureCoding Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("erasureCoding")]
        public bool ErasureCoding { get; set; }//;
        
        // Key: gatewayCidr Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gatewayCidr")]
        public string GatewayCidr { get; set; }//;
        
        // Key: infraVlanNumber Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infraVlanNumber")]
        public long InfraVlanNumber { get; set; }//;
        
        // Key: ipfo Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipfo")]
        public string Ipfo { get; set; }//;
        
        // Key: iplb Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iplb")]
        public string Iplb { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: nodes Type: nutanix.nodes[] FullType: nutanix.nodes[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nodes")]
        public _nutanix.nodes[] Nodes { get; set; }//;
        
        // Key: prismCentral Type: nutanix.prismcentral FullType: nutanix.prismcentral
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prismCentral")]
        public _nutanix.prismcentral PrismCentral { get; set; }//;
        
        // Key: prismElementVip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prismElementVip")]
        public string PrismElementVip { get; set; }//;
        
        // Key: prismSecretId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prismSecretId")]
        public System.Guid PrismSecretId { get; set; }//;
        
        // Key: rackAwareness Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rackAwareness")]
        public bool RackAwareness { get; set; }//;
        
        // Key: redundancyFactor Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redundancyFactor")]
        public long RedundancyFactor { get; set; }//;
        
        // Key: version Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public string Version { get; set; }//;
        
        // Key: vrack Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public string Vrack { get; set; }//;
    }
    
    // Id: nodes Namespace: nutanix
    public class nodes {
        
        // Key: ahvIp Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ahvIp")]
        public string AhvIp { get; set; }//;
        
        // Key: cvmIp Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cvmIp")]
        public string CvmIp { get; set; }//;
        
        // Key: server Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("server")]
        public string Server { get; set; }//;
    }
    
    // Id: pctypeEnum Namespace: nutanix
    public enum pctypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alone")]
        alone,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scale")]
        scale,
    }
    
    // Id: prismcentral Namespace: nutanix
    public class prismcentral {
        
        // Key: ips Type: ipv4[] FullType: ipv4[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ips")]
        public string[] Ips { get; set; }//;
        
        // Key: type Type: nutanix.pctypeEnum FullType: nutanix.pctypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _nutanix.pctypeEnum Type { get; set; }//;
        
        // Key: vip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vip")]
        public string Vip { get; set; }//;
    }
    
    // Id: state Namespace: nutanix
    public class state {
        
        // Key: allowedRedundancyFactor Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedRedundancyFactor")]
        public long[] AllowedRedundancyFactor { get; set; }//;
        
        // Key: availableVersions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableVersions")]
        public string[] AvailableVersions { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: status Type: nutanix.statusEnum FullType: nutanix.statusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _nutanix.statusEnum Status { get; set; }//;
        
        // Key: targetSpec Type: nutanix.cluster FullType: nutanix.cluster
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public _nutanix.cluster TargetSpec { get; set; }//;
    }
    
    // Id: state Namespace: nutanix
    public class stateWithIAM {
        
        // Key: allowedRedundancyFactor Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedRedundancyFactor")]
        public long[] AllowedRedundancyFactor { get; set; }//;
        
        // Key: availableVersions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableVersions")]
        public string[] AvailableVersions { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: status Type: nutanix.statusEnum FullType: nutanix.statusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _nutanix.statusEnum Status { get; set; }//;
        
        // Key: targetSpec Type: nutanix.cluster FullType: nutanix.cluster
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public _nutanix.cluster TargetSpec { get; set; }//;
    }
    
    // Id: statusEnum Namespace: nutanix
    public enum statusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Active")]
        Active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Deploying")]
        Deploying,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Error")]
        Error,
    }
}
