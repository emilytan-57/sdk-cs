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
    public class CancellationPolicy : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int numberOfDays;
        private int refundPercentage;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("numberOfDays")]
        public int NumberOfDays 
        { 
            get 
            {
                return this.numberOfDays; 
            } 
            set 
            {
                this.numberOfDays = value;
                onPropertyChanged("NumberOfDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("refundPercentage")]
        public int RefundPercentage 
        { 
            get 
            {
                return this.refundPercentage; 
            } 
            set 
            {
                this.refundPercentage = value;
                onPropertyChanged("RefundPercentage");
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