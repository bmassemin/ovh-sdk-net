//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_io {
    
    
    // Id: Stream Namespace: cloud.project.io
    public class Stream {
        
        // Key: backlog Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backlog")]
        public required System.TimeSpan Backlog { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: kind Type: cloud.project.io.StreamKindEnum FullType: cloud.project.io.StreamKindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_io.StreamKindEnum Kind { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: regions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public required System.String[] Regions { get; set; }//;
        
        // Key: retention Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("retention")]
        public required System.TimeSpan Retention { get; set; }//;
        
        // Key: status Type: cloud.project.io.StreamStatusEnum FullType: cloud.project.io.StreamStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_project_io.StreamStatusEnum Status { get; set; }//;
        
        // Key: throttling Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("throttling")]
        public required System.Int64 Throttling { get; set; }//;
    }
    
    // Id: StreamCreation Namespace: cloud.project.io
    public class StreamCreation {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: kind Type: cloud.project.io.StreamKindEnum FullType: cloud.project.io.StreamKindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_io.StreamKindEnum Kind { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
    }
    
    // Id: StreamKindEnum Namespace: cloud.project.io
    public enum StreamKindEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NON_PERSISTENT")]
        NON_PERSISTENT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PERSISTENT")]
        PERSISTENT,
    }
    
    // Id: StreamStats Namespace: cloud.project.io
    public class StreamStats {
        
        // Key: usage Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usage")]
        public required System.Double Usage { get; set; }//;
    }
    
    // Id: StreamStatusEnum Namespace: cloud.project.io
    public enum StreamStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INSTALLING")]
        INSTALLING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
    }
}
