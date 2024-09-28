//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _okms_resource {
    
    
    // Id: Response Namespace: okms.resource
    public class Response {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: kmipEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kmipEndpoint")]
        public string KmipEndpoint { get; set; }//;
        
        // Key: publicCA Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicCA")]
        public System.String? PublicCA { get; set; }//;
        
        // Key: region Type: okms.RegionEnum FullType: okms.RegionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public _okms.RegionEnum Region { get; set; }//;
        
        // Key: restEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restEndpoint")]
        public string RestEndpoint { get; set; }//;
        
        // Key: swaggerEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("swaggerEndpoint")]
        public string SwaggerEndpoint { get; set; }//;
    }
    
    // Id: Response Namespace: okms.resource
    public class ResponseWithIAM {
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: kmipEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kmipEndpoint")]
        public string KmipEndpoint { get; set; }//;
        
        // Key: publicCA Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicCA")]
        public System.String? PublicCA { get; set; }//;
        
        // Key: region Type: okms.RegionEnum FullType: okms.RegionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public _okms.RegionEnum Region { get; set; }//;
        
        // Key: restEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restEndpoint")]
        public string RestEndpoint { get; set; }//;
        
        // Key: swaggerEndpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("swaggerEndpoint")]
        public string SwaggerEndpoint { get; set; }//;
    }
}