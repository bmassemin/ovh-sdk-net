//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _xdsl_email_pro {
    
    
    // Id: Task Namespace: xdsl.email.pro
    public class Task {
        
        // Key: finishDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("finishDate")]
        public System.DateTime FinishDate { get; set; }//;
        
        // Key: function Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("function")]
        public string Function { get; set; }//;
        
        // Key: status Type: xdsl.email.pro.TaskStatusEnum FullType: xdsl.email.pro.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _xdsl_email_pro.TaskStatusEnum Status { get; set; }//;
        
        // Key: todoDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todoDate")]
        public System.DateTime TodoDate { get; set; }//;
    }
    
    // Id: TaskStatusEnum Namespace: xdsl.email.pro
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
}
