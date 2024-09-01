//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _recommendations {
    
    
    // Id: Recommendation Namespace: recommendations
    public class Recommendation {
        
        // Key: advices Type: recommendations.RecommendationAdvice[] FullType: recommendations.RecommendationAdvice[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("advices")]
        public _recommendations.RecommendationAdvice[] Advices { get; set; }//;
        
        // Key: localizedDescription Type: map[string]string FullType: map[string]string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localizedDescription")]
        public Dictionary<string, string> LocalizedDescription { get; set; }//;
        
        // Key: rank Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rank")]
        public long Rank { get; set; }//;
    }
    
    // Id: RecommendationAdvice Namespace: recommendations
    public class RecommendationAdvice {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: score Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("score")]
        public double Score { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
    }
    
    // Id: Recommendations Namespace: recommendations
    public class Recommendations {
        
        // Key: recommendations Type: recommendations.Recommendation[] FullType: recommendations.Recommendation[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("recommendations")]
        public _recommendations.Recommendation[] _Recommendations { get; set; }//;
    }
    
    // Id: productRangesEnum Namespace: recommendations
    public enum productRangesEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baremetal")]
        baremetal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        domain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("public_cloud")]
        public_cloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("saas")]
        saas,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vps")]
        vps,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web")]
        web,
    }
}
