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
    public class CheckABookingRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string productTypeUuid;
        private int pax;
        private int children;
        private string timeSlotUuid;
        private List<dynamic> addons;
        private string arrivalDate;
        private bool usePromotion;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("productTypeUuid")]
        public string ProductTypeUuid 
        { 
            get 
            {
                return this.productTypeUuid; 
            } 
            set 
            {
                this.productTypeUuid = value;
                onPropertyChanged("ProductTypeUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pax")]
        public int Pax 
        { 
            get 
            {
                return this.pax; 
            } 
            set 
            {
                this.pax = value;
                onPropertyChanged("Pax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("children")]
        public int Children 
        { 
            get 
            {
                return this.children; 
            } 
            set 
            {
                this.children = value;
                onPropertyChanged("Children");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("timeSlotUuid")]
        public string TimeSlotUuid 
        { 
            get 
            {
                return this.timeSlotUuid; 
            } 
            set 
            {
                this.timeSlotUuid = value;
                onPropertyChanged("TimeSlotUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("addons")]
        public List<dynamic> Addons 
        { 
            get 
            {
                return this.addons; 
            } 
            set 
            {
                this.addons = value;
                onPropertyChanged("Addons");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("arrivalDate")]
        public string ArrivalDate 
        { 
            get 
            {
                return this.arrivalDate; 
            } 
            set 
            {
                this.arrivalDate = value;
                onPropertyChanged("ArrivalDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("usePromotion")]
        public bool UsePromotion 
        { 
            get 
            {
                return this.usePromotion; 
            } 
            set 
            {
                this.usePromotion = value;
                onPropertyChanged("UsePromotion");
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