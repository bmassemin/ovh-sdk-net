//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_partnerLevel {
    
    
    // Id: Level Namespace: me.partnerLevel
    public class Level {
        
        // Key: level Type: me.partnerLevel.LevelTypeEnum FullType: me.partnerLevel.LevelTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("level")]
        public _me_partnerLevel.LevelTypeEnum _Level { get; set; }//;
        
        // Key: msa Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("msa")]
        public bool Msa { get; set; }//;
        
        // Key: requirement Type: me.partnerLevel.RequirementLoSEnum FullType: me.partnerLevel.RequirementLoSEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requirement")]
        public _me_partnerLevel.RequirementLoSEnum Requirement { get; set; }//;
    }
    
    // Id: LevelTypeEnum Namespace: me.partnerLevel
    public enum LevelTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("advanced")]
        advanced,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("none")]
        none,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("standard")]
        standard,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("strategic")]
        strategic,
    }
    
    // Id: RequirementLoSEnum Namespace: me.partnerLevel
    public enum RequirementLoSEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("none")]
        none,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("premium")]
        premium,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("premium-accredited")]
        premium_accredited,
    }
}