//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _connectivity_eligibility {
    
    
    // Id: ActivationTypeEnum Namespace: connectivity.eligibility
    public enum ActivationTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activate")]
        activate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("create")]
        create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createNeighbour")]
        createNeighbour,
    }
    
    // Id: Address Namespace: connectivity.eligibility
    public class Address {
        
        // Key: building Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("building")]
        public System.String? Building { get; set; }//;
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public required System.String City { get; set; }//;
        
        // Key: door Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("door")]
        public System.String? Door { get; set; }//;
        
        // Key: floor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("floor")]
        public System.String? Floor { get; set; }//;
        
        // Key: housingComplex Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("housingComplex")]
        public System.String? HousingComplex { get; set; }//;
        
        // Key: inseeCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inseeCode")]
        public required System.String InseeCode { get; set; }//;
        
        // Key: ownerName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownerName")]
        public System.String? OwnerName { get; set; }//;
        
        // Key: stairs Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stairs")]
        public System.String? Stairs { get; set; }//;
        
        // Key: streetCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetCode")]
        public System.String? StreetCode { get; set; }//;
        
        // Key: streetName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetName")]
        public System.String? StreetName { get; set; }//;
        
        // Key: streetNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetNumber")]
        public System.String? StreetNumber { get; set; }//;
        
        // Key: zipCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zipCode")]
        public required System.String ZipCode { get; set; }//;
    }
    
    // Id: AddressWithCoordinates Namespace: connectivity.eligibility
    public class AddressWithCoordinates {
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public required System.String City { get; set; }//;
        
        // Key: distance Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("distance")]
        public System.String? Distance { get; set; }//;
        
        // Key: inseeCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inseeCode")]
        public required System.String InseeCode { get; set; }//;
        
        // Key: latitude Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
        public required System.String Latitude { get; set; }//;
        
        // Key: longitude Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
        public required System.String Longitude { get; set; }//;
        
        // Key: streetCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetCode")]
        public System.String? StreetCode { get; set; }//;
        
        // Key: streetName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetName")]
        public System.String? StreetName { get; set; }//;
        
        // Key: streetNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetNumber")]
        public System.String? StreetNumber { get; set; }//;
        
        // Key: zipCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zipCode")]
        public required System.String ZipCode { get; set; }//;
    }
    
    // Id: Building Namespace: connectivity.eligibility
    public class Building {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: nro Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nro")]
        public System.String? Nro { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public required System.String Reference { get; set; }//;
        
        // Key: stairs Type: connectivity.eligibility.BuildingStair[] FullType: connectivity.eligibility.BuildingStair[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stairs")]
        public _connectivity_eligibility.BuildingStair[]? Stairs { get; set; }//;
        
        // Key: type Type: connectivity.eligibility.BuildingTypeEnum FullType: connectivity.eligibility.BuildingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _connectivity_eligibility.BuildingTypeEnum? Type { get; set; }//;
    }
    
    // Id: BuildingStair Namespace: connectivity.eligibility
    public class BuildingStair {
        
        // Key: floors Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("floors")]
        public required System.String[] Floors { get; set; }//;
        
        // Key: stair Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stair")]
        public required System.String Stair { get; set; }//;
    }
    
    // Id: BuildingTypeEnum Namespace: connectivity.eligibility
    public enum BuildingTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BUILDING")]
        BUILDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HOUSE")]
        HOUSE,
    }
    
    // Id: City Namespace: connectivity.eligibility
    public class City {
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public required System.String _City { get; set; }//;
        
        // Key: inseeCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inseeCode")]
        public required System.String InseeCode { get; set; }//;
        
        // Key: locality Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("locality")]
        public System.String? Locality { get; set; }//;
        
        // Key: zipCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zipCode")]
        public required System.String ZipCode { get; set; }//;
    }
    
    // Id: CopperInfo Namespace: connectivity.eligibility
    public class CopperInfo {
        
        // Key: availablePairs Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availablePairs")]
        public System.Int64? AvailablePairs { get; set; }//;
        
        // Key: maxAvailablePairs Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxAvailablePairs")]
        public System.Int64? MaxAvailablePairs { get; set; }//;
        
        // Key: nra Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nra")]
        public System.String? Nra { get; set; }//;
        
        // Key: sectionsLengths Type: connectivity.eligibility.SectionLength[] FullType: connectivity.eligibility.SectionLength[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sectionsLengths")]
        public required _connectivity_eligibility.SectionLength[] SectionsLengths { get; set; }//;
        
        // Key: status Type: connectivity.eligibility.LineStatusEnum FullType: connectivity.eligibility.LineStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public required _connectivity_eligibility.LineStatusEnum Status { get; set; }//;
        
        // Key: underConstruction Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("underConstruction")]
        public System.Boolean? UnderConstruction { get; set; }//;
        
        // Key: unlistedNumber Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unlistedNumber")]
        public required System.Boolean UnlistedNumber { get; set; }//;
    }
    
    // Id: EligibilityTest Namespace: connectivity.eligibility
    public class EligibilityTest {
        
        // Key: eligibilityReference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eligibilityReference")]
        public required System.String EligibilityReference { get; set; }//;
        
        // Key: endpoint Type: connectivity.eligibility.Endpoint FullType: connectivity.eligibility.Endpoint
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoint")]
        public required _connectivity_eligibility.Endpoint Endpoint { get; set; }//;
        
        // Key: offers Type: connectivity.eligibility.Offer[] FullType: connectivity.eligibility.Offer[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offers")]
        public required _connectivity_eligibility.Offer[] Offers { get; set; }//;
    }
    
    // Id: Endpoint Namespace: connectivity.eligibility
    public class Endpoint {
        
        // Key: address Type: connectivity.eligibility.Address FullType: connectivity.eligibility.Address
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public _connectivity_eligibility.Address? Address { get; set; }//;
        
        // Key: copperInfo Type: connectivity.eligibility.CopperInfo FullType: connectivity.eligibility.CopperInfo
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("copperInfo")]
        public _connectivity_eligibility.CopperInfo? CopperInfo { get; set; }//;
        
        // Key: fiberInfo Type: connectivity.eligibility.FiberInfo FullType: connectivity.eligibility.FiberInfo
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fiberInfo")]
        public _connectivity_eligibility.FiberInfo? FiberInfo { get; set; }//;
        
        // Key: portability Type: connectivity.eligibility.Portability FullType: connectivity.eligibility.Portability
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portability")]
        public _connectivity_eligibility.Portability? Portability { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public required System.String Reference { get; set; }//;
        
        // Key: referenceType Type: connectivity.eligibility.EndpointReferenceTypeEnum FullType: connectivity.eligibility.EndpointReferenceTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("referenceType")]
        public required _connectivity_eligibility.EndpointReferenceTypeEnum ReferenceType { get; set; }//;
    }
    
    // Id: EndpointReferenceTypeEnum Namespace: connectivity.eligibility
    public enum EndpointReferenceTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("building")]
        building,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lineNumber")]
        lineNumber,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("otp")]
        otp,
    }
    
    // Id: FiberInfo Namespace: connectivity.eligibility
    public class FiberInfo {
        
        // Key: buildingName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("buildingName")]
        public System.String? BuildingName { get; set; }//;
        
        // Key: buildingReference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("buildingReference")]
        public required System.String BuildingReference { get; set; }//;
        
        // Key: buildingType Type: connectivity.eligibility.BuildingTypeEnum FullType: connectivity.eligibility.BuildingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("buildingType")]
        public required _connectivity_eligibility.BuildingTypeEnum BuildingType { get; set; }//;
        
        // Key: latitude Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
        public System.String? Latitude { get; set; }//;
        
        // Key: longitude Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
        public System.String? Longitude { get; set; }//;
        
        // Key: nro Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nro")]
        public System.String? Nro { get; set; }//;
        
        // Key: operatorCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operatorCode")]
        public required System.String OperatorCode { get; set; }//;
        
        // Key: operatorName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operatorName")]
        public required System.String OperatorName { get; set; }//;
        
        // Key: pmReference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pmReference")]
        public System.String? PmReference { get; set; }//;
    }
    
    // Id: InstallationTypeEnum Namespace: connectivity.eligibility
    public enum InstallationTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activate")]
        activate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activate_undefined")]
        activate_undefined,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("create")]
        create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("multiOtp")]
        multiOtp,
    }
    
    // Id: Line Namespace: connectivity.eligibility
    public class Line {
        
        // Key: address Type: connectivity.eligibility.Address FullType: connectivity.eligibility.Address
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public required _connectivity_eligibility.Address Address { get; set; }//;
        
        // Key: copperInfo Type: connectivity.eligibility.CopperInfo FullType: connectivity.eligibility.CopperInfo
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("copperInfo")]
        public required _connectivity_eligibility.CopperInfo CopperInfo { get; set; }//;
        
        // Key: lineNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lineNumber")]
        public required System.String LineNumber { get; set; }//;
    }
    
    // Id: LineStatusEnum Namespace: connectivity.eligibility
    public enum LineStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inactive")]
        inactive,
    }
    
    // Id: MeetingCapacities Namespace: connectivity.eligibility
    public class MeetingCapacities {
        
        // Key: eRdv Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eRdv")]
        public required System.Boolean ERdv { get; set; }//;
        
        // Key: phoneCall Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("phoneCall")]
        public required System.Boolean PhoneCall { get; set; }//;
    }
    
    // Id: MeetingSlot Namespace: connectivity.eligibility
    public class MeetingSlot {
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public required System.DateTime EndDate { get; set; }//;
        
        // Key: slotId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("slotId")]
        public System.String? SlotId { get; set; }//;
        
        // Key: startDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public required System.DateTime StartDate { get; set; }//;
        
        // Key: uiCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uiCode")]
        public System.String? UiCode { get; set; }//;
    }
    
    // Id: Meetings Namespace: connectivity.eligibility
    public class Meetings {
        
        // Key: canBookFakeMeeting Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("canBookFakeMeeting")]
        public required System.Boolean CanBookFakeMeeting { get; set; }//;
        
        // Key: capacities Type: connectivity.eligibility.MeetingCapacities FullType: connectivity.eligibility.MeetingCapacities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("capacities")]
        public required _connectivity_eligibility.MeetingCapacities Capacities { get; set; }//;
        
        // Key: meetingSlots Type: connectivity.eligibility.MeetingSlot[] FullType: connectivity.eligibility.MeetingSlot[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("meetingSlots")]
        public required _connectivity_eligibility.MeetingSlot[] MeetingSlots { get; set; }//;
    }
    
    // Id: Message Namespace: connectivity.eligibility
    public class Message {
        
        // Key: availabilityDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availabilityDate")]
        public System.DateTime? AvailabilityDate { get; set; }//;
        
        // Key: code Type: connectivity.eligibility.MessageCodeEnum FullType: connectivity.eligibility.MessageCodeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public required _connectivity_eligibility.MessageCodeEnum Code { get; set; }//;
        
        // Key: message Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public required System.String _Message { get; set; }//;
    }
    
    // Id: MessageCodeEnum Namespace: connectivity.eligibility
    public enum MessageCodeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2006")]
        _2006,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2011")]
        _2011,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2102")]
        _2102,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2103")]
        _2103,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2104")]
        _2104,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2105")]
        _2105,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3009")]
        _3009,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3011")]
        _3011,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3012")]
        _3012,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3013")]
        _3013,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3014")]
        _3014,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3031")]
        _3031,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3040")]
        _3040,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3041")]
        _3041,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3043")]
        _3043,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3044")]
        _3044,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3045")]
        _3045,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3046")]
        _3046,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3047")]
        _3047,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3048")]
        _3048,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("3049")]
        _3049,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ATTENUATION_LIMIT")]
        ATTENUATION_LIMIT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COMPATIBILITY_CHECK")]
        COMPATIBILITY_CHECK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COPPER_NOT_AVAILABLE")]
        COPPER_NOT_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COPPER_NOT_YET_AVAILABLE")]
        COPPER_NOT_YET_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELAY_30")]
        DELAY_30,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELAY_7")]
        DELAY_7,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EXTERNAL_WS_UNREACHABLE")]
        EXTERNAL_WS_UNREACHABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_NOT_AVAILABLE")]
        FIBER_NOT_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_NOT_DEPLOYED_IN_BUILDING")]
        FIBER_NOT_DEPLOYED_IN_BUILDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_NOT_YET_AVAILABLE")]
        FIBER_NOT_YET_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_NOT_YET_DEPLOYED")]
        FIBER_NOT_YET_DEPLOYED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INCOMPATIBLE_LOCAL_LOOP")]
        INCOMPATIBLE_LOCAL_LOOP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NETWORK_SATURATED")]
        NETWORK_SATURATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OTP_NOT_CONNECTABLE")]
        OTP_NOT_CONNECTABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OTP_NOT_MARKETABLE")]
        OTP_NOT_MARKETABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PAIRS_SATURATION")]
        PAIRS_SATURATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PRODUCT_NOT_AVAILABLE")]
        PRODUCT_NOT_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PRODUCT_NOT_YET_AVAILABLE")]
        PRODUCT_NOT_YET_AVAILABLE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TOO_MUCH_ATTENUATION")]
        TOO_MUCH_ATTENUATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNCERTAIN_DATA")]
        UNCERTAIN_DATA,
    }
    
    // Id: Offer Namespace: connectivity.eligibility
    public class Offer {
        
        // Key: eligibility Type: connectivity.eligibility.OfferEligibility FullType: connectivity.eligibility.OfferEligibility
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eligibility")]
        public required _connectivity_eligibility.OfferEligibility Eligibility { get; set; }//;
        
        // Key: product Type: connectivity.eligibility.OfferProduct FullType: connectivity.eligibility.OfferProduct
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("product")]
        public required _connectivity_eligibility.OfferProduct Product { get; set; }//;
    }
    
    // Id: OfferEligibility Namespace: connectivity.eligibility
    public class OfferEligibility {
        
        // Key: activationTypes Type: connectivity.eligibility.ActivationTypeEnum[] FullType: connectivity.eligibility.ActivationTypeEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activationTypes")]
        public required _connectivity_eligibility.ActivationTypeEnum[] ActivationTypes { get; set; }//;
        
        // Key: eligible Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eligible")]
        public required System.Boolean Eligible { get; set; }//;
        
        // Key: estimatedDownloadRate Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("estimatedDownloadRate")]
        public System.Double? EstimatedDownloadRate { get; set; }//;
        
        // Key: estimatedUploadRate Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("estimatedUploadRate")]
        public System.Double? EstimatedUploadRate { get; set; }//;
        
        // Key: multiOtp Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("multiOtp")]
        public System.Boolean? MultiOtp { get; set; }//;
        
        // Key: reasons Type: connectivity.eligibility.Message[] FullType: connectivity.eligibility.Message[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reasons")]
        public required _connectivity_eligibility.Message[] Reasons { get; set; }//;
        
        // Key: underConditions Type: connectivity.eligibility.Message[] FullType: connectivity.eligibility.Message[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("underConditions")]
        public required _connectivity_eligibility.Message[] UnderConditions { get; set; }//;
    }
    
    // Id: OfferProduct Namespace: connectivity.eligibility
    public class OfferProduct {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public required System.String Code { get; set; }//;
        
        // Key: downloadRate Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("downloadRate")]
        public required System.Double DownloadRate { get; set; }//;
        
        // Key: grt Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grt")]
        public required System.String[] Grt { get; set; }//;
        
        // Key: guaranteed Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("guaranteed")]
        public required System.Boolean Guaranteed { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public required System.String Name { get; set; }//;
        
        // Key: operator Type: connectivity.eligibility.OfferProductProviderEnum FullType: connectivity.eligibility.OfferProductProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operator")]
        public required _connectivity_eligibility.OfferProductProviderEnum @operator { get; set; }//;
        
        // Key: pairs Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pairs")]
        public System.Int64? Pairs { get; set; }//;
        
        // Key: provider Type: connectivity.eligibility.OfferProductProviderEnum FullType: connectivity.eligibility.OfferProductProviderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provider")]
        public required _connectivity_eligibility.OfferProductProviderEnum Provider { get; set; }//;
        
        // Key: type Type: connectivity.eligibility.OfferProductTypeEnum FullType: connectivity.eligibility.OfferProductTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _connectivity_eligibility.OfferProductTypeEnum Type { get; set; }//;
        
        // Key: unbundlingType Type: connectivity.eligibility.OfferProductUnbundlingTypeEnum FullType: connectivity.eligibility.OfferProductUnbundlingTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unbundlingType")]
        public _connectivity_eligibility.OfferProductUnbundlingTypeEnum? UnbundlingType { get; set; }//;
        
        // Key: uploadRate Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uploadRate")]
        public required System.Double UploadRate { get; set; }//;
    }
    
    // Id: OfferProductProviderEnum Namespace: connectivity.eligibility
    public enum OfferProductProviderEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AI")]
        AI,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ALTERNATIVE")]
        ALTERNATIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AX")]
        AX,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AXIONE")]
        AXIONE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BOUYGTEL")]
        BOUYGTEL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BOUYGUES")]
        BOUYGUES,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("COVAGE")]
        COVAGE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FI")]
        FI,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("KOSC")]
        KOSC,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OR")]
        OR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ORANGE")]
        ORANGE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OS")]
        OS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REFERENCE")]
        REFERENCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SFR")]
        SFR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TF")]
        TF,
    }
    
    // Id: OfferProductTypeEnum Namespace: connectivity.eligibility
    public enum OfferProductTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ADSL")]
        ADSL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FTTE")]
        FTTE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FTTH")]
        FTTH,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SDSL")]
        SDSL,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VDSL")]
        VDSL,
    }
    
    // Id: OfferProductUnbundlingTypeEnum Namespace: connectivity.eligibility
    public enum OfferProductUnbundlingTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("full")]
        full,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("partial")]
        @partial,
    }
    
    // Id: Portability Namespace: connectivity.eligibility
    public class Portability {
        
        // Key: eligibility Type: connectivity.eligibility.PortabilityEligibility FullType: connectivity.eligibility.PortabilityEligibility
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eligibility")]
        public required _connectivity_eligibility.PortabilityEligibility Eligibility { get; set; }//;
        
        // Key: quarantineEndDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quarantineEndDate")]
        public System.DateTime? QuarantineEndDate { get; set; }//;
        
        // Key: type Type: connectivity.eligibility.PortabilityTypeEnum FullType: connectivity.eligibility.PortabilityTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _connectivity_eligibility.PortabilityTypeEnum? Type { get; set; }//;
    }
    
    // Id: PortabilityEligibility Namespace: connectivity.eligibility
    public class PortabilityEligibility {
        
        // Key: eligible Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eligible")]
        public required System.Boolean Eligible { get; set; }//;
        
        // Key: reasons Type: connectivity.eligibility.Message[] FullType: connectivity.eligibility.Message[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reasons")]
        public required _connectivity_eligibility.Message[] Reasons { get; set; }//;
        
        // Key: underConditions Type: connectivity.eligibility.Message[] FullType: connectivity.eligibility.Message[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("underConditions")]
        public required _connectivity_eligibility.Message[] UnderConditions { get; set; }//;
    }
    
    // Id: PortabilityTypeEnum Namespace: connectivity.eligibility
    public enum PortabilityTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portin")]
        portin,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portinback")]
        portinback,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portout")]
        portout,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subsequent")]
        subsequent,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subsquentportin")]
        subsquentportin,
    }
    
    // Id: SectionLength Namespace: connectivity.eligibility
    public class SectionLength {
        
        // Key: diameter Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diameter")]
        public required System.Int64 Diameter { get; set; }//;
        
        // Key: length Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("length")]
        public required System.Int64 Length { get; set; }//;
    }
    
    // Id: Street Namespace: connectivity.eligibility
    public class Street {
        
        // Key: streetAltCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetAltCode")]
        public System.String? StreetAltCode { get; set; }//;
        
        // Key: streetCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetCode")]
        public required System.String StreetCode { get; set; }//;
        
        // Key: streetName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("streetName")]
        public required System.String StreetName { get; set; }//;
    }
    
    // Id: StreetNumberDetails Namespace: connectivity.eligibility
    public class StreetNumberDetails {
        
        // Key: hexacle Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hexacle")]
        public System.String? Hexacle { get; set; }//;
        
        // Key: number Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public required System.String Number { get; set; }//;
    }
}
