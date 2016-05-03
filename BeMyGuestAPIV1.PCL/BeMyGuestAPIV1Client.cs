/*
 * BeMyGuestAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 on 05/03/2016
 */
using System;
using BeMyGuestAPIV1.PCL.Controllers;
using BeMyGuestAPIV1.PCL.Http.Client;

namespace BeMyGuestAPIV1.PCL
{
    public partial class BeMyGuestAPIV1Client
    {

        /// <summary>
        /// Singleton access to Config controller
        /// </summary>
        public ConfigController Config
        {
            get
            {
                return ConfigController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Bookings controller
        /// </summary>
        public BookingsController Bookings
        {
            get
            {
                return BookingsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Products controller
        /// </summary>
        public ProductsController Products
        {
            get
            {
                return ProductsController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public BeMyGuestAPIV1Client() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public BeMyGuestAPIV1Client(string xAuthorization)
        {
            Configuration.XAuthorization = xAuthorization;
        }
    }
}