//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _xdsl_orderFollowup {
    
    
    // Id: DurationUnitEnum Namespace: xdsl.orderFollowup
    public enum DurationUnitEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("day")]
        day,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hour")]
        hour,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minute")]
        minute,
    }
    
    // Id: Step Namespace: xdsl.orderFollowup
    public class Step {
        
        // Key: comments Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("comments")]
        public string[] Comments { get; set; }//;
        
        // Key: doneDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doneDate")]
        public System.DateTime? DoneDate { get; set; }//;
        
        // Key: durationUnit Type: xdsl.orderFollowup.DurationUnitEnum FullType: xdsl.orderFollowup.DurationUnitEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("durationUnit")]
        public _xdsl_orderFollowup.DurationUnitEnum DurationUnit { get; set; }//;
        
        // Key: expectedDuration Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expectedDuration")]
        public long ExpectedDuration { get; set; }//;
        
        // Key: name Type: xdsl.orderFollowup.StepNameEnum FullType: xdsl.orderFollowup.StepNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public _xdsl_orderFollowup.StepNameEnum Name { get; set; }//;
        
        // Key: status Type: xdsl.orderFollowup.StepStatusEnum FullType: xdsl.orderFollowup.StepStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _xdsl_orderFollowup.StepStatusEnum Status { get; set; }//;
    }
    
    // Id: StepNameEnum Namespace: xdsl.orderFollowup
    public enum StepNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accessIsOperational")]
        accessIsOperational,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkInfrastructure")]
        checkInfrastructure,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configureAccessOnOVH")]
        configureAccessOnOVH,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderPayed")]
        orderPayed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderReceived")]
        orderReceived,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderTreatment")]
        orderTreatment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sendModem")]
        sendModem,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sendOrderToProvider")]
        sendOrderToProvider,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("setupCustomerPremisesEquipment")]
        setupCustomerPremisesEquipment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingForProviderInstallReport")]
        waitingForProviderInstallReport,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingForWithdrawalPeriodToBeOver")]
        waitingForWithdrawalPeriodToBeOver,
    }
    
    // Id: StepStatusEnum Namespace: xdsl.orderFollowup
    public enum StepStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waitingCustomer")]
        waitingCustomer,
    }
}
