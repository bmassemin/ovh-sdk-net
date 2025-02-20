//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _dedicated_storage {
    
    
    // Id: AclTypeEnum Namespace: dedicated.storage
    public enum AclTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readonly")]
        @readonly,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readwrite")]
        readwrite,
    }
    
    // Id: AtimeEnum Namespace: dedicated.storage
    public enum AtimeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("off")]
        off,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("on")]
        on,
    }
    
    // Id: DiskTypeEnum Namespace: dedicated.storage
    public enum DiskTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hdd")]
        hdd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nvme")]
        nvme,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssd")]
        ssd,
    }
    
    // Id: MetricsTokenResult Namespace: dedicated.storage
    public class MetricsTokenResult {
        
        // Key: endpoint Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoint")]
        public required System.String Endpoint { get; set; }//;
        
        // Key: token Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("token")]
        public required System.String Token { get; set; }//;
    }
    
    // Id: NasUsageTypeEnum Namespace: dedicated.storage
    public enum NasUsageTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        size,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("used")]
        used,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usedbysnapshots")]
        usedbysnapshots,
    }
    
    // Id: PartitionUsageTypeEnum Namespace: dedicated.storage
    public enum PartitionUsageTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        size,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("used")]
        used,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usedbysnapshots")]
        usedbysnapshots,
    }
    
    // Id: ProtocolEnum Namespace: dedicated.storage
    public enum ProtocolEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CIFS")]
        CIFS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NFS")]
        NFS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NFS_CIFS")]
        NFS_CIFS,
    }
    
    // Id: RecordSizeEnum Namespace: dedicated.storage
    public enum RecordSizeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("1048576")]
        _1048576,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("131072")]
        _131072,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("16384")]
        _16384,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("32768")]
        _32768,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("4096")]
        _4096,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("65536")]
        _65536,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("8192")]
        _8192,
    }
    
    // Id: SnapshotEnum Namespace: dedicated.storage
    public enum SnapshotEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day-1")]
        day_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day-2")]
        day_2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day-3")]
        day_3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day-7")]
        day_7,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hour-1")]
        hour_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hour-6")]
        hour_6,
    }
    
    // Id: SyncEnum Namespace: dedicated.storage
    public enum SyncEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("always")]
        always,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("standard")]
        standard,
    }
    
    // Id: TaskFunctionEnum Namespace: dedicated.storage
    public enum TaskFunctionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backupRecursiveDestroy")]
        backupRecursiveDestroy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercAclUpdate")]
        clusterLeclercAclUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercChangeServiceIp")]
        clusterLeclercChangeServiceIp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercCustomSnapCreate")]
        clusterLeclercCustomSnapCreate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercCustomSnapDelete")]
        clusterLeclercCustomSnapDelete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercDeleteSnapshotDirectory")]
        clusterLeclercDeleteSnapshotDirectory,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercDestroyNasContainer")]
        clusterLeclercDestroyNasContainer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercPartitionAdd")]
        clusterLeclercPartitionAdd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercPartitionDelete")]
        clusterLeclercPartitionDelete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercPartitionUpdate")]
        clusterLeclercPartitionUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercQuotaUpdate")]
        clusterLeclercQuotaUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercSetupNasContainer")]
        clusterLeclercSetupNasContainer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercSnapshotUpdate")]
        clusterLeclercSnapshotUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clusterLeclercZfsOptions")]
        clusterLeclercZfsOptions,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasAclUpdate")]
        nasAclUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasDeleteSnapshotDirectory")]
        nasDeleteSnapshotDirectory,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasPartitionAdd")]
        nasPartitionAdd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasPartitionDelete")]
        nasPartitionDelete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasPartitionUpdate")]
        nasPartitionUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nasQuotaUpdate")]
        nasQuotaUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remoteBackupRecursiveDestroy")]
        remoteBackupRecursiveDestroy,
    }
    
    // Id: TemplateUsageOptionsDetails Namespace: dedicated.storage
    public class TemplateUsageOptionsDetails {
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
    }
    
    // Id: TemplateUsageOptionsEnum Namespace: dedicated.storage
    public enum TemplateUsageOptionsEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Databases")]
        Databases,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Default")]
        Default,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("File Systems (big files)")]
        File_Systems__big_files_,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Virtual machines")]
        Virtual_machines,
    }
}
