//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cdn_domain_option {
    
    
    // Id: config Namespace: cdn.domain.option
    public class config {
        
        // Key: destination Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("destination")]
        public System.String? Destination { get; set; }//;
        
        // Key: followUri Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("followUri")]
        public System.Boolean? FollowUri { get; set; }//;
        
        // Key: origins Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("origins")]
        public System.String? Origins { get; set; }//;
        
        // Key: patternType Type: cdn.OptionPatternTypeEnum FullType: cdn.OptionPatternTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("patternType")]
        public _cdn.OptionPatternTypeEnum? PatternType { get; set; }//;
        
        // Key: priority Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priority")]
        public System.Int64? Priority { get; set; }//;
        
        // Key: queryParameters Type: cdn.OptionQueryParametersEnum FullType: cdn.OptionQueryParametersEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queryParameters")]
        public _cdn.OptionQueryParametersEnum? QueryParameters { get; set; }//;
        
        // Key: resources Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resources")]
        public System.String[]? Resources { get; set; }//;
        
        // Key: statusCode Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("statusCode")]
        public System.Int64? StatusCode { get; set; }//;
        
        // Key: ttl Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ttl")]
        public System.Int64? Ttl { get; set; }//;
    }
    
    // Id: extra Namespace: cdn.domain.option
    public class extra {
        
        // Key: quota Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quota")]
        public System.Int64? Quota { get; set; }//;
        
        // Key: usage Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usage")]
        public System.Int64? Usage { get; set; }//;
    }
}
