//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _domain_data_smd {
    
    
    // Id: Smd Namespace: domain.data.smd
    public class Smd {
        
        // Key: data Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data")]
        public required System.String Data { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: notAfter Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notAfter")]
        public required System.DateTime NotAfter { get; set; }//;
        
        // Key: notBefore Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notBefore")]
        public required System.DateTime NotBefore { get; set; }//;
        
        // Key: protectedLabels Type: domain.data.smd.SmdLabel[] FullType: domain.data.smd.SmdLabel[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protectedLabels")]
        public required _domain_data_smd.SmdLabel[] ProtectedLabels { get; set; }//;
        
        // Key: smdId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("smdId")]
        public required System.String SmdId { get; set; }//;
    }
    
    // Id: SmdBody Namespace: domain.data.smd
    public class SmdBody {
        
        // Key: data Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data")]
        public required System.String Data { get; set; }//;
    }
    
    // Id: SmdLabel Namespace: domain.data.smd
    public class SmdLabel {
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public required System.String Label { get; set; }//;
        
        // Key: trademark Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trademark")]
        public required System.String Trademark { get; set; }//;
    }
}
