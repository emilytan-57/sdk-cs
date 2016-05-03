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
    public class ProductType : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string uuid;
        private string title;
        private string titleTranslated;
        private string description;
        private string descriptionTranslated;
        private int durationDays;
        private int durationHours;
        private int durationMinutes;
        private int paxMin;
        private int paxMax;
        private int daysInAdvance;
        private bool isNonRefundable;
        private bool hasChildPrice;
        private int minAdultAge;
        private int maxAdultAge;
        private bool allowChildren;
        private string minChildAge;
        private string maxChildAge;
        private bool instantConfirmation;
        private string voucherUse;
        private string voucherUseTranslated;
        private string voucherRedemptionAddress;
        private string voucherRedemptionAddressTranslated;
        private double recommendedMarkup;
        private dynamic prices;
        private List<TimeSlot> timeSlots;

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
        [JsonProperty("durationDays")]
        public int DurationDays 
        { 
            get 
            {
                return this.durationDays; 
            } 
            set 
            {
                this.durationDays = value;
                onPropertyChanged("DurationDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("durationHours")]
        public int DurationHours 
        { 
            get 
            {
                return this.durationHours; 
            } 
            set 
            {
                this.durationHours = value;
                onPropertyChanged("DurationHours");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("durationMinutes")]
        public int DurationMinutes 
        { 
            get 
            {
                return this.durationMinutes; 
            } 
            set 
            {
                this.durationMinutes = value;
                onPropertyChanged("DurationMinutes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paxMin")]
        public int PaxMin 
        { 
            get 
            {
                return this.paxMin; 
            } 
            set 
            {
                this.paxMin = value;
                onPropertyChanged("PaxMin");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paxMax")]
        public int PaxMax 
        { 
            get 
            {
                return this.paxMax; 
            } 
            set 
            {
                this.paxMax = value;
                onPropertyChanged("PaxMax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("daysInAdvance")]
        public int DaysInAdvance 
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
        [JsonProperty("isNonRefundable")]
        public bool IsNonRefundable 
        { 
            get 
            {
                return this.isNonRefundable; 
            } 
            set 
            {
                this.isNonRefundable = value;
                onPropertyChanged("IsNonRefundable");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hasChildPrice")]
        public bool HasChildPrice 
        { 
            get 
            {
                return this.hasChildPrice; 
            } 
            set 
            {
                this.hasChildPrice = value;
                onPropertyChanged("HasChildPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minAdultAge")]
        public int MinAdultAge 
        { 
            get 
            {
                return this.minAdultAge; 
            } 
            set 
            {
                this.minAdultAge = value;
                onPropertyChanged("MinAdultAge");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("maxAdultAge")]
        public int MaxAdultAge 
        { 
            get 
            {
                return this.maxAdultAge; 
            } 
            set 
            {
                this.maxAdultAge = value;
                onPropertyChanged("MaxAdultAge");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("allowChildren")]
        public bool AllowChildren 
        { 
            get 
            {
                return this.allowChildren; 
            } 
            set 
            {
                this.allowChildren = value;
                onPropertyChanged("AllowChildren");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minChildAge")]
        public string MinChildAge 
        { 
            get 
            {
                return this.minChildAge; 
            } 
            set 
            {
                this.minChildAge = value;
                onPropertyChanged("MinChildAge");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("maxChildAge")]
        public string MaxChildAge 
        { 
            get 
            {
                return this.maxChildAge; 
            } 
            set 
            {
                this.maxChildAge = value;
                onPropertyChanged("MaxChildAge");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("instantConfirmation")]
        public bool InstantConfirmation 
        { 
            get 
            {
                return this.instantConfirmation; 
            } 
            set 
            {
                this.instantConfirmation = value;
                onPropertyChanged("InstantConfirmation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("voucherUse")]
        public string VoucherUse 
        { 
            get 
            {
                return this.voucherUse; 
            } 
            set 
            {
                this.voucherUse = value;
                onPropertyChanged("VoucherUse");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("voucherUseTranslated")]
        public string VoucherUseTranslated 
        { 
            get 
            {
                return this.voucherUseTranslated; 
            } 
            set 
            {
                this.voucherUseTranslated = value;
                onPropertyChanged("VoucherUseTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("voucherRedemptionAddress")]
        public string VoucherRedemptionAddress 
        { 
            get 
            {
                return this.voucherRedemptionAddress; 
            } 
            set 
            {
                this.voucherRedemptionAddress = value;
                onPropertyChanged("VoucherRedemptionAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("voucherRedemptionAddressTranslated")]
        public string VoucherRedemptionAddressTranslated 
        { 
            get 
            {
                return this.voucherRedemptionAddressTranslated; 
            } 
            set 
            {
                this.voucherRedemptionAddressTranslated = value;
                onPropertyChanged("VoucherRedemptionAddressTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("recommendedMarkup")]
        public double RecommendedMarkup 
        { 
            get 
            {
                return this.recommendedMarkup; 
            } 
            set 
            {
                this.recommendedMarkup = value;
                onPropertyChanged("RecommendedMarkup");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("prices")]
        public dynamic Prices 
        { 
            get 
            {
                return this.prices; 
            } 
            set 
            {
                this.prices = value;
                onPropertyChanged("Prices");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("timeSlots")]
        public List<TimeSlot> TimeSlots 
        { 
            get 
            {
                return this.timeSlots; 
            } 
            set 
            {
                this.timeSlots = value;
                onPropertyChanged("TimeSlots");
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