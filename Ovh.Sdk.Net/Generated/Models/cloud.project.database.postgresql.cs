//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_database_postgresql {
    
    
    // Id: ConnectionPool Namespace: cloud.project.database.postgresql
    public class ConnectionPool {
        
        // Key: databaseId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseId")]
        public required System.Guid DatabaseId { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Guid Id { get; set; }//;
        
        // Key: mode Type: cloud.project.database.postgresql.connectionpool.ModeEnum FullType: cloud.project.database.postgresql.connectionpool.ModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public required _cloud_project_database_postgresql_connectionpool.ModeEnum Mode { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public required System.Int64 Port { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public required System.Int64 Size { get; set; }//;
        
        // Key: sslMode Type: cloud.project.database.postgresql.connectionpool.SslModeEnum FullType: cloud.project.database.postgresql.connectionpool.SslModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslMode")]
        public _cloud_project_database_postgresql_connectionpool.SslModeEnum? SslMode { get; set; }//;
        
        // Key: uri Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uri")]
        public required System.String Uri { get; set; }//;
        
        // Key: userId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userId")]
        public System.Guid? UserId { get; set; }//;
    }
    
    // Id: ConnectionPoolCreation Namespace: cloud.project.database.postgresql
    public class ConnectionPoolCreation {
        
        // Key: databaseId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseId")]
        public required System.Guid DatabaseId { get; set; }//;
        
        // Key: mode Type: cloud.project.database.postgresql.connectionpool.ModeEnum FullType: cloud.project.database.postgresql.connectionpool.ModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public required _cloud_project_database_postgresql_connectionpool.ModeEnum Mode { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public required System.Int64 Size { get; set; }//;
        
        // Key: userId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userId")]
        public System.Guid? UserId { get; set; }//;
    }
    
    // Id: QueryStatistics Namespace: cloud.project.database.postgresql
    public class QueryStatistics {
        
        // Key: queries Type: cloud.project.database.postgresql.querystatistics.Query[] FullType: cloud.project.database.postgresql.querystatistics.Query[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("queries")]
        public required _cloud_project_database_postgresql_querystatistics.Query[] Queries { get; set; }//;
    }
}
