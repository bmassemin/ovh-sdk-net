//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _services_expanded {
    
    
    // Id: Route Namespace: services.expanded
    public class Route {
        
        // Key: path Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("path")]
        public string Path { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
        
        // Key: vars Type: complexType.SafeKeyValue<string>[] FullType: complexType.SafeKeyValue<string>[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vars")]
        public _complexType.SafeKeyValue<string> Vars { get; set; }//;
    }
    
    // Id: Billing Namespace: services.expanded
    public class Billing {
        
        // Key: engagement Type: services.expanded.EngagementSummary FullType: services.expanded.EngagementSummary
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engagement")]
        public _services_expanded.EngagementSummary Engagement { get; set; }//;
        
        // Key: engagementRequest Type: services.expanded.EngagementRequestSummary FullType: services.expanded.EngagementRequestSummary
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engagementRequest")]
        public _services_expanded.EngagementRequestSummary EngagementRequest { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateTime ExpirationDate { get; set; }//;
        
        // Key: group Type: services.expanded.Group FullType: services.expanded.Group
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public _services_expanded.Group Group { get; set; }//;
        
        // Key: lifecycle Type: services.expanded.Lifecycle FullType: services.expanded.Lifecycle
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lifecycle")]
        public _services_expanded.Lifecycle Lifecycle { get; set; }//;
        
        // Key: nextBillingDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nextBillingDate")]
        public System.DateTime NextBillingDate { get; set; }//;
        
        // Key: plan Type: services.expanded.Plan FullType: services.expanded.Plan
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plan")]
        public _services_expanded.Plan Plan { get; set; }//;
        
        // Key: pricing Type: services.billing.Pricing FullType: services.billing.Pricing
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricing")]
        public _services_billing.Pricing Pricing { get; set; }//;
        
        // Key: renew Type: services.expanded.Renew FullType: services.expanded.Renew
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renew")]
        public _services_expanded.Renew Renew { get; set; }//;
    }
    
    // Id: Customer Namespace: services.expanded
    public class Customer {
        
        // Key: contacts Type: services.expanded.Customer.Contact[] FullType: services.expanded.Customer.Contact[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contacts")]
        public _services_expanded_Customer.Contact[] Contacts { get; set; }//;
    }
    
    // Id: EngagementRequestSummary Namespace: services.expanded
    public class EngagementRequestSummary {
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: requestDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestDate")]
        public System.DateOnly RequestDate { get; set; }//;
    }
    
    // Id: EngagementSummary Namespace: services.expanded
    public class EngagementSummary {
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly EndDate { get; set; }//;
        
        // Key: endRule Type: services.billing.engagement.EndRule FullType: services.billing.engagement.EndRule
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endRule")]
        public _services_billing_engagement.EndRule EndRule { get; set; }//;
    }
    
    // Id: Group Namespace: services.expanded
    public class Group {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
    }
    
    // Id: Lifecycle Namespace: services.expanded
    public class Lifecycle {
        
        // Key: capacities Type: services.expanded.Lifecycle.Capacities FullType: services.expanded.Lifecycle.Capacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("capacities")]
        public _services_expanded_Lifecycle.Capacities Capacities { get; set; }//;
        
        // Key: current Type: services.expanded.Lifecycle.Current FullType: services.expanded.Lifecycle.Current
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public _services_expanded_Lifecycle.Current Current { get; set; }//;
    }
    
    // Id: Plan Namespace: services.expanded
    public class Plan {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: invoiceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("invoiceName")]
        public string InvoiceName { get; set; }//;
    }
    
    // Id: Product Namespace: services.expanded
    public class Product {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Renew Namespace: services.expanded
    public class Renew {
        
        // Key: capacities Type: services.expanded.Renew.Capacities FullType: services.expanded.Renew.Capacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("capacities")]
        public _services_expanded_Renew.Capacities Capacities { get; set; }//;
        
        // Key: current Type: services.expanded.Renew.Current FullType: services.expanded.Renew.Current
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public _services_expanded_Renew.Current Current { get; set; }//;
    }
    
    // Id: ResellingProviderEnum Namespace: services.expanded
    public enum ResellingProviderEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovh.ca")]
        ovh_ca,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovh.eu")]
        ovh_eu,
    }
    
    // Id: Resource Namespace: services.expanded
    public class Resource {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: product Type: services.expanded.Product FullType: services.expanded.Product
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("product")]
        public _services_expanded.Product Product { get; set; }//;
        
        // Key: resellingProvider Type: services.expanded.ResellingProviderEnum FullType: services.expanded.ResellingProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resellingProvider")]
        public _services_expanded.ResellingProviderEnum ResellingProvider { get; set; }//;
        
        // Key: state Type: services.expanded.Resource.StateEnum FullType: services.expanded.Resource.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _services_expanded_Resource.StateEnum State { get; set; }//;
    }
    
    // Id: Service Namespace: services.expanded
    public class Service {
        
        // Key: billing Type: services.expanded.Billing FullType: services.expanded.Billing
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billing")]
        public _services_expanded.Billing Billing { get; set; }//;
        
        // Key: customer Type: services.expanded.Customer FullType: services.expanded.Customer
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customer")]
        public _services_expanded.Customer Customer { get; set; }//;
        
        // Key: parentServiceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parentServiceId")]
        public long ParentServiceId { get; set; }//;
        
        // Key: resource Type: services.expanded.Resource FullType: services.expanded.Resource
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resource")]
        public _services_expanded.Resource Resource { get; set; }//;
        
        // Key: route Type: services.expanded.Route FullType: services.expanded.Route
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("route")]
        public _services_expanded.Route Route { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
        
        // Key: tags Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
        public string[] Tags { get; set; }//;
    }
    
    // Id: TechnicalDetails Namespace: services.expanded
    public class TechnicalDetails {
        
        // Key: baremetalServers Type: services.expanded.technical.BaremetalServer FullType: services.expanded.technical.BaremetalServer
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baremetalServers")]
        public _services_expanded_technical.BaremetalServer BaremetalServers { get; set; }//;
        
        // Key: nutanixCluster Type: services.expanded.technical.NutanixCluster FullType: services.expanded.technical.NutanixCluster
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nutanixCluster")]
        public _services_expanded_technical.NutanixCluster NutanixCluster { get; set; }//;
    }
    
    // Id: terminationPolicyEnum Namespace: services.expanded
    public enum terminationPolicyEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("empty")]
        empty,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("terminateAtEngagementDate")]
        terminateAtEngagementDate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("terminateAtExpirationDate")]
        terminateAtExpirationDate,
    }
}
