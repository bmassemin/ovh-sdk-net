//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _pack_xdsl_migration {
    
    
    // Id: MigrationOffer Namespace: pack.xdsl.migration
    public class MigrationOffer {
        
        // Key: contractList Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contractList")]
        public required System.String[] ContractList { get; set; }//;
        
        // Key: contracts Type: order.Contract[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contracts")]
        public required _order.Contract[] Contracts { get; set; }//;
        
        // Key: currentOfferPrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currentOfferPrice")]
        public required _order.Price CurrentOfferPrice { get; set; }//;
        
        // Key: customOntAddress Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customOntAddress")]
        public required System.Boolean CustomOntAddress { get; set; }//;
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public required System.String Description { get; set; }//;
        
        // Key: due Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("due")]
        public _order.Price? Due { get; set; }//;
        
        // Key: engageMonths Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engageMonths")]
        public System.Int64? EngageMonths { get; set; }//;
        
        // Key: engaged Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engaged")]
        public required System.Boolean Engaged { get; set; }//;
        
        // Key: engagementMonths Type: long[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engagementMonths")]
        public required System.Int64[] EngagementMonths { get; set; }//;
        
        // Key: firstYearPromo Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("firstYearPromo")]
        public _order.Price? FirstYearPromo { get; set; }//;
        
        // Key: gtrComfortFees Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gtrComfortFees")]
        public _order.Price? GtrComfortFees { get; set; }//;
        
        // Key: installFees Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installFees")]
        public _order.Price? InstallFees { get; set; }//;
        
        // Key: modemMacToReturn Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemMacToReturn")]
        public System.String? ModemMacToReturn { get; set; }//;
        
        // Key: modemOptions Type: pack.xdsl.migration.OfferModemOption[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemOptions")]
        public _pack_xdsl_migration.OfferModemOption[]? ModemOptions { get; set; }//;
        
        // Key: modemRental Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modemRental")]
        public _order.Price? ModemRental { get; set; }//;
        
        // Key: multiOtp Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("multiOtp")]
        public required System.Boolean MultiOtp { get; set; }//;
        
        // Key: needModem Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("needModem")]
        public required System.Boolean NeedModem { get; set; }//;
        
        // Key: needNewModem Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("needNewModem")]
        public required System.Boolean NeedNewModem { get; set; }//;
        
        // Key: offerName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerName")]
        public required System.String OfferName { get; set; }//;
        
        // Key: options Type: pack.xdsl.migration.OfferAvailableOption[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public required _pack_xdsl_migration.OfferAvailableOption[] Options { get; set; }//;
        
        // Key: price Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
        
        // Key: promotion Type: pack.xdsl.migrationAndAddressMove.Promotion FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("promotion")]
        public _pack_xdsl_migrationAndAddressMove.Promotion? Promotion { get; set; }//;
        
        // Key: providerAI Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerAI")]
        public _order.Price? ProviderAI { get; set; }//;
        
        // Key: providerOrange Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("providerOrange")]
        public _order.Price? ProviderOrange { get; set; }//;
        
        // Key: subServicesToDelete Type: pack.xdsl.migration.SubServiceToDelete[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subServicesToDelete")]
        public required _pack_xdsl_migration.SubServiceToDelete[] SubServicesToDelete { get; set; }//;
        
        // Key: url Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public required System.String Url { get; set; }//;
    }
    
    // Id: MigrationOfferResponse Namespace: pack.xdsl.migration
    public class MigrationOfferResponse {
        
        // Key: buildings Type: connectivity.eligibility.Building[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("buildings")]
        public required _connectivity_eligibility.Building[] Buildings { get; set; }//;
        
        // Key: offers Type: pack.xdsl.migration.MigrationOffer[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offers")]
        public required _pack_xdsl_migration.MigrationOffer[] Offers { get; set; }//;
    }
    
    // Id: OfferAvailableOption Namespace: pack.xdsl.migration
    public class OfferAvailableOption {
        
        // Key: duration Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public required System.Int64 Duration { get; set; }//;
        
        // Key: included Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("included")]
        public required System.Int64 Included { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: optional Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("optional")]
        public required System.Int64 Optional { get; set; }//;
        
        // Key: optionalPrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("optionalPrice")]
        public _order.Price? OptionalPrice { get; set; }//;
    }
    
    // Id: OfferModemOption Namespace: pack.xdsl.migration
    public class OfferModemOption {
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: price Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price? Price { get; set; }//;
    }
    
    // Id: OfferOption Namespace: pack.xdsl.migration
    public class OfferOption {
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: quantity Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public required System.Int64 Quantity { get; set; }//;
    }
    
    // Id: OfferServiceToDelete Namespace: pack.xdsl.migration
    public class OfferServiceToDelete {
        
        // Key: service Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        public required System.String Service { get; set; }//;
        
        // Key: type Type: pack.xdsl.ServiceNameEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _pack_xdsl.ServiceNameEnum Type { get; set; }//;
    }
    
    // Id: OfferServiceToKeep Namespace: pack.xdsl.migration
    public class OfferServiceToKeep {
        
        // Key: service Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        public required System.String Service { get; set; }//;
        
        // Key: type Type: pack.xdsl.ServiceNameEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _pack_xdsl.ServiceNameEnum Type { get; set; }//;
    }
    
    // Id: SubServiceDetails Namespace: pack.xdsl.migration
    public class SubServiceDetails {
        
        // Key: isAllowed Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isAllowed")]
        public required System.Boolean IsAllowed { get; set; }//;
        
        // Key: price Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public required _order.Price Price { get; set; }//;
        
        // Key: renewPeriod Type: double FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renewPeriod")]
        public required System.Double RenewPeriod { get; set; }//;
        
        // Key: renewPrice Type: order.Price FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renewPrice")]
        public required _order.Price RenewPrice { get; set; }//;
        
        // Key: service Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        public required System.String Service { get; set; }//;
    }
    
    // Id: SubServiceToDelete Namespace: pack.xdsl.migration
    public class SubServiceToDelete {
        
        // Key: numberToDelete Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("numberToDelete")]
        public required System.Int64 NumberToDelete { get; set; }//;
        
        // Key: services Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("services")]
        public required System.String[] Services { get; set; }//;
        
        // Key: type Type: pack.xdsl.ServiceNameEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _pack_xdsl.ServiceNameEnum Type { get; set; }//;
    }
    
    // Id: SubServicesDetailsToDelete Namespace: pack.xdsl.migration
    public class SubServicesDetailsToDelete {
        
        // Key: numberToDelete Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("numberToDelete")]
        public required System.Int64 NumberToDelete { get; set; }//;
        
        // Key: services Type: pack.xdsl.migration.SubServiceDetails[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("services")]
        public required _pack_xdsl_migration.SubServiceDetails[] Services { get; set; }//;
        
        // Key: type Type: pack.xdsl.ServiceNameEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _pack_xdsl.ServiceNameEnum Type { get; set; }//;
    }
}
