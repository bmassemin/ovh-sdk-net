//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_instance {
    
    
    // Id: Access Namespace: cloud.instance
    public class Access {
        
        // Key: login Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("login")]
        public required System.String Login { get; set; }//;
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public required System.String Password { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: ApplicationAccess Namespace: cloud.instance
    public class ApplicationAccess {
        
        // Key: accesses Type: cloud.instance.Access[] FullType: cloud.instance.Access[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accesses")]
        public required _cloud_instance.Access[] Accesses { get; set; }//;
        
        // Key: status Type: cloud.instance.ApplicationAccessStateEnum FullType: cloud.instance.ApplicationAccessStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_instance.ApplicationAccessStateEnum Status { get; set; }//;
    }
    
    // Id: ApplicationAccessStateEnum Namespace: cloud.instance
    public enum ApplicationAccessStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installing")]
        installing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
    }
    
    // Id: AssociateFloatingIp Namespace: cloud.instance
    public class AssociateFloatingIp {
        
        // Key: floatingIpId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("floatingIpId")]
        public required System.Guid FloatingIpId { get; set; }//;
        
        // Key: gateway Type: cloud.network.CreateGatewaySummary FullType: cloud.network.CreateGatewaySummary
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public _cloud_network.CreateGatewaySummary? Gateway { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String Ip { get; set; }//;
    }
    
    // Id: AutoBackup Namespace: cloud.instance
    public class AutoBackup {
        
        // Key: cron Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cron")]
        public required System.String Cron { get; set; }//;
        
        // Key: rotation Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rotation")]
        public required System.Int64 Rotation { get; set; }//;
    }
    
    // Id: CreateFloatingIp Namespace: cloud.instance
    public class CreateFloatingIp {
        
        // Key: gateway Type: cloud.network.CreateGatewaySummary FullType: cloud.network.CreateGatewaySummary
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public _cloud_network.CreateGatewaySummary? Gateway { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String Ip { get; set; }//;
    }
    
    // Id: CreateInput Namespace: cloud.instance
    public class CreateInput {
        
        // Key: autobackup Type: cloud.instance.CreateInput.Autobackup FullType: cloud.instance.CreateInput.Autobackup
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autobackup")]
        public _cloud_instance_CreateInput.Autobackup? Autobackup { get; set; }//;
        
        // Key: billingPeriod Type: cloud.instance.CreateInput.BillingPeriodEnum FullType: cloud.instance.CreateInput.BillingPeriodEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingPeriod")]
        public required _cloud_instance_CreateInput.BillingPeriodEnum BillingPeriod { get; set; }//;
        
        // Key: bootFrom Type: cloud.instance.CreateInput.BootFrom FullType: cloud.instance.CreateInput.BootFrom
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bootFrom")]
        public required _cloud_instance_CreateInput.BootFrom BootFrom { get; set; }//;
        
        // Key: bulk Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bulk")]
        public required System.Int64 Bulk { get; set; }//;
        
        // Key: flavor Type: cloud.instance.CreateInput.Flavor FullType: cloud.instance.CreateInput.Flavor
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public required _cloud_instance_CreateInput.Flavor Flavor { get; set; }//;
        
        // Key: group Type: cloud.instance.CreateInput.Group FullType: cloud.instance.CreateInput.Group
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("group")]
        public _cloud_instance_CreateInput.Group? Group { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: network Type: cloud.instance.CreateInput.Network FullType: cloud.instance.CreateInput.Network
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        public required _cloud_instance_CreateInput.Network Network { get; set; }//;
        
        // Key: sshKey Type: cloud.instance.CreateInput.SshKey FullType: cloud.instance.CreateInput.SshKey
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sshKey")]
        public _cloud_instance_CreateInput.SshKey? SshKey { get; set; }//;
        
        // Key: sshKeyCreate Type: cloud.instance.CreateInput.SshKeyCreate FullType: cloud.instance.CreateInput.SshKeyCreate
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sshKeyCreate")]
        public _cloud_instance_CreateInput.SshKeyCreate? SshKeyCreate { get; set; }//;
        
        // Key: userData Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userData")]
        public System.String? UserData { get; set; }//;
    }
    
    // Id: Instance Namespace: cloud.instance
    public class Instance {
        
        // Key: availabilityZone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }//;
        
        // Key: created Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("created")]
        public required System.DateTime Created { get; set; }//;
        
        // Key: currentMonthOutgoingTraffic Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentMonthOutgoingTraffic")]
        public System.Int64? CurrentMonthOutgoingTraffic { get; set; }//;
        
        // Key: flavorId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavorId")]
        public required System.String FlavorId { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: imageId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("imageId")]
        public required System.String ImageId { get; set; }//;
        
        // Key: ipAddresses Type: cloud.instance.IpAddress[] FullType: cloud.instance.IpAddress[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipAddresses")]
        public required _cloud_instance.IpAddress[] IpAddresses { get; set; }//;
        
        // Key: monthlyBilling Type: cloud.instance.MonthlyBilling FullType: cloud.instance.MonthlyBilling
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthlyBilling")]
        public _cloud_instance.MonthlyBilling? MonthlyBilling { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: operationIds Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operationIds")]
        public required System.String[] OperationIds { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
        
        // Key: sshKeyId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sshKeyId")]
        public System.String? SshKeyId { get; set; }//;
        
        // Key: status Type: cloud.instance.InstanceStatusEnum FullType: cloud.instance.InstanceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_instance.InstanceStatusEnum Status { get; set; }//;
    }
    
    // Id: InstanceAddress Namespace: cloud.instance
    public class InstanceAddress {
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String Ip { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public required System.Int64 Version { get; set; }//;
    }
    
    // Id: InstanceDetail Namespace: cloud.instance
    public class InstanceDetail {
        
        // Key: availabilityZone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }//;
        
        // Key: created Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("created")]
        public required System.DateTime Created { get; set; }//;
        
        // Key: currentMonthOutgoingTraffic Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentMonthOutgoingTraffic")]
        public System.Int64? CurrentMonthOutgoingTraffic { get; set; }//;
        
        // Key: flavor Type: cloud.flavor.Flavor FullType: cloud.flavor.Flavor
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public required _cloud_flavor.Flavor Flavor { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: image Type: cloud.image.Image FullType: cloud.image.Image
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("image")]
        public required _cloud_image.Image Image { get; set; }//;
        
        // Key: ipAddresses Type: cloud.instance.IpAddress[] FullType: cloud.instance.IpAddress[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipAddresses")]
        public required _cloud_instance.IpAddress[] IpAddresses { get; set; }//;
        
        // Key: monthlyBilling Type: cloud.instance.MonthlyBilling FullType: cloud.instance.MonthlyBilling
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthlyBilling")]
        public _cloud_instance.MonthlyBilling? MonthlyBilling { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: operationIds Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operationIds")]
        public required System.String[] OperationIds { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
        
        // Key: rescuePassword Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rescuePassword")]
        public System.String? RescuePassword { get; set; }//;
        
        // Key: sshKey Type: cloud.sshkey.SshKeyDetail FullType: cloud.sshkey.SshKeyDetail
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sshKey")]
        public _cloud_sshkey.SshKeyDetail? SshKey { get; set; }//;
        
        // Key: status Type: cloud.instance.InstanceStatusEnum FullType: cloud.instance.InstanceStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_instance.InstanceStatusEnum Status { get; set; }//;
    }
    
    // Id: InstanceMetrics Namespace: cloud.instance
    public class InstanceMetrics {
        
        // Key: unit Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit")]
        public required System.String Unit { get; set; }//;
        
        // Key: values Type: cloud.instance.InstanceMetricsValue[] FullType: cloud.instance.InstanceMetricsValue[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("values")]
        public required _cloud_instance.InstanceMetricsValue[] Values { get; set; }//;
    }
    
    // Id: InstanceMetricsValue Namespace: cloud.instance
    public class InstanceMetricsValue {
        
        // Key: timestamp Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public required System.Int64 Timestamp { get; set; }//;
        
        // Key: value Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public required System.Double Value { get; set; }//;
    }
    
    // Id: InstanceStatusEnum Namespace: cloud.instance
    public enum InstanceStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BUILD")]
        BUILD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BUILDING")]
        BUILDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HARD_REBOOT")]
        HARD_REBOOT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MIGRATING")]
        MIGRATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PASSWORD")]
        PASSWORD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PAUSED")]
        PAUSED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REBOOT")]
        REBOOT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REBUILD")]
        REBUILD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESCUE")]
        RESCUE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESCUED")]
        RESCUED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESCUING")]
        RESCUING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESIZE")]
        RESIZE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESIZED")]
        RESIZED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESUMING")]
        RESUMING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REVERT_RESIZE")]
        REVERT_RESIZE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SHELVED")]
        SHELVED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SHELVED_OFFLOADED")]
        SHELVED_OFFLOADED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SHELVING")]
        SHELVING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SHUTOFF")]
        SHUTOFF,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SNAPSHOTTING")]
        SNAPSHOTTING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SOFT_DELETED")]
        SOFT_DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("STOPPED")]
        STOPPED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNKNOWN")]
        UNKNOWN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNRESCUING")]
        UNRESCUING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNSHELVING")]
        UNSHELVING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VERIFY_RESIZE")]
        VERIFY_RESIZE,
    }
    
    // Id: InstanceSummary Namespace: cloud.instance
    public class InstanceSummary {
        
        // Key: addresses Type: cloud.instance.InstanceAddress[] FullType: cloud.instance.InstanceAddress[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addresses")]
        public required _cloud_instance.InstanceAddress[] Addresses { get; set; }//;
        
        // Key: attachedVolumes Type: cloud.instance.InstanceSummaryVolumeValue[] FullType: cloud.instance.InstanceSummaryVolumeValue[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedVolumes")]
        public required _cloud_instance.InstanceSummaryVolumeValue[] AttachedVolumes { get; set; }//;
        
        // Key: availabilityZone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }//;
        
        // Key: flavorId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavorId")]
        public required System.Guid FlavorId { get; set; }//;
        
        // Key: flavorName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavorName")]
        public required System.String FlavorName { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: imageId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("imageId")]
        public required System.Guid ImageId { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
        
        // Key: sshKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sshKey")]
        public required System.String SshKey { get; set; }//;
        
        // Key: taskState Type: cloud.instance.InstanceSummaryTaskStateEnum FullType: cloud.instance.InstanceSummaryTaskStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskState")]
        public required _cloud_instance.InstanceSummaryTaskStateEnum TaskState { get; set; }//;
    }
    
    // Id: InstanceSummaryTaskStateEnum Namespace: cloud.instance
    public enum InstanceSummaryTaskStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("")]
        _Empty,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BlockDeviceMapping")]
        BlockDeviceMapping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Deleting")]
        Deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ImageBackup")]
        ImageBackup,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ImagePendingUpload")]
        ImagePendingUpload,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ImageSnapshot")]
        ImageSnapshot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ImageUpload")]
        ImageUpload,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Migrating")]
        Migrating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Networking")]
        Networking,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Pausing")]
        Pausing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PoweringOff")]
        PoweringOff,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PoweringOn")]
        PoweringOn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Rebooting")]
        Rebooting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RebootingHard")]
        RebootingHard,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RebuildBlockDeviceMapping")]
        RebuildBlockDeviceMapping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RebuildSpawning")]
        RebuildSpawning,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Rebuilding")]
        Rebuilding,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Rescuing")]
        Rescuing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizeConfirming")]
        ResizeConfirming,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizeFinish")]
        ResizeFinish,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizeMigrated")]
        ResizeMigrated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizeMigrating")]
        ResizeMigrating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizePrep")]
        ResizePrep,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ResizeReverting")]
        ResizeReverting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Resuming")]
        Resuming,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Scheduling")]
        Scheduling,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Spawning")]
        Spawning,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Starting")]
        Starting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Stopping")]
        Stopping,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Suspending")]
        Suspending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Unknown")]
        Unknown,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Unpausing")]
        Unpausing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Unrescuing")]
        Unrescuing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UpdatingPassword")]
        UpdatingPassword,
    }
    
    // Id: InstanceSummaryVolumeValue Namespace: cloud.instance
    public class InstanceSummaryVolumeValue {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
    }
    
    // Id: InstanceVnc Namespace: cloud.instance
    public class InstanceVnc {
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: IpAddress Namespace: cloud.instance
    public class IpAddress {
        
        // Key: gatewayIp Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gatewayIp")]
        public System.String? GatewayIp { get; set; }//;
        
        // Key: ip Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String Ip { get; set; }//;
        
        // Key: networkId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkId")]
        public required System.String NetworkId { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public required System.Int64 Version { get; set; }//;
    }
    
    // Id: MetricsPeriodEnum Namespace: cloud.instance
    public enum MetricsPeriodEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastday")]
        lastday,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastmonth")]
        lastmonth,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastweek")]
        lastweek,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastyear")]
        lastyear,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("today")]
        today,
    }
    
    // Id: MetricsTypeEnum Namespace: cloud.instance
    public enum MetricsTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cpu:max")]
        cpu_max,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cpu:used")]
        cpu_used,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mem:max")]
        mem_max,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mem:used")]
        mem_used,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("net:rx")]
        net_rx,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("net:tx")]
        net_tx,
    }
    
    // Id: MonthlyBilling Namespace: cloud.instance
    public class MonthlyBilling {
        
        // Key: since Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("since")]
        public required System.DateTime Since { get; set; }//;
        
        // Key: status Type: cloud.instance.MonthlyBillingStatusEnum FullType: cloud.instance.MonthlyBillingStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _cloud_instance.MonthlyBillingStatusEnum Status { get; set; }//;
    }
    
    // Id: MonthlyBillingStatusEnum Namespace: cloud.instance
    public enum MonthlyBillingStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activationPending")]
        activationPending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
    }
    
    // Id: MonthlyInstanceBulkParams Namespace: cloud.instance
    public class MonthlyInstanceBulkParams {
        
        // Key: instanceId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public required System.Guid InstanceId { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
    }
    
    // Id: NetworkBulkParams Namespace: cloud.instance
    public class NetworkBulkParams {
        
        // Key: networkId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkId")]
        public required System.String NetworkId { get; set; }//;
    }
    
    // Id: NetworkParams Namespace: cloud.instance
    public class NetworkParams {
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: networkId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkId")]
        public required System.String NetworkId { get; set; }//;
    }
    
    // Id: RebootTypeEnum Namespace: cloud.instance
    public enum RebootTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hard")]
        hard,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("soft")]
        soft,
    }
    
    // Id: RescueAdminPassword Namespace: cloud.instance
    public class RescueAdminPassword {
        
        // Key: adminPassword Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adminPassword")]
        public System.String? AdminPassword { get; set; }//;
    }
}
