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
    public class Product : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string uuid;
        private string title;
        private string titleTranslated;
        private string description;
        private string descriptionTranslated;
        private string highlights;
        private string highlightsTranslated;
        private string additionalInfo;
        private string additionalInfoTranslated;
        private string priceIncludes;
        private string priceIncludesTranslated;
        private string priceExcludes;
        private string priceExcludesTranslated;
        private string itinerary;
        private string itineraryTranslated;
        private string warnings;
        private string warningsTranslated;
        private string safety;
        private string safetyTranslated;
        private string latitude;
        private string longitude;
        private int minPax;
        private int maxPax;
        private double basePrice;
        private Currency currency;
        private bool isFlatPaxPrice;
        private int reviewCount;
        private double reviewAverageScore;
        private string typeName;
        private string typeUuid;
        private string photosUrl;
        private string businessHoursFrom;
        private string businessHoursTo;
        private string meetingTime;
        private bool hotelPickup;
        private string meetingLocation;
        private string meetingLocationTranslated;
        private List<Photo> photos;
        private List<Category> categories;
        private List<ProductType> productTypes;
        private List<Addon> addons;
        private List<Location> locations;
        private string url;
        private string staticUrl;
        private List<Language> guideLanguages;
        private List<Language> audioHeadsetLanguages;
        private List<Language> writtenLanguages;

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
        [JsonProperty("highlights")]
        public string Highlights 
        { 
            get 
            {
                return this.highlights; 
            } 
            set 
            {
                this.highlights = value;
                onPropertyChanged("Highlights");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("highlightsTranslated")]
        public string HighlightsTranslated 
        { 
            get 
            {
                return this.highlightsTranslated; 
            } 
            set 
            {
                this.highlightsTranslated = value;
                onPropertyChanged("HighlightsTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo 
        { 
            get 
            {
                return this.additionalInfo; 
            } 
            set 
            {
                this.additionalInfo = value;
                onPropertyChanged("AdditionalInfo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("additionalInfoTranslated")]
        public string AdditionalInfoTranslated 
        { 
            get 
            {
                return this.additionalInfoTranslated; 
            } 
            set 
            {
                this.additionalInfoTranslated = value;
                onPropertyChanged("AdditionalInfoTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("priceIncludes")]
        public string PriceIncludes 
        { 
            get 
            {
                return this.priceIncludes; 
            } 
            set 
            {
                this.priceIncludes = value;
                onPropertyChanged("PriceIncludes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("priceIncludesTranslated")]
        public string PriceIncludesTranslated 
        { 
            get 
            {
                return this.priceIncludesTranslated; 
            } 
            set 
            {
                this.priceIncludesTranslated = value;
                onPropertyChanged("PriceIncludesTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("priceExcludes")]
        public string PriceExcludes 
        { 
            get 
            {
                return this.priceExcludes; 
            } 
            set 
            {
                this.priceExcludes = value;
                onPropertyChanged("PriceExcludes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("priceExcludesTranslated")]
        public string PriceExcludesTranslated 
        { 
            get 
            {
                return this.priceExcludesTranslated; 
            } 
            set 
            {
                this.priceExcludesTranslated = value;
                onPropertyChanged("PriceExcludesTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("itinerary")]
        public string Itinerary 
        { 
            get 
            {
                return this.itinerary; 
            } 
            set 
            {
                this.itinerary = value;
                onPropertyChanged("Itinerary");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("itineraryTranslated")]
        public string ItineraryTranslated 
        { 
            get 
            {
                return this.itineraryTranslated; 
            } 
            set 
            {
                this.itineraryTranslated = value;
                onPropertyChanged("ItineraryTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("warnings")]
        public string Warnings 
        { 
            get 
            {
                return this.warnings; 
            } 
            set 
            {
                this.warnings = value;
                onPropertyChanged("Warnings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("warningsTranslated")]
        public string WarningsTranslated 
        { 
            get 
            {
                return this.warningsTranslated; 
            } 
            set 
            {
                this.warningsTranslated = value;
                onPropertyChanged("WarningsTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("safety")]
        public string Safety 
        { 
            get 
            {
                return this.safety; 
            } 
            set 
            {
                this.safety = value;
                onPropertyChanged("Safety");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("safetyTranslated")]
        public string SafetyTranslated 
        { 
            get 
            {
                return this.safetyTranslated; 
            } 
            set 
            {
                this.safetyTranslated = value;
                onPropertyChanged("SafetyTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude 
        { 
            get 
            {
                return this.latitude; 
            } 
            set 
            {
                this.latitude = value;
                onPropertyChanged("Latitude");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude 
        { 
            get 
            {
                return this.longitude; 
            } 
            set 
            {
                this.longitude = value;
                onPropertyChanged("Longitude");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minPax")]
        public int MinPax 
        { 
            get 
            {
                return this.minPax; 
            } 
            set 
            {
                this.minPax = value;
                onPropertyChanged("MinPax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("maxPax")]
        public int MaxPax 
        { 
            get 
            {
                return this.maxPax; 
            } 
            set 
            {
                this.maxPax = value;
                onPropertyChanged("MaxPax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("basePrice")]
        public double BasePrice 
        { 
            get 
            {
                return this.basePrice; 
            } 
            set 
            {
                this.basePrice = value;
                onPropertyChanged("BasePrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency")]
        public Currency Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("isFlatPaxPrice")]
        public bool IsFlatPaxPrice 
        { 
            get 
            {
                return this.isFlatPaxPrice; 
            } 
            set 
            {
                this.isFlatPaxPrice = value;
                onPropertyChanged("IsFlatPaxPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("reviewCount")]
        public int ReviewCount 
        { 
            get 
            {
                return this.reviewCount; 
            } 
            set 
            {
                this.reviewCount = value;
                onPropertyChanged("ReviewCount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("reviewAverageScore")]
        public double ReviewAverageScore 
        { 
            get 
            {
                return this.reviewAverageScore; 
            } 
            set 
            {
                this.reviewAverageScore = value;
                onPropertyChanged("ReviewAverageScore");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("typeName")]
        public string TypeName 
        { 
            get 
            {
                return this.typeName; 
            } 
            set 
            {
                this.typeName = value;
                onPropertyChanged("TypeName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("typeUuid")]
        public string TypeUuid 
        { 
            get 
            {
                return this.typeUuid; 
            } 
            set 
            {
                this.typeUuid = value;
                onPropertyChanged("TypeUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("photosUrl")]
        public string PhotosUrl 
        { 
            get 
            {
                return this.photosUrl; 
            } 
            set 
            {
                this.photosUrl = value;
                onPropertyChanged("PhotosUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("businessHoursFrom")]
        public string BusinessHoursFrom 
        { 
            get 
            {
                return this.businessHoursFrom; 
            } 
            set 
            {
                this.businessHoursFrom = value;
                onPropertyChanged("BusinessHoursFrom");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("businessHoursTo")]
        public string BusinessHoursTo 
        { 
            get 
            {
                return this.businessHoursTo; 
            } 
            set 
            {
                this.businessHoursTo = value;
                onPropertyChanged("BusinessHoursTo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("meetingTime")]
        public string MeetingTime 
        { 
            get 
            {
                return this.meetingTime; 
            } 
            set 
            {
                this.meetingTime = value;
                onPropertyChanged("MeetingTime");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hotelPickup")]
        public bool HotelPickup 
        { 
            get 
            {
                return this.hotelPickup; 
            } 
            set 
            {
                this.hotelPickup = value;
                onPropertyChanged("HotelPickup");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("meetingLocation")]
        public string MeetingLocation 
        { 
            get 
            {
                return this.meetingLocation; 
            } 
            set 
            {
                this.meetingLocation = value;
                onPropertyChanged("MeetingLocation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("meetingLocationTranslated")]
        public string MeetingLocationTranslated 
        { 
            get 
            {
                return this.meetingLocationTranslated; 
            } 
            set 
            {
                this.meetingLocationTranslated = value;
                onPropertyChanged("MeetingLocationTranslated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("photos")]
        public List<Photo> Photos 
        { 
            get 
            {
                return this.photos; 
            } 
            set 
            {
                this.photos = value;
                onPropertyChanged("Photos");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("categories")]
        public List<Category> Categories 
        { 
            get 
            {
                return this.categories; 
            } 
            set 
            {
                this.categories = value;
                onPropertyChanged("Categories");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("productTypes")]
        public List<ProductType> ProductTypes 
        { 
            get 
            {
                return this.productTypes; 
            } 
            set 
            {
                this.productTypes = value;
                onPropertyChanged("ProductTypes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("addons")]
        public List<Addon> Addons 
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
        [JsonProperty("locations")]
        public List<Location> Locations 
        { 
            get 
            {
                return this.locations; 
            } 
            set 
            {
                this.locations = value;
                onPropertyChanged("Locations");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("staticUrl")]
        public string StaticUrl 
        { 
            get 
            {
                return this.staticUrl; 
            } 
            set 
            {
                this.staticUrl = value;
                onPropertyChanged("StaticUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("guideLanguages")]
        public List<Language> GuideLanguages 
        { 
            get 
            {
                return this.guideLanguages; 
            } 
            set 
            {
                this.guideLanguages = value;
                onPropertyChanged("GuideLanguages");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("audioHeadsetLanguages")]
        public List<Language> AudioHeadsetLanguages 
        { 
            get 
            {
                return this.audioHeadsetLanguages; 
            } 
            set 
            {
                this.audioHeadsetLanguages = value;
                onPropertyChanged("AudioHeadsetLanguages");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("writtenLanguages")]
        public List<Language> WrittenLanguages 
        { 
            get 
            {
                return this.writtenLanguages; 
            } 
            set 
            {
                this.writtenLanguages = value;
                onPropertyChanged("WrittenLanguages");
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