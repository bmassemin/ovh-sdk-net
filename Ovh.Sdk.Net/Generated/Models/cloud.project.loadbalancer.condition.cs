//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_loadbalancer_condition {
    
    
    // Id: MatchEnum Namespace: cloud.project.loadbalancer.condition
    public enum MatchEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("end-with")]
        end_with,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exists")]
        exists,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("is")]
        @is,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regex")]
        regex,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start-with")]
        start_with,
    }
    
    // Id: TypeEnum Namespace: cloud.project.loadbalancer.condition
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cookie")]
        cookie,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("header")]
        header,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        host,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("method")]
        method,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("path")]
        path,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("query-param")]
        query_param,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        source,
    }
}
