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
        
        // Key: policyCreatedDetails Type: audit.LogPolicyCreatedDetails FullType: audit.LogPolicyCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyCreatedDetails")]
        public _audit.LogPolicyCreatedDetails? PolicyCreatedDetails { get; set; }//;
        
        // Key: policyDeletedDetails Type: audit.LogPolicyDeletedDetails FullType: audit.LogPolicyDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyDeletedDetails")]
        public _audit.LogPolicyDeletedDetails? PolicyDeletedDetails { get; set; }//;
        
        // Key: policyModifiedDetails Type: audit.LogPolicyModifiedDetails FullType: audit.LogPolicyModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyModifiedDetails")]
        public _audit.LogPolicyModifiedDetails? PolicyModifiedDetails { get; set; }//;
        
        // Key: providerCreatedDetails Type: audit.LogProviderCreatedDetails FullType: audit.LogProviderCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerCreatedDetails")]
        public _audit.LogProviderCreatedDetails? ProviderCreatedDetails { get; set; }//;
        
        // Key: providerDeletedDetails Type: audit.LogProviderDeletedDetails FullType: audit.LogProviderDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerDeletedDetails")]
        public _audit.LogProviderDeletedDetails? ProviderDeletedDetails { get; set; }//;
        
        // Key: providerModifiedDetails Type: audit.LogProviderModifiedDetails FullType: audit.LogProviderModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerModifiedDetails")]
        public _audit.LogProviderModifiedDetails? ProviderModifiedDetails { get; set; }//;
        
        // Key: resourceGroupCreatedDetails Type: audit.LogResourceGroupCreatedDetails FullType: audit.LogResourceGroupCreatedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupCreatedDetails")]
        public _audit.LogResourceGroupCreatedDetails? ResourceGroupCreatedDetails { get; set; }//;
        
        // Key: resourceGroupDeletedDetails Type: audit.LogResourceGroupDeletedDetails FullType: audit.LogResourceGroupDeletedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupDeletedDetails")]
        public _audit.LogResourceGroupDeletedDetails? ResourceGroupDeletedDetails { get; set; }//;
        
        // Key: resourceGroupModifiedDetails Type: audit.LogResourceGroupModifiedDetails FullType: audit.LogResourceGroupModifiedDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupModifiedDetails")]
        public _audit.LogResourceGroupModifiedDetails? ResourceGroupModifiedDetails { get; set; }//;
        
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
        
        // Key: new Type: audit.LogGroupDetails FullType: audit.LogGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogGroupDetails? @new { get; set; }//;
    }
    
    // Id: LogGroupDeletedDetails Namespace: audit
    public class LogGroupDeletedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: old Type: audit.LogGroupDetails FullType: audit.LogGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogGroupDetails? Old { get; set; }//;
    }
    
    // Id: LogGroupDetails Namespace: audit
    public class LogGroupDetails {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: role Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public required System.String Role { get; set; }//;
    }
    
    // Id: LogGroupModifiedDetails Namespace: audit
    public class LogGroupModifiedDetails {
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: new Type: audit.LogGroupDetails FullType: audit.LogGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogGroupDetails? @new { get; set; }//;
        
        // Key: old Type: audit.LogGroupDetails FullType: audit.LogGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogGroupDetails? Old { get; set; }//;
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
    
    // Id: LogPolicyChanges Namespace: audit
    public class LogPolicyChanges {
        
        // Key: identities Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("identities")]
        public System.String[]? Identities { get; set; }//;
        
        // Key: resources Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resources")]
        public System.String[]? Resources { get; set; }//;
    }
    
    // Id: LogPolicyCreatedDetails Namespace: audit
    public class LogPolicyCreatedDetails {
        
        // Key: added Type: audit.LogPolicyChanges FullType: audit.LogPolicyChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("added")]
        public _audit.LogPolicyChanges? Added { get; set; }//;
        
        // Key: new Type: audit.LogPolicyDetails FullType: audit.LogPolicyDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogPolicyDetails? @new { get; set; }//;
        
        // Key: policyId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyId")]
        public required System.Guid PolicyId { get; set; }//;
        
        // Key: policyName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyName")]
        public required System.String PolicyName { get; set; }//;
    }
    
    // Id: LogPolicyDeletedDetails Namespace: audit
    public class LogPolicyDeletedDetails {
        
        // Key: old Type: audit.LogPolicyDetails FullType: audit.LogPolicyDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogPolicyDetails? Old { get; set; }//;
        
        // Key: policyId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyId")]
        public required System.Guid PolicyId { get; set; }//;
        
        // Key: policyName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyName")]
        public required System.String PolicyName { get; set; }//;
        
        // Key: removed Type: audit.LogPolicyChanges FullType: audit.LogPolicyChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removed")]
        public _audit.LogPolicyChanges? Removed { get; set; }//;
    }
    
    // Id: LogPolicyDetails Namespace: audit
    public class LogPolicyDetails {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: LogPolicyModifiedDetails Namespace: audit
    public class LogPolicyModifiedDetails {
        
        // Key: added Type: audit.LogPolicyChanges FullType: audit.LogPolicyChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("added")]
        public _audit.LogPolicyChanges? Added { get; set; }//;
        
        // Key: new Type: audit.LogPolicyDetails FullType: audit.LogPolicyDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogPolicyDetails? @new { get; set; }//;
        
        // Key: old Type: audit.LogPolicyDetails FullType: audit.LogPolicyDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogPolicyDetails? Old { get; set; }//;
        
        // Key: policyId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyId")]
        public required System.Guid PolicyId { get; set; }//;
        
        // Key: policyName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("policyName")]
        public required System.String PolicyName { get; set; }//;
        
        // Key: removed Type: audit.LogPolicyChanges FullType: audit.LogPolicyChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removed")]
        public _audit.LogPolicyChanges? Removed { get; set; }//;
    }
    
    // Id: LogProviderCreatedDetails Namespace: audit
    public class LogProviderCreatedDetails {
        
        // Key: new Type: audit.LogProviderDetails FullType: audit.LogProviderDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogProviderDetails? @new { get; set; }//;
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
    }
    
    // Id: LogProviderDeletedDetails Namespace: audit
    public class LogProviderDeletedDetails {
        
        // Key: old Type: audit.LogProviderDetails FullType: audit.LogProviderDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogProviderDetails? Old { get; set; }//;
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
    }
    
    // Id: LogProviderDetails Namespace: audit
    public class LogProviderDetails {
        
        // Key: groupAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupAttributeName")]
        public required System.String GroupAttributeName { get; set; }//;
        
        // Key: requestSignatureEnabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestSignatureEnabled")]
        public required System.Boolean RequestSignatureEnabled { get; set; }//;
        
        // Key: userAttributeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userAttributeName")]
        public required System.String UserAttributeName { get; set; }//;
        
        // Key: usersDisabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usersDisabled")]
        public required System.Boolean UsersDisabled { get; set; }//;
    }
    
    // Id: LogProviderModifiedDetails Namespace: audit
    public class LogProviderModifiedDetails {
        
        // Key: new Type: audit.LogProviderDetails FullType: audit.LogProviderDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogProviderDetails? @new { get; set; }//;
        
        // Key: old Type: audit.LogProviderDetails FullType: audit.LogProviderDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogProviderDetails? Old { get; set; }//;
        
        // Key: ssoServiceURL Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssoServiceURL")]
        public required System.String SsoServiceURL { get; set; }//;
    }
    
    // Id: LogResourceGroupChanges Namespace: audit
    public class LogResourceGroupChanges {
        
        // Key: resources Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resources")]
        public System.String[]? Resources { get; set; }//;
    }
    
    // Id: LogResourceGroupCreatedDetails Namespace: audit
    public class LogResourceGroupCreatedDetails {
        
        // Key: added Type: audit.LogResourceGroupChanges FullType: audit.LogResourceGroupChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("added")]
        public _audit.LogResourceGroupChanges? Added { get; set; }//;
        
        // Key: new Type: audit.LogResourceGroupDetails FullType: audit.LogResourceGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogResourceGroupDetails? @new { get; set; }//;
        
        // Key: resourceGroupId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupId")]
        public required System.Guid ResourceGroupId { get; set; }//;
        
        // Key: resourceGroupName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupName")]
        public required System.String ResourceGroupName { get; set; }//;
    }
    
    // Id: LogResourceGroupDeletedDetails Namespace: audit
    public class LogResourceGroupDeletedDetails {
        
        // Key: old Type: audit.LogResourceGroupDetails FullType: audit.LogResourceGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogResourceGroupDetails? Old { get; set; }//;
        
        // Key: removed Type: audit.LogResourceGroupChanges FullType: audit.LogResourceGroupChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removed")]
        public _audit.LogResourceGroupChanges? Removed { get; set; }//;
        
        // Key: resourceGroupId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupId")]
        public required System.Guid ResourceGroupId { get; set; }//;
        
        // Key: resourceGroupName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupName")]
        public required System.String ResourceGroupName { get; set; }//;
    }
    
    // Id: LogResourceGroupDetails Namespace: audit
    public class LogResourceGroupDetails {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: LogResourceGroupModifiedDetails Namespace: audit
    public class LogResourceGroupModifiedDetails {
        
        // Key: added Type: audit.LogResourceGroupChanges FullType: audit.LogResourceGroupChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("added")]
        public _audit.LogResourceGroupChanges? Added { get; set; }//;
        
        // Key: new Type: audit.LogResourceGroupDetails FullType: audit.LogResourceGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogResourceGroupDetails? @new { get; set; }//;
        
        // Key: old Type: audit.LogResourceGroupDetails FullType: audit.LogResourceGroupDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogResourceGroupDetails? Old { get; set; }//;
        
        // Key: removed Type: audit.LogResourceGroupChanges FullType: audit.LogResourceGroupChanges
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removed")]
        public _audit.LogResourceGroupChanges? Removed { get; set; }//;
        
        // Key: resourceGroupId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupId")]
        public required System.Guid ResourceGroupId { get; set; }//;
        
        // Key: resourceGroupName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resourceGroupName")]
        public required System.String ResourceGroupName { get; set; }//;
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
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("POLICY_CREATED")]
        POLICY_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("POLICY_DELETED")]
        POLICY_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("POLICY_MODIFIED")]
        POLICY_MODIFIED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_CREATED")]
        PROVIDER_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_DELETED")]
        PROVIDER_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PROVIDER_MODIFIED")]
        PROVIDER_MODIFIED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESOURCE_GROUP_CREATED")]
        RESOURCE_GROUP_CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESOURCE_GROUP_DELETED")]
        RESOURCE_GROUP_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESOURCE_GROUP_MODIFIED")]
        RESOURCE_GROUP_MODIFIED,
        
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
        
        // Key: new Type: audit.LogUserDetails FullType: audit.LogUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogUserDetails? @new { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
        
        // Key: userCreatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCreatedAt")]
        public System.DateTime? UserCreatedAt { get; set; }//;
    }
    
    // Id: LogUserDeletedDetails Namespace: audit
    public class LogUserDeletedDetails {
        
        // Key: old Type: audit.LogUserDetails FullType: audit.LogUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogUserDetails? Old { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
        
        // Key: userCreatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCreatedAt")]
        public System.DateTime? UserCreatedAt { get; set; }//;
    }
    
    // Id: LogUserDetails Namespace: audit
    public class LogUserDetails {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: group Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public required System.String Group { get; set; }//;
        
        // Key: passwordRecoveryEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("passwordRecoveryEmail")]
        public required System.String PasswordRecoveryEmail { get; set; }//;
    }
    
    // Id: LogUserModifiedDetails Namespace: audit
    public class LogUserModifiedDetails {
        
        // Key: new Type: audit.LogUserDetails FullType: audit.LogUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        public _audit.LogUserDetails? @new { get; set; }//;
        
        // Key: old Type: audit.LogUserDetails FullType: audit.LogUserDetails
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("old")]
        public _audit.LogUserDetails? Old { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
        
        // Key: userCreatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCreatedAt")]
        public System.DateTime? UserCreatedAt { get; set; }//;
    }
    
    // Id: LogUserPasswordChangedDetails Namespace: audit
    public class LogUserPasswordChangedDetails {
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
        
        // Key: userCreatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCreatedAt")]
        public System.DateTime? UserCreatedAt { get; set; }//;
    }
}
