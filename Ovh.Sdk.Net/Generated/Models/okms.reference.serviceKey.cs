//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _okms_reference_serviceKey {
    
    
    // Id: Curve Namespace: okms.reference.serviceKey
    public class Curve {
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public bool @default { get; set; }//;
        
        // Key: value Type: okms.KeyCurveEnum FullType: okms.KeyCurveEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public _okms.KeyCurveEnum Value { get; set; }//;
    }
    
    // Id: Operations Namespace: okms.reference.serviceKey
    public class Operations {
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public bool @default { get; set; }//;
        
        // Key: value Type: okms.KeyOpsEnum[] FullType: okms.KeyOpsEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public _okms.KeyOpsEnum[] Value { get; set; }//;
    }
    
    // Id: Response Namespace: okms.reference.serviceKey
    public class Response {
        
        // Key: curves Type: okms.reference.serviceKey.Curve[] FullType: okms.reference.serviceKey.Curve[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("curves")]
        public _okms_reference_serviceKey.Curve[] Curves { get; set; }//;
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public bool @default { get; set; }//;
        
        // Key: operations Type: okms.reference.serviceKey.Operations[] FullType: okms.reference.serviceKey.Operations[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operations")]
        public _okms_reference_serviceKey.Operations[] Operations { get; set; }//;
        
        // Key: sizes Type: okms.reference.serviceKey.Size[] FullType: okms.reference.serviceKey.Size[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sizes")]
        public _okms_reference_serviceKey.Size[] Sizes { get; set; }//;
        
        // Key: type Type: okms.KeyTypeEnum FullType: okms.KeyTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _okms.KeyTypeEnum Type { get; set; }//;
    }
    
    // Id: Size Namespace: okms.reference.serviceKey
    public class Size {
        
        // Key: default Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public bool @default { get; set; }//;
        
        // Key: value Type: okms.KeySizeEnum FullType: okms.KeySizeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public _okms.KeySizeEnum Value { get; set; }//;
    }
}