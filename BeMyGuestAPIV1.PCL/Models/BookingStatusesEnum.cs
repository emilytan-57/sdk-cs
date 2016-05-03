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
    public enum BookingStatusesEnum
    {
        reserved, //TODO: Write general description for this method
        waiting, //TODO: Write general description for this method
        cancelled, //TODO: Write general description for this method
        approved, //TODO: Write general description for this method
        expired, //TODO: Write general description for this method
        rejected, //TODO: Write general description for this method
        released, //TODO: Write general description for this method
        refunded, //TODO: Write general description for this method
    }
} 