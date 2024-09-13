//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _domain_data_claimNotice {
    
    
    // Id: Address Namespace: domain.data.claimNotice
    public class Address {
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public System.String? City { get; set; }//;
        
        // Key: countryCode Type: nichandle.CountryEnum FullType: nichandle.CountryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("countryCode")]
        public _nichandle.CountryEnum? CountryCode { get; set; }//;
        
        // Key: fax Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fax")]
        public System.String? Fax { get; set; }//;
        
        // Key: faxExtension Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxExtension")]
        public System.String? FaxExtension { get; set; }//;
        
        // Key: postalCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("postalCode")]
        public System.String? PostalCode { get; set; }//;
        
        // Key: stateOrProvince Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stateOrProvince")]
        public System.String? StateOrProvince { get; set; }//;
        
        // Key: streets Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streets")]
        public string[] Streets { get; set; }//;
        
        // Key: voice Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voice")]
        public System.String? Voice { get; set; }//;
        
        // Key: voiceExtension Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voiceExtension")]
        public System.String? VoiceExtension { get; set; }//;
    }
    
    // Id: ClaimNotice Namespace: domain.data.claimNotice
    public class ClaimNotice {
        
        // Key: claims Type: domain.data.claimNotice.ClaimNoticeDecision[] FullType: domain.data.claimNotice.ClaimNoticeDecision[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("claims")]
        public _domain_data_claimNotice.ClaimNoticeDecision[]? Claims { get; set; }//;
        
        // Key: endingDate Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endingDate")]
        public string EndingDate { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public string Label { get; set; }//;
        
        // Key: startingDate Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startingDate")]
        public System.String? StartingDate { get; set; }//;
        
        // Key: type Type: domain.data.claimNotice.ClaimNoticeTypeEnum FullType: domain.data.claimNotice.ClaimNoticeTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _domain_data_claimNotice.ClaimNoticeTypeEnum? Type { get; set; }//;
    }
    
    // Id: ClaimNoticeDecision Namespace: domain.data.claimNotice
    public class ClaimNoticeDecision {
        
        // Key: classifications Type: domain.data.claimNotice.Classification[] FullType: domain.data.claimNotice.Classification[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("classifications")]
        public _domain_data_claimNotice.Classification[] Classifications { get; set; }//;
        
        // Key: courtDecisions Type: domain.data.claimNotice.CourtDecision[] FullType: domain.data.claimNotice.CourtDecision[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("courtDecisions")]
        public _domain_data_claimNotice.CourtDecision[] CourtDecisions { get; set; }//;
        
        // Key: goodsAndServices Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("goodsAndServices")]
        public string GoodsAndServices { get; set; }//;
        
        // Key: jurisdiction Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("jurisdiction")]
        public string Jurisdiction { get; set; }//;
        
        // Key: jurisdictionCountryCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("jurisdictionCountryCode")]
        public string JurisdictionCountryCode { get; set; }//;
        
        // Key: markName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("markName")]
        public string MarkName { get; set; }//;
        
        // Key: trademarkContacts Type: domain.data.claimNotice.Contact[] FullType: domain.data.claimNotice.Contact[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trademarkContacts")]
        public _domain_data_claimNotice.Contact[] TrademarkContacts { get; set; }//;
        
        // Key: trademarkHolders Type: domain.data.claimNotice.Contact[] FullType: domain.data.claimNotice.Contact[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trademarkHolders")]
        public _domain_data_claimNotice.Contact[] TrademarkHolders { get; set; }//;
        
        // Key: trademarkUDRP Type: domain.data.claimNotice.UDRP[] FullType: domain.data.claimNotice.UDRP[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trademarkUDRP")]
        public _domain_data_claimNotice.UDRP[] TrademarkUDRP { get; set; }//;
    }
    
    // Id: ClaimNoticeTypeEnum Namespace: domain.data.claimNotice
    public enum ClaimNoticeTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRADEMARK")]
        TRADEMARK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UK")]
        UK,
    }
    
    // Id: Classification Namespace: domain.data.claimNotice
    public class Classification {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: number Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public string Number { get; set; }//;
    }
    
    // Id: Contact Namespace: domain.data.claimNotice
    public class Contact {
        
        // Key: address Type: domain.data.claimNotice.Address FullType: domain.data.claimNotice.Address
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public _domain_data_claimNotice.Address Address { get; set; }//;
        
        // Key: email Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("email")]
        public System.String? Email { get; set; }//;
        
        // Key: entitlement Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entitlement")]
        public System.String? Entitlement { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: organisation Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("organisation")]
        public System.String? Organisation { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public System.String? Type { get; set; }//;
    }
    
    // Id: CourtDecision Namespace: domain.data.claimNotice
    public class CourtDecision {
        
        // Key: countryCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("countryCode")]
        public string CountryCode { get; set; }//;
        
        // Key: courtName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("courtName")]
        public string CourtName { get; set; }//;
        
        // Key: referenceNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("referenceNumber")]
        public string ReferenceNumber { get; set; }//;
        
        // Key: regions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public string[] Regions { get; set; }//;
    }
    
    // Id: UDRP Namespace: domain.data.claimNotice
    public class UDRP {
        
        // Key: caseNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("caseNumber")]
        public string CaseNumber { get; set; }//;
        
        // Key: udrpProvider Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("udrpProvider")]
        public string UdrpProvider { get; set; }//;
    }
}
