//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_consumption_transaction {
    
    
    // Id: Element Namespace: me.consumption.transaction
    public class Element {
        
        // Key: details Type: me.consumption.transaction.element.Detail[] FullType: me.consumption.transaction.element.Detail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _me_consumption_transaction_element.Detail[] Details { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: planFamily Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planFamily")]
        public string PlanFamily { get; set; }//;
        
        // Key: price Type: me.consumption.Price FullType: me.consumption.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _me_consumption.Price Price { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
    }
}
