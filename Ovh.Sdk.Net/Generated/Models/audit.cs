//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _audit {
    
    
    // Id: Log Namespace: audit
    public class Log {
        
        // Key: authDetails Type: audit.LogAuthDetails FullType: audit.LogAuthDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("authDetails")]
        public _audit.LogAuthDetails? AuthDetails { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.DateTime CreatedAt { get; set; }//;
        
        // Key: groupCreatedDetails Type: audit.LogGroupCreatedDetails FullType: audit.LogGroupCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupCreatedDetails")]
        public _audit.LogGroupCreatedDetails? GroupCreatedDetails { get; set; }//;
        
        // Key: groupDeletedDetails Type: audit.LogGroupDeletedDetails FullType: audit.LogGroupDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupDeletedDetails")]
        public _audit.LogGroupDeletedDetails? GroupDeletedDetails { get; set; }//;
        
        // Key: groupModifiedDetails Type: audit.LogGroupModifiedDetails FullType: audit.LogGroupModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupModifiedDetails")]
        public _audit.LogGroupModifiedDetails? GroupModifiedDetails { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: loginSuccessDetails Type: audit.LogLoginSuccessDetails FullType: audit.LogLoginSuccessDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("loginSuccessDetails")]
        public _audit.LogLoginSuccessDetails? LoginSuccessDetails { get; set; }//;
        
        // Key: providerCreatedDetails Type: audit.LogProviderCreatedDetails FullType: audit.LogProviderCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerCreatedDetails")]
        public _audit.LogProviderCreatedDetails? ProviderCreatedDetails { get; set; }//;
        
        // Key: providerDeletedDetails Type: audit.LogProviderDeletedDetails FullType: audit.LogProviderDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerDeletedDetails")]
        public _audit.LogProviderDeletedDetails? ProviderDeletedDetails { get; set; }//;
        
        // Key: providerModifiedDetails Type: audit.LogProviderModifiedDetails FullType: audit.LogProviderModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerModifiedDetails")]
        public _audit.LogProviderModifiedDetails? ProviderModifiedDetails { get; set; }//;
        
        // Key: type Type: audit.LogTypeEnum FullType: audit.LogTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _audit.LogTypeEnum Type { get; set; }//;
        
        // Key: userCreatedDetails Type: audit.LogUserCreatedDetails FullType: audit.LogUserCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCreatedDetails")]
        public _audit.LogUserCreatedDetails? UserCreatedDetails { get; set; }//;
        
        // Key: userDeletedDetails Type: audit.LogUserDeletedDetails FullType: audit.LogUserDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userDeletedDetails")]
        public _audit.LogUserDeletedDetails? UserDeletedDetails { get; set; }//;
        
        // Key: userModifiedDetails Type: audit.LogUserModifiedDetails FullType: audit.LogUserModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userModifiedDetails")]
        public _audit.LogUserModifiedDetails? UserModifiedDetails { get; set; }//;
        
        // Key: userPasswordChangedDetails Type: audit.LogUserPasswordChangedDetails FullType: audit.LogUserPasswordChangedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userPasswordChangedDetails")]
        public _audit.LogUserPasswordChangedDetails? UserPasswordChangedDetails { get; set; }//;
    }
    
    // Id: LogAuthDetails Namespace: audit
    public class LogAuthDetails {
        
        // Key: userDetails Type: audit.LogAuthUserDetails FullType: audit.LogAuthUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userDetails")]
        public required _audit.LogAuthUserDetails UserDetails { get; set; }//;
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
        public required _audit.LogAuthUserTypeEnum Type { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public System.String? User { get; set; }//;
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
    
    // Id: LogGroupCreatedDetails Namespace: audit
    public class LogGroupCreatedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: role Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public required System.String Role { get; set; }//;
    }
    
    // Id: LogGroupDeletedDetails Namespace: audit
    public class LogGroupDeletedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
    }
    
    // Id: LogGroupModifiedDetails Namespace: audit
    public class LogGroupModifiedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: role Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public required System.String Role { get; set; }//;
    }
    
    // Id: LogLoginSuccessDetails Namespace: audit
    public class LogLoginSuccessDetails {
        
        // Key: mfaType Type: audit.LogAuthMFATypeEnum FullType: audit.LogAuthMFATypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mfaType")]
        public _audit.LogAuthMFATypeEnum? MfaType { get; set; }//;
        
        // Key: userAgent Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userAgent")]
        public required System.String UserAgent { get; set; }//;
    }
    
    // Id: LogProviderCreatedDetails Namespace: audit
    public class LogProviderCreatedDetails {
        
        // Key: groupAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupAttributeName")]
        public required System.String GroupAttributeName { get; set; }//;
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
        
        // Key: userAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userAttributeName")]
        public required System.String UserAttributeName { get; set; }//;
    }
    
    // Id: LogProviderDeletedDetails Namespace: audit
    public class LogProviderDeletedDetails {
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
    }
    
    // Id: LogProviderModifiedDetails Namespace: audit
    public class LogProviderModifiedDetails {
        
        // Key: groupAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupAttributeName")]
        public required System.String GroupAttributeName { get; set; }//;
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
        
        // Key: userAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userAttributeName")]
        public required System.String UserAttributeName { get; set; }//;
    }
    
    // Id: LogTypeEnum Namespace: audit
    public enum LogTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACCOUNT_PASSWORD_CHANGED")]
        ACCOUNT_PASSWORD_CHANGED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GROUP_CREATED")]
        GROUP_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GROUP_DELETED")]
        GROUP_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GROUP_MODIFIED")]
        GROUP_MODIFIED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOGIN_SUCCESS")]
        LOGIN_SUCCESS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_CREATED")]
        PROVIDER_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_DELETED")]
        PROVIDER_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_MODIFIED")]
        PROVIDER_MODIFIED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER_CREATED")]
        USER_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER_DELETED")]
        USER_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER_MODIFIED")]
        USER_MODIFIED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("USER_PASSWORD_CHANGED")]
        USER_PASSWORD_CHANGED,
    }
    
    // Id: LogUserCreatedDetails Namespace: audit
    public class LogUserCreatedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: passwordRecoveryEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("passwordRecoveryEmail")]
        public required System.String PasswordRecoveryEmail { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
    }
    
    // Id: LogUserDeletedDetails Namespace: audit
    public class LogUserDeletedDetails {
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
    }
    
    // Id: LogUserModifiedDetails Namespace: audit
    public class LogUserModifiedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: passwordRecoveryEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("passwordRecoveryEmail")]
        public required System.String PasswordRecoveryEmail { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
    }
    
    // Id: LogUserPasswordChangedDetails Namespace: audit
    public class LogUserPasswordChangedDetails {
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
    }
}
