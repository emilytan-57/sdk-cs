/*
 * BeMyGuestAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 on 05/03/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BeMyGuestAPIV1.PCL;

namespace BeMyGuestAPIV1.PCL.Models
{
    public class GetBookingsResponse : BaseResponse 
    {
        // These fields hold the values for the public properties.
        private dynamic meta;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("meta")]
        public dynamic Meta 
        { 
            get 
            {
                return this.meta; 
            } 
            set 
            {
                this.meta = value;
                onPropertyChanged("Meta");
            }
        }
    }
} 