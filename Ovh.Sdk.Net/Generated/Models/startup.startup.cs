//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _startup_startup {
    
    
    // Id: company Namespace: startup.startup
    public class company {
        
        // Key: detail Type: startup.startup.company.detail FullType: startup.startup.company.detail
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("detail")]
        public _startup_startup_company.detail? Detail { get; set; }//;
        
        // Key: employeesNumber Type: startup.employeesNumberEnum FullType: startup.employeesNumberEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("employeesNumber")]
        public required _startup.employeesNumberEnum EmployeesNumber { get; set; }//;
        
        // Key: incubator Type: startup.startup.company.incubator FullType: startup.startup.company.incubator
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incubator")]
        public _startup_startup_company.incubator? Incubator { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: relatedIndustry Type: startup.relatedIndustryEnum FullType: startup.relatedIndustryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("relatedIndustry")]
        public required _startup.relatedIndustryEnum RelatedIndustry { get; set; }//;
        
        // Key: socialNetwork Type: startup.startup.company.socialNetwork FullType: startup.startup.company.socialNetwork
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("socialNetwork")]
        public _startup_startup_company.socialNetwork? SocialNetwork { get; set; }//;
        
        // Key: societyWebsite Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("societyWebsite")]
        public required System.String SocietyWebsite { get; set; }//;
    }
    
    // Id: fundRaising Namespace: startup.startup
    public class fundRaising {
        
        // Key: lastFundraising Type: startup.lastFundraisingEnum FullType: startup.lastFundraisingEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastFundraising")]
        public required _startup.lastFundraisingEnum LastFundraising { get; set; }//;
        
        // Key: plannedFundRaising Type: startup.plannedFundRaisingEnum FullType: startup.plannedFundRaisingEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plannedFundRaising")]
        public required _startup.plannedFundRaisingEnum PlannedFundRaising { get; set; }//;
    }
    
    // Id: project Namespace: startup.startup
    public class project {
        
        // Key: businessModel Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("businessModel")]
        public required System.String BusinessModel { get; set; }//;
        
        // Key: description Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: developmentStage Type: text FullType: text
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("developmentStage")]
        public required System.String DevelopmentStage { get; set; }//;
        
        // Key: productName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productName")]
        public required System.String ProductName { get; set; }//;
        
        // Key: relatedTechnology Type: startup.relatedTechnologyEnum[] FullType: startup.relatedTechnologyEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("relatedTechnology")]
        public required _startup.relatedTechnologyEnum[] RelatedTechnology { get; set; }//;
        
        // Key: requirements Type: startup.startup.project.technicalNeed FullType: startup.startup.project.technicalNeed
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requirements")]
        public required _startup_startup_project.technicalNeed Requirements { get; set; }//;
    }
}
