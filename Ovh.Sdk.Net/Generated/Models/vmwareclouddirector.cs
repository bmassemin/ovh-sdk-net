//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vmwareCloudDirector {
    
    
    // Id: AZNameEnum Namespace: vmwareCloudDirector
    public enum AZNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ca-east-bhs-a")]
        ca_east_bhs_a,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-central-waw-a")]
        eu_central_waw_a,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-eri-a")]
        eu_west_eri_a,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-lim-a")]
        eu_west_lim_a,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-rbx-a")]
        eu_west_rbx_a,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-sbg-a")]
        eu_west_sbg_a,
    }
    
    // Id: BackupOfferNameEnum Namespace: vmwareCloudDirector
    public enum BackupOfferNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BRONZE")]
        BRONZE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GOLD")]
        GOLD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SILVER")]
        SILVER,
    }
    
    // Id: BackupResourceStatusEnum Namespace: vmwareCloudDirector
    public enum BackupResourceStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATING")]
        CREATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DISABLED")]
        DISABLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DISABLING")]
        DISABLING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REMOVED")]
        REMOVED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REMOVING")]
        REMOVING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UPDATING")]
        UPDATING,
    }
    
    // Id: BillingTypeEnum Namespace: vmwareCloudDirector
    public enum BillingTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DEMO")]
        DEMO,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MONTHLY")]
        MONTHLY,
    }
    
    // Id: CommercialRangeEnum Namespace: vmwareCloudDirector
    public enum CommercialRangeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NSX")]
        NSX,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("STANDARD")]
        STANDARD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VSAN-NSX")]
        VSAN_NSX,
    }
    
    // Id: Compute Namespace: vmwareCloudDirector
    public class Compute {
        
        // Key: currentState Type: vmwareCloudDirector.compute.CurrentState FullType: vmwareCloudDirector.compute.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_compute.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: OrderableResource Namespace: vmwareCloudDirector
    public class OrderableResource {
        
        // Key: compute Type: vmwareCloudDirector.orderableResource.Compute[] FullType: vmwareCloudDirector.orderableResource.Compute[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("compute")]
        public required _vmwareCloudDirector_orderableResource.Compute[] Compute { get; set; }//;
        
        // Key: storage Type: vmwareCloudDirector.orderableResource.Storage[] FullType: vmwareCloudDirector.orderableResource.Storage[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public required _vmwareCloudDirector_orderableResource.Storage[] Storage { get; set; }//;
    }
    
    // Id: Organization Namespace: vmwareCloudDirector
    public class Organization {
        
        // Key: currentState Type: vmwareCloudDirector.organization.CurrentState FullType: vmwareCloudDirector.organization.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_organization.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: targetSpec Type: vmwareCloudDirector.organization.TargetSpec FullType: vmwareCloudDirector.organization.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_organization.TargetSpec TargetSpec { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: Organization Namespace: vmwareCloudDirector
    public class OrganizationWithIAM {
        
        // Key: currentState Type: vmwareCloudDirector.organization.CurrentState FullType: vmwareCloudDirector.organization.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_organization.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: targetSpec Type: vmwareCloudDirector.organization.TargetSpec FullType: vmwareCloudDirector.organization.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_organization.TargetSpec TargetSpec { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: Region Namespace: vmwareCloudDirector
    public class Region {
        
        // Key: location Type: vmwareCloudDirector.RegionLocationEnum FullType: vmwareCloudDirector.RegionLocationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
        public required _vmwareCloudDirector.RegionLocationEnum Location { get; set; }//;
        
        // Key: region Type: vmwareCloudDirector.RegionNameEnum FullType: vmwareCloudDirector.RegionNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required _vmwareCloudDirector.RegionNameEnum _Region { get; set; }//;
    }
    
    // Id: RegionLocationEnum Namespace: vmwareCloudDirector
    public enum RegionLocationEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Asia Pacific (Australia - Sydney)")]
        Asia_Pacific__Australia___Sydney_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Asia Pacific (Singapore -Singapore)")]
        Asia_Pacific__Singapore__Singapore_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (France - Gravelines)")]
        Europe__France___Gravelines_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (France - Paris)")]
        Europe__France___Paris_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (France - Roubaix)")]
        Europe__France___Roubaix_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (France - Strasbourg)")]
        Europe__France___Strasbourg_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (Germany - Limburg)")]
        Europe__Germany___Limburg_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (Poland - Warsaw)")]
        Europe__Poland___Warsaw_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Europe (United Kingdom - Erith)")]
        Europe__United_Kingdom___Erith_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("North America (Canada - East - Beauharnois)")]
        North_America__Canada___East___Beauharnois_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("North America (US - East - Vinthill)")]
        North_America__US___East___Vinthill_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("North America (US - West - Hillsboro)")]
        North_America__US___West___Hillsboro_,
    }
    
    // Id: RegionNameEnum Namespace: vmwareCloudDirector
    public enum RegionNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ap-south-mum")]
        ap_south_mum,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ap-southeast-sgp")]
        ap_southeast_sgp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ap-southeast-syd")]
        ap_southeast_syd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ca-east-bhs")]
        ca_east_bhs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-central-waw")]
        eu_central_waw,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-eri")]
        eu_west_eri,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-gra")]
        eu_west_gra,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-lim")]
        eu_west_lim,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-par")]
        eu_west_par,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-rbx")]
        eu_west_rbx,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-sbg")]
        eu_west_sbg,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("us-east-vin")]
        us_east_vin,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("us-west-hil")]
        us_west_hil,
    }
    
    // Id: Storage Namespace: vmwareCloudDirector
    public class Storage {
        
        // Key: currentState Type: vmwareCloudDirector.storage.CurrentState FullType: vmwareCloudDirector.storage.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_storage.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: VirtualDataCenter Namespace: vmwareCloudDirector
    public class VirtualDataCenter {
        
        // Key: currentState Type: vmwareCloudDirector.virtualDataCenter.CurrentState FullType: vmwareCloudDirector.virtualDataCenter.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_virtualDataCenter.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: targetSpec Type: vmwareCloudDirector.virtualDataCenter.TargetSpec FullType: vmwareCloudDirector.virtualDataCenter.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_virtualDataCenter.TargetSpec TargetSpec { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: VirtualDataCenter Namespace: vmwareCloudDirector
    public class VirtualDataCenterWithIAM {
        
        // Key: currentState Type: vmwareCloudDirector.virtualDataCenter.CurrentState FullType: vmwareCloudDirector.virtualDataCenter.CurrentState
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentState")]
        public required _vmwareCloudDirector_virtualDataCenter.CurrentState CurrentState { get; set; }//;
        
        // Key: currentTasks Type: common.CurrentTask[] FullType: common.CurrentTask[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentTasks")]
        public _common.CurrentTask[]? CurrentTasks { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: resourceStatus Type: common.ResourceStatusEnum FullType: common.ResourceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceStatus")]
        public required _common.ResourceStatusEnum ResourceStatus { get; set; }//;
        
        // Key: targetSpec Type: vmwareCloudDirector.virtualDataCenter.TargetSpec FullType: vmwareCloudDirector.virtualDataCenter.TargetSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetSpec")]
        public required _vmwareCloudDirector_virtualDataCenter.TargetSpec TargetSpec { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
}
