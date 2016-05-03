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
    public class Addon : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string uuid;
        private string title;
        private string titleTranslated;
        private string description;
        private string descriptionTranslated;
        private double pricePerPerson;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid 
        { 
            get 
            {
                return this.uuid; 
            } 
            set 
            {
                this.uuid = value;
                onPropertyChanged("Uuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("titleTranslated")]
        public string TitleTranslated 
        { 
            get 
            {
                return this.titleTranslated; 
            } 
            set 
            {
                this.titleTranslated = value;
                onPropertyChanged("TitleTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("descriptionTranslated")]
        public string DescriptionTranslated 
        { 
            get 
            {
                return this.descriptionTranslated; 
            } 
            set 
            {
                this.descriptionTranslated = value;
                onPropertyChanged("DescriptionTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pricePerPerson")]
        public double PricePerPerson 
        { 
            get 
            {
                return this.pricePerPerson; 
            } 
            set 
            {
                this.pricePerPerson = value;
                onPropertyChanged("PricePerPerson");
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