//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _vps_backupftp_access {
    
    
    // Id: post Namespace: vps.backupftp.access
    public class post {
        
        // Key: cifs Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cifs")]
        public required System.Boolean Cifs { get; set; }//;
        
        // Key: ftp Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ftp")]
        public required System.Boolean Ftp { get; set; }//;
        
        // Key: ipBlock Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipBlock")]
        public required System.String IpBlock { get; set; }//;
        
        // Key: nfs Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nfs")]
        public required System.Boolean Nfs { get; set; }//;
    }
}
