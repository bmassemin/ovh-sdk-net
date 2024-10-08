//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_mysql_querystatistics {
    
    
    // Id: Query Namespace: cloud.project.database.mysql.querystatistics
    public class Query {
        
        // Key: avgTimerWait Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("avgTimerWait")]
        public required System.Double AvgTimerWait { get; set; }//;
        
        // Key: countStar Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("countStar")]
        public required System.Int64 CountStar { get; set; }//;
        
        // Key: digest Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("digest")]
        public required System.String Digest { get; set; }//;
        
        // Key: digestText Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("digestText")]
        public required System.String DigestText { get; set; }//;
        
        // Key: firstSeen Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("firstSeen")]
        public required System.DateTime FirstSeen { get; set; }//;
        
        // Key: lastSeen Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastSeen")]
        public required System.DateTime LastSeen { get; set; }//;
        
        // Key: maxTimerWait Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxTimerWait")]
        public required System.Double MaxTimerWait { get; set; }//;
        
        // Key: minTimerWait Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minTimerWait")]
        public required System.Double MinTimerWait { get; set; }//;
        
        // Key: quantile95 Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantile95")]
        public required System.Int64 Quantile95 { get; set; }//;
        
        // Key: quantile99 Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantile99")]
        public required System.Int64 Quantile99 { get; set; }//;
        
        // Key: quantile999 Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantile999")]
        public required System.Int64 Quantile999 { get; set; }//;
        
        // Key: querySampleSeen Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("querySampleSeen")]
        public required System.DateTime QuerySampleSeen { get; set; }//;
        
        // Key: querySampleText Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("querySampleText")]
        public required System.String QuerySampleText { get; set; }//;
        
        // Key: querySampleTimerWait Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("querySampleTimerWait")]
        public required System.Double QuerySampleTimerWait { get; set; }//;
        
        // Key: schemaName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("schemaName")]
        public required System.String SchemaName { get; set; }//;
        
        // Key: sumCreatedTmpDiskTables Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumCreatedTmpDiskTables")]
        public required System.Int64 SumCreatedTmpDiskTables { get; set; }//;
        
        // Key: sumCreatedTmpTables Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumCreatedTmpTables")]
        public required System.Int64 SumCreatedTmpTables { get; set; }//;
        
        // Key: sumErrors Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumErrors")]
        public required System.Int64 SumErrors { get; set; }//;
        
        // Key: sumLockTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumLockTime")]
        public required System.Double SumLockTime { get; set; }//;
        
        // Key: sumNoGoodIndexUsed Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumNoGoodIndexUsed")]
        public required System.Int64 SumNoGoodIndexUsed { get; set; }//;
        
        // Key: sumNoIndexUsed Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumNoIndexUsed")]
        public required System.Int64 SumNoIndexUsed { get; set; }//;
        
        // Key: sumRowsAffected Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumRowsAffected")]
        public required System.Int64 SumRowsAffected { get; set; }//;
        
        // Key: sumRowsExamined Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumRowsExamined")]
        public required System.Int64 SumRowsExamined { get; set; }//;
        
        // Key: sumRowsSent Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumRowsSent")]
        public required System.Int64 SumRowsSent { get; set; }//;
        
        // Key: sumSelectFullJoin Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSelectFullJoin")]
        public required System.Int64 SumSelectFullJoin { get; set; }//;
        
        // Key: sumSelectFullRangeJoin Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSelectFullRangeJoin")]
        public required System.Int64 SumSelectFullRangeJoin { get; set; }//;
        
        // Key: sumSelectRange Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSelectRange")]
        public required System.Int64 SumSelectRange { get; set; }//;
        
        // Key: sumSelectRangeCheck Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSelectRangeCheck")]
        public required System.Int64 SumSelectRangeCheck { get; set; }//;
        
        // Key: sumSelectScan Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSelectScan")]
        public required System.Int64 SumSelectScan { get; set; }//;
        
        // Key: sumSortMergePasses Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSortMergePasses")]
        public required System.Int64 SumSortMergePasses { get; set; }//;
        
        // Key: sumSortRange Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSortRange")]
        public required System.Int64 SumSortRange { get; set; }//;
        
        // Key: sumSortRows Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSortRows")]
        public required System.Int64 SumSortRows { get; set; }//;
        
        // Key: sumSortScan Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumSortScan")]
        public required System.Int64 SumSortScan { get; set; }//;
        
        // Key: sumTimerWait Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumTimerWait")]
        public required System.Double SumTimerWait { get; set; }//;
        
        // Key: sumWarnings Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sumWarnings")]
        public required System.Int64 SumWarnings { get; set; }//;
    }
}
