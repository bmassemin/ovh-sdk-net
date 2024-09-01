//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_project_loadbalancer_networking {
    
    
    // Id: Egress Namespace: cloud.project.loadbalancer.networking
    public class Egress {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid? Id { get; set; }//;
        
        // Key: kind Type: cloud.project.loadbalancer.networking.egress.KindEnum FullType: cloud.project.loadbalancer.networking.egress.KindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_loadbalancer_networking_egress.KindEnum Kind { get; set; }//;
    }
    
    // Id: EgressCreation Namespace: cloud.project.loadbalancer.networking
    public class EgressCreation {
        
        // Key: kind Type: cloud.project.loadbalancer.networking.egress.KindEnum FullType: cloud.project.loadbalancer.networking.egress.KindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_loadbalancer_networking_egress.KindEnum Kind { get; set; }//;
    }
    
    // Id: Ingress Namespace: cloud.project.loadbalancer.networking
    public class Ingress {
        
        // Key: kind Type: cloud.project.loadbalancer.networking.ingress.KindEnum FullType: cloud.project.loadbalancer.networking.ingress.KindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_loadbalancer_networking_ingress.KindEnum Kind { get; set; }//;
    }
    
    // Id: IngressCreation Namespace: cloud.project.loadbalancer.networking
    public class IngressCreation {
        
        // Key: kind Type: cloud.project.loadbalancer.networking.ingress.KindEnum FullType: cloud.project.loadbalancer.networking.ingress.KindEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("kind")]
        public required _cloud_project_loadbalancer_networking_ingress.KindEnum Kind { get; set; }//;
    }
    
    // Id: Networking Namespace: cloud.project.loadbalancer.networking
    public class Networking {
        
        // Key: egress Type: cloud.project.loadbalancer.networking.Egress FullType: cloud.project.loadbalancer.networking.Egress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("egress")]
        public required _cloud_project_loadbalancer_networking.Egress Egress { get; set; }//;
        
        // Key: ingress Type: cloud.project.loadbalancer.networking.Ingress FullType: cloud.project.loadbalancer.networking.Ingress
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ingress")]
        public required _cloud_project_loadbalancer_networking.Ingress Ingress { get; set; }//;
    }
    
    // Id: NetworkingCreation Namespace: cloud.project.loadbalancer.networking
    public class NetworkingCreation {
        
        // Key: egress Type: cloud.project.loadbalancer.networking.EgressCreation FullType: cloud.project.loadbalancer.networking.EgressCreation
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("egress")]
        public _cloud_project_loadbalancer_networking.EgressCreation? Egress { get; set; }//;
        
        // Key: ingress Type: cloud.project.loadbalancer.networking.IngressCreation FullType: cloud.project.loadbalancer.networking.IngressCreation
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ingress")]
        public _cloud_project_loadbalancer_networking.IngressCreation? Ingress { get; set; }//;
    }
}
