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
    public partial class ConfigController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ConfigController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ConfigController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ConfigController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// A Config object has the following attributes:+ `timezone` - Our sever timezone+ `now` - Our server timestamp+ `version` - Current version is "1.0"+ `serverUrl` - Main API URL+ `photosUrl` - Base Path to server where we store our images+ `productsSorting` - Available Products lists sorting options (can be combined with commas, for example &sort=date,-price )    + `date` - Date ascending    + `-date` - Date descending    + `price` - Price ascending    + `-price` - Price descending    + `distance` - Distance ascending (works only if `latitude`,`longitude` & `distance` parameters are provided, ignored otherwise)     + `-distance` - Distance descending (works only if `latitude`,`longitude` & `distance` parameters are provided, ignored otherwise)+ user - All important userdata for provided API key    + `name` - Name / Company / Organization    + `email` - E-Mail Address    + `uuid` - Unique ID    + `continueUrl` - Continue URL (not in use now)    + `notifyUrl` - Notify URL (not in use now)    + `suggestedMarkup` - Suggested markup, % decimal value, for example 7.5    + `defaultPagination` - Default Pagination value (per page), between 1-100    + `defaultSortBy` - Default sort by for /products (if not specified)    + `defaultCurrencyUuid` - Default currency UUID for /products (if not specified)    + `defaultCurrencyCode` - Default currency code for /products (if not specified)    + `defaultLanguageUuid` - Default language UUID  /products (if not specified)    + `defaultLanguageCode` - Default language code  /products (if not specified)    + `walletBalance` - Partner's available wallet balance, based on his deposits    + `walletAvailableBalance` - Wallet balance which is a combination of partner's deposit and assigned credit amount    + `wallet_alert_value` - Threshold value in SGD, when `walletBallance` reach this value then BMG and partner will be notified on this event+ `languages` - A list of supported languages.+ `currencies` - An array of supported currencies.+ `types` - An array of supported products types.+ `categories` - A tree of supported product categories.+ `locations` - A tree of supported locations. (Continent -> Country -> State -> City)
        /// </summary>
        /// <return>Returns the RetrieveConfigResponse response from the API call</return>
        public async Task<RetrieveConfigResponse> RetrieveConfigAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/config");


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
                return APIHelper.JsonDeserialize<RetrieveConfigResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 