//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_database_service_currentqueries {
    
    
    // Id: Query Namespace: cloud.project.database.service.currentqueries
    public class Query {
        
        // Key: applicationName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applicationName")]
        public string ApplicationName { get; set; }//;
        
        // Key: backendStart Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendStart")]
        public System.DateTime BackendStart { get; set; }//;
        
        // Key: backendType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendType")]
        public string BackendType { get; set; }//;
        
        // Key: backendXid Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendXid")]
        public long BackendXid { get; set; }//;
        
        // Key: backendXmin Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backendXmin")]
        public long BackendXmin { get; set; }//;
        
        // Key: clientHostname Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientHostname")]
        public string ClientHostname { get; set; }//;
        
        // Key: clientIp Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientIp")]
        public System.Net.IPAddress ClientIp { get; set; }//;
        
        // Key: clientPort Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientPort")]
        public long ClientPort { get; set; }//;
        
        // Key: databaseId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseId")]
        public long DatabaseId { get; set; }//;
        
        // Key: databaseName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseName")]
        public string DatabaseName { get; set; }//;
        
        // Key: leaderPid Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("leaderPid")]
        public long LeaderPid { get; set; }//;
        
        // Key: pid Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pid")]
        public long Pid { get; set; }//;
        
        // Key: query Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("query")]
        public string _Query { get; set; }//;
        
        // Key: queryDuration Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queryDuration")]
        public double QueryDuration { get; set; }//;
        
        // Key: queryStart Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queryStart")]
        public System.DateTime QueryStart { get; set; }//;
        
        // Key: state Type: cloud.project.database.service.currentqueries.StateEnum FullType: cloud.project.database.service.currentqueries.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cloud_project_database_service_currentqueries.StateEnum State { get; set; }//;
        
        // Key: stateChange Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stateChange")]
        public System.DateTime StateChange { get; set; }//;
        
        // Key: transactionStart Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transactionStart")]
        public System.DateTime TransactionStart { get; set; }//;
        
        // Key: userId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userId")]
        public long UserId { get; set; }//;
        
        // Key: userName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userName")]
        public string UserName { get; set; }//;
        
        // Key: waitEvent Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitEvent")]
        public string WaitEvent { get; set; }//;
        
        // Key: waitEventType Type: cloud.project.database.service.currentqueries.WaitEventTypeEnum FullType: cloud.project.database.service.currentqueries.WaitEventTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitEventType")]
        public _cloud_project_database_service_currentqueries.WaitEventTypeEnum WaitEventType { get; set; }//;
    }
    
    // Id: StateEnum Namespace: cloud.project.database.service.currentqueries
    public enum StateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DISABLED")]
        DISABLED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FASTPATH_FUNCTION_CALL")]
        FASTPATH_FUNCTION_CALL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IDLE")]
        IDLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IDLE_IN_TRANSACTION")]
        IDLE_IN_TRANSACTION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IDLE_IN_TRANSACTION_ABORTED")]
        IDLE_IN_TRANSACTION_ABORTED,
    }
    
    // Id: WaitEventTypeEnum Namespace: cloud.project.database.service.currentqueries
    public enum WaitEventTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVITY")]
        ACTIVITY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BUFFER_PIN")]
        BUFFER_PIN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CLIENT")]
        CLIENT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXTENSION")]
        EXTENSION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IO")]
        IO,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IPC")]
        IPC,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOCK")]
        LOCK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LWLOCK")]
        LWLOCK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TIMEOUT")]
        TIMEOUT,
    }
}
