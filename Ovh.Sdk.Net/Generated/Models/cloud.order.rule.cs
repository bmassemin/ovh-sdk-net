//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_order_rule {
    
    
    // Id: Availability Namespace: cloud.order.rule
    public class Availability {
        
        // Key: plans Type: cloud.order.rule.AvailabilityPlan[] FullType: cloud.order.rule.AvailabilityPlan[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public _cloud_order_rule.AvailabilityPlan[] Plans { get; set; }//;
        
        // Key: products Type: cloud.order.rule.AvailabilityProduct[] FullType: cloud.order.rule.AvailabilityProduct[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("products")]
        public _cloud_order_rule.AvailabilityProduct[] Products { get; set; }//;
    }
    
    // Id: AvailabilityPlan Namespace: cloud.order.rule
    public class AvailabilityPlan {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: regions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public string[] Regions { get; set; }//;
    }
    
    // Id: AvailabilityProduct Namespace: cloud.order.rule
    public class AvailabilityProduct {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: regions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public string[] Regions { get; set; }//;
    }
    
    // Id: InstanceCategories Namespace: cloud.order.rule
    public class InstanceCategories {
        
        // Key: categories Type: cloud.order.rule.InstanceCategory[] FullType: cloud.order.rule.InstanceCategory[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("categories")]
        public _cloud_order_rule.InstanceCategory[] Categories { get; set; }//;
        
        // Key: defaultCategory Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultCategory")]
        public string DefaultCategory { get; set; }//;
    }
    
    // Id: InstanceCategory Namespace: cloud.order.rule
    public class InstanceCategory {
        
        // Key: category Type: cloud.order.rule.InstanceCategoryTypeEnum FullType: cloud.order.rule.InstanceCategoryTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("category")]
        public _cloud_order_rule.InstanceCategoryTypeEnum Category { get; set; }//;
        
        // Key: isNew Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isNew")]
        public System.Boolean? IsNew { get; set; }//;
        
        // Key: kinds Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kinds")]
        public string[] Kinds { get; set; }//;
        
        // Key: title Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("title")]
        public string Title { get; set; }//;
    }
    
    // Id: InstanceCategoryTypeEnum Namespace: cloud.order.rule
    public enum InstanceCategoryTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accelerated")]
        accelerated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balanced")]
        balanced,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baremetal")]
        baremetal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("discovery")]
        discovery,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iops")]
        iops,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ram")]
        ram,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vps")]
        vps,
    }
}
