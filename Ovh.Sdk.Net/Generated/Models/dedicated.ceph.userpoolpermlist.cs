//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicated_ceph_userPoolPermList {
    
    
    // Id: response Namespace: dedicated.ceph.userPoolPermList
    public class response {
        
        // Key: classRead Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("classRead")]
        public bool ClassRead { get; set; }//;
        
        // Key: classWrite Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("classWrite")]
        public bool ClassWrite { get; set; }//;
        
        // Key: execute Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("execute")]
        public bool Execute { get; set; }//;
        
        // Key: poolName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("poolName")]
        public string PoolName { get; set; }//;
        
        // Key: read Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("read")]
        public bool Read { get; set; }//;
        
        // Key: write Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("write")]
        public bool Write { get; set; }//;
    }
}