//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_ai_volume {
    
    
    // Id: DataStore Namespace: cloud.project.ai.volume
    public class DataStore {
        
        // Key: alias Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alias")]
        public required System.String Alias { get; set; }//;
        
        // Key: archive Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("archive")]
        public System.String? Archive { get; set; }//;
        
        // Key: container Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("container")]
        public required System.String Container { get; set; }//;
        
        // Key: internal Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        public System.Boolean? @internal { get; set; }//;
        
        // Key: prefix Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prefix")]
        public System.String? Prefix { get; set; }//;
    }
    
    // Id: DataSync Namespace: cloud.project.ai.volume
    public class DataSync {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: spec Type: cloud.project.ai.volume.DataSyncSpec FullType: cloud.project.ai.volume.DataSyncSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spec")]
        public required _cloud_project_ai_volume.DataSyncSpec Spec { get; set; }//;
        
        // Key: status Type: cloud.project.ai.volume.DataSyncStatus FullType: cloud.project.ai.volume.DataSyncStatus
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_project_ai_volume.DataSyncStatus Status { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: DataSyncEnum Namespace: cloud.project.ai.volume
    public enum DataSyncEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pull")]
        pull,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("push")]
        push,
    }
    
    // Id: DataSyncProgressStateEnum Namespace: cloud.project.ai.volume
    public enum DataSyncProgressStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DONE")]
        DONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FAILED")]
        FAILED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INTERRUPTED")]
        INTERRUPTED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("QUEUED")]
        QUEUED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
    }
    
    // Id: DataSyncSpec Namespace: cloud.project.ai.volume
    public class DataSyncSpec {
        
        // Key: direction Type: cloud.project.ai.volume.DataSyncEnum FullType: cloud.project.ai.volume.DataSyncEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("direction")]
        public required _cloud_project_ai_volume.DataSyncEnum Direction { get; set; }//;
        
        // Key: manual Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("manual")]
        public required System.Boolean Manual { get; set; }//;
        
        // Key: volume Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volume")]
        public System.Guid? Volume { get; set; }//;
    }
    
    // Id: DataSyncStateEnum Namespace: cloud.project.ai.volume
    public enum DataSyncStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DONE")]
        DONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FAILED")]
        FAILED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INTERRUPTED")]
        INTERRUPTED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("QUEUED")]
        QUEUED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
    }
    
    // Id: DataSyncStatus Namespace: cloud.project.ai.volume
    public class DataSyncStatus {
        
        // Key: endedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endedAt")]
        public System.DateTime? EndedAt { get; set; }//;
        
        // Key: info Type: cloud.project.ai.Info FullType: cloud.project.ai.Info
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("info")]
        public required _cloud_project_ai.Info Info { get; set; }//;
        
        // Key: progress Type: cloud.project.ai.volume.Progress[] FullType: cloud.project.ai.volume.Progress[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("progress")]
        public required _cloud_project_ai_volume.Progress[] Progress { get; set; }//;
        
        // Key: queuedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queuedAt")]
        public required System.DateTime QueuedAt { get; set; }//;
        
        // Key: startedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startedAt")]
        public System.DateTime? StartedAt { get; set; }//;
        
        // Key: state Type: cloud.project.ai.volume.DataSyncStateEnum FullType: cloud.project.ai.volume.DataSyncStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _cloud_project_ai_volume.DataSyncStateEnum State { get; set; }//;
    }
    
    // Id: PrivateSwift Namespace: cloud.project.ai.volume
    public class PrivateSwift {
        
        // Key: archive Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("archive")]
        public System.String? Archive { get; set; }//;
        
        // Key: container Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("container")]
        public required System.String Container { get; set; }//;
        
        // Key: internal Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        public System.Boolean? @internal { get; set; }//;
        
        // Key: prefix Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prefix")]
        public System.String? Prefix { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
    }
    
    // Id: Progress Namespace: cloud.project.ai.volume
    public class Progress {
        
        // Key: completed Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("completed")]
        public required System.Int64 Completed { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public required System.DateTime CreatedAt { get; set; }//;
        
        // Key: deleted Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        public required System.Int64 Deleted { get; set; }//;
        
        // Key: direction Type: cloud.project.ai.volume.DataSyncEnum FullType: cloud.project.ai.volume.DataSyncEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("direction")]
        public required _cloud_project_ai_volume.DataSyncEnum Direction { get; set; }//;
        
        // Key: eta Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eta")]
        public System.Int64? Eta { get; set; }//;
        
        // Key: failed Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("failed")]
        public required System.Int64 Failed { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: info Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("info")]
        public required System.String Info { get; set; }//;
        
        // Key: processed Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("processed")]
        public required System.Int64 Processed { get; set; }//;
        
        // Key: skipped Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("skipped")]
        public required System.Int64 Skipped { get; set; }//;
        
        // Key: state Type: cloud.project.ai.volume.DataSyncProgressStateEnum FullType: cloud.project.ai.volume.DataSyncProgressStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _cloud_project_ai_volume.DataSyncProgressStateEnum State { get; set; }//;
        
        // Key: total Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("total")]
        public required System.Int64 Total { get; set; }//;
        
        // Key: transferredBytes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transferredBytes")]
        public required System.Int64 TransferredBytes { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public required System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: PublicGit Namespace: cloud.project.ai.volume
    public class PublicGit {
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: PublicSwift Namespace: cloud.project.ai.volume
    public class PublicSwift {
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: Standalone Namespace: cloud.project.ai.volume
    public class Standalone {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
    }
    
    // Id: Volume Namespace: cloud.project.ai.volume
    public class Volume {
        
        // Key: cache Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cache")]
        public required System.Boolean Cache { get; set; }//;
        
        // Key: container Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("container")]
        public System.String? Container { get; set; }//;
        
        // Key: dataStore Type: cloud.project.ai.volume.DataStore FullType: cloud.project.ai.volume.DataStore
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dataStore")]
        public _cloud_project_ai_volume.DataStore? DataStore { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid? Id { get; set; }//;
        
        // Key: mountPath Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mountPath")]
        public required System.String MountPath { get; set; }//;
        
        // Key: permission Type: cloud.project.ai.VolumePermissionEnum FullType: cloud.project.ai.VolumePermissionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("permission")]
        public required _cloud_project_ai.VolumePermissionEnum Permission { get; set; }//;
        
        // Key: prefix Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prefix")]
        public System.String? Prefix { get; set; }//;
        
        // Key: privateSwift Type: cloud.project.ai.volume.PrivateSwift FullType: cloud.project.ai.volume.PrivateSwift
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateSwift")]
        public _cloud_project_ai_volume.PrivateSwift? PrivateSwift { get; set; }//;
        
        // Key: publicGit Type: cloud.project.ai.volume.PublicGit FullType: cloud.project.ai.volume.PublicGit
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicGit")]
        public _cloud_project_ai_volume.PublicGit? PublicGit { get; set; }//;
        
        // Key: publicSwift Type: cloud.project.ai.volume.PublicSwift FullType: cloud.project.ai.volume.PublicSwift
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicSwift")]
        public _cloud_project_ai_volume.PublicSwift? PublicSwift { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public System.String? Region { get; set; }//;
        
        // Key: standalone Type: cloud.project.ai.volume.Standalone FullType: cloud.project.ai.volume.Standalone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("standalone")]
        public _cloud_project_ai_volume.Standalone? Standalone { get; set; }//;
        
        // Key: targetDataStore Type: cloud.project.ai.volume.DataStore FullType: cloud.project.ai.volume.DataStore
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetDataStore")]
        public _cloud_project_ai_volume.DataStore? TargetDataStore { get; set; }//;
        
        // Key: targetPrivateSwift Type: cloud.project.ai.volume.PrivateSwift FullType: cloud.project.ai.volume.PrivateSwift
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetPrivateSwift")]
        public _cloud_project_ai_volume.PrivateSwift? TargetPrivateSwift { get; set; }//;
        
        // Key: volumeSource Type: cloud.project.ai.volume.VolumeSource FullType: cloud.project.ai.volume.VolumeSource
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeSource")]
        public _cloud_project_ai_volume.VolumeSource? VolumeSource { get; set; }//;
        
        // Key: volumeTarget Type: cloud.project.ai.volume.VolumeTarget FullType: cloud.project.ai.volume.VolumeTarget
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeTarget")]
        public _cloud_project_ai_volume.VolumeTarget? VolumeTarget { get; set; }//;
    }
    
    // Id: VolumeSource Namespace: cloud.project.ai.volume
    public class VolumeSource {
        
        // Key: dataStore Type: cloud.project.ai.volume.DataStore FullType: cloud.project.ai.volume.DataStore
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dataStore")]
        public _cloud_project_ai_volume.DataStore? DataStore { get; set; }//;
        
        // Key: publicGit Type: cloud.project.ai.volume.PublicGit FullType: cloud.project.ai.volume.PublicGit
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicGit")]
        public _cloud_project_ai_volume.PublicGit? PublicGit { get; set; }//;
        
        // Key: publicSwift Type: cloud.project.ai.volume.PublicSwift FullType: cloud.project.ai.volume.PublicSwift
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicSwift")]
        public _cloud_project_ai_volume.PublicSwift? PublicSwift { get; set; }//;
        
        // Key: standalone Type: cloud.project.ai.volume.Standalone FullType: cloud.project.ai.volume.Standalone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("standalone")]
        public _cloud_project_ai_volume.Standalone? Standalone { get; set; }//;
    }
    
    // Id: VolumeStatus Namespace: cloud.project.ai.volume
    public class VolumeStatus {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: mountPath Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mountPath")]
        public required System.String MountPath { get; set; }//;
        
        // Key: userVolumeId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userVolumeId")]
        public required System.Guid UserVolumeId { get; set; }//;
    }
    
    // Id: VolumeTarget Namespace: cloud.project.ai.volume
    public class VolumeTarget {
        
        // Key: targetDataStore Type: cloud.project.ai.volume.DataStore FullType: cloud.project.ai.volume.DataStore
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetDataStore")]
        public _cloud_project_ai_volume.DataStore? TargetDataStore { get; set; }//;
    }
}
