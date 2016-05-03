/*
 * BeMyGuestAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 on 05/03/2016
 */
 using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
		
namespace BeMyGuestAPIV1.PCL.Models
{
    [JsonConverter(typeof(StringEnumConverter))]		
    public enum BookingStatusEnum
    {
        confirm, //Confirms given booking
        cancel, //Cancels given booking
        resend, //If confirmationEmailSentAt value is not null then copy of the confirmation email sent to partner will be sent again and the timestamp value of this field will be updated
    }
} 