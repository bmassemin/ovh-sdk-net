//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _services_consumption {
    
    
    // Id: Detail Namespace: services.consumption
    public class Detail {
        
        // Key: beginDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("beginDate")]
        public System.DateTime? BeginDate { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public required System.String PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public required System.Int64 Quantity { get; set; }//;
    }
    
    // Id: Element Namespace: services.consumption
    public class Element {
        
        // Key: details Type: services.consumption.Detail[] FullType: services.consumption.Detail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public required _services_consumption.Detail[] Details { get; set; }//;
        
        // Key: metadata Type: complexType.SafeKeyValue<string>[] FullType: complexType.SafeKeyValue<string>[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metadata")]
        public _complexType.SafeKeyValue<string>? Metadata { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public required System.String PlanCode { get; set; }//;
        
        // Key: planFamily Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planFamily")]
        public required System.String PlanFamily { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public required System.Int64 Quantity { get; set; }//;
        
        // Key: uniqueId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uniqueId")]
        public System.String? UniqueId { get; set; }//;
    }
    
    // Id: PricePlanFamily Namespace: services.consumption
    public class PricePlanFamily {
        
        // Key: planFamily Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planFamily")]
        public required System.String PlanFamily { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
    }
    
    // Id: Summary Namespace: services.consumption
    public class Summary {
        
        // Key: beginDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("beginDate")]
        public required System.DateTime BeginDate { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public required System.DateTime EndDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public System.Int64? OrderId { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
        
        // Key: priceByPlanFamily Type: services.consumption.PricePlanFamily[] FullType: services.consumption.PricePlanFamily[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priceByPlanFamily")]
        public required _services_consumption.PricePlanFamily[] PriceByPlanFamily { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public required System.Int64 ServiceId { get; set; }//;
    }
}
