//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _serviceList {
    
    
    // Id: Service Namespace: serviceList
    public class Service {
        
        // Key: creationDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateOnly CreationDate { get; set; }//;
        
        // Key: details Type: complexType.SafeKeyValue<string>[] FullType: complexType.SafeKeyValue<string>[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _complexType.SafeKeyValue<string> Details { get; set; }//;
        
        // Key: engagementDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engagementDate")]
        public System.DateOnly? EngagementDate { get; set; }//;
        
        // Key: expirationDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateOnly? ExpirationDate { get; set; }//;
        
        // Key: nextBillingDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nextBillingDate")]
        public System.DateOnly? NextBillingDate { get; set; }//;
        
        // Key: plan Type: service.Plan FullType: service.Plan
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plan")]
        public _service.Plan Plan { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
        
        // Key: renew Type: service.Renew FullType: service.Renew
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renew")]
        public _service.Renew? Renew { get; set; }//;
        
        // Key: resource Type: service.Resource FullType: service.Resource
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resource")]
        public _service.Resource Resource { get; set; }//;
        
        // Key: route Type: service.Route FullType: service.Route
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("route")]
        public _service.Route Route { get; set; }//;
        
        // Key: state Type: service.BillingStateEnum FullType: service.BillingStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _service.BillingStateEnum State { get; set; }//;
    }
}
