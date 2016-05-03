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
    public class CreateABookingRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string salutation;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string message;
        private string productTypeUuid;
        private int pax;
        private int children;
        private string timeSlotUuid;
        private List<dynamic> addons;
        private string arrivalDate;
        private string partnerReference;
        private bool usePromotion;

        /// <summary>
        /// One of Mr.|Ms.|Mrs.
        /// </summary>
        [JsonProperty("salutation")]
        public string Salutation 
        { 
            get 
            {
                return this.salutation; 
            } 
            set 
            {
                this.salutation = value;
                onPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Guest's first name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Guest's last name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Guest's email address
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Guest's phone number
        /// </summary>
        [JsonProperty("phone")]
        public string Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Message to the host
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// UUID of the ProductType
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
        /// Number of adults
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
        /// Number of children
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
        /// Selected timeslot. If the product has timeslots, the "timeslotUUID" of the product is REQUIRED in "Check a Booking" and "Create a new booking" methods. Otherwise, it can be excluded
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
        /// Add-ons for product (array of uuid/quantity values)
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
        /// Arrival date in YYYY-MM-DD format
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
        /// Maximum 36 characters partner reference code or number
        /// </summary>
        [JsonProperty("partnerReference")]
        public string PartnerReference 
        { 
            get 
            {
                return this.partnerReference; 
            } 
            set 
            {
                this.partnerReference = value;
                onPropertyChanged("PartnerReference");
            }
        }

        /// <summary>
        /// f API should check price against "promotion" and not "regular" , default is set to "false"
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