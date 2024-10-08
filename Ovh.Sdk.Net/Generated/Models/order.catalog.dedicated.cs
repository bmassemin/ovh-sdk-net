//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _order_catalog_dedicated {
    
    
    // Id: Catalog Namespace: order.catalog.dedicated
    public class Catalog {
        
        // Key: families Type: order.catalog.dedicated.Family[] FullType: order.catalog.dedicated.Family[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("families")]
        public required _order_catalog_dedicated.Family[] Families { get; set; }//;
        
        // Key: metadatas Type: order.catalog.dedicated.Metadata FullType: order.catalog.dedicated.Metadata
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metadatas")]
        public required _order_catalog_dedicated.Metadata Metadatas { get; set; }//;
        
        // Key: products Type: order.catalog.dedicated.Product[] FullType: order.catalog.dedicated.Product[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("products")]
        public required _order_catalog_dedicated.Product[] Products { get; set; }//;
        
        // Key: techDetails Type: order.catalog.dedicated.TechDetails[] FullType: order.catalog.dedicated.TechDetails[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("techDetails")]
        public required _order_catalog_dedicated.TechDetails[] TechDetails { get; set; }//;
    }
    
    // Id: Family Namespace: order.catalog.dedicated
    public class Family {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: products Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("products")]
        public required System.String[] Products { get; set; }//;
    }
    
    // Id: Metadata Namespace: order.catalog.dedicated
    public class Metadata {
        
        // Key: catalog Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("catalog")]
        public required System.Int64 Catalog { get; set; }//;
        
        // Key: core Type: order.catalog.dedicated.Metadata.Capacities FullType: order.catalog.dedicated.Metadata.Capacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("core")]
        public required _order_catalog_dedicated_Metadata.Capacities Core { get; set; }//;
        
        // Key: currency Type: order.catalog.dedicated.Metadata.Currency FullType: order.catalog.dedicated.Metadata.Currency
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currency")]
        public required _order_catalog_dedicated_Metadata.Currency Currency { get; set; }//;
        
        // Key: datacenters Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public required System.String[] Datacenters { get; set; }//;
        
        // Key: frequency Type: order.catalog.dedicated.Metadata.Frequency FullType: order.catalog.dedicated.Metadata.Frequency
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frequency")]
        public required _order_catalog_dedicated_Metadata.Frequency Frequency { get; set; }//;
        
        // Key: merchant Type: nichandle.OvhSubsidiaryEnum FullType: nichandle.OvhSubsidiaryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("merchant")]
        public required _nichandle.OvhSubsidiaryEnum Merchant { get; set; }//;
        
        // Key: price Type: order.catalog.dedicated.Metadata.Price FullType: order.catalog.dedicated.Metadata.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order_catalog_dedicated_Metadata.Price Price { get; set; }//;
        
        // Key: ram Type: order.catalog.dedicated.Metadata.Capacities FullType: order.catalog.dedicated.Metadata.Capacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ram")]
        public required _order_catalog_dedicated_Metadata.Capacities Ram { get; set; }//;
        
        // Key: thread Type: order.catalog.dedicated.Metadata.Capacities FullType: order.catalog.dedicated.Metadata.Capacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("thread")]
        public required _order_catalog_dedicated_Metadata.Capacities Thread { get; set; }//;
        
        // Key: timestamp Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public required System.Int64 Timestamp { get; set; }//;
    }
    
    // Id: Product Namespace: order.catalog.dedicated
    public class Product {
        
        // Key: addonsFamily Type: order.catalog.dedicated.Product.AddonFamily[] FullType: order.catalog.dedicated.Product.AddonFamily[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addonsFamily")]
        public required _order_catalog_dedicated_Product.AddonFamily[] AddonsFamily { get; set; }//;
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public required System.String Code { get; set; }//;
        
        // Key: compatibilities Type: order.catalog.dedicated.Product.Compatibility[] FullType: order.catalog.dedicated.Product.Compatibility[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("compatibilities")]
        public _order_catalog_dedicated_Product.Compatibility[]? Compatibilities { get; set; }//;
        
        // Key: datacenters Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public required System.String[] Datacenters { get; set; }//;
        
        // Key: derivatives Type: order.catalog.dedicated.Product.AddonItem[] FullType: order.catalog.dedicated.Product.AddonItem[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("derivatives")]
        public _order_catalog_dedicated_Product.AddonItem[]? Derivatives { get; set; }//;
        
        // Key: family Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("family")]
        public required System.String Family { get; set; }//;
        
        // Key: invoiceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("invoiceName")]
        public required System.String InvoiceName { get; set; }//;
        
        // Key: isChildOf Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isChildOf")]
        public System.String? IsChildOf { get; set; }//;
        
        // Key: isParentOf Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isParentOf")]
        public System.String[]? IsParentOf { get; set; }//;
        
        // Key: prices Type: order.catalog.dedicated.Product.Price FullType: order.catalog.dedicated.Product.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public required _order_catalog_dedicated_Product.Price Prices { get; set; }//;
        
        // Key: specifications Type: order.catalog.dedicated.Product.Specification FullType: order.catalog.dedicated.Product.Specification
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("specifications")]
        public required _order_catalog_dedicated_Product.Specification Specifications { get; set; }//;
    }
    
    // Id: TechDetails Namespace: order.catalog.dedicated
    public class TechDetails {
        
        // Key: plans Type: order.catalog.dedicated.TechDetails.Plan[] FullType: order.catalog.dedicated.TechDetails.Plan[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public required _order_catalog_dedicated_TechDetails.Plan[] Plans { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
    }
}
