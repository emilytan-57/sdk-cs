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
    public class Price : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private PriceSet regular;
        private Promotion promotion;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("regular")]
        public PriceSet Regular 
        { 
            get 
            {
                return this.regular; 
            } 
            set 
            {
                this.regular = value;
                onPropertyChanged("Regular");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("promotion")]
        public Promotion Promotion 
        { 
            get 
            {
                return this.promotion; 
            } 
            set 
            {
                this.promotion = value;
                onPropertyChanged("Promotion");
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