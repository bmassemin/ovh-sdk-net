//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _sslGateway {
    
    
    // Id: Domain Namespace: sslGateway
    public class Domain {
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public required System.String _Domain { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: state Type: sslGateway.DomainStateEnum FullType: sslGateway.DomainStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _sslGateway.DomainStateEnum State { get; set; }//;
    }
    
    // Id: DomainStateEnum Namespace: sslGateway
    public enum DomainStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("http-only")]
        http_only,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
    }
    
    // Id: EligibilityStatus Namespace: sslGateway
    public class EligibilityStatus {
        
        // Key: domain Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public required System.String Domain { get; set; }//;
        
        // Key: ip6s Type: ipv6[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip6s")]
        public required System.String[] Ip6s { get; set; }//;
        
        // Key: ips Type: ipv4[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ips")]
        public required System.String[] Ips { get; set; }//;
        
        // Key: isHostedByOvh Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isHostedByOvh")]
        public required System.Boolean IsHostedByOvh { get; set; }//;
    }
    
    // Id: NatIps Namespace: sslGateway
    public class NatIps {
        
        // Key: ip Type: ipBlock[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public required System.String[] Ip { get; set; }//;
        
        // Key: zone Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public required System.String Zone { get; set; }//;
    }
    
    // Id: OfferEnum Namespace: sslGateway
    public enum OfferEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("advanced")]
        advanced,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enterprise")]
        enterprise,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("free")]
        free,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
    }
    
    // Id: Server Namespace: sslGateway
    public class Server {
        
        // Key: address Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public required System.String Address { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public required System.Int64 Port { get; set; }//;
        
        // Key: state Type: sslGateway.ServerStateEnum FullType: sslGateway.ServerStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _sslGateway.ServerStateEnum State { get; set; }//;
    }
    
    // Id: ServerStateEnum Namespace: sslGateway
    public enum ServerStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updating")]
        updating,
    }
    
    // Id: SslConfigurationEnum Namespace: sslGateway
    public enum SslConfigurationEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("intermediate")]
        intermediate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modern")]
        modern,
    }
    
    // Id: SslGateway Namespace: sslGateway
    public class SslGateway {
        
        // Key: allowedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedSource")]
        public System.String[]? AllowedSource { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: hsts Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hsts")]
        public required System.Boolean Hsts { get; set; }//;
        
        // Key: httpsRedirect Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpsRedirect")]
        public required System.Boolean HttpsRedirect { get; set; }//;
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public required System.String Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String? Ipv6 { get; set; }//;
        
        // Key: metricsToken Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metricsToken")]
        public System.String? MetricsToken { get; set; }//;
        
        // Key: offer Type: sslGateway.OfferEnum FullType: sslGateway.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public required _sslGateway.OfferEnum Offer { get; set; }//;
        
        // Key: reverse Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reverse")]
        public System.String? Reverse { get; set; }//;
        
        // Key: serverHttps Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverHttps")]
        public required System.Boolean ServerHttps { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: sslConfiguration Type: sslGateway.SslConfigurationEnum FullType: sslGateway.SslConfigurationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslConfiguration")]
        public _sslGateway.SslConfigurationEnum? SslConfiguration { get; set; }//;
        
        // Key: state Type: sslGateway.StateEnum FullType: sslGateway.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _sslGateway.StateEnum State { get; set; }//;
        
        // Key: zones Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zones")]
        public required System.String[] Zones { get; set; }//;
    }
    
    // Id: SslGateway Namespace: sslGateway
    public class SslGatewayWithIAM {
        
        // Key: allowedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedSource")]
        public System.String[]? AllowedSource { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: hsts Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hsts")]
        public required System.Boolean Hsts { get; set; }//;
        
        // Key: httpsRedirect Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpsRedirect")]
        public required System.Boolean HttpsRedirect { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public required System.String Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String? Ipv6 { get; set; }//;
        
        // Key: metricsToken Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metricsToken")]
        public System.String? MetricsToken { get; set; }//;
        
        // Key: offer Type: sslGateway.OfferEnum FullType: sslGateway.OfferEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public required _sslGateway.OfferEnum Offer { get; set; }//;
        
        // Key: reverse Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reverse")]
        public System.String? Reverse { get; set; }//;
        
        // Key: serverHttps Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serverHttps")]
        public required System.Boolean ServerHttps { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public required System.String ServiceName { get; set; }//;
        
        // Key: sslConfiguration Type: sslGateway.SslConfigurationEnum FullType: sslGateway.SslConfigurationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslConfiguration")]
        public _sslGateway.SslConfigurationEnum? SslConfiguration { get; set; }//;
        
        // Key: state Type: sslGateway.StateEnum FullType: sslGateway.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _sslGateway.StateEnum State { get; set; }//;
        
        // Key: zones Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zones")]
        public required System.String[] Zones { get; set; }//;
    }
    
    // Id: StateEnum Namespace: sslGateway
    public enum StateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("http-only")]
        http_only,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("suspended")]
        suspended,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upgrading")]
        upgrading,
    }
    
    // Id: Task Namespace: sslGateway
    public class Task {
        
        // Key: action Type: sslGateway.TaskActionEnum FullType: sslGateway.TaskActionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("action")]
        public required _sslGateway.TaskActionEnum Action { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.Int64 Id { get; set; }//;
        
        // Key: progress Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("progress")]
        public required System.Int64 Progress { get; set; }//;
        
        // Key: status Type: sslGateway.TaskStatusEnum FullType: sslGateway.TaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _sslGateway.TaskStatusEnum Status { get; set; }//;
    }
    
    // Id: TaskActionEnum Namespace: sslGateway
    public enum TaskActionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addDomain")]
        addDomain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addPaidCertificate")]
        addPaidCertificate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("addServer")]
        addServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createService")]
        createService,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteDomain")]
        deleteDomain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteServer")]
        deleteServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteService")]
        deleteService,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalTask")]
        internalTask,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updateServer")]
        updateServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updateService")]
        updateService,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("upgrade")]
        upgrade,
    }
    
    // Id: TaskStatusEnum Namespace: sslGateway
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blocked")]
        blocked,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("paused")]
        paused,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
}
