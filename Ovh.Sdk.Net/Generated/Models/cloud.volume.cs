//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_volume {
    
    
    // Id: Snapshot Namespace: cloud.volume
    public class Snapshot {
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: status Type: cloud.volume.SnapshotStatusEnum FullType: cloud.volume.SnapshotStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_volume.SnapshotStatusEnum Status { get; set; }//;
        
        // Key: volumeId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeId")]
        public string VolumeId { get; set; }//;
    }
    
    // Id: SnapshotStatusEnum Namespace: cloud.volume
    public enum SnapshotStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_deleting")]
        error_deleting,
    }
    
    // Id: Volume Namespace: cloud.volume
    public class Volume {
        
        // Key: attachedTo Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedTo")]
        public string[] AttachedTo { get; set; }//;
        
        // Key: bootable Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bootable")]
        public bool Bootable { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: status Type: cloud.volume.VolumeStatusEnum FullType: cloud.volume.VolumeStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_volume.VolumeStatusEnum Status { get; set; }//;
        
        // Key: type Type: cloud.volume.VolumeTypeEnum FullType: cloud.volume.VolumeTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_volume.VolumeTypeEnum Type { get; set; }//;
    }
    
    // Id: VolumeStatusEnum Namespace: cloud.volume
    public enum VolumeStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attaching")]
        attaching,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("awaiting-transfer")]
        awaiting_transfer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backing-up")]
        backing_up,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("detaching")]
        detaching,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downloading")]
        downloading,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_backing-up")]
        error_backing_up,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_deleting")]
        error_deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_extending")]
        error_extending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_restoring")]
        error_restoring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extending")]
        extending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("in-use")]
        in_use,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maintenance")]
        maintenance,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reserved")]
        reserved,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restoring-backup")]
        restoring_backup,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("retyping")]
        retyping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uploading")]
        uploading,
    }
    
    // Id: VolumeTypeEnum Namespace: cloud.volume
    public enum VolumeTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("classic")]
        classic,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("high-speed")]
        high_speed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("high-speed-gen2")]
        high_speed_gen2,
    }
}
