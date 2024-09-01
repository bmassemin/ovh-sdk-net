//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _dedicatedCloud_securityOption {
    
    
    // Id: CompatibilityMatrixEntry Namespace: dedicatedCloud.securityOption
    public class CompatibilityMatrixEntry {
        
        // Key: compatible Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("compatible")]
        public required System.Boolean Compatible { get; set; }//;
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: enabled Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public required System.Boolean Enabled { get; set; }//;
        
        // Key: name Type: dedicatedCloud.securityOption.SecurityOptionEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required _dedicatedCloud_securityOption.SecurityOptionEnum Name { get; set; }//;
        
        // Key: reason Type: dedicatedCloud.securityOption.ErrorMessage FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reason")]
        public _dedicatedCloud_securityOption.ErrorMessage? Reason { get; set; }//;
        
        // Key: state Type: dedicatedCloud.securityOption.StateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _dedicatedCloud_securityOption.StateEnum State { get; set; }//;
    }
    
    // Id: DependenciesTree Namespace: dedicatedCloud.securityOption
    public class DependenciesTree {
        
        // Key: conflicts Type: dedicatedCloud.securityOption.SecurityOptionEnum[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conflicts")]
        public required _dedicatedCloud_securityOption.SecurityOptionEnum[] Conflicts { get; set; }//;
        
        // Key: depends Type: dedicatedCloud.securityOption.SecurityOptionEnum[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("depends")]
        public required _dedicatedCloud_securityOption.SecurityOptionEnum[] Depends { get; set; }//;
        
        // Key: requires Type: dedicatedCloud.securityOption.SecurityOptionEnum[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requires")]
        public required _dedicatedCloud_securityOption.SecurityOptionEnum[] Requires { get; set; }//;
    }
    
    // Id: ErrorEnum Namespace: dedicatedCloud.securityOption
    public enum ErrorEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTION_IMPOSSIBLE")]
        ACTION_IMPOSSIBLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ALREADY_DISABLED")]
        ALREADY_DISABLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ALREADY_ENABLED")]
        ALREADY_ENABLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BAD_ZONE")]
        BAD_ZONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BREAKING_REQUIREMENTS")]
        BREAKING_REQUIREMENTS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CONFLICTING_OPTIONS")]
        CONFLICTING_OPTIONS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DEFINITIVE_OPTION")]
        DEFINITIVE_OPTION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GENERIC_ERROR")]
        GENERIC_ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HAS_UNSUPPORTED_DEPENDENCIES")]
        HAS_UNSUPPORTED_DEPENDENCIES,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MISSING_REQUIREMENTS_OPTIONS")]
        MISSING_REQUIREMENTS_OPTIONS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NOT_ENABLED")]
        NOT_ENABLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NOT_MANAGEABLE_DIRECTLY")]
        NOT_MANAGEABLE_DIRECTLY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SERVICE_SUSPENDED")]
        SERVICE_SUSPENDED,
    }
    
    // Id: ErrorMessage Namespace: dedicatedCloud.securityOption
    public class ErrorMessage {
        
        // Key: code Type: dedicatedCloud.securityOption.ErrorEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public required _dedicatedCloud_securityOption.ErrorEnum Code { get; set; }//;
        
        // Key: message Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public required System.String Message { get; set; }//;
    }
    
    // Id: SecurityOptionEnum Namespace: dedicatedCloud.securityOption
    public enum SecurityOptionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accessNetworkFiltered")]
        accessNetworkFiltered,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("advancedSecurity")]
        advancedSecurity,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("base")]
        @base,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contentLibrary")]
        contentLibrary,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grsecKernel")]
        grsecKernel,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hds")]
        hds,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hids")]
        hids,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hipaa")]
        hipaa,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("logForwarder")]
        logForwarder,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nids")]
        nids,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pcidss")]
        pcidss,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateCustomerVlan")]
        privateCustomerVlan,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateGw")]
        privateGw,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sendLogToCustomer")]
        sendLogToCustomer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sessionTimeout")]
        sessionTimeout,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sftp")]
        sftp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snc")]
        snc,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spla")]
        spla,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslV3")]
        sslV3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tls1.2")]
        tls1_2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tokenValidation")]
        tokenValidation,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("twoFa")]
        twoFa,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("twoFaFail2ban")]
        twoFaFail2ban,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrliForwarder")]
        vrliForwarder,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waf")]
        waf,
    }
    
    // Id: StateEnum Namespace: dedicatedCloud.securityOption
    public enum StateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delivered")]
        delivered,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pending")]
        pending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toCreate")]
        toCreate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updating")]
        updating,
    }
}
