//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _otb_device {
    
    
    // Id: statistics Namespace: otb.device
    public class statistics {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: points Type: otb.device.statistics.point[] FullType: otb.device.statistics.point[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("points")]
        public required _otb_device_statistics.point[] Points { get; set; }//;
        
        // Key: tags Type: otb.device.statistics.tag[] FullType: otb.device.statistics.tag[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
        public required _otb_device_statistics.tag[] Tags { get; set; }//;
        
        // Key: unit Type: otb.DeviceStatisticsUnitEnum FullType: otb.DeviceStatisticsUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit")]
        public required _otb.DeviceStatisticsUnitEnum Unit { get; set; }//;
    }
}
