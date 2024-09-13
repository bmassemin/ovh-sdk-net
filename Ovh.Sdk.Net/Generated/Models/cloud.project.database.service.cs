//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_database_service {
    
    
    // Id: Backup Namespace: cloud.project.database.service
    public class Backup {
        
        // Key: pitr Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pitr")]
        public System.DateTime? Pitr { get; set; }//;
        
        // Key: regions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regions")]
        public string[] Regions { get; set; }//;
        
        // Key: retentionDays Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("retentionDays")]
        public System.Int64? RetentionDays { get; set; }//;
        
        // Key: time Type: time FullType: time
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("time")]
        public System.TimeOnly Time { get; set; }//;
    }
    
    // Id: CapabilityActions Namespace: cloud.project.database.service
    public class CapabilityActions {
        
        // Key: create Type: cloud.project.database.service.capability.StateEnum FullType: cloud.project.database.service.capability.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("create")]
        public _cloud_project_database_service_capability.StateEnum? Create { get; set; }//;
        
        // Key: delete Type: cloud.project.database.service.capability.StateEnum FullType: cloud.project.database.service.capability.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delete")]
        public _cloud_project_database_service_capability.StateEnum? Delete { get; set; }//;
        
        // Key: read Type: cloud.project.database.service.capability.StateEnum FullType: cloud.project.database.service.capability.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("read")]
        public _cloud_project_database_service_capability.StateEnum? Read { get; set; }//;
        
        // Key: update Type: cloud.project.database.service.capability.StateEnum FullType: cloud.project.database.service.capability.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public _cloud_project_database_service_capability.StateEnum? Update { get; set; }//;
    }
    
    // Id: CapabilityEnum Namespace: cloud.project.database.service
    public enum CapabilityEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("advancedConfiguration")]
        advancedConfiguration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backupRestore")]
        backupRestore,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backupTime")]
        backupTime,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backups")]
        backups,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificates")]
        certificates,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connectionPools")]
        connectionPools,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentQueries")]
        currentQueries,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentQueriesCancel")]
        currentQueriesCancel,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databases")]
        databases,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enableWrites")]
        enableWrites,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fork")]
        fork,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("integrations")]
        integrations,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipRestrictions")]
        ipRestrictions,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maintenanceApply")]
        maintenanceApply,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maintenanceTime")]
        maintenanceTime,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maintenances")]
        maintenances,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("namespaces")]
        namespaces,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nodes")]
        nodes,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queryStatistics")]
        queryStatistics,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queryStatisticsReset")]
        queryStatisticsReset,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        service,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userCredentialsReset")]
        userCredentialsReset,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("users")]
        users,
    }
    
    // Id: Certificates Namespace: cloud.project.database.service
    public class Certificates {
        
        // Key: ca Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ca")]
        public string Ca { get; set; }//;
    }
    
    // Id: CurrentQueries Namespace: cloud.project.database.service
    public class CurrentQueries {
        
        // Key: queries Type: cloud.project.database.service.currentqueries.Query[] FullType: cloud.project.database.service.currentqueries.Query[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queries")]
        public _cloud_project_database_service_currentqueries.Query[] Queries { get; set; }//;
    }
    
    // Id: DataPoint Namespace: cloud.project.database.service
    public class DataPoint {
        
        // Key: timestamp Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public long Timestamp { get; set; }//;
        
        // Key: value Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public double Value { get; set; }//;
    }
    
    // Id: Database Namespace: cloud.project.database.service
    public class Database {
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public bool @default { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Disk Namespace: cloud.project.database.service
    public class Disk {
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: Endpoint Namespace: cloud.project.database.service
    public class Endpoint {
        
        // Key: component Type: cloud.project.database.service.endpoint.ComponentEnum FullType: cloud.project.database.service.endpoint.ComponentEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("component")]
        public _cloud_project_database_service_endpoint.ComponentEnum Component { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: path Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("path")]
        public System.String? Path { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public System.Int64? Port { get; set; }//;
        
        // Key: scheme Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scheme")]
        public System.String? Scheme { get; set; }//;
        
        // Key: ssl Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssl")]
        public bool Ssl { get; set; }//;
        
        // Key: sslMode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslMode")]
        public System.String? SslMode { get; set; }//;
        
        // Key: uri Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uri")]
        public System.String? Uri { get; set; }//;
    }
    
    // Id: HostMetric Namespace: cloud.project.database.service
    public class HostMetric {
        
        // Key: dataPoints Type: cloud.project.database.service.DataPoint[] FullType: cloud.project.database.service.DataPoint[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dataPoints")]
        public _cloud_project_database_service.DataPoint[] DataPoints { get; set; }//;
        
        // Key: hostname Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostname")]
        public string Hostname { get; set; }//;
    }
    
    // Id: Integration Namespace: cloud.project.database.service
    public class Integration {
        
        // Key: destinationServiceId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("destinationServiceId")]
        public System.Guid DestinationServiceId { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: parameters Type: map[string]string FullType: map[string]string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parameters")]
        public Dictionary<string, string>? Parameters { get; set; }//;
        
        // Key: sourceServiceId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceServiceId")]
        public System.Guid SourceServiceId { get; set; }//;
        
        // Key: status Type: cloud.project.database.service.integration.StatusEnum FullType: cloud.project.database.service.integration.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database_service_integration.StatusEnum Status { get; set; }//;
        
        // Key: type Type: cloud.project.database.service.integration.TypeEnum FullType: cloud.project.database.service.integration.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_project_database_service_integration.TypeEnum Type { get; set; }//;
    }
    
    // Id: IpRestriction Namespace: cloud.project.database.service
    public class IpRestriction {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: ip Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
    }
    
    // Id: LogEntry Namespace: cloud.project.database.service
    public class LogEntry {
        
        // Key: hostname Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostname")]
        public string Hostname { get; set; }//;
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public string Message { get; set; }//;
        
        // Key: timestamp Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public long Timestamp { get; set; }//;
    }
    
    // Id: Maintenance Namespace: cloud.project.database.service
    public class Maintenance {
        
        // Key: appliedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("appliedAt")]
        public System.DateTime? AppliedAt { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: scheduledAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scheduledAt")]
        public System.DateTime? ScheduledAt { get; set; }//;
        
        // Key: status Type: cloud.project.database.service.maintenance.StatusEnum FullType: cloud.project.database.service.maintenance.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database_service_maintenance.StatusEnum Status { get; set; }//;
    }
    
    // Id: Metric Namespace: cloud.project.database.service
    public class Metric {
        
        // Key: metrics Type: cloud.project.database.service.HostMetric[] FullType: cloud.project.database.service.HostMetric[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metrics")]
        public _cloud_project_database_service.HostMetric[] Metrics { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: units Type: cloud.project.database.service.MetricUnitEnum FullType: cloud.project.database.service.MetricUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("units")]
        public _cloud_project_database_service.MetricUnitEnum Units { get; set; }//;
    }
    
    // Id: MetricPeriodEnum Namespace: cloud.project.database.service
    public enum MetricPeriodEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastDay")]
        lastDay,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastHour")]
        lastHour,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastMonth")]
        lastMonth,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastWeek")]
        lastWeek,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastYear")]
        lastYear,
    }
    
    // Id: MetricUnitEnum Namespace: cloud.project.database.service
    public enum MetricUnitEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BYTES")]
        BYTES,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BYTES_PER_SECOND")]
        BYTES_PER_SECOND,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GIGABYTES")]
        GIGABYTES,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GIGABYTES_PER_HOUR")]
        GIGABYTES_PER_HOUR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MEGABYTES")]
        MEGABYTES,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MEGABYTES_PER_SECOND")]
        MEGABYTES_PER_SECOND,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MILLISECONDS")]
        MILLISECONDS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PERCENT")]
        PERCENT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SCALAR")]
        SCALAR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SCALAR_PER_SECOND")]
        SCALAR_PER_SECOND,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SECONDS")]
        SECONDS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNKNOWN")]
        UNKNOWN,
    }
    
    // Id: Node Namespace: cloud.project.database.service
    public class Node {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: flavor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public string Flavor { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public long Port { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: role Type: cloud.project.database.service.node.RoleEnum FullType: cloud.project.database.service.node.RoleEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public _cloud_project_database_service_node.RoleEnum? Role { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
    }
    
    // Id: NodeCreation Namespace: cloud.project.database.service
    public class NodeCreation {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: flavor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public string Flavor { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public long Port { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: role Type: cloud.project.database.service.node.RoleEnum FullType: cloud.project.database.service.node.RoleEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("role")]
        public _cloud_project_database_service_node.RoleEnum? Role { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
    }
    
    // Id: NodePattern Namespace: cloud.project.database.service
    public class NodePattern {
        
        // Key: flavor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public string Flavor { get; set; }//;
        
        // Key: number Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public long Number { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
    }
    
    // Id: Replication Namespace: cloud.project.database.service
    public class Replication {
        
        // Key: emitHeartbeats Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("emitHeartbeats")]
        public bool EmitHeartbeats { get; set; }//;
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: replicationPolicyClass Type: cloud.project.database.service.replication.PolicyClassEnum FullType: cloud.project.database.service.replication.PolicyClassEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("replicationPolicyClass")]
        public _cloud_project_database_service_replication.PolicyClassEnum ReplicationPolicyClass { get; set; }//;
        
        // Key: sourceIntegration Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceIntegration")]
        public System.Guid SourceIntegration { get; set; }//;
        
        // Key: syncGroupOffsets Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncGroupOffsets")]
        public bool SyncGroupOffsets { get; set; }//;
        
        // Key: syncInterval Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncInterval")]
        public long SyncInterval { get; set; }//;
        
        // Key: targetIntegration Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetIntegration")]
        public System.Guid TargetIntegration { get; set; }//;
        
        // Key: topicExcludeList Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("topicExcludeList")]
        public string[] TopicExcludeList { get; set; }//;
        
        // Key: topics Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("topics")]
        public string[] Topics { get; set; }//;
    }
    
    // Id: ReplicationCreation Namespace: cloud.project.database.service
    public class ReplicationCreation {
        
        // Key: emitHeartbeats Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("emitHeartbeats")]
        public bool EmitHeartbeats { get; set; }//;
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: replicationPolicyClass Type: cloud.project.database.service.replication.PolicyClassEnum FullType: cloud.project.database.service.replication.PolicyClassEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("replicationPolicyClass")]
        public _cloud_project_database_service_replication.PolicyClassEnum ReplicationPolicyClass { get; set; }//;
        
        // Key: sourceIntegration Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceIntegration")]
        public System.Guid SourceIntegration { get; set; }//;
        
        // Key: syncGroupOffsets Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncGroupOffsets")]
        public bool SyncGroupOffsets { get; set; }//;
        
        // Key: syncInterval Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("syncInterval")]
        public long SyncInterval { get; set; }//;
        
        // Key: targetIntegration Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targetIntegration")]
        public System.Guid TargetIntegration { get; set; }//;
        
        // Key: topicExcludeList Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("topicExcludeList")]
        public string[] TopicExcludeList { get; set; }//;
        
        // Key: topics Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("topics")]
        public string[] Topics { get; set; }//;
    }
    
    // Id: Restore Namespace: cloud.project.database.service
    public class Restore {
        
        // Key: pointInTime Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pointInTime")]
        public System.DateTime PointInTime { get; set; }//;
    }
    
    // Id: Storage Namespace: cloud.project.database.service
    public class Storage {
        
        // Key: size Type: complexType.UnitAndValue<long> FullType: complexType.UnitAndValue<long>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _complexType.UnitAndValue<long> Size { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: User Namespace: cloud.project.database.service
    public class User {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: UserCreation Namespace: cloud.project.database.service
    public class UserCreation {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: UserWithPassword Namespace: cloud.project.database.service
    public class UserWithPassword {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: UserWithPasswordAndRoles Namespace: cloud.project.database.service
    public class UserWithPasswordAndRoles {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: roles Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roles")]
        public string[] Roles { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: UserWithRoles Namespace: cloud.project.database.service
    public class UserWithRoles {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: roles Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roles")]
        public string[] Roles { get; set; }//;
        
        // Key: status Type: cloud.project.database.StatusEnum FullType: cloud.project.database.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_database.StatusEnum Status { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: UserWithRolesCreation Namespace: cloud.project.database.service
    public class UserWithRolesCreation {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: roles Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roles")]
        public string[] Roles { get; set; }//;
    }
}
