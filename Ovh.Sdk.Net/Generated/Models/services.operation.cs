//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _services_operation {
    
    
    // Id: AddonDetachExecutionRequest Namespace: services.operation
    public class AddonDetachExecutionRequest {
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
    }
    
    // Id: DetachExecutionRequest Namespace: services.operation
    public class DetachExecutionRequest {
        
        // Key: addons Type: services.operation.AddonDetachExecutionRequest[] FullType: services.operation.AddonDetachExecutionRequest[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addons")]
        public _services_operation.AddonDetachExecutionRequest[]? Addons { get; set; }//;
        
        // Key: autoPayWithPreferredPaymentMethod Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoPayWithPreferredPaymentMethod")]
        public bool AutoPayWithPreferredPaymentMethod { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: DetachOptionsDefinition Namespace: services.operation
    public class DetachOptionsDefinition {
        
        // Key: plans Type: order.cart.GenericProductDefinition[] FullType: order.cart.GenericProductDefinition[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public _order_cart.GenericProductDefinition[] Plans { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
    }
    
    // Id: ExecutionRequest Namespace: services.operation
    public class ExecutionRequest {
        
        // Key: autoPayWithPreferredPaymentMethod Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoPayWithPreferredPaymentMethod")]
        public bool AutoPayWithPreferredPaymentMethod { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: Order Namespace: services.operation
    public class Order {
        
        // Key: order Type: order.Order FullType: order.Order
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
        public _order.Order? _Order { get; set; }//;
    }
}
