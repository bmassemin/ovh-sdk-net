//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _webPaaS {
    
    
    // Id: AddonFamilyEnum Namespace: webPaaS
    public enum AddonFamilyEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("staging_environment")]
        staging_environment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        storage,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user_license")]
        user_license,
    }
    
    // Id: AddonProductNameEnum Namespace: webPaaS
    public enum AddonProductNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("additional-staging-environment")]
        additional_staging_environment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("additional-storage")]
        additional_storage,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("additional-user-license")]
        additional_user_license,
    }
    
    // Id: AddonStatusEnum Namespace: webPaaS
    public enum AddonStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING")]
        PENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
    }
    
    // Id: Capabilities Namespace: webPaaS
    public class Capabilities {
        
        // Key: regions Type: webPaaS.RegionEnum[] FullType: webPaaS.RegionEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public _webPaaS.RegionEnum[] Regions { get; set; }//;
        
        // Key: templates Type: webPaaS.Template[] FullType: webPaaS.Template[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("templates")]
        public _webPaaS.Template[] Templates { get; set; }//;
    }
    
    // Id: CustomerTypeEnum Namespace: webPaaS
    public enum CustomerTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OWNER")]
        OWNER,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER")]
        USER,
    }
    
    // Id: OfferEnum Namespace: webPaaS
    public enum OfferEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("develop-1")]
        develop_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("develop-16")]
        develop_16,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("develop-2")]
        develop_2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("develop-4")]
        develop_4,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("develop-8")]
        develop_8,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expand-1")]
        expand_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expand-16")]
        expand_16,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expand-2")]
        expand_2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expand-4")]
        expand_4,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expand-8")]
        expand_8,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-1")]
        start_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-16")]
        start_16,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-2")]
        start_2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-4")]
        start_4,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-8")]
        start_8,
    }
    
    // Id: RegionEnum Namespace: webPaaS
    public enum RegionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GRA7")]
        GRA7,
    }
    
    // Id: StatusEnum Namespace: webPaaS
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CANCELED")]
        CANCELED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CANCELING")]
        CANCELING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CANCELLATION_REQUESTED")]
        CANCELLATION_REQUESTED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CLOSED")]
        CLOSED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXPIRED")]
        EXPIRED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING")]
        PENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SETTLED")]
        SETTLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SETTLING")]
        SETTLING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TERMINATED")]
        TERMINATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TO_SETTLE")]
        TO_SETTLE,
    }
    
    // Id: StorageUnitEnum Namespace: webPaaS
    public enum StorageUnitEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GB")]
        GB,
    }
    
    // Id: Subscription Namespace: webPaaS
    public class Subscription {
        
        // Key: addons Type: webPaaS.SubscriptionAddon[] FullType: webPaaS.SubscriptionAddon[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addons")]
        public _webPaaS.SubscriptionAddon[] Addons { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: metadata Type: webPaaS.SubscriptionMetadata FullType: webPaaS.SubscriptionMetadata
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metadata")]
        public _webPaaS.SubscriptionMetadata Metadata { get; set; }//;
        
        // Key: offer Type: webPaaS.OfferEnum FullType: webPaaS.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _webPaaS.OfferEnum Offer { get; set; }//;
        
        // Key: partnerProjectId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("partnerProjectId")]
        public System.String? PartnerProjectId { get; set; }//;
        
        // Key: projectName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("projectName")]
        public string ProjectName { get; set; }//;
        
        // Key: serviceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public string ServiceId { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateTime? StartDate { get; set; }//;
        
        // Key: status Type: webPaaS.StatusEnum FullType: webPaaS.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _webPaaS.StatusEnum Status { get; set; }//;
    }
    
    // Id: SubscriptionAddon Namespace: webPaaS
    public class SubscriptionAddon {
        
        // Key: planFamilyName Type: webPaaS.AddonFamilyEnum FullType: webPaaS.AddonFamilyEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planFamilyName")]
        public _webPaaS.AddonFamilyEnum PlanFamilyName { get; set; }//;
        
        // Key: productName Type: webPaaS.AddonProductNameEnum FullType: webPaaS.AddonProductNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productName")]
        public _webPaaS.AddonProductNameEnum ProductName { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: status Type: webPaaS.AddonStatusEnum FullType: webPaaS.AddonStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _webPaaS.AddonStatusEnum Status { get; set; }//;
    }
    
    // Id: SubscriptionMetadata Namespace: webPaaS
    public class SubscriptionMetadata {
        
        // Key: customer Type: webPaaS.subscription.Customer FullType: webPaaS.subscription.Customer
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customer")]
        public _webPaaS_subscription.Customer? Customer { get; set; }//;
        
        // Key: partnerConsole Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("partnerConsole")]
        public string PartnerConsole { get; set; }//;
        
        // Key: project Type: webPaaS.subscriptionMetadata.Project FullType: webPaaS.subscriptionMetadata.Project
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("project")]
        public _webPaaS_subscriptionMetadata.Project? Project { get; set; }//;
    }
    
    // Id: Subscription Namespace: webPaaS
    public class SubscriptionWithIAM {
        
        // Key: addons Type: webPaaS.SubscriptionAddon[] FullType: webPaaS.SubscriptionAddon[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addons")]
        public _webPaaS.SubscriptionAddon[] Addons { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: metadata Type: webPaaS.SubscriptionMetadata FullType: webPaaS.SubscriptionMetadata
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metadata")]
        public _webPaaS.SubscriptionMetadata Metadata { get; set; }//;
        
        // Key: offer Type: webPaaS.OfferEnum FullType: webPaaS.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _webPaaS.OfferEnum Offer { get; set; }//;
        
        // Key: partnerProjectId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("partnerProjectId")]
        public System.String? PartnerProjectId { get; set; }//;
        
        // Key: projectName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("projectName")]
        public string ProjectName { get; set; }//;
        
        // Key: serviceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public string ServiceId { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateTime? StartDate { get; set; }//;
        
        // Key: status Type: webPaaS.StatusEnum FullType: webPaaS.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _webPaaS.StatusEnum Status { get; set; }//;
    }
    
    // Id: Template Namespace: webPaaS
    public class Template {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: features Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("features")]
        public string[] Features { get; set; }//;
        
        // Key: image Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("image")]
        public string Image { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: template Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("template")]
        public string _Template { get; set; }//;
    }
}
