//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _services_expanded_technical {
    
    
    // Id: BaremetalServer Namespace: services.expanded.technical
    public class BaremetalServer {
        
        // Key: bandwidth Type: services.expanded.technical.baremetalServer.Bandwidth FullType: services.expanded.technical.baremetalServer.Bandwidth
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public _services_expanded_technical_baremetalServer.Bandwidth? Bandwidth { get; set; }//;
        
        // Key: gpu Type: services.expanded.technical.baremetalServer.Gpu FullType: services.expanded.technical.baremetalServer.Gpu
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gpu")]
        public _services_expanded_technical_baremetalServer.Gpu? Gpu { get; set; }//;
        
        // Key: memory Type: services.expanded.technical.baremetalServer.Memory FullType: services.expanded.technical.baremetalServer.Memory
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("memory")]
        public _services_expanded_technical_baremetalServer.Memory? Memory { get; set; }//;
        
        // Key: server Type: services.expanded.technical.baremetalServer.Server FullType: services.expanded.technical.baremetalServer.Server
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("server")]
        public _services_expanded_technical_baremetalServer.Server? Server { get; set; }//;
        
        // Key: storage Type: services.expanded.technical.baremetalServer.Storage FullType: services.expanded.technical.baremetalServer.Storage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public _services_expanded_technical_baremetalServer.Storage? Storage { get; set; }//;
        
        // Key: vrack Type: services.expanded.technical.baremetalServer.Vrack FullType: services.expanded.technical.baremetalServer.Vrack
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrack")]
        public _services_expanded_technical_baremetalServer.Vrack? Vrack { get; set; }//;
    }
    
    // Id: NutanixCluster Namespace: services.expanded.technical
    public class NutanixCluster {
        
        // Key: cluster Type: services.expanded.technical.nutanixCluster.Cluster FullType: services.expanded.technical.nutanixCluster.Cluster
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster")]
        public _services_expanded_technical_nutanixCluster.Cluster? Cluster { get; set; }//;
        
        // Key: features Type: services.expanded.technical.nutanixCluster.Features[] FullType: services.expanded.technical.nutanixCluster.Features[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("features")]
        public _services_expanded_technical_nutanixCluster.Features[]? Features { get; set; }//;
        
        // Key: license Type: services.expanded.technical.nutanixCluster.License FullType: services.expanded.technical.nutanixCluster.License
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("license")]
        public _services_expanded_technical_nutanixCluster.License? License { get; set; }//;
        
        // Key: service Type: services.expanded.technical.nutanixCluster.Service FullType: services.expanded.technical.nutanixCluster.Service
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        public _services_expanded_technical_nutanixCluster.Service? Service { get; set; }//;
    }
}
