//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _ovhcloudconnect_task {
    
    
    // Id: FunctionEnum Namespace: ovhcloudconnect.task
    public enum FunctionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addDatacenterConfiguration")]
        addDatacenterConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addDatacenterExtraConfiguration")]
        addDatacenterExtraConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addPopConfiguration")]
        addPopConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addVrack")]
        addVrack,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delDatacenterConfiguration")]
        delDatacenterConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delDatacenterExtraConfiguration")]
        delDatacenterExtraConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delPopConfiguration")]
        delPopConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lockInterface")]
        lockInterface,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("removeVrack")]
        removeVrack,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unlockInterface")]
        unlockInterface,
    }
    
    // Id: StatusEnum Namespace: ovhcloudconnect.task
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pause")]
        pause,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
}
