//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_catalog_dedicated_Product {
    
    
    // Id: AddonFamily Namespace: order.catalog.dedicated.Product
    public class AddonFamily {
        
        // Key: addons Type: order.catalog.dedicated.Product.AddonItem[] FullType: order.catalog.dedicated.Product.AddonItem[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addons")]
        public _order_catalog_dedicated_Product.AddonItem[] Addons { get; set; }//;
        
        // Key: family Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("family")]
        public string Family { get; set; }//;
    }
    
    // Id: AddonItem Namespace: order.catalog.dedicated.Product
    public class AddonItem {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: datacenters Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public string[] Datacenters { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: options Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public string Options { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price Price { get; set; }//;
    }
    
    // Id: Compatibility Namespace: order.catalog.dedicated.Product
    public class Compatibility {
        
        // Key: plan Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plan")]
        public string Plan { get; set; }//;
        
        // Key: restrictions Type: order.catalog.dedicated.Product.Compatibility.Restriction[] FullType: order.catalog.dedicated.Product.Compatibility.Restriction[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restrictions")]
        public _order_catalog_dedicated_Product_Compatibility.Restriction[] Restrictions { get; set; }//;
        
        // Key: specificities Type: order.catalog.dedicated.TechDetails.Plan.Specificity[] FullType: order.catalog.dedicated.TechDetails.Plan.Specificity[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("specificities")]
        public _order_catalog_dedicated_TechDetails_Plan.Specificity[] Specificities { get; set; }//;
    }
    
    // Id: Price Namespace: order.catalog.dedicated.Product
    public class Price {
        
        // Key: default Type: order.catalog.dedicated.Product.Price.Default FullType: order.catalog.dedicated.Product.Price.Default
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public _order_catalog_dedicated_Product_Price.Default @default { get; set; }//;
        
        // Key: hardzone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardzone")]
        public string Hardzone { get; set; }//;
        
        // Key: week Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("week")]
        public string Week { get; set; }//;
    }
    
    // Id: Specification Namespace: order.catalog.dedicated.Product
    public class Specification {
        
        // Key: cpu Type: order.catalog.dedicated.Product.Specification.CPU FullType: order.catalog.dedicated.Product.Specification.CPU
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cpu")]
        public _order_catalog_dedicated_Product_Specification.CPU Cpu { get; set; }//;
        
        // Key: disks Type: order.catalog.dedicated.Product.Specification.Disk[] FullType: order.catalog.dedicated.Product.Specification.Disk[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disks")]
        public _order_catalog_dedicated_Product_Specification.Disk[] Disks { get; set; }//;
        
        // Key: gpu Type: order.catalog.dedicated.Product.Specification.GPU FullType: order.catalog.dedicated.Product.Specification.GPU
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gpu")]
        public _order_catalog_dedicated_Product_Specification.GPU Gpu { get; set; }//;
        
        // Key: memory Type: order.catalog.dedicated.Product.Specification.Memory FullType: order.catalog.dedicated.Product.Specification.Memory
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memory")]
        public _order_catalog_dedicated_Product_Specification.Memory Memory { get; set; }//;
        
        // Key: network Type: order.catalog.dedicated.Product.Specification.Network FullType: order.catalog.dedicated.Product.Specification.Network
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public _order_catalog_dedicated_Product_Specification.Network Network { get; set; }//;
    }
}
