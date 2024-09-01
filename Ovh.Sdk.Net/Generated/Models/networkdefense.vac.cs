//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _networkDefense_Vac {
    
    
    // Id: Event Namespace: networkDefense.Vac
    public class Event {
        
        // Key: endedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endedAt")]
        public System.DateTime? EndedAt { get; set; }//;
        
        // Key: startedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startedAt")]
        public required System.DateTime StartedAt { get; set; }//;
        
        // Key: subnet Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnet")]
        public required System.String Subnet { get; set; }//;
        
        // Key: vectors Type: networkDefense.VectorsEnum[] FullType: networkDefense.VectorsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vectors")]
        public required _networkDefense.VectorsEnum[] Vectors { get; set; }//;
    }
    
    // Id: EventsResponse Namespace: networkDefense.Vac
    public class EventsResponse {
        
        // Key: events Type: networkDefense.Vac.Event[] FullType: networkDefense.Vac.Event[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("events")]
        public _networkDefense_Vac.Event[]? Events { get; set; }//;
    }
    
    // Id: TrafficResponse Namespace: networkDefense.Vac
    public class TrafficResponse {
        
        // Key: bps Type: networkDefense.Vac.TrafficResponseData FullType: networkDefense.Vac.TrafficResponseData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bps")]
        public required _networkDefense_Vac.TrafficResponseData Bps { get; set; }//;
        
        // Key: pps Type: networkDefense.Vac.TrafficResponseData FullType: networkDefense.Vac.TrafficResponseData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pps")]
        public required _networkDefense_Vac.TrafficResponseData Pps { get; set; }//;
        
        // Key: timestamps Type: datetime[] FullType: datetime[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamps")]
        public required System.DateTime[] Timestamps { get; set; }//;
    }
    
    // Id: TrafficResponseData Namespace: networkDefense.Vac
    public class TrafficResponseData {
        
        // Key: dropped Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dropped")]
        public required System.String[] Dropped { get; set; }//;
        
        // Key: passed Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("passed")]
        public required System.String[] Passed { get; set; }//;
    }
}
