//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _me_billing_purchaseOrder {
    
    
    // Id: Creation Namespace: me.billing.purchaseOrder
    public class Creation {
        
        // Key: active Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        public System.Boolean? Active { get; set; }//;
        
        // Key: billingGroupId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingGroupId")]
        public System.Int64? BillingGroupId { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly? EndDate { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public required System.String Reference { get; set; }//;
        
        // Key: startDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public required System.DateOnly StartDate { get; set; }//;
        
        // Key: type Type: me.billing.purchaseOrder.PurchaseOrderTypeEnum FullType: me.billing.purchaseOrder.PurchaseOrderTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _me_billing_purchaseOrder.PurchaseOrderTypeEnum Type { get; set; }//;
    }
    
    // Id: PurchaseOrder Namespace: me.billing.purchaseOrder
    public class PurchaseOrder {
        
        // Key: active Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        public System.Boolean? Active { get; set; }//;
        
        // Key: billingGroupId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingGroupId")]
        public System.Int64? BillingGroupId { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly? EndDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public required System.DateTime LastUpdate { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public required System.String Reference { get; set; }//;
        
        // Key: startDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public required System.DateOnly StartDate { get; set; }//;
        
        // Key: status Type: me.billing.purchaseOrder.StatusEnum FullType: me.billing.purchaseOrder.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _me_billing_purchaseOrder.StatusEnum Status { get; set; }//;
        
        // Key: type Type: me.billing.purchaseOrder.PurchaseOrderTypeEnum FullType: me.billing.purchaseOrder.PurchaseOrderTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _me_billing_purchaseOrder.PurchaseOrderTypeEnum Type { get; set; }//;
    }
    
    // Id: PurchaseOrderTypeEnum Namespace: me.billing.purchaseOrder
    public enum PurchaseOrderTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PURCHASE_ORDER")]
        PURCHASE_ORDER,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REFERENCE_ORDER")]
        REFERENCE_ORDER,
    }
    
    // Id: StatusEnum Namespace: me.billing.purchaseOrder
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATED")]
        CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
    }
    
    // Id: Update Namespace: me.billing.purchaseOrder
    public class Update {
        
        // Key: active Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        public System.Boolean? Active { get; set; }//;
        
        // Key: billingGroupId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingGroupId")]
        public System.Int64? BillingGroupId { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly? EndDate { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public System.String? Reference { get; set; }//;
        
        // Key: startDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateOnly? StartDate { get; set; }//;
        
        // Key: type Type: me.billing.purchaseOrder.PurchaseOrderTypeEnum FullType: me.billing.purchaseOrder.PurchaseOrderTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _me_billing_purchaseOrder.PurchaseOrderTypeEnum? Type { get; set; }//;
    }
}
