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
    public enum PromotionTypeEnum
    {
        early_booking, //TODO: Write general description for this method
        last_minute, //TODO: Write general description for this method
        discount, //TODO: Write general description for this method
    }
} 