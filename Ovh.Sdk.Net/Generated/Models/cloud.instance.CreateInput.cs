//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_instance_CreateInput {
    
    
    // Id: Autobackup Namespace: cloud.instance.CreateInput
    public class Autobackup {
        
        // Key: cron Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cron")]
        public string Cron { get; set; }//;
        
        // Key: rotation Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rotation")]
        public long Rotation { get; set; }//;
    }
    
    // Id: BillingPeriodEnum Namespace: cloud.instance.CreateInput
    public enum BillingPeriodEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hourly")]
        hourly,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monthly")]
        monthly,
    }
    
    // Id: BootFrom Namespace: cloud.instance.CreateInput
    public class BootFrom {
        
        // Key: imageId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("imageId")]
        public System.Guid ImageId { get; set; }//;
        
        // Key: volumeId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeId")]
        public System.Guid VolumeId { get; set; }//;
    }
    
    // Id: Flavor Namespace: cloud.instance.CreateInput
    public class Flavor {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
    }
    
    // Id: Group Namespace: cloud.instance.CreateInput
    public class Group {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
    }
    
    // Id: Network Namespace: cloud.instance.CreateInput
    public class Network {
        
        // Key: private Type: cloud.instance.CreateInput.Network.Private FullType: cloud.instance.CreateInput.Network.Private
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("private")]
        public _cloud_instance_CreateInput_Network.Private @private { get; set; }//;
        
        // Key: public Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("public")]
        public bool @public { get; set; }//;
    }
    
    // Id: SshKey Namespace: cloud.instance.CreateInput
    public class SshKey {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: SshKeyCreate Namespace: cloud.instance.CreateInput
    public class SshKeyCreate {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: publicKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publicKey")]
        public string PublicKey { get; set; }//;
    }
}
