//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _common {
    
    
    // Id: CurrentTask Namespace: common
    public class CurrentTask {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: link Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("link")]
        public string Link { get; set; }//;
        
        // Key: status Type: common.CurrentTaskStatusEnum FullType: common.CurrentTaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _common.CurrentTaskStatusEnum? Status { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: CurrentTaskStatusEnum Namespace: common
    public enum CurrentTaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING")]
        PENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SCHEDULED")]
        SCHEDULED,
    }
    
    // Id: Event Namespace: common
    public class Event {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: kind Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public string Kind { get; set; }//;
        
        // Key: link Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("link")]
        public System.String? Link { get; set; }//;
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public string Message { get; set; }//;
        
        // Key: type Type: common.EventTypeEnum FullType: common.EventTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _common.EventTypeEnum Type { get; set; }//;
    }
    
    // Id: EventTypeEnum Namespace: common
    public enum EventTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TARGET_SPEC_UPDATE")]
        TARGET_SPEC_UPDATE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TASK_ERROR")]
        TASK_ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TASK_START")]
        TASK_START,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TASK_SUCCESS")]
        TASK_SUCCESS,
    }
    
    // Id: ResourceStatusEnum Namespace: common
    public enum ResourceStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATING")]
        CREATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UPDATING")]
        UPDATING,
    }
    
    // Id: Task Namespace: common
    public class Task {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: errors Type: common.TaskError[] FullType: common.TaskError[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("errors")]
        public _common.TaskError[]? Errors { get; set; }//;
        
        // Key: finishedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("finishedAt")]
        public System.DateTime? FinishedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: link Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("link")]
        public string Link { get; set; }//;
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public string Message { get; set; }//;
        
        // Key: progress Type: common.TaskProgress[] FullType: common.TaskProgress[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("progress")]
        public _common.TaskProgress[] Progress { get; set; }//;
        
        // Key: startedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startedAt")]
        public System.DateTime? StartedAt { get; set; }//;
        
        // Key: status Type: common.TaskStatusEnum FullType: common.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _common.TaskStatusEnum Status { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: TaskError Namespace: common
    public class TaskError {
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public string Message { get; set; }//;
    }
    
    // Id: TaskProgress Namespace: common
    public class TaskProgress {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: status Type: common.TaskStatusEnum FullType: common.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _common.TaskStatusEnum Status { get; set; }//;
    }
    
    // Id: TaskStatusEnum Namespace: common
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DONE")]
        DONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING")]
        PENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SCHEDULED")]
        SCHEDULED,
    }
}