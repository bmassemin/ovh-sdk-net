//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_QuotaHistory {
    
    
    // Id: QuotaHistory Namespace: ipLoadbalancing.QuotaHistory
    public class QuotaHistory {
        
        // Key: historizedDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("historizedDate")]
        public System.DateOnly HistorizedDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: lastUpdateDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdateDate")]
        public System.DateTime LastUpdateDate { get; set; }//;
        
        // Key: resetDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resetDate")]
        public System.DateTime ResetDate { get; set; }//;
        
        // Key: total Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("total")]
        public long Total { get; set; }//;
        
        // Key: zone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
}
