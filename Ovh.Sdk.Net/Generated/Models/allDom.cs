//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _allDom {
    
    
    // Id: AllDom Namespace: allDom
    public class AllDom {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: offer Type: domain.OfferEnum FullType: domain.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _domain.OfferEnum Offer { get; set; }//;
        
        // Key: type Type: allDom.TypeEnum FullType: allDom.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _allDom.TypeEnum Type { get; set; }//;
    }
    
    // Id: AllDomDomain Namespace: allDom
    public class AllDomDomain {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
    }
    
    // Id: AllDomService Namespace: allDom
    public class AllDomService {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: offer Type: allDom.OfferEnum FullType: allDom.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _allDom.OfferEnum Offer { get; set; }//;
        
        // Key: type Type: allDom.TypeEnum FullType: allDom.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _allDom.TypeEnum Type { get; set; }//;
    }
    
    // Id: AllDomService Namespace: allDom
    public class AllDomServiceWithIAM {
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: offer Type: allDom.OfferEnum FullType: allDom.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _allDom.OfferEnum Offer { get; set; }//;
        
        // Key: type Type: allDom.TypeEnum FullType: allDom.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _allDom.TypeEnum Type { get; set; }//;
    }
    
    // Id: AllDom Namespace: allDom
    public class AllDomWithIAM {
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: offer Type: domain.OfferEnum FullType: domain.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public _domain.OfferEnum Offer { get; set; }//;
        
        // Key: type Type: allDom.TypeEnum FullType: allDom.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _allDom.TypeEnum Type { get; set; }//;
    }
    
    // Id: Domain Namespace: allDom
    public class Domain {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string _Domain { get; set; }//;
    }
    
    // Id: OfferEnum Namespace: allDom
    public enum OfferEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diamond")]
        diamond,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gold")]
        gold,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("platinum")]
        platinum,
    }
    
    // Id: TypeEnum Namespace: allDom
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("french")]
        french,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("french+international")]
        french_plus_international,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("international")]
        international,
    }
}
