//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _okms {
    
    
    // Id: CredentialStatusEnum Namespace: okms
    public enum CredentialStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATING")]
        CREATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXPIRED")]
        EXPIRED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
    }
    
    // Id: KeyAlgEnum Namespace: okms
    public enum KeyAlgEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ES256")]
        ES256,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ES384")]
        ES384,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ES512")]
        ES512,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PS256")]
        PS256,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PS384")]
        PS384,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PS512")]
        PS512,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RS256")]
        RS256,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RS384")]
        RS384,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RS512")]
        RS512,
    }
    
    // Id: KeyCurveEnum Namespace: okms
    public enum KeyCurveEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P-256")]
        P_256,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P-384")]
        P_384,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P-521")]
        P_521,
    }
    
    // Id: KeyDeactivationReasonEnum Namespace: okms
    public enum KeyDeactivationReasonEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AFFILIATION_CHANGED")]
        AFFILIATION_CHANGED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CA_COMPROMISE")]
        CA_COMPROMISE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CESSATION_OF_OPERATION")]
        CESSATION_OF_OPERATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("KEY_COMPROMISE")]
        KEY_COMPROMISE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PRIVILEGE_WITHDRAWN")]
        PRIVILEGE_WITHDRAWN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUPERSEDED")]
        SUPERSEDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNSPECIFIED")]
        UNSPECIFIED,
    }
    
    // Id: KeyFormatEnum Namespace: okms
    public enum KeyFormatEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("JWK")]
        JWK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PEM")]
        PEM,
    }
    
    // Id: KeyOpsEnum Namespace: okms
    public enum KeyOpsEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("decrypt")]
        decrypt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("encrypt")]
        encrypt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sign")]
        sign,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unwrapKey")]
        unwrapKey,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("verify")]
        verify,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("wrapKey")]
        wrapKey,
    }
    
    // Id: KeySizeEnum Namespace: okms
    public enum KeySizeEnum {
        
        _128 = 128,
        
        _192 = 192,
        
        _256 = 256,
        
        _2048 = 2048,
        
        _3072 = 3072,
        
        _4096 = 4096,
    }
    
    // Id: KeyStateEnum Namespace: okms
    public enum KeyStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ALL")]
        ALL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COMPROMISED")]
        COMPROMISED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DEACTIVATED")]
        DEACTIVATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DESTROYED")]
        DESTROYED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DESTROYED_COMPROMISED")]
        DESTROYED_COMPROMISED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PRE_ACTIVE")]
        PRE_ACTIVE,
    }
    
    // Id: KeyStateUpdateEnum Namespace: okms
    public enum KeyStateUpdateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COMPROMISED")]
        COMPROMISED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DEACTIVATED")]
        DEACTIVATED,
    }
    
    // Id: KeyTypeEnum Namespace: okms
    public enum KeyTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EC")]
        EC,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RSA")]
        RSA,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("oct")]
        oct,
    }
    
    // Id: KeyUseEnum Namespace: okms
    public enum KeyUseEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enc")]
        enc,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sig")]
        sig,
    }
    
    // Id: RegionEnum Namespace: okms
    public enum RegionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-par")]
        eu_west_par,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-rbx")]
        eu_west_rbx,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eu-west-sbg")]
        eu_west_sbg,
    }
}
