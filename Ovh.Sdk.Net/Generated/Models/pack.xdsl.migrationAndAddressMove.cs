//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _pack_xdsl_migrationAndAddressMove {
    
    
    // Id: Promotion Namespace: pack.xdsl.migrationAndAddressMove
    public class Promotion {
        
        // Key: endDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime? EndDate { get; set; }//;
        
        // Key: id Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: installFee Type: pack.xdsl.migrationAndAddressMove.PromotionDetails FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installFee")]
        public _pack_xdsl_migrationAndAddressMove.PromotionDetails? InstallFee { get; set; }//;
        
        // Key: startDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateTime? StartDate { get; set; }//;
        
        // Key: subscription Type: pack.xdsl.migrationAndAddressMove.PromotionDetails FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subscription")]
        public _pack_xdsl_migrationAndAddressMove.PromotionDetails? Subscription { get; set; }//;
    }
    
    // Id: PromotionDetails Namespace: pack.xdsl.migrationAndAddressMove
    public class PromotionDetails {
        
        // Key: discount Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("discount")]
        public required _order.Price Discount { get; set; }//;
        
        // Key: duration Type: duration FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan? Duration { get; set; }//;
    }
}
