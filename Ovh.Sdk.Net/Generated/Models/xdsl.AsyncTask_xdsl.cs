//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _xdsl_AsyncTask_xdsl {
    
    
    // Id: ModemInfo Namespace: xdsl.AsyncTask_xdsl
    public class ModemInfo {
        
        // Key: error Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        public System.String? Error { get; set; }//;
        
        // Key: result Type: xdsl.ModemInfo FullType: xdsl.ModemInfo
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("result")]
        public _xdsl.ModemInfo? Result { get; set; }//;
        
        // Key: status Type: xdsl.AsyncTaskStatusEnum FullType: xdsl.AsyncTaskStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _xdsl.AsyncTaskStatusEnum Status { get; set; }//;
    }
}
