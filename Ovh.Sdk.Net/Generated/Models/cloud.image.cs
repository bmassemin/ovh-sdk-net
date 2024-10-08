//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _cloud_image {
    
    
    // Id: Image Namespace: cloud.image
    public class Image {
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: flavorType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavorType")]
        public System.String? FlavorType { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public required System.String Id { get; set; }//;
        
        // Key: minDisk Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minDisk")]
        public required System.Int64 MinDisk { get; set; }//;
        
        // Key: minRam Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minRam")]
        public required System.Int64 MinRam { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: planCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public System.String? PlanCode { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public required System.String Region { get; set; }//;
        
        // Key: size Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public required System.Double Size { get; set; }//;
        
        // Key: status Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required System.String Status { get; set; }//;
        
        // Key: tags Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
        public System.String[]? Tags { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required System.String Type { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public required System.String User { get; set; }//;
        
        // Key: visibility Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("visibility")]
        public required System.String Visibility { get; set; }//;
    }
    
    // Id: OSTypeEnum Namespace: cloud.image
    public enum OSTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baremetal-linux")]
        baremetal_linux,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bsd")]
        bsd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linux")]
        linux,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("windows")]
        windows,
    }
}
