//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _me_payment_method {
    
    
    // Id: CallbackUrl Namespace: me.payment.method
    public class CallbackUrl {
        
        // Key: cancel Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancel")]
        public required System.String Cancel { get; set; }//;
        
        // Key: error Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        public required System.String Error { get; set; }//;
        
        // Key: failure Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failure")]
        public required System.String Failure { get; set; }//;
        
        // Key: pending Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pending")]
        public required System.String Pending { get; set; }//;
        
        // Key: success Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("success")]
        public required System.String Success { get; set; }//;
    }
    
    // Id: Challenge Namespace: me.payment.method
    public class Challenge {
        
        // Key: challenge Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("challenge")]
        public required System.String _Challenge { get; set; }//;
    }
    
    // Id: Creation Namespace: me.payment.method
    public class Creation {
        
        // Key: billingContactId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingContactId")]
        public System.Int64? BillingContactId { get; set; }//;
        
        // Key: callbackUrl Type: me.payment.method.CallbackUrl FullType: me.payment.method.CallbackUrl
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("callbackUrl")]
        public required _me_payment_method.CallbackUrl CallbackUrl { get; set; }//;
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public required System.Boolean @default { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: formData Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("formData")]
        public System.String? FormData { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public System.Int64? OrderId { get; set; }//;
        
        // Key: paymentSubType Type: me.payment.CreationSubTypeEnum FullType: me.payment.CreationSubTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("paymentSubType")]
        public _me_payment.CreationSubTypeEnum? PaymentSubType { get; set; }//;
        
        // Key: paymentType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("paymentType")]
        public required System.String PaymentType { get; set; }//;
        
        // Key: register Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("register")]
        public required System.Boolean Register { get; set; }//;
    }
    
    // Id: Details Namespace: me.payment.method
    public class Details {
        
        // Key: details Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public required System.String _Details { get; set; }//;
        
        // Key: transactionId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transactionId")]
        public required System.Int64 TransactionId { get; set; }//;
    }
    
    // Id: Finalize Namespace: me.payment.method
    public class Finalize {
        
        // Key: expirationMonth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationMonth")]
        public System.Int64? ExpirationMonth { get; set; }//;
        
        // Key: expirationYear Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationYear")]
        public System.Int64? ExpirationYear { get; set; }//;
        
        // Key: formSessionId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("formSessionId")]
        public System.String? FormSessionId { get; set; }//;
        
        // Key: registrationId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("registrationId")]
        public System.String? RegistrationId { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: me.payment.method
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CANCELED")]
        CANCELED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CANCELING")]
        CANCELING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATED")]
        CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATING")]
        CREATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXPIRED")]
        EXPIRED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FAILED")]
        FAILED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MAINTENANCE")]
        MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PAUSED")]
        PAUSED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REJECTED")]
        REJECTED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REPLACED")]
        REPLACED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VALID")]
        VALID,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VALIDATING")]
        VALIDATING,
    }
    
    // Id: Validation Namespace: me.payment.method
    public class Validation {
        
        // Key: formSessionId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("formSessionId")]
        public System.String? FormSessionId { get; set; }//;
        
        // Key: merchantId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("merchantId")]
        public System.String? MerchantId { get; set; }//;
        
        // Key: organizationId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("organizationId")]
        public System.String? OrganizationId { get; set; }//;
        
        // Key: paymentMethodId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("paymentMethodId")]
        public required System.Int64 PaymentMethodId { get; set; }//;
        
        // Key: transactionId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transactionId")]
        public System.Int64? TransactionId { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public System.String? Url { get; set; }//;
        
        // Key: validationType Type: me.payment.IntegrationEnum FullType: me.payment.IntegrationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationType")]
        public required _me_payment.IntegrationEnum ValidationType { get; set; }//;
    }
}
