//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _dedicated_ceph {
    
    
    // Id: UpdateClusterDetails Namespace: dedicated.ceph
    public class UpdateClusterDetails {
        
        // Key: crushTunables Type: dedicated.ceph.clusterUpdate.crushTunablesEnum FullType: dedicated.ceph.clusterUpdate.crushTunablesEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("crushTunables")]
        public required _dedicated_ceph_clusterUpdate.crushTunablesEnum CrushTunables { get; set; }//;
        
        // Key: label Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("label")]
        public required System.String Label { get; set; }//;
    }
}
