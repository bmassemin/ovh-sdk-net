//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_postgresql_querystatistics {
    
    
    // Id: Query Namespace: cloud.project.database.postgresql.querystatistics
    public class Query {
        
        // Key: blkReadTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blkReadTime")]
        public required System.Double BlkReadTime { get; set; }//;
        
        // Key: blkWriteTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blkWriteTime")]
        public required System.Double BlkWriteTime { get; set; }//;
        
        // Key: calls Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("calls")]
        public required System.Int64 Calls { get; set; }//;
        
        // Key: databaseName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseName")]
        public required System.String DatabaseName { get; set; }//;
        
        // Key: localBlksDirtied Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localBlksDirtied")]
        public required System.Int64 LocalBlksDirtied { get; set; }//;
        
        // Key: localBlksHit Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localBlksHit")]
        public required System.Int64 LocalBlksHit { get; set; }//;
        
        // Key: localBlksRead Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localBlksRead")]
        public required System.Int64 LocalBlksRead { get; set; }//;
        
        // Key: localBlksWritten Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localBlksWritten")]
        public required System.Int64 LocalBlksWritten { get; set; }//;
        
        // Key: maxPlanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxPlanTime")]
        public required System.Double MaxPlanTime { get; set; }//;
        
        // Key: maxTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxTime")]
        public required System.Double MaxTime { get; set; }//;
        
        // Key: meanPlanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("meanPlanTime")]
        public required System.Double MeanPlanTime { get; set; }//;
        
        // Key: meanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("meanTime")]
        public required System.Double MeanTime { get; set; }//;
        
        // Key: minPlanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minPlanTime")]
        public required System.Double MinPlanTime { get; set; }//;
        
        // Key: minTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minTime")]
        public required System.Double MinTime { get; set; }//;
        
        // Key: query Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("query")]
        public required System.String _Query { get; set; }//;
        
        // Key: rows Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rows")]
        public required System.Int64 Rows { get; set; }//;
        
        // Key: sharedBlksDirtied Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sharedBlksDirtied")]
        public required System.Int64 SharedBlksDirtied { get; set; }//;
        
        // Key: sharedBlksHit Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sharedBlksHit")]
        public required System.Int64 SharedBlksHit { get; set; }//;
        
        // Key: sharedBlksRead Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sharedBlksRead")]
        public required System.Int64 SharedBlksRead { get; set; }//;
        
        // Key: sharedBlksWritten Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sharedBlksWritten")]
        public required System.Int64 SharedBlksWritten { get; set; }//;
        
        // Key: stddevPlanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stddevPlanTime")]
        public required System.Double StddevPlanTime { get; set; }//;
        
        // Key: stddevTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stddevTime")]
        public required System.Double StddevTime { get; set; }//;
        
        // Key: tempBlksRead Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tempBlksRead")]
        public required System.Int64 TempBlksRead { get; set; }//;
        
        // Key: tempBlksWritten Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tempBlksWritten")]
        public required System.Int64 TempBlksWritten { get; set; }//;
        
        // Key: totalPlanTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPlanTime")]
        public required System.Double TotalPlanTime { get; set; }//;
        
        // Key: totalTime Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalTime")]
        public required System.Double TotalTime { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public required System.String Username { get; set; }//;
        
        // Key: walBytes Type: complexType.UnitAndValue<long> FullType: complexType.UnitAndValue<long>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("walBytes")]
        public required _complexType.UnitAndValue<long> WalBytes { get; set; }//;
        
        // Key: walFpi Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("walFpi")]
        public required System.Int64 WalFpi { get; set; }//;
        
        // Key: walRecords Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("walRecords")]
        public required System.Int64 WalRecords { get; set; }//;
    }
}
