//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_catalog_dedicated_Product_Specification {
    
    
    // Id: CPU Namespace: order.catalog.dedicated.Product.Specification
    public class CPU {
        
        // Key: boost Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("boost")]
        public System.Double? Boost { get; set; }//;
        
        // Key: brand Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("brand")]
        public System.String? Brand { get; set; }//;
        
        // Key: cores Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cores")]
        public System.Int64? Cores { get; set; }//;
        
        // Key: frequency Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frequency")]
        public System.Double? Frequency { get; set; }//;
        
        // Key: model Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public System.String? Model { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: threads Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("threads")]
        public System.Int64? Threads { get; set; }//;
    }
    
    // Id: Disk Namespace: order.catalog.dedicated.Product.Specification
    public class Disk {
        
        // Key: number Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public long Number { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: raid Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("raid")]
        public string Raid { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: GPU Namespace: order.catalog.dedicated.Product.Specification
    public class GPU {
        
        // Key: model Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
        public System.String? Model { get; set; }//;
        
        // Key: number Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public System.Int64? Number { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
    }
    
    // Id: Memory Namespace: order.catalog.dedicated.Product.Specification
    public class Memory {
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public System.Int64? Size { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public System.String? Type { get; set; }//;
    }
    
    // Id: Network Namespace: order.catalog.dedicated.Product.Specification
    public class Network {
        
        // Key: failover Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failover")]
        public long Failover { get; set; }//;
        
        // Key: internal Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        public long @internal { get; set; }//;
        
        // Key: ip Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public long Ip { get; set; }//;
        
        // Key: outgoing Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoing")]
        public long Outgoing { get; set; }//;
        
        // Key: private Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("private")]
        public long @private { get; set; }//;
        
        // Key: privateBandwidth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateBandwidth")]
        public long PrivateBandwidth { get; set; }//;
    }
}