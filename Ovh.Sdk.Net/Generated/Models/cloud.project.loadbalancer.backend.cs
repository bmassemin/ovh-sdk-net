//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_loadbalancer_backend {
    
    
    // Id: BalancerAlgorithmEnum Namespace: cloud.project.loadbalancer.backend
    public enum BalancerAlgorithmEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("first")]
        first,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("leastconn")]
        leastconn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roundrobin")]
        roundrobin,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        source,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("static-rr")]
        static_rr,
    }
    
    // Id: ProxyProtocolEnum Namespace: cloud.project.loadbalancer.backend
    public enum ProxyProtocolEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v1")]
        v1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2")]
        v2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2-cn")]
        v2_cn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2-ssl")]
        v2_ssl,
    }
}
