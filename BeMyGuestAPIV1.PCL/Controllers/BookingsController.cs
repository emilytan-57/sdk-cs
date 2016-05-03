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
    public partial class BookingsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static BookingsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static BookingsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new BookingsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Updates Booking status information.Newly created booking has status `reserved`. In this status BeMyGuest inventory is not yet deducted.Inventory is locked after changing status of the booking from `reserved` to `waiting` (`confirm` action).When the booking is first created, it is marked as `reserved`. Inventories aren't touched yet. Once the partner decides to confirm the said booking, this is the only time the inventory will be impacted. The booking status will be updated from `reserved` to `waiting`.5 days after the booking date all booking with status `waiting` will be marked `expired`.There's 3rd extra action you may invoke in this method : `resend`. If `confirmationEmailSentAt` value is not null then the confirmation email copy sent o partner will be sent again and the timestamp value of this field will be updated.In response Booking object is returned, for example        {          "data": {              "uuid": "c53cbc74-1efa-58bb-afef-750afc52cd75",              "totalAmount": "123.98",              "currencyCode": "SGD",              "currencyUuid": "cd15153e-dfd1-5039-8aa3-115bec58e86e",              "totalAmountRequestCurrency": "369.46",              "requestCurrencyCode": "MYR",              "requestCurrencyUuid": "e98aaf89-ae5a-5c11-859a-b36f2c8e13c7",              "createdAt": "2015-12-21 19:53:23",              "updatedAt": "2015-12-21 19:53:23",              "arrivalDate": "2016-02-21",              "salutation": "Mr.",              "firstName": "test",              "lastName": "test",              "email": "test@126.com",              "phone": "123456789",              "guests": 2,              "children": 0,              "partnerReference": "test93828",              "confirmationEmailSentAt": null,              "confirmationEmailFiles": [],              "status": "reserved",              "productTypeTitle": "14% OFF for Family: E-Ticket to Universal Studios Singapore",              "productTypeTitleTranslated": "14% OFF for Family: E-Ticket to Universal Studios Singapore",              "productTypeUuid": "9b967f1a-89c2-5083-a758-e359deb2af9b"            }        }### Parameters+ uuid (required,string) - UUID of booking+ status (string) - Status "confirm" or "cancel"
        /// </summary>
        /// <param name="status">Required parameter: New status of the booking, one of [confirm, cancel, resend]</param>
        /// <param name="uuid">Required parameter: UUID of booking</param>
        /// <param name="data">Optional parameter: TODO: type parameter description here</param>
        /// <return>Returns the UpdateBookingStatusResponse response from the API call</return>
        public async Task<UpdateBookingStatusResponse> UpdateBookingStatusAsync(
                string status,
                string uuid,
                UpdateBookingRequest data = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/bookings/{uuid}/{status}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "status", status },
                { "uuid", uuid }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.SDK.v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //append body params
            var _body = APIHelper.JsonSerialize(data);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<UpdateBookingStatusResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Creates a new booking.
        /// Newly created booking has always `reserved` status. It means it's not payed yet, not confirmed by partner but it's created and reserved in BeMyGuest database. 
        /// After creating a booking partner can do perform two scenarios:
        /// - either confirm booking - it means it's been paid by client to partner
        /// - ..or cancel
        /// After succesfull request - new booking object will be returned with status `waiting`.
        /// If you try to create new booking with the same `partnerReference` value as before you will get `GEN-FORBIDDEN` / `403` / `Booking with this partnerReference already exists` error in response.
        /// If you try to create a new booking with the total amount (in SGD) higher than the current available credit `walletAvailableBalance` value as before you will get `GEN-FORBIDDEN` / `403` / `Wallet balance too low to create a booking. Current balance: -90.98` error in response.
        /// If the product has timeslots, the `timeslotUUID` of the product is REQUIRED in `Check a Booking` and `Create a new booking` methods. Otherwise, it can be excluded.
        /// Please remember that with all Booking requests you need to providea proper Content-Type header.
        /// `Content-Type: application/json`
        /// Example JSON request:
        ///         {
        ///             "salutation": "Mr.",
        ///             "firstName": "Daryle",
        ///             "lastName": "De Silva",
        ///             "email": "daryle@bemyguest.com.sg",
        ///             "phone": "+6591591923",
        ///             "message": "Hello",
        ///             "productTypeUuid": "9d4b4d76-5b54-5407-b2d9-e6c021cc472e",
        ///             "pax": 2,
        ///             "children": 3,
        ///             "timeSlotUuid": "b02ae425-421f-5edf-a880-4104c0245dac",
        ///             "addons": [
        ///                 {
        ///                     "uuid": "37e0f490-d31d-521b-b1f0-95c6e4e38d4c",
        ///                     "quantity": "1"
        ///                 },
        ///                 {
        ///                     "uuid": "a50090e3-567d-5743-9d87-e9d261aad0a9",
        ///                     "quantity": "2"
        ///                 }
        ///                 ],
        ///             "arrivalDate": "2015-06-07",
        ///             "partnerReference" : "REF-001",
        ///             "usePromotion": false
        ///         }
        /// Example JSON response:
        ///     {
        ///         "data": {
        ///               "uuid": "c53cbc74-1efa-58bb-afef-750afc52cd75",
        ///               "totalAmount": "123.98",
        ///               "currencyCode": "SGD",
        ///               "currencyUuid": "cd15153e-dfd1-5039-8aa3-115bec58e86e",
        ///               "totalAmountRequestCurrency": "369.46",
        ///               "requestCurrencyCode": "MYR",
        ///               "requestCurrencyUuid": "e98aaf89-ae5a-5c11-859a-b36f2c8e13c7",
        ///               "createdAt": "2015-12-21 19:53:23",
        ///               "updatedAt": "2015-12-21 19:53:23",
        ///               "arrivalDate": "2016-02-21",
        ///               "salutation": "Mr.",
        ///               "firstName": "test",
        ///               "lastName": "test",
        ///               "email": "test@126.com",
        ///               "phone": "123456789",
        ///               "guests": 2,
        ///               "children": 0,
        ///               "partnerReference": "test93828",
        ///               "confirmationEmailSentAt": null,
        ///               "confirmationEmailFiles": [],
        ///               "status": "reserved",
        ///               "productTypeTitle": "14% OFF for Family: E-Ticket to Universal Studios Singapore",
        ///               "productTypeTitleTranslated": "14% OFF for Family: E-Ticket to Universal Studios Singapore",
        ///               "productTypeUuid": "9b967f1a-89c2-5083-a758-e359deb2af9b"
        ///         }
        ///     }
        /// Example JSON error message when Wallet balance is lower than the new booking :
        ///     {
        ///         "error": {
        ///             "code": "GEN-FORBIDDEN",
        ///             "http_code": 403,
        ///             "message": "Wallet balance too low to create a booking. Current balance: -90.98"
        ///         }
        ///     }
        /// </summary>
        /// <param name="body">Required parameter: TODO: type parameter description here</param>
        /// <return>Returns the CreateABookingResponse response from the API call</return>
        public async Task<CreateABookingResponse> CreateABookingAsync(
                CreateABookingRequest body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/bookings");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.SDK.v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<CreateABookingResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a list of bookings.A request can take these parameters:+ `date_start`: As compared with arrivalDate, format YYYY-MM-DD+ `date_end`: As compared with arrivalDate, format YYYY-MM-DD+ `first_name`: Guest's first name+ `last_name`: Guest's last name+ `email`: Guest's email address+ `phone`: Guest's contact number+ `partner_reference`: The given unique partnerReference ID of this booking.+ `page`: Page number for results+ `per_page`: How many results per page - if not provided default value from user account will be used+ `query`: Free phrase for text search for example &query=John###ResponseA response object has the following attributes:  + `uuid` - UUID of the booking+ `totalAmount` - Total amount of the booking+ `currencyCode` - Currency code used in this booking+ `currencyUuid` - UUID of the `currencyCode`+ `totalAmountRequestCurrency` - Total amount of the booking in the requested currency. (The requested currency is set in user's profile).+ `requestCurrencyCode` - Currency used by `totalAmountRequestCurrency`+ `requestCurrencyUuid` - UUID of the requested currency+ `createdAt` - The booking's created date+ `updatedAt` - The last updated date+ `arrivalDate` - The arrival date+ `salutation` - Available salutation title: "Mr.", "Ms.", "Mrs."+ `firstName` - Guest's first name+ `lastName` - Guest's last name+ `email` - Guest's email address+ `phone` - Guest's contact number+ `guests` - Number of guests(adults) in this booking+ `children` - Number of children in this booking+ `partnerReference` - The given unique partnerReference ID of this booking.+ `confirmationEmailSentAt` - The sent out time of theconfirmation email + `confirmationEmailFiles` - The confirmation email files of this booking+ `status` - The booking status+ `productTypeTitle` - The productType's title of this booking+ `productTypeTitleTranslated` - The translated productType's title of this booking+ `productTypeUuid` - The productType UUID of this booking.
        /// </summary>
        /// <param name="dateEnd">Optional parameter: As compared with arrivalDate, format YYYY-MM-DD</param>
        /// <param name="dateStart">Optional parameter: As compared with arrivalDate, format YYYY-MM-DD</param>
        /// <param name="email">Optional parameter: Guest's email address</param>
        /// <param name="firstName">Optional parameter: Guest's first name</param>
        /// <param name="lastName">Optional parameter: Guest's last name</param>
        /// <param name="page">Optional parameter: Page number for results</param>
        /// <param name="partnerReference">Optional parameter: The given unique partnerReference ID of this booking</param>
        /// <param name="perPage">Optional parameter: How many results per page - if not provided default value from user account will be used</param>
        /// <param name="phone">Optional parameter: Guest's contact number</param>
        /// <param name="query">Optional parameter: Free phrase for text search for example &query=John</param>
        /// <param name="status">Optional parameter: Filter bookings by status reserved|waiting|cancelled|approved|expired|rejected|released|refunded</param>
        /// <return>Returns the GetBookingsResponse response from the API call</return>
        public async Task<GetBookingsResponse> GetBookingsAsync(
                string dateEnd = null,
                string dateStart = null,
                string email = null,
                string firstName = null,
                string lastName = null,
                string page = null,
                string partnerReference = null,
                string perPage = null,
                string phone = null,
                string query = null,
                BookingStatusesEnum? status = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/bookings/");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "date_end", dateEnd },
                { "date_start", dateStart },
                { "email", email },
                { "first_name", firstName },
                { "last_name", lastName },
                { "page", page },
                { "partner_reference", partnerReference },
                { "per_page", perPage },
                { "phone", phone },
                { "query", query },
                { "status", status }
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
                return APIHelper.JsonDeserialize<GetBookingsResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// `Check if booking is possible` method request requires lesser parameters as compared to `Create a booking`.In fact before creating a booking we advise to run this request first:- it will check if booking can be made without writing any data in BMG database- it will provide a correct total amount for selected services- if partner is caching products this should be used just before creating a booking - so any differences in cached prices (on partner side) and current price for total amount can be discovered- if partner discover difference in provided total amount then he can act accordingly in his user/client interface (for example - ask customer to accept final changed price)The main difference is that no booking is created in the system and some fields in response JSON object have NULL values. If the product has timeslots, the `timeslotUUID` of the product is REQUIRED in `Check a Booking` and `Create a new booking` methods. Otherwise, it can be excluded.For `booking check` request you don't have to pass customer's data or `partnerReference`.Example JSON request:        {            "productTypeUuid": "9d4b4d76-5b54-5407-b2d9-e6c021cc472e",            "pax": 2,            "children": 3,            "timeSlotUuid": "b02ae425-421f-5edf-a880-4104c0245dac",            "addons": [                {                    "uuid": "37e0f490-d31d-521b-b1f0-95c6e4e38d4c",                    "quantity": "1"                },                {                    "uuid": "a50090e3-567d-5743-9d87-e9d261aad0a9",                    "quantity": "2"                }                ],            "arrivalDate": "2015-06-07",            "usePromotion": false        }Response example:        {          "data": {              "uuid": null,              "totalAmount": "123.98",              "currencyCode": "SGD",              "currencyUuid": "cd15153e-dfd1-5039-8aa3-115bec58e86e",              "totalAmountRequestCurrency": "369.46",              "requestCurrencyCode": "MYR",              "requestCurrencyUuid": "e98aaf89-ae5a-5c11-859a-b36f2c8e13c7",              "createdAt": null,              "updatedAt": null,              "arrivalDate": "2015-06-07",              "salutation": null,              "firstName": null,              "lastName": null,              "email": null,              "phone": null,              "guests": 2,              "children": 3,              "partnerReference": null,              "confirmationEmailSentAt": null,              "confirmationEmailFiles": [],              "status": null,              "productTypeTitle": null,              "productTypeTitleTranslated": null,              "productTypeUuid": "9d4b4d76-5b54-5407-b2d9-e6c021cc472e"          }        }
        /// </summary>
        /// <param name="body">Required parameter: TODO: type parameter description here</param>
        /// <return>Returns the CheckABookingResponse response from the API call</return>
        public async Task<CheckABookingResponse> CreateCheckABookingAsync(
                CheckABookingRequest body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/bookings/check");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.SDK.v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<CheckABookingResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get Booking status information.
        /// Possible status return values:
        /// - `reserved` - booking created but not confirmed by partner
        /// - `waiting` - booking confirmed by partner (for example payed on partned side)
        /// - `approved` - booking confirmed by supplier
        /// - `cancelled` - cancelled by partner or BeMyGuest
        /// - `expired` - no action has been done by supplier or BeMyGuest and booking has expired
        /// - `rejected` - supplier rejected booking
        /// In response Booking object is returned, for example
        ///         {
        ///           "data": {
        ///               "uuid": "c53cbc74-1efa-58bb-afef-750afc52cd75",
        ///               "totalAmount": "123.98",
        ///               "currencyCode": "SGD",
        ///               "currencyUuid": "cd15153e-dfd1-5039-8aa3-115bec58e86e",
        ///               "totalAmountRequestCurrency": "369.46",
        ///               "requestCurrencyCode": "MYR",
        ///               "requestCurrencyUuid": "e98aaf89-ae5a-5c11-859a-b36f2c8e13c7",
        ///               "createdAt": "2015-12-21 19:53:23",
        ///               "updatedAt": "2015-12-21 19:53:23",
        ///               "arrivalDate": "2016-02-21",
        ///               "salutation": "Mr.",
        ///               "firstName": "test",
        ///               "lastName": "test",
        ///               "email": "test@126.com",
        ///               "phone": "123456789",
        ///               "guests": 2,
        ///               "children": 0,
        ///               "partnerReference": "test93828",
        ///               "confirmationEmailSentAt": null,
        ///               "confirmationEmailFiles": [],
        ///               "status": "reserved",
        ///               "productTypeTitle": "14% OFF for Family: E-Ticket to Universal Studios Singapore",
        ///               "productTypeTitleTranslated": "14% OFF for Family: E-Ticket to Universal Studios Singapore",
        ///               "productTypeUuid": "9b967f1a-89c2-5083-a758-e359deb2af9b"
        ///             }
        ///         }
        /// ###Parameters
        /// + uuid (required,string) - UUID of booking
        /// </summary>
        /// <param name="uuid">Required parameter: UUID of booking</param>
        /// <return>Returns the GetBookingStatusResponse response from the API call</return>
        public async Task<GetBookingStatusResponse> GetBookingStatusAsync(
                string uuid)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/bookings/{uuid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "uuid", uuid }
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
                return APIHelper.JsonDeserialize<GetBookingStatusResponse>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 