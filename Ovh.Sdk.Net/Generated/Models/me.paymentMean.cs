//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _me_paymentMean {
    
    
    // Id: BankAccount Namespace: me.paymentMean
    public class BankAccount {
        
        // Key: bic Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bic")]
        public required System.String Bic { get; set; }//;
        
        // Key: creationDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateOnly CreationDate { get; set; }//;
        
        // Key: defaultPaymentMean Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultPaymentMean")]
        public required System.Boolean DefaultPaymentMean { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: iban Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iban")]
        public required System.String Iban { get; set; }//;
        
        // Key: icon Type: me.paymentMean.IconData FullType: me.paymentMean.IconData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public _me_paymentMean.IconData? Icon { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: mandateSignatureDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mandateSignatureDate")]
        public System.DateOnly? MandateSignatureDate { get; set; }//;
        
        // Key: ownerAddress Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownerAddress")]
        public required System.String OwnerAddress { get; set; }//;
        
        // Key: ownerName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownerName")]
        public required System.String OwnerName { get; set; }//;
        
        // Key: state Type: me.paymentMean.BankAccountStateEnum FullType: me.paymentMean.BankAccountStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _me_paymentMean.BankAccountStateEnum State { get; set; }//;
        
        // Key: uniqueReference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uniqueReference")]
        public required System.String UniqueReference { get; set; }//;
        
        // Key: validationDocumentLink Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationDocumentLink")]
        public System.String? ValidationDocumentLink { get; set; }//;
    }
    
    // Id: BankAccountChallengeCreation Namespace: me.paymentMean
    public class BankAccountChallengeCreation {
        
        // Key: challenge Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("challenge")]
        public required System.String Challenge { get; set; }//;
    }
    
    // Id: BankAccountCreation Namespace: me.paymentMean
    public class BankAccountCreation {
        
        // Key: bic Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bic")]
        public required System.String Bic { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: iban Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iban")]
        public required System.String Iban { get; set; }//;
        
        // Key: ownerAddress Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownerAddress")]
        public required System.String OwnerAddress { get; set; }//;
        
        // Key: ownerName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownerName")]
        public required System.String OwnerName { get; set; }//;
        
        // Key: setDefault Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("setDefault")]
        public System.Boolean? SetDefault { get; set; }//;
    }
    
    // Id: BankAccountStateEnum Namespace: me.paymentMean
    public enum BankAccountStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blockedForIncidents")]
        blockedForIncidents,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pendingValidation")]
        pendingValidation,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("replaced")]
        replaced,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("valid")]
        valid,
    }
    
    // Id: BankAccountValidation Namespace: me.paymentMean
    public class BankAccountValidation {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: submitUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("submitUrl")]
        public System.String? SubmitUrl { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
        
        // Key: validationType Type: me.paymentMean.ValidationTypeEnum FullType: me.paymentMean.ValidationTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationType")]
        public required _me_paymentMean.ValidationTypeEnum ValidationType { get; set; }//;
    }
    
    // Id: CreditCard Namespace: me.paymentMean
    public class CreditCard {
        
        // Key: defaultPaymentMean Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultPaymentMean")]
        public required System.Boolean DefaultPaymentMean { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: expirationDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public required System.DateOnly ExpirationDate { get; set; }//;
        
        // Key: icon Type: me.paymentMean.IconData FullType: me.paymentMean.IconData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public _me_paymentMean.IconData? Icon { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: number Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public required System.String Number { get; set; }//;
        
        // Key: state Type: me.paymentMean.CreditCardStateEnum FullType: me.paymentMean.CreditCardStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _me_paymentMean.CreditCardStateEnum State { get; set; }//;
        
        // Key: threeDsValidated Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("threeDsValidated")]
        public required System.Boolean ThreeDsValidated { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
    }
    
    // Id: CreditCardChallengeCreation Namespace: me.paymentMean
    public class CreditCardChallengeCreation {
        
        // Key: challenge Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("challenge")]
        public required System.String Challenge { get; set; }//;
    }
    
    // Id: CreditCardCreation Namespace: me.paymentMean
    public class CreditCardCreation {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: returnUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("returnUrl")]
        public System.String? ReturnUrl { get; set; }//;
        
        // Key: setDefault Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("setDefault")]
        public System.Boolean? SetDefault { get; set; }//;
    }
    
    // Id: CreditCardStateEnum Namespace: me.paymentMean
    public enum CreditCardStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expired")]
        expired,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tooManyFailures")]
        tooManyFailures,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("valid")]
        valid,
    }
    
    // Id: CreditCardValidation Namespace: me.paymentMean
    public class CreditCardValidation {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: submitUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("submitUrl")]
        public System.String? SubmitUrl { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
        
        // Key: validationType Type: me.paymentMean.ValidationTypeEnum FullType: me.paymentMean.ValidationTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationType")]
        public required _me_paymentMean.ValidationTypeEnum ValidationType { get; set; }//;
    }
    
    // Id: Deferred Namespace: me.paymentMean
    public class Deferred {
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: defaultPaymentMean Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultPaymentMean")]
        public required System.Boolean DefaultPaymentMean { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: icon Type: me.paymentMean.IconData FullType: me.paymentMean.IconData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public _me_paymentMean.IconData? Icon { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public System.String? Label { get; set; }//;
        
        // Key: state Type: me.paymentMean.DeferredStateEnum FullType: me.paymentMean.DeferredStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _me_paymentMean.DeferredStateEnum State { get; set; }//;
    }
    
    // Id: DeferredStateEnum Namespace: me.paymentMean
    public enum DeferredStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failed")]
        failed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("valid")]
        valid,
    }
    
    // Id: IconData Namespace: me.paymentMean
    public class IconData {
        
        // Key: data Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data")]
        public System.String? Data { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public System.String? Url { get; set; }//;
    }
    
    // Id: Paypal Namespace: me.paymentMean
    public class Paypal {
        
        // Key: agreementId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("agreementId")]
        public required System.String AgreementId { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: defaultPaymentMean Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultPaymentMean")]
        public required System.Boolean DefaultPaymentMean { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: email Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("email")]
        public required System.String Email { get; set; }//;
        
        // Key: icon Type: me.paymentMean.IconData FullType: me.paymentMean.IconData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public _me_paymentMean.IconData? Icon { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: state Type: me.paymentMean.PaypalStateEnum FullType: me.paymentMean.PaypalStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _me_paymentMean.PaypalStateEnum State { get; set; }//;
    }
    
    // Id: PaypalChallengeCreation Namespace: me.paymentMean
    public class PaypalChallengeCreation {
        
        // Key: challenge Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("challenge")]
        public required System.String Challenge { get; set; }//;
    }
    
    // Id: PaypalCreation Namespace: me.paymentMean
    public class PaypalCreation {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: returnUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("returnUrl")]
        public System.String? ReturnUrl { get; set; }//;
        
        // Key: setDefault Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("setDefault")]
        public System.Boolean? SetDefault { get; set; }//;
    }
    
    // Id: PaypalStateEnum Namespace: me.paymentMean
    public enum PaypalStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failing")]
        failing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tooManyFailures")]
        tooManyFailures,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("valid")]
        valid,
    }
    
    // Id: PaypalValidation Namespace: me.paymentMean
    public class PaypalValidation {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: submitUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("submitUrl")]
        public System.String? SubmitUrl { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
        
        // Key: validationType Type: me.paymentMean.ValidationTypeEnum FullType: me.paymentMean.ValidationTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("validationType")]
        public required _me_paymentMean.ValidationTypeEnum ValidationType { get; set; }//;
    }
    
    // Id: ValidationTypeEnum Namespace: me.paymentMean
    public enum ValidationTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creditAccount")]
        creditAccount,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("documentToSend")]
        documentToSend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("simpleValidation")]
        simpleValidation,
    }
}
