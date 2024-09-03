//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _audit {
    
    
    // Id: Log Namespace: audit
    public class Log {
        
        // Key: authDetails Type: audit.LogAuthDetails FullType: audit.LogAuthDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("authDetails")]
        public _audit.LogAuthDetails AuthDetails { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: loginSuccessDetails Type: audit.LogLoginSuccessDetails FullType: audit.LogLoginSuccessDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("loginSuccessDetails")]
        public _audit.LogLoginSuccessDetails LoginSuccessDetails { get; set; }//;
        
        // Key: type Type: audit.LogTypeEnum FullType: audit.LogTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _audit.LogTypeEnum Type { get; set; }//;
        
        // Key: userPasswordChangedDetails Type: audit.LogUserPasswordChangedDetails FullType: audit.LogUserPasswordChangedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userPasswordChangedDetails")]
        public _audit.LogUserPasswordChangedDetails UserPasswordChangedDetails { get; set; }//;
    }
    
    // Id: LogAuthDetails Namespace: audit
    public class LogAuthDetails {
        
        // Key: userDetails Type: audit.LogAuthUserDetails FullType: audit.LogAuthUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userDetails")]
        public _audit.LogAuthUserDetails UserDetails { get; set; }//;
    }
    
    // Id: LogAuthMFATypeEnum Namespace: audit
    public enum LogAuthMFATypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BACKUP_CODE")]
        BACKUP_CODE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MAIL")]
        MAIL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NONE")]
        NONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SMS")]
        SMS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TOTP")]
        TOTP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("U2F")]
        U2F,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNKNOWN")]
        UNKNOWN,
    }
    
    // Id: LogAuthUserDetails Namespace: audit
    public class LogAuthUserDetails {
        
        // Key: type Type: audit.LogAuthUserTypeEnum FullType: audit.LogAuthUserTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _audit.LogAuthUserTypeEnum Type { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public string User { get; set; }//;
    }
    
    // Id: LogAuthUserTypeEnum Namespace: audit
    public enum LogAuthUserTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACCOUNT")]
        ACCOUNT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER")]
        PROVIDER,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER")]
        USER,
    }
    
    // Id: LogLoginSuccessDetails Namespace: audit
    public class LogLoginSuccessDetails {
        
        // Key: mfaType Type: audit.LogAuthMFATypeEnum FullType: audit.LogAuthMFATypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mfaType")]
        public _audit.LogAuthMFATypeEnum MfaType { get; set; }//;
        
        // Key: userAgent Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userAgent")]
        public string UserAgent { get; set; }//;
    }
    
    // Id: LogTypeEnum Namespace: audit
    public enum LogTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACCOUNT_PASSWORD_CHANGED")]
        ACCOUNT_PASSWORD_CHANGED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOGIN_SUCCESS")]
        LOGIN_SUCCESS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER_PASSWORD_CHANGED")]
        USER_PASSWORD_CHANGED,
    }
    
    // Id: LogUserPasswordChangedDetails Namespace: audit
    public class LogUserPasswordChangedDetails {
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public string User { get; set; }//;
    }
}
