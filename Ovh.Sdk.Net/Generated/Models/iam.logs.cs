//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _iam_logs {
    
    
    // Id: ForwardRequest Namespace: iam.logs
    public class ForwardRequest {
        
        // Key: streamId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streamId")]
        public System.Guid StreamId { get; set; }//;
    }
    
    // Id: ForwardResponse Namespace: iam.logs
    public class ForwardResponse {
        
        // Key: operationId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operationId")]
        public System.Guid OperationId { get; set; }//;
    }
}