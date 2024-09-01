//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _contact {
    
    
    // Id: FormCharacteristic Namespace: contact
    public class FormCharacteristic {
        
        // Key: keys Type: contact.KeyFormCharacteristic[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("keys")]
        public _contact.KeyFormCharacteristic[] Keys { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: KeyFormCharacteristic Namespace: contact
    public class KeyFormCharacteristic {
        
        // Key: key Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public string Key { get; set; }//;
        
        // Key: required Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("required")]
        public bool Required { get; set; }//;
    }
    
    // Id: Address Namespace: contact
    public class Address {
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public string City { get; set; }//;
        
        // Key: country Type: nichandle.CountryEnum FullType: nichandle.CountryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("country")]
        public _nichandle.CountryEnum Country { get; set; }//;
        
        // Key: line1 Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("line1")]
        public string Line1 { get; set; }//;
        
        // Key: line2 Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("line2")]
        public string Line2 { get; set; }//;
        
        // Key: line3 Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("line3")]
        public string Line3 { get; set; }//;
        
        // Key: otherDetails Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("otherDetails")]
        public string OtherDetails { get; set; }//;
        
        // Key: province Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("province")]
        public string Province { get; set; }//;
        
        // Key: zip Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zip")]
        public string Zip { get; set; }//;
    }
    
    // Id: Contact Namespace: contact
    public class Contact {
        
        // Key: address Type: contact.Address FullType: contact.Address
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public _contact.Address Address { get; set; }//;
        
        // Key: birthCity Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("birthCity")]
        public string BirthCity { get; set; }//;
        
        // Key: birthCountry Type: nichandle.CountryEnum FullType: nichandle.CountryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("birthCountry")]
        public _nichandle.CountryEnum BirthCountry { get; set; }//;
        
        // Key: birthDay Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("birthDay")]
        public System.DateOnly BirthDay { get; set; }//;
        
        // Key: birthZip Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("birthZip")]
        public string BirthZip { get; set; }//;
        
        // Key: cellPhone Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cellPhone")]
        public string CellPhone { get; set; }//;
        
        // Key: companyNationalIdentificationNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("companyNationalIdentificationNumber")]
        public string CompanyNationalIdentificationNumber { get; set; }//;
        
        // Key: email Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("email")]
        public string Email { get; set; }//;
        
        // Key: fax Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fax")]
        public string Fax { get; set; }//;
        
        // Key: firstName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("firstName")]
        public string FirstName { get; set; }//;
        
        // Key: gender Type: nichandle.GenderEnum FullType: nichandle.GenderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gender")]
        public _nichandle.GenderEnum Gender { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: language Type: nichandle.LanguageEnum FullType: nichandle.LanguageEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("language")]
        public _nichandle.LanguageEnum Language { get; set; }//;
        
        // Key: lastName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastName")]
        public string LastName { get; set; }//;
        
        // Key: legalForm Type: nichandle.LegalFormEnum FullType: nichandle.LegalFormEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legalForm")]
        public _nichandle.LegalFormEnum LegalForm { get; set; }//;
        
        // Key: nationalIdentificationNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nationalIdentificationNumber")]
        public string NationalIdentificationNumber { get; set; }//;
        
        // Key: nationality Type: nichandle.CountryEnum FullType: nichandle.CountryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nationality")]
        public _nichandle.CountryEnum Nationality { get; set; }//;
        
        // Key: organisationName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("organisationName")]
        public string OrganisationName { get; set; }//;
        
        // Key: organisationType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("organisationType")]
        public string OrganisationType { get; set; }//;
        
        // Key: phone Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("phone")]
        public string Phone { get; set; }//;
        
        // Key: spareEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spareEmail")]
        public string SpareEmail { get; set; }//;
        
        // Key: vat Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vat")]
        public string Vat { get; set; }//;
    }
    
    // Id: FieldInformation Namespace: contact
    public class FieldInformation {
        
        // Key: fieldName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fieldName")]
        public string FieldName { get; set; }//;
        
        // Key: mandatory Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mandatory")]
        public bool Mandatory { get; set; }//;
        
        // Key: readOnly Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("readOnly")]
        public bool ReadOnly { get; set; }//;
    }
}
