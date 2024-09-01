//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
namespace _support {
    
    
    // Id: NewMessageInfo Namespace: support
    public class NewMessageInfo {
        
        // Key: additionalNotice Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("additionalNotice")]
        public System.String? AdditionalNotice { get; set; }//;
        
        // Key: messageId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("messageId")]
        public required System.Int64 MessageId { get; set; }//;
        
        // Key: ticketId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ticketId")]
        public required System.Int64 TicketId { get; set; }//;
        
        // Key: ticketNumber Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ticketNumber")]
        public required System.Int64 TicketNumber { get; set; }//;
    }
    
    // Id: Message Namespace: support
    public class Message {
        
        // Key: body Type: text FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("body")]
        public required System.String Body { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: from Type: support.MessageSenderEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("from")]
        public required _support.MessageSenderEnum From { get; set; }//;
        
        // Key: messageId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("messageId")]
        public required System.Int64 MessageId { get; set; }//;
        
        // Key: ticketId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ticketId")]
        public required System.Int64 TicketId { get; set; }//;
        
        // Key: updateDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updateDate")]
        public required System.DateTime UpdateDate { get; set; }//;
    }
    
    // Id: MessageSenderEnum Namespace: support
    public enum MessageSenderEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customer")]
        customer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("support")]
        support,
    }
    
    // Id: Ticket Namespace: support
    public class Ticket {
        
        // Key: accountId Type: coreTypes.AccountId:string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accountId")]
        public required System.String AccountId { get; set; }//;
        
        // Key: canBeClosed Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("canBeClosed")]
        public required System.Boolean CanBeClosed { get; set; }//;
        
        // Key: category Type: support.TicketCategoryEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("category")]
        public _support.TicketCategoryEnum? Category { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public required System.DateTime CreationDate { get; set; }//;
        
        // Key: lastMessageFrom Type: support.MessageSenderEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastMessageFrom")]
        public required _support.MessageSenderEnum LastMessageFrom { get; set; }//;
        
        // Key: product Type: support.TicketProductEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("product")]
        public _support.TicketProductEnum? Product { get; set; }//;
        
        // Key: score Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("score")]
        public required System.String Score { get; set; }//;
        
        // Key: serviceName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public System.String? ServiceName { get; set; }//;
        
        // Key: state Type: support.TicketStatusEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public required _support.TicketStatusEnum State { get; set; }//;
        
        // Key: subject Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subject")]
        public required System.String Subject { get; set; }//;
        
        // Key: ticketId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ticketId")]
        public required System.Int64 TicketId { get; set; }//;
        
        // Key: ticketNumber Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ticketNumber")]
        public required System.Int64 TicketNumber { get; set; }//;
        
        // Key: type Type: support.TicketTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public required _support.TicketTypeEnum Type { get; set; }//;
        
        // Key: updateDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updateDate")]
        public required System.DateTime UpdateDate { get; set; }//;
    }
    
    // Id: TicketCategoryEnum Namespace: support
    public enum TicketCategoryEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("assistance")]
        assistance,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billing")]
        billing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incident")]
        incident,
    }
    
    // Id: TicketImpactUrgencyEnum Namespace: support
    public enum TicketImpactUrgencyEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("high")]
        high,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("low")]
        low,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("medium")]
        medium,
    }
    
    // Id: TicketProductEnum Namespace: support
    public enum TicketProductEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adsl")]
        adsl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn")]
        cdn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicated")]
        dedicated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicated-billing")]
        dedicated_billing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicated-other")]
        dedicated_other,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedcloud")]
        dedicatedcloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        domain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exchange")]
        exchange,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fax")]
        fax,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting")]
        hosting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("housing")]
        housing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iaas")]
        iaas,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mail")]
        mail,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
        network,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("publiccloud")]
        publiccloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sms")]
        sms,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssl")]
        ssl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        storage,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("telecom-billing")]
        telecom_billing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("telecom-other")]
        telecom_other,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vac")]
        vac,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voip")]
        voip,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vps")]
        vps,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web-billing")]
        web_billing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web-other")]
        web_other,
    }
    
    // Id: TicketStatusEnum Namespace: support
    public enum TicketStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("closed")]
        closed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("open")]
        open,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unknown")]
        unknown,
    }
    
    // Id: TicketSubCategoryEnum Namespace: support
    public enum TicketSubCategoryEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("alerts")]
        alerts,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autorenew")]
        autorenew,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bill")]
        bill,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("down")]
        down,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inProgress")]
        inProgress,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("new")]
        @new,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("other")]
        other,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("perfs")]
        perfs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start")]
        start,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usage")]
        usage,
    }
    
    // Id: TicketTypeEnum Namespace: support
    public enum TicketTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("criticalIntervention")]
        criticalIntervention,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("genericRequest")]
        genericRequest,
    }
}
