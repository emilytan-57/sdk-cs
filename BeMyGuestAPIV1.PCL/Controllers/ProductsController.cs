/*
 * BeMyGuestAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 on 05/03/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeMyGuestAPIV1.PCL;
using BeMyGuestAPIV1.PCL.Http.Request;
using BeMyGuestAPIV1.PCL.Http.Response;
using BeMyGuestAPIV1.PCL.Http.Client;
using BeMyGuestAPIV1.PCL.Models;

namespace BeMyGuestAPIV1.PCL.Controllers
{
    public partial class ProductsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ProductsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ProductsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ProductsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get information about product using its UUID as parameter.###Response+ `uuid` - UUID of product+ `published` - true / false+ `title` - Title of product. Everytime on English+ `titleTranslated` - Title of product on requested language+ `description` - Description of product. Everytime on English+ `descriptionTranslated` - Description of product on requested language+ `highlights` - Highlights of product. Everytime on English+ `highlightsTranslated` - Highlights of product on requested language+ `additionalInfo` - Additional information of product. Everytime on English+ `additionalInfoTranslated` - Additional information of product on requested language+ `priceIncludes` - What's included in product price+ `priceIncludesTranslated` - Translated version of `priceIncludes`+ `itinerary` - Activity itinerary - only applicable for Package type, will be `NULL` for others+ `itineraryTranslated` - translated version of itinerary+ `warnings` - Warnings of the activity (related to safety and insurance)+ `warningsTranslated` - translated version of warnings+ `safety` - activity safety information+ `safetyTranslated` - translated version of safety information+ `latitude` - Latitude+ `longitude` - Longitude+ `minPax` - Minimum number of pax+ `maxPax` - Maximum number of pax+ `basePrice` - Base price of product (for list only)+ `currency` - Currency+ `isFlatPaxPrice` - `true/false` (An indication to tell if the `Product` has the same price for each pax in all of its `productTypes`)+ `reviewCount` - Number of reviews+ `reviewAverageScore` - Average score+ `typeName` - Type of product+ `typeUuid` - Type UUID+ `businessHoursFrom` - supplier business hours `from`+ `businessHoursTo` - supplier business hours `to`+ `meetingTime` - meeting time+ `hotelPickup` - false+ `meetingLocation` - instructions about meeting location with supplier+ `meetingLocationTranslated` - translated version of meeting location+ `photosUrl` - Base URL for images+ `photos` - Array of photos in different dimensions (Sizes: original, 75x50, 175x112, 680x325)+ `categories` - Array of categories+ `productTypes`    + `uuid` - UUID of Product Type    + `title` - Title of Product Type    + `titleTranslated` - Translated version of title    + `description` - Description of Product Type    + `descriptionTranslated` - translated version of description    + `durationDays` - duration in days    + `durationHours` - duration in hours    + `durationMinutes` - duration in  minutes    + `paxMin` - Minimum number of people    + `paxMax` - Maximum number of people    + `daysInAdvance` - how many days in advance booking can be made    + `isNonRefundable` - True if product not refundable    + `hasChildPrice` - Does product has child price    + `minAdultAge` - The minimum age allowed for an adult    + `maxAdultAge` - The maximum age allowed for an adult    + `allowChildren` - Is a child allowed for this product    + `minChildAge` - The minimum age allowed for a child    + `maxChildAge` - The maximum age allowed for a child    + `instantConfirmation` - if it's TRUE then booking this product should return new Booking status = `approved`, but if we're out of stock of e-tickets it can still return `waiting`     + `voucherUse` - instruction on how to use the voucher (Using what? Go to what palce? To redeem with who?)    + `voucherUseTranslated` - translated version of how to use voucher    + `voucherRedemptionAddress` - Voucher redemption address IF client needs to redeem a voucher.     + `voucherRedemptionAddressTranslated` - translated version of `voucherRedemptionAddress`    + `recommendedMarkup` - Apply this markup if you want to match with BMG's website prices    + `prices` - List of prices for Product Type for one month. The prices array consist of price for adults depending of number of adults and price for child.    + `timeSlots` - Available timeslots for product, might be `null`. If the `ProductType` has timeslots, the `timeslotUUID` of the product is REQUIRED in `Check a Booking` and `Create a new booking` methods.+ `addons` - Add-ons for product+ `locations` - Information about product location+ `url` - URL of product + `staticUrl` - Static URL of product+ `guideLanguages` - Available languages speak by tour guide.+ `audioHeadsetLanguages` - Available languages for Audio Headset material.+ `writtenLanguages` - Available written languages for reading material.If product has been deleted from BeMyGuest database response will be:        {          "error": {            "code": "GEN-GONE",            "http_code": 410,            "message": "Resource No Longer Available"          }        }### Promotional pricesExample of promotion data block:        "promotion": {              "type": "early_booking",              "daysInAdvance": 30,              "hoursInAdvance": null,              "name": "Early Bird",              "adult": {                "2": 93.45              },              "child": 0,              "discountPercent": 30,              "cancellationPolicy": []        }- If product type has promotional prices for selected date only one promotion (with best price) will be visible in API.- there are 3 types of promotions (`type` parameter) : `early_booking`, `last_minute` and `discount`- `early_booking` will have value for `daysInAdvance` parameter provided (`hoursInAdvance` will be `NULL`)- `last_minute` will have value for `hoursInAdvance` provided (`daysInAdvance` will be `NULL`)- `discount` type will have both `daysInAdvance` and `hoursInAdvance` set to `NULL`
        /// </summary>
        /// <param name="uuid">Required parameter: UUID of product</param>
        /// <param name="currency">Optional parameter: currency UUID, also currency code may be provided in exchange</param>
        /// <param name="dateEnd">Optional parameter: product's prices end date, format YYYY-MM-DD</param>
        /// <param name="dateStart">Optional parameter: product's prices start date, format YYYY-MM-DD</param>
        /// <param name="language">Optional parameter: language UUID, also language code may be provided</param>
        /// <return>Returns the GETProductResponse response from the API call</return>
        public async Task<GETProductResponse> GetProductAsync(
                string uuid,
                string currency = null,
                string dateEnd = null,
                string dateStart = null,
                string language = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/products/{uuid}/");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "uuid", uuid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "currency", currency },
                { "date_end", dateEnd },
                { "date_start", dateStart },
                { "language", language }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.SDK.v1" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 410)
                throw new APIException(@"Resource No Longer Available", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<GETProductResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// ###ResponseA response object has the following attributes:  + `uuid` - UUID of product+ `published` - true / false,+ `title` - Title of product. Always on English+ `titleTranslated` - Title of product on requested language+ `description` - Description of product. Always on English+ `descriptionTranslated` - Description of product on requested language+ `highlights` - Highlights of product. Always on English+ `highlightsTranslated` - Highlights of product on requested language+ `additionalInfo` - Additional information of product. Always on English+ `additionalInfoTranslated` - Additional information of product on requested language+ `priceIncludes` - What's included in product price+ `priceIncludesTranslated` - Translated version of `priceIncludes`+ `itinerary` - Activity itinerary - only applicable for Package type, will be `NULL` for others+ `itineraryTranslated` - translated version of itinerary+ `warnings` - Warnings of the activity (related to safety and insurance)+ `warningsTranslated` - translated version of warnings+ `safety` - activity safety information+ `safetyTranslated` - translated version of safety information+ `latitude` - Latitude+ `longitude` - Longitude+ `minPax` - Minimum number of pax+ `maxPax` - Maximum number of pax+ `basePrice` - Base price of product (for list only)+ `currency` - Currency+ `isFlatPaxPrice` - `true/false` (An indication to tell if the `Product` has the same price for each pax in all of its `productTypes` for the selected date. )+ `reviewCount` - Number of reviews+ `reviewAverageScore` - Average score+ `typeName` - Type of product+ `typeUuid` - Type UUID+ `businessHoursFrom` - supplier business hours `from`+ `businessHoursTo` - supplier business hours `to`+ `meetingTime` - meeting time+ `hotelPickup` - `true/false` + `meetingLocation` - instructions about meeting location with supplier+ `meetingLocationTranslated` - translated version of meeting location+ `photosUrl` - Base URL for images+ `photos` - Array of photos in different dimensions (Sizes: original, 75x50, 175x112, 680x325)+ `categories` - Array of categories+ `locations` - Information about product location+ `url` - URL of product If you requested only unpublished (`published` = `false`) products then the list will be simplified.Each element will consist only of these attributes:        {          "data": [            {                "uuid":"b03ce312-742f-5256-bfe2-014daf1c8d01",                "published":false,                "title":"Everest BaseCamp Trek - 16 Days",                "titleTranslated":null            },            {                "uuid":"d70fb77c-3e97-591e-b876-d638a643c41b",                "published":false,                "title":"Half day rock climbing, Ha Long Bay, Vietnam",                "titleTranslated":null            }            [...]        }If you requested only deleted (`deleted` = `false`) products then the list will be simplified.In this case `published` parameter will be ignored.This parameter exists to help partners to synchronize its cached products database.Each element will consist only of these attributes:        {          "data": [            {                "uuid":"b03ce312-742f-5256-bfe2-014daf1c8d01",                "deletedAt":"2015-06-01 14:28:37",                "title":"Everest BaseCamp Trek - 16 Days",                "titleTranslated":null            },            {                "uuid":"d70fb77c-3e97-591e-b876-d638a643c41b",                "published":"deletedAt":"2015-06-01 14:28:37",                "title":"Half day rock climbing, Ha Long Bay, Vietnam",                "titleTranslated":null            }            [...]        }###RequestA request can take these parameters:+ `type`: `b90bd912-3e92-52e6-8abb-c2722cf947db` (optional, string) - UUID of type of product+ `country`: `ebbfac98-5f89-5106-9c4e-9e5dfd485231` (optional, string) - UUID of country+ `city`: `f67e3919-036d-11e5-a2a9-d07e352b4840` (optional, string) - UUID of city - it will always overwrite (nullify) country parameter if provided+ `price_min`: 25.00 (optional, decimal) - minimal price in decimal format 000.00 - it's compared to base price+ `price_max`: 100.00 (optional, decimal) - max price in decimal format 000.00+ `category`: `5a6495b5-9a58-5257-93db-902ca3cf8b40` (optional, string) - UUID of litsing category+ `pax`: `2` (optional, integer) - number of guests+ `currency`: `79efbd4e-3648-5204-8f35-a0e51661a4c7` (optional, string) - currency UUID, also currency code may be provided in exchange+ `language`: `ZH-HANS` (optional, string) - language UUID, also language code may be provided+ `date_start`: `2015-06-25` (optional, string) - product start date, format YYYY-MM-DD+ `date_end`: `2015-06-30` (optional, string) - product end date, format YYYY-MM-DD+ `query`: `diving in Bali` (optional, string) - free phrase for text search for example &query=Bali+ `duration_days_min`: `0` (optional,integer) - product duration minimum days (default 0)+ `duration_days_max`: `0` (optional,integer) - product duration maximum days (default NULL)+ `latitude`: `1.313430` (optional, float) - search in distance radius: latitude value + `longitude`: `103.883768` (optional, float) - search in distance radius: longitude value+ `distance`: `10.5` (optional, float) - search in distance radius in km - to use this param you need to provide always 3 parameters: latitude, longitude and distance+ `sort`: `price` (optional, string) - sorting field, example: &sort=date,-price  or &sort=price+ `page`: `5` (optional, integer) - page number for results+ `per_page`: `25` (optional, integer) - how many results per page - if not provided default value from user account will be used+ `published`: `true` (optional, string) - default is set to true, if set to false then a list of shortened unpublished products will be returned+ `deleted`: `false` (optional, string) - default is set to false, if set to true then a list of shortened deleted products will be returned
        /// </summary>
        /// <param name="category">Optional parameter: UUID of litsing category</param>
        /// <param name="city">Optional parameter: UUID of city, it will always overwrite country parameter if provided</param>
        /// <param name="country">Optional parameter: UUID of country</param>
        /// <param name="currency">Optional parameter: currency UUID, also currency code may be provided in exchange</param>
        /// <param name="dateEnd">Optional parameter: product end date, format YYYY-MM-DD</param>
        /// <param name="dateStart">Optional parameter: product start date, format YYYY-MM-DD</param>
        /// <param name="deleted">Optional parameter: default is set to `false`</param>
        /// <param name="distance">Optional parameter: Distance in km</param>
        /// <param name="durationDaysMax">Optional parameter: product duration maximum days (default NULL)</param>
        /// <param name="durationDaysMin">Optional parameter: product duration minimum days (default 0)</param>
        /// <param name="language">Optional parameter: language UUID, also language code may be provided. It will overwrite the default language from user account</param>
        /// <param name="latitude">Optional parameter: Latitude value</param>
        /// <param name="longitude">Optional parameter: Longitute value</param>
        /// <param name="page">Optional parameter: page number for results</param>
        /// <param name="pax">Optional parameter: number of people</param>
        /// <param name="perPage">Optional parameter: how many results per page - if not provided default value from user account will be used</param>
        /// <param name="priceMax">Optional parameter: max price in decimal format 000.00</param>
        /// <param name="priceMin">Optional parameter: minimal price in decimal format 000.00 - it's compared to base price</param>
        /// <param name="published">Optional parameter: default is always set to `true`</param>
        /// <param name="query">Optional parameter: free phrase for text search for example &query=Bali</param>
        /// <param name="sort">Optional parameter: sorting field, example: &sort=date,-price  or &sort=price</param>
        /// <param name="type">Optional parameter: UUID of type of product</param>
        /// <return>Returns the GETProductsResponse response from the API call</return>
        public async Task<GETProductsResponse> GetProductsListAsync(
                string category = null,
                string city = null,
                string country = null,
                string currency = null,
                string dateEnd = null,
                string dateStart = null,
                string deleted = null,
                string distance = null,
                int? durationDaysMax = null,
                int? durationDaysMin = null,
                string language = null,
                string latitude = null,
                string longitude = null,
                double? page = null,
                double? pax = null,
                double? perPage = null,
                int? priceMax = null,
                int? priceMin = null,
                string published = null,
                string query = null,
                string sort = null,
                string type = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/products");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "category", category },
                { "city", city },
                { "country", country },
                { "currency", currency },
                { "date_end", dateEnd },
                { "date_start", dateStart },
                { "deleted", deleted },
                { "distance", distance },
                { "duration_days_max", durationDaysMax },
                { "duration_days_min", durationDaysMin },
                { "language", language },
                { "latitude", latitude },
                { "longitude", longitude },
                { "page", page },
                { "pax", pax },
                { "per_page", perPage },
                { "price_max", priceMax },
                { "price_min", priceMin },
                { "published", published },
                { "query", query },
                { "sort", sort },
                { "type", type }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.SDK.v1" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<GETProductsResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 