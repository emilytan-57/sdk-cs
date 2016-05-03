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
using Newtonsoft.Json.Converters;
using BeMyGuestAPIV1.PCL;

namespace BeMyGuestAPIV1.PCL.Models
{
    public class Promotion : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private PromotionTypeEnum type;
        private int? daysInAdvance;
        private int? hoursInAdvance;
        private string name;
        private dynamic adult;
        private int child;
        private int discountPercent;
        private List<CancellationPolicy> cancellationPolicy;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public PromotionTypeEnum Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("daysInAdvance")]
        public int? DaysInAdvance 
        { 
            get 
            {
                return this.daysInAdvance; 
            } 
            set 
            {
                this.daysInAdvance = value;
                onPropertyChanged("DaysInAdvance");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hoursInAdvance")]
        public int? HoursInAdvance 
        { 
            get 
            {
                return this.hoursInAdvance; 
            } 
            set 
            {
                this.hoursInAdvance = value;
                onPropertyChanged("HoursInAdvance");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("adult")]
        public dynamic Adult 
        { 
            get 
            {
                return this.adult; 
            } 
            set 
            {
                this.adult = value;
                onPropertyChanged("Adult");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("child")]
        public int Child 
        { 
            get 
            {
                return this.child; 
            } 
            set 
            {
                this.child = value;
                onPropertyChanged("Child");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("discountPercent")]
        public int DiscountPercent 
        { 
            get 
            {
                return this.discountPercent; 
            } 
            set 
            {
                this.discountPercent = value;
                onPropertyChanged("DiscountPercent");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cancellationPolicy")]
        public List<CancellationPolicy> CancellationPolicy 
        { 
            get 
            {
                return this.cancellationPolicy; 
            } 
            set 
            {
                this.cancellationPolicy = value;
                onPropertyChanged("CancellationPolicy");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 