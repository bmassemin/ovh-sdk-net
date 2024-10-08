//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _services_form {
    
    
    // Id: Answer Namespace: services.form
    public class Answer {
        
        // Key: question Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("question")]
        public required System.String Question { get; set; }//;
        
        // Key: value Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public required System.String Value { get; set; }//;
    }
    
    // Id: AnswerAllowedValue Namespace: services.form
    public class AnswerAllowedValue {
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public required System.String Key { get; set; }//;
    }
    
    // Id: AnswerTypeEnum Namespace: services.form
    public enum AnswerTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("boolean")]
        boolean,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        date,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("datetime")]
        datetime,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("double")]
        @double,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enum")]
        @enum,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("long")]
        @long,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("string")]
        @string,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("text")]
        text,
    }
    
    // Id: Description Namespace: services.form
    public class Description {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: questions Type: services.form.Question[] FullType: services.form.Question[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("questions")]
        public required _services_form.Question[] Questions { get; set; }//;
    }
    
    // Id: Form Namespace: services.form
    public class Form {
        
        // Key: answers Type: services.form.Answer[] FullType: services.form.Answer[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("answers")]
        public required _services_form.Answer[] Answers { get; set; }//;
    }
    
    // Id: Question Namespace: services.form
    public class Question {
        
        // Key: answers Type: services.form.AnswerAllowedValue[] FullType: services.form.AnswerAllowedValue[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("answers")]
        public _services_form.AnswerAllowedValue[]? Answers { get; set; }//;
        
        // Key: mandatory Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mandatory")]
        public required System.Boolean Mandatory { get; set; }//;
        
        // Key: question Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("question")]
        public required System.String _Question { get; set; }//;
        
        // Key: type Type: services.form.AnswerTypeEnum FullType: services.form.AnswerTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _services_form.AnswerTypeEnum Type { get; set; }//;
    }
    
    // Id: Response Namespace: services.form
    public class Response {
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public required System.String Message { get; set; }//;
    }
}
