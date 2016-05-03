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
    public class PhotoPaths : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string original;
        private string m75x50;
        private string m175x112;
        private string m680x325;
        private string m1280x720;
        private string m1920x1080;
        private string m2048x1536;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("original")]
        public string Original 
        { 
            get 
            {
                return this.original; 
            } 
            set 
            {
                this.original = value;
                onPropertyChanged("Original");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("75x50")]
        public string M75x50 
        { 
            get 
            {
                return this.m75x50; 
            } 
            set 
            {
                this.m75x50 = value;
                onPropertyChanged("M75x50");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("175x112")]
        public string M175x112 
        { 
            get 
            {
                return this.m175x112; 
            } 
            set 
            {
                this.m175x112 = value;
                onPropertyChanged("M175x112");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("680x325")]
        public string M680x325 
        { 
            get 
            {
                return this.m680x325; 
            } 
            set 
            {
                this.m680x325 = value;
                onPropertyChanged("M680x325");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("1280x720")]
        public string M1280x720 
        { 
            get 
            {
                return this.m1280x720; 
            } 
            set 
            {
                this.m1280x720 = value;
                onPropertyChanged("M1280x720");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("1920x1080")]
        public string M1920x1080 
        { 
            get 
            {
                return this.m1920x1080; 
            } 
            set 
            {
                this.m1920x1080 = value;
                onPropertyChanged("M1920x1080");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("2048x1536")]
        public string M2048x1536 
        { 
            get 
            {
                return this.m2048x1536; 
            } 
            set 
            {
                this.m2048x1536 = value;
                onPropertyChanged("M2048x1536");
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