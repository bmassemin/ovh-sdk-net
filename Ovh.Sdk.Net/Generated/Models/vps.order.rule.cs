//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _vps_order_rule {
    
    
    // Id: Datacenter Namespace: vps.order.rule
    public class Datacenter {
        
        // Key: datacenter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenter")]
        public string _Datacenter { get; set; }//;
        
        // Key: status Type: vps.order.rule.DatacenterStatusEnum FullType: vps.order.rule.DatacenterStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _vps_order_rule.DatacenterStatusEnum Status { get; set; }//;
    }
    
    // Id: DatacenterStatusEnum Namespace: vps.order.rule
    public enum DatacenterStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("out-of-stock")]
        out_of_stock,
    }
    
    // Id: Datacenters Namespace: vps.order.rule
    public class Datacenters {
        
        // Key: datacenters Type: vps.order.rule.Datacenter[] FullType: vps.order.rule.Datacenter[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datacenters")]
        public _vps_order_rule.Datacenter[] _Datacenters { get; set; }//;
    }
    
    // Id: OSChoice Namespace: vps.order.rule
    public class OSChoice {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: status Type: vps.order.rule.OSChoiceStatusEnum FullType: vps.order.rule.OSChoiceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _vps_order_rule.OSChoiceStatusEnum Status { get; set; }//;
    }
    
    // Id: OSChoiceStatusEnum Namespace: vps.order.rule
    public enum OSChoiceStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checked-by-default")]
        checked_by_default,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unavailable")]
        unavailable,
    }
    
    // Id: OSChoices Namespace: vps.order.rule
    public class OSChoices {
        
        // Key: choices Type: vps.order.rule.OSChoice[] FullType: vps.order.rule.OSChoice[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("choices")]
        public _vps_order_rule.OSChoice[] Choices { get; set; }//;
    }
}
