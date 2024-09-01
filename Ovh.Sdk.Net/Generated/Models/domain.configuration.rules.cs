//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _domain_configuration_rules {
    
    
    // Id: Constraint Namespace: domain.configuration.rules
    public class Constraint {
        
        // Key: conditions Type: domain.configuration.rules.Rule FullType: domain.configuration.rules.Rule
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditions")]
        public _domain_configuration_rules.Rule? Conditions { get; set; }//;
        
        // Key: contexts Type: domain.configuration.rules.ContextEnum[] FullType: domain.configuration.rules.ContextEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contexts")]
        public _domain_configuration_rules.ContextEnum[]? Contexts { get; set; }//;
        
        // Key: operator Type: domain.configuration.rules.OperatorEnum FullType: domain.configuration.rules.OperatorEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operator")]
        public _domain_configuration_rules.OperatorEnum? @operator { get; set; }//;
        
        // Key: value Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public System.String? Value { get; set; }//;
        
        // Key: values Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("values")]
        public System.String[]? Values { get; set; }//;
    }
    
    // Id: ContextEnum Namespace: domain.configuration.rules
    public enum ContextEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accept_conditions")]
        accept_conditions,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("claims")]
        claims,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("create")]
        create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
        order,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("premium")]
        premium,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protected_code")]
        protected_code,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reason")]
        reason,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("trade")]
        trade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transfer")]
        transfer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        update,
    }
    
    // Id: OperatorEnum Namespace: domain.configuration.rules
    public enum OperatorEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("between")]
        between,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contains")]
        contains,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("empty")]
        empty,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eq")]
        eq,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gt")]
        gt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gte")]
        gte,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lt")]
        lt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lte")]
        lte,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("match")]
        match,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxlength")]
        maxlength,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minlength")]
        minlength,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ne")]
        ne,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notcontains")]
        notcontains,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notempty")]
        notempty,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readonly")]
        @readonly,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("required")]
        required,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shouldbetrue")]
        shouldbetrue,
    }
    
    // Id: Rule Namespace: domain.configuration.rules
    public class Rule {
        
        // Key: and Type: domain.configuration.rules.Rule[] FullType: domain.configuration.rules.Rule[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("and")]
        public _domain_configuration_rules.Rule[]? And { get; set; }//;
        
        // Key: conditions Type: domain.configuration.rules.Rule FullType: domain.configuration.rules.Rule
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditions")]
        public _domain_configuration_rules.Rule? Conditions { get; set; }//;
        
        // Key: constraints Type: domain.configuration.rules.Constraint[] FullType: domain.configuration.rules.Constraint[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("constraints")]
        public _domain_configuration_rules.Constraint[]? Constraints { get; set; }//;
        
        // Key: contexts Type: domain.configuration.rules.ContextEnum[] FullType: domain.configuration.rules.ContextEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contexts")]
        public _domain_configuration_rules.ContextEnum[]? Contexts { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: fields Type: domain.configuration.rules.Rule FullType: domain.configuration.rules.Rule
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fields")]
        public _domain_configuration_rules.Rule? Fields { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public System.String? Label { get; set; }//;
        
        // Key: or Type: domain.configuration.rules.Rule[] FullType: domain.configuration.rules.Rule[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("or")]
        public _domain_configuration_rules.Rule[]? Or { get; set; }//;
        
        // Key: placeholder Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("placeholder")]
        public System.String? Placeholder { get; set; }//;
        
        // Key: type Type: domain.configuration.rules.TypeEnum FullType: domain.configuration.rules.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _domain_configuration_rules.TypeEnum? Type { get; set; }//;
    }
    
    // Id: RuleData Namespace: domain.configuration.rules
    public class RuleData {
        
        // Key: adminAccount Type: nichandle.Nichandle FullType: nichandle.Nichandle
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adminAccount")]
        public _nichandle.Nichandle? AdminAccount { get; set; }//;
        
        // Key: domain Type: domain.Data FullType: domain.Data
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public _domain.Data? Domain { get; set; }//;
        
        // Key: extras Type: domain.configuration.rules.RuleExtraData FullType: domain.configuration.rules.RuleExtraData
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extras")]
        public _domain_configuration_rules.RuleExtraData? Extras { get; set; }//;
        
        // Key: owner Type: domain.Contact FullType: domain.Contact
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("owner")]
        public _domain.Contact? Owner { get; set; }//;
        
        // Key: techAccount Type: nichandle.Nichandle FullType: nichandle.Nichandle
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("techAccount")]
        public _nichandle.Nichandle? TechAccount { get; set; }//;
    }
    
    // Id: RuleExtraData Namespace: domain.configuration.rules
    public class RuleExtraData {
        
        // Key: acceptCondition Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("acceptCondition")]
        public System.Boolean? AcceptCondition { get; set; }//;
        
        // Key: authInfo Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("authInfo")]
        public System.String? AuthInfo { get; set; }//;
    }
    
    // Id: TypeEnum Namespace: domain.configuration.rules
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bool")]
        @bool,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contact")]
        contact,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date_ISO8601")]
        date_ISO8601,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        domain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("json")]
        json,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        number,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("string")]
        @string,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("string[]")]
        string_array_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("text")]
        text,
    }
}
