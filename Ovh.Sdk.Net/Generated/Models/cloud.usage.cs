//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_usage {
    
    
    // Id: PaymentTypeEnum Namespace: cloud.usage
    public enum PaymentTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("post")]
        post,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pre")]
        pre,
    }
    
    // Id: Period Namespace: cloud.usage
    public class Period {
        
        // Key: from Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("from")]
        public System.DateTime From { get; set; }//;
        
        // Key: to Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("to")]
        public System.DateTime To { get; set; }//;
    }
    
    // Id: UsageBill Namespace: cloud.usage
    public class UsageBill {
        
        // Key: bill_id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bill_id")]
        public string Bill_id { get; set; }//;
        
        // Key: credit Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("credit")]
        public double Credit { get; set; }//;
        
        // Key: part Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("part")]
        public double Part { get; set; }//;
        
        // Key: payment_type Type: cloud.usage.PaymentTypeEnum FullType: cloud.usage.PaymentTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("payment_type")]
        public _cloud_usage.PaymentTypeEnum Payment_type { get; set; }//;
        
        // Key: total Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("total")]
        public double Total { get; set; }//;
    }
    
    // Id: UsageCurrent Namespace: cloud.usage
    public class UsageCurrent {
        
        // Key: hourlyUsage Type: cloud.billingView.HourlyResources FullType: cloud.billingView.HourlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hourlyUsage")]
        public _cloud_billingView.HourlyResources? HourlyUsage { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: monthlyUsage Type: cloud.billingView.MonthlyResources FullType: cloud.billingView.MonthlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthlyUsage")]
        public _cloud_billingView.MonthlyResources? MonthlyUsage { get; set; }//;
        
        // Key: period Type: cloud.usage.Period FullType: cloud.usage.Period
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public _cloud_usage.Period Period { get; set; }//;
        
        // Key: resourcesUsage Type: cloud.billingView.TypedResources[] FullType: cloud.billingView.TypedResources[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourcesUsage")]
        public _cloud_billingView.TypedResources[]? ResourcesUsage { get; set; }//;
    }
    
    // Id: UsageCurrentBills Namespace: cloud.usage
    public class UsageCurrentBills {
        
        // Key: bills Type: cloud.usage.UsageBill[] FullType: cloud.usage.UsageBill[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bills")]
        public _cloud_usage.UsageBill[] Bills { get; set; }//;
    }
    
    // Id: UsageForecast Namespace: cloud.usage
    public class UsageForecast {
        
        // Key: hourlyUsage Type: cloud.billingView.HourlyResources FullType: cloud.billingView.HourlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hourlyUsage")]
        public _cloud_billingView.HourlyResources? HourlyUsage { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: monthlyUsage Type: cloud.billingView.MonthlyResources FullType: cloud.billingView.MonthlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthlyUsage")]
        public _cloud_billingView.MonthlyResources? MonthlyUsage { get; set; }//;
        
        // Key: period Type: cloud.usage.Period FullType: cloud.usage.Period
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public _cloud_usage.Period Period { get; set; }//;
        
        // Key: resourcesUsage Type: cloud.billingView.TypedResources[] FullType: cloud.billingView.TypedResources[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourcesUsage")]
        public _cloud_billingView.TypedResources[]? ResourcesUsage { get; set; }//;
        
        // Key: usableCredits Type: cloud.billingView.UsedCredits FullType: cloud.billingView.UsedCredits
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usableCredits")]
        public _cloud_billingView.UsedCredits? UsableCredits { get; set; }//;
    }
    
    // Id: UsageHistory Namespace: cloud.usage
    public class UsageHistory {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: period Type: cloud.usage.Period FullType: cloud.usage.Period
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public _cloud_usage.Period Period { get; set; }//;
    }
    
    // Id: UsageHistoryDetail Namespace: cloud.usage
    public class UsageHistoryDetail {
        
        // Key: hourlyUsage Type: cloud.billingView.HourlyResources FullType: cloud.billingView.HourlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hourlyUsage")]
        public _cloud_billingView.HourlyResources? HourlyUsage { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: monthlyUsage Type: cloud.billingView.MonthlyResources FullType: cloud.billingView.MonthlyResources
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthlyUsage")]
        public _cloud_billingView.MonthlyResources? MonthlyUsage { get; set; }//;
        
        // Key: period Type: cloud.usage.Period FullType: cloud.usage.Period
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public _cloud_usage.Period Period { get; set; }//;
        
        // Key: resourcesUsage Type: cloud.billingView.TypedResources[] FullType: cloud.billingView.TypedResources[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourcesUsage")]
        public _cloud_billingView.TypedResources[]? ResourcesUsage { get; set; }//;
    }
    
    // Id: UsageHistoryDetailBills Namespace: cloud.usage
    public class UsageHistoryDetailBills {
        
        // Key: bills Type: cloud.usage.UsageBill[] FullType: cloud.usage.UsageBill[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bills")]
        public _cloud_usage.UsageBill[] Bills { get; set; }//;
    }
}
