//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _okms_serviceKey {
    
    
    // Id: Creation Namespace: okms.serviceKey
    public class Creation {
        
        // Key: context Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("context")]
        public System.String? Context { get; set; }//;
        
        // Key: curve Type: okms.KeyCurveEnum FullType: okms.KeyCurveEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("curve")]
        public _okms.KeyCurveEnum? Curve { get; set; }//;
        
        // Key: keys Type: okms.serviceKey.JsonWebKey[] FullType: okms.serviceKey.JsonWebKey[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("keys")]
        public _okms_serviceKey.JsonWebKey[]? Keys { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: operations Type: okms.KeyOpsEnum[] FullType: okms.KeyOpsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operations")]
        public _okms.KeyOpsEnum[]? Operations { get; set; }//;
        
        // Key: size Type: okms.KeySizeEnum FullType: okms.KeySizeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _okms.KeySizeEnum? Size { get; set; }//;
        
        // Key: type Type: okms.KeyTypeEnum FullType: okms.KeyTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _okms.KeyTypeEnum? Type { get; set; }//;
    }
    
    // Id: JsonWebKey Namespace: okms.serviceKey
    public class JsonWebKey {
        
        // Key: alg Type: okms.KeyAlgEnum FullType: okms.KeyAlgEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alg")]
        public _okms.KeyAlgEnum? Alg { get; set; }//;
        
        // Key: crv Type: okms.KeyCurveEnum FullType: okms.KeyCurveEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("crv")]
        public _okms.KeyCurveEnum? Crv { get; set; }//;
        
        // Key: d Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("d")]
        public System.String? D { get; set; }//;
        
        // Key: dp Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dp")]
        public System.String? Dp { get; set; }//;
        
        // Key: dq Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dq")]
        public System.String? Dq { get; set; }//;
        
        // Key: e Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("e")]
        public System.String? E { get; set; }//;
        
        // Key: k Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("k")]
        public System.String? K { get; set; }//;
        
        // Key: key_ops Type: okms.KeyOpsEnum[] FullType: okms.KeyOpsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key_ops")]
        public _okms.KeyOpsEnum[]? Key_ops { get; set; }//;
        
        // Key: kid Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kid")]
        public string Kid { get; set; }//;
        
        // Key: kty Type: okms.KeyTypeEnum FullType: okms.KeyTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kty")]
        public _okms.KeyTypeEnum Kty { get; set; }//;
        
        // Key: n Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("n")]
        public System.String? N { get; set; }//;
        
        // Key: p Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("p")]
        public System.String? P { get; set; }//;
        
        // Key: q Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("q")]
        public System.String? Q { get; set; }//;
        
        // Key: qi Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("qi")]
        public System.String? Qi { get; set; }//;
        
        // Key: use Type: okms.KeyUseEnum FullType: okms.KeyUseEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("use")]
        public _okms.KeyUseEnum? Use { get; set; }//;
        
        // Key: x Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("x")]
        public System.String? X { get; set; }//;
        
        // Key: y Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("y")]
        public System.String? Y { get; set; }//;
    }
    
    // Id: PEM Namespace: okms.serviceKey
    public class PEM {
        
        // Key: pem Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pem")]
        public string _Pem { get; set; }//;
    }
    
    // Id: Response Namespace: okms.serviceKey
    public class Response {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: curve Type: okms.KeyCurveEnum FullType: okms.KeyCurveEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("curve")]
        public _okms.KeyCurveEnum? Curve { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: keys Type: okms.serviceKey.JsonWebKey[] FullType: okms.serviceKey.JsonWebKey[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("keys")]
        public _okms_serviceKey.JsonWebKey[]? Keys { get; set; }//;
        
        // Key: keysPEM Type: okms.serviceKey.PEM[] FullType: okms.serviceKey.PEM[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("keysPEM")]
        public _okms_serviceKey.PEM[]? KeysPEM { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: operations Type: okms.KeyOpsEnum[] FullType: okms.KeyOpsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operations")]
        public _okms.KeyOpsEnum[]? Operations { get; set; }//;
        
        // Key: size Type: okms.KeySizeEnum FullType: okms.KeySizeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _okms.KeySizeEnum? Size { get; set; }//;
        
        // Key: state Type: okms.KeyStateEnum FullType: okms.KeyStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _okms.KeyStateEnum State { get; set; }//;
        
        // Key: type Type: okms.KeyTypeEnum FullType: okms.KeyTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _okms.KeyTypeEnum Type { get; set; }//;
    }
    
    // Id: Update Namespace: okms.serviceKey
    public class Update {
        
        // Key: deactivationReason Type: okms.KeyDeactivationReasonEnum FullType: okms.KeyDeactivationReasonEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deactivationReason")]
        public _okms.KeyDeactivationReasonEnum? DeactivationReason { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: state Type: okms.KeyStateUpdateEnum FullType: okms.KeyStateUpdateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _okms.KeyStateUpdateEnum? State { get; set; }//;
    }
}