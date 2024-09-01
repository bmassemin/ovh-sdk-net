//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_capabilities {
    
    
    // Id: Availability Namespace: cloud.capabilities
    public class Availability {
        
        // Key: plans Type: cloud.capabilities.AvailabilityPlan[] FullType: cloud.capabilities.AvailabilityPlan[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public _cloud_capabilities.AvailabilityPlan[] Plans { get; set; }//;
        
        // Key: products Type: cloud.capabilities.AvailabilityProduct[] FullType: cloud.capabilities.AvailabilityProduct[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("products")]
        public _cloud_capabilities.AvailabilityProduct[] Products { get; set; }//;
    }
    
    // Id: AvailabilityPlan Namespace: cloud.capabilities
    public class AvailabilityPlan {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: regions Type: cloud.capabilities.AvailabilityRegion[] FullType: cloud.capabilities.AvailabilityRegion[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public _cloud_capabilities.AvailabilityRegion[] Regions { get; set; }//;
    }
    
    // Id: AvailabilityProduct Namespace: cloud.capabilities
    public class AvailabilityProduct {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: regions Type: cloud.capabilities.AvailabilityRegion[] FullType: cloud.capabilities.AvailabilityRegion[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public _cloud_capabilities.AvailabilityRegion[] Regions { get; set; }//;
    }
    
    // Id: AvailabilityRegion Namespace: cloud.capabilities
    public class AvailabilityRegion {
        
        // Key: continentCode Type: cloud.RegionContinentEnum FullType: cloud.RegionContinentEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("continentCode")]
        public _cloud.RegionContinentEnum ContinentCode { get; set; }//;
        
        // Key: datacenter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public string Datacenter { get; set; }//;
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: type Type: cloud.RegionTypeEnum FullType: cloud.RegionTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud.RegionTypeEnum Type { get; set; }//;
    }
}
