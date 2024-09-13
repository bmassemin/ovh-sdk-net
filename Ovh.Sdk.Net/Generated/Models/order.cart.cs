//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_cart {
    
    
    // Id: GenericProductDefinition Namespace: order.cart
    public class GenericProductDefinition {
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: prices Type: order.cart.GenericProductPricing[] FullType: order.cart.GenericProductPricing[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.GenericProductPricing[] Prices { get; set; }//;
        
        // Key: productName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productName")]
        public string ProductName { get; set; }//;
        
        // Key: productType Type: order.cart.GenericProductTypeEnum FullType: order.cart.GenericProductTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productType")]
        public _order_cart.GenericProductTypeEnum ProductType { get; set; }//;
    }
    
    // Id: GenericProductPricing Namespace: order.cart
    public class GenericProductPricing {
        
        // Key: capacities Type: order.cart.GenericProductPricingCapacitiesEnum[] FullType: order.cart.GenericProductPricingCapacitiesEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("capacities")]
        public _order_cart.GenericProductPricingCapacitiesEnum[] Capacities { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: interval Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interval")]
        public long Interval { get; set; }//;
        
        // Key: maximumQuantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maximumQuantity")]
        public System.Int64? MaximumQuantity { get; set; }//;
        
        // Key: maximumRepeat Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maximumRepeat")]
        public System.Int64? MaximumRepeat { get; set; }//;
        
        // Key: minimumQuantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minimumQuantity")]
        public long MinimumQuantity { get; set; }//;
        
        // Key: minimumRepeat Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minimumRepeat")]
        public long MinimumRepeat { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price Price { get; set; }//;
        
        // Key: priceInUcents Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priceInUcents")]
        public long PriceInUcents { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: pricingType Type: order.cart.GenericProductPricingTypeEnum FullType: order.cart.GenericProductPricingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingType")]
        public _order_cart.GenericProductPricingTypeEnum PricingType { get; set; }//;
    }
    
    // Id: GenericProductPricingCapacitiesEnum Namespace: order.cart
    public enum GenericProductPricingCapacitiesEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("consumption")]
        consumption,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("detach")]
        detach,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downgrade")]
        downgrade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dynamic")]
        dynamic,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installation")]
        installation,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renew")]
        renew,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upgrade")]
        upgrade,
    }
    
    // Id: GenericProductPricingTypeEnum Namespace: order.cart
    public enum GenericProductPricingTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("consumption")]
        consumption,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("purchase")]
        purchase,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rental")]
        rental,
    }
    
    // Id: GenericProductTypeEnum Namespace: order.cart
    public enum GenericProductTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloud_service")]
        cloud_service,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delivery")]
        delivery,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deposit")]
        deposit,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        domain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("implementation_services")]
        implementation_services,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("saas_license")]
        saas_license,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shipping")]
        shipping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        storage,
    }
    
    // Id: Cart Namespace: order.cart
    public class Cart {
        
        // Key: cartId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cartId")]
        public string CartId { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: expire Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expire")]
        public System.DateTime? Expire { get; set; }//;
        
        // Key: items Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("items")]
        public long[] Items { get; set; }//;
        
        // Key: readOnly Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readOnly")]
        public bool ReadOnly { get; set; }//;
    }
    
    // Id: Checkout Namespace: order.cart
    public class Checkout {
        
        // Key: autoPayWithPreferredPaymentMethod Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoPayWithPreferredPaymentMethod")]
        public bool AutoPayWithPreferredPaymentMethod { get; set; }//;
        
        // Key: waiveRetractationPeriod Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waiveRetractationPeriod")]
        public bool WaiveRetractationPeriod { get; set; }//;
    }
    
    // Id: ConfigurationItem Namespace: order.cart
    public class ConfigurationItem {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public string Label { get; set; }//;
        
        // Key: value Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public string Value { get; set; }//;
    }
    
    // Id: ConfigurationRequirements Namespace: order.cart
    public class ConfigurationRequirements {
        
        // Key: fields Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fields")]
        public System.String[]? Fields { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public string Label { get; set; }//;
        
        // Key: required Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("required")]
        public bool Required { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: CouponCreation Namespace: order.cart
    public class CouponCreation {
        
        // Key: coupon Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("coupon")]
        public string Coupon { get; set; }//;
    }
    
    // Id: Creation Namespace: order.cart
    public class Creation {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: expire Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expire")]
        public System.DateTime Expire { get; set; }//;
        
        // Key: ovhSubsidiary Type: nichandle.OvhSubsidiaryEnum FullType: nichandle.OvhSubsidiaryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhSubsidiary")]
        public _nichandle.OvhSubsidiaryEnum OvhSubsidiary { get; set; }//;
    }
    
    // Id: DomainActionEnum Namespace: order.cart
    public enum DomainActionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("create")]
        create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trade")]
        trade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transfer")]
        transfer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        update,
    }
    
    // Id: DomainPacksCreation Namespace: order.cart
    public class DomainPacksCreation {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: duration Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public string Duration { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: DomainPacksDescription Namespace: order.cart
    public class DomainPacksDescription {
        
        // Key: domains Type: order.cart.DomainPacksDescriptionItem[] FullType: order.cart.DomainPacksDescriptionItem[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domains")]
        public _order_cart.DomainPacksDescriptionItem[] Domains { get; set; }//;
    }
    
    // Id: DomainPacksDescriptionItem Namespace: order.cart
    public class DomainPacksDescriptionItem {
        
        // Key: available Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        public bool Available { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
    }
    
    // Id: DomainPacksProductInformation Namespace: order.cart
    public class DomainPacksProductInformation {
        
        // Key: description Type: order.cart.DomainPacksDescription FullType: order.cart.DomainPacksDescription
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public _order_cart.DomainPacksDescription Description { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: prices Type: order.cart.GenericProductPricing[] FullType: order.cart.GenericProductPricing[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.GenericProductPricing[] Prices { get; set; }//;
    }
    
    // Id: DomainSettings Namespace: order.cart
    public class DomainSettings {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
    }
    
    // Id: DurationUnitEnum Namespace: order.cart
    public enum DurationUnitEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day")]
        day,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hour")]
        hour,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("month")]
        month,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("none")]
        none,
    }
    
    // Id: GenericDomainCreation Namespace: order.cart
    public class GenericDomainCreation {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan? Duration { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public System.String? OfferId { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public System.String? PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public System.Int64? Quantity { get; set; }//;
    }
    
    // Id: GenericDomainOptionsCreation Namespace: order.cart
    public class GenericDomainOptionsCreation {
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: itemId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("itemId")]
        public long ItemId { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: GenericOptionCreation Namespace: order.cart
    public class GenericOptionCreation {
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: itemId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("itemId")]
        public long ItemId { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: GenericOptionDefinition Namespace: order.cart
    public class GenericOptionDefinition {
        
        // Key: exclusive Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exclusive")]
        public bool Exclusive { get; set; }//;
        
        // Key: family Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("family")]
        public string Family { get; set; }//;
        
        // Key: mandatory Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mandatory")]
        public bool Mandatory { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: prices Type: order.cart.GenericProductPricing[] FullType: order.cart.GenericProductPricing[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.GenericProductPricing[] Prices { get; set; }//;
        
        // Key: productName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productName")]
        public string ProductName { get; set; }//;
        
        // Key: productType Type: order.cart.GenericProductTypeEnum FullType: order.cart.GenericProductTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productType")]
        public _order_cart.GenericProductTypeEnum ProductType { get; set; }//;
    }
    
    // Id: GenericProductCreation Namespace: order.cart
    public class GenericProductCreation {
        
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
    }
    
    // Id: GenericProductPricingStrategyEnum Namespace: order.cart
    public enum GenericProductPricingStrategyEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stairstep")]
        stairstep,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tiered")]
        tiered,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volume")]
        volume,
    }
    
    // Id: Item Namespace: order.cart
    public class Item {
        
        // Key: cartId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cartId")]
        public string CartId { get; set; }//;
        
        // Key: configurations Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configurations")]
        public System.Int64[]? Configurations { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan? Duration { get; set; }//;
        
        // Key: itemId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("itemId")]
        public long ItemId { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public System.String? OfferId { get; set; }//;
        
        // Key: options Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public long[] Options { get; set; }//;
        
        // Key: parentItemId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parentItemId")]
        public System.Int64? ParentItemId { get; set; }//;
        
        // Key: prices Type: order.cart.Price[] FullType: order.cart.Price[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.Price[] Prices { get; set; }//;
        
        // Key: productId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productId")]
        public string ProductId { get; set; }//;
        
        // Key: settings Type: order.cart.ItemSettings FullType: order.cart.ItemSettings
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("settings")]
        public _order_cart.ItemSettings Settings { get; set; }//;
    }
    
    // Id: ItemConfigurationCreation Namespace: order.cart
    public class ItemConfigurationCreation {
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public string Label { get; set; }//;
        
        // Key: value Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public string Value { get; set; }//;
    }
    
    // Id: ItemSettings Namespace: order.cart
    public class ItemSettings {
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public System.String? PricingMode { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public System.Int64? Quantity { get; set; }//;
    }
    
    // Id: ItemUpdate Namespace: order.cart
    public class ItemUpdate {
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
    
    // Id: Price Namespace: order.cart
    public class Price {
        
        // Key: label Type: order.cart.PriceLabelEnum FullType: order.cart.PriceLabelEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public _order_cart.PriceLabelEnum Label { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price _Price { get; set; }//;
        
        // Key: promotions Type: order.cart.Promotion[] FullType: order.cart.Promotion[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("promotions")]
        public _order_cart.Promotion[]? Promotions { get; set; }//;
    }
    
    // Id: PriceLabelEnum Namespace: order.cart
    public enum PriceLabelEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DISCOUNT")]
        DISCOUNT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FEE")]
        FEE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PRICE")]
        PRICE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RENEW")]
        RENEW,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TOTAL")]
        TOTAL,
    }
    
    // Id: ProductInformation Namespace: order.cart
    public class ProductInformation {
        
        // Key: action Type: order.cart.DomainActionEnum FullType: order.cart.DomainActionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("action")]
        public _order_cart.DomainActionEnum Action { get; set; }//;
        
        // Key: configurations Type: order.cart.ConfigurationRequirements[] FullType: order.cart.ConfigurationRequirements[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configurations")]
        public _order_cart.ConfigurationRequirements[] Configurations { get; set; }//;
        
        // Key: deliveryTime Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deliveryTime")]
        public string DeliveryTime { get; set; }//;
        
        // Key: duration Type: duration[] FullType: duration[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan[] Duration { get; set; }//;
        
        // Key: offer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public System.String? Offer { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public System.String? OfferId { get; set; }//;
        
        // Key: orderable Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderable")]
        public bool Orderable { get; set; }//;
        
        // Key: phase Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("phase")]
        public string Phase { get; set; }//;
        
        // Key: prices Type: order.cart.Price[] FullType: order.cart.Price[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.Price[]? Prices { get; set; }//;
        
        // Key: pricingMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pricingMode")]
        public string PricingMode { get; set; }//;
        
        // Key: productId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productId")]
        public string ProductId { get; set; }//;
        
        // Key: quantityMax Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantityMax")]
        public long QuantityMax { get; set; }//;
    }
    
    // Id: Promotion Namespace: order.cart
    public class Promotion {
        
        // Key: bundleWithPlanCodes Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bundleWithPlanCodes")]
        public string[] BundleWithPlanCodes { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price Price { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateTime StartDate { get; set; }//;
        
        // Key: tags Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
        public System.String[]? Tags { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: Update Namespace: order.cart
    public class Update {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: expire Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expire")]
        public System.DateTime Expire { get; set; }//;
    }
    
    // Id: WebHostingProductInformation Namespace: order.cart
    public class WebHostingProductInformation {
        
        // Key: description Type: hosting.web.Capabilities FullType: hosting.web.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public _hosting_web.Capabilities Description { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: prices Type: order.cart.GenericProductPricing[] FullType: order.cart.GenericProductPricing[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _order_cart.GenericProductPricing[] Prices { get; set; }//;
    }
}
