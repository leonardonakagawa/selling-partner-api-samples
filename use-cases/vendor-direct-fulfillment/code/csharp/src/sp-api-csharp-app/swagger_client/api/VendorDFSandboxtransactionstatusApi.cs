/* 
 * Selling Partner API for Vendor Direct Fulfillment Sandbox Test Data
 *
 * The Selling Partner API for Vendor Direct Fulfillment Sandbox Test Data provides programmatic access to vendor direct fulfillment sandbox test data.
 *
 * OpenAPI spec version: 2021-10-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using spApiCsharpApp.swaggerClient.Client;
using spApiCsharpApp.swaggerClient.Model.DirectFulfillmentInventory;
using Amazon.SellingPartnerAPIAA;
using spApiCsharpApp.swaggerClient.Model.DirectFulfillmentSandboxData;

namespace spApiCsharpApp.swaggerClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVendorDFSandboxtransactionstatusApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>TransactionStatus</returns>
        TransactionStatus GetOrderScenarios (string transactionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>ApiResponse of TransactionStatus</returns>
        ApiResponse<TransactionStatus> GetOrderScenariosWithHttpInfo (string transactionId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>Task of TransactionStatus</returns>
        System.Threading.Tasks.Task<TransactionStatus> GetOrderScenariosAsync (string transactionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>Task of ApiResponse (TransactionStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionStatus>> GetOrderScenariosAsyncWithHttpInfo (string transactionId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VendorDFSandboxtransactionstatusApi : IVendorDFSandboxtransactionstatusApi
    {
        private spApiCsharpApp.swaggerClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorDFSandboxtransactionstatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VendorDFSandboxtransactionstatusApi(spApiCsharpApp.swaggerClient.Client.Configuration configuration)
        {
            this.Configuration = configuration;
            ExceptionFactory = spApiCsharpApp.swaggerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public spApiCsharpApp.swaggerClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public spApiCsharpApp.swaggerClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>TransactionStatus</returns>
        public TransactionStatus GetOrderScenarios (string transactionId)
        {
             ApiResponse<TransactionStatus> localVarResponse = GetOrderScenariosWithHttpInfo(transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>ApiResponse of TransactionStatus</returns>
        public ApiResponse< TransactionStatus > GetOrderScenariosWithHttpInfo (string transactionId)
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling VendorDFSandboxtransactionstatusApi->GetOrderScenarios");

            var localVarPath = "/vendor/directFulfillment/sandbox/2021-10-28/transactions/{transactionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOrderScenarios", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionStatus)));
        }

        /// <summary>
        ///  Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>Task of TransactionStatus</returns>
        public async System.Threading.Tasks.Task<TransactionStatus> GetOrderScenariosAsync (string transactionId)
        {
             ApiResponse<TransactionStatus> localVarResponse = await GetOrderScenariosAsyncWithHttpInfo(transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns the status of the transaction indicated by the specified transactionId. If the transaction was successful, also returns the requested test order data.
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">The transaction identifier returned in the response to the generateOrderScenarios operation.</param>
        /// <returns>Task of ApiResponse (TransactionStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionStatus>> GetOrderScenariosAsyncWithHttpInfo (string transactionId)
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling VendorDFSandboxtransactionstatusApi->GetOrderScenarios");

            var localVarPath = "/vendor/directFulfillment/sandbox/2021-10-28/transactions/{transactionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOrderScenarios", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionStatus)));
        }


        public class Builder
        {
            private LWAAuthorizationCredentials lwaAuthorizationCredentials;
            private RateLimitConfiguration rateLimitConfiguration;

            public Builder SetLWAAuthorizationCredentials(LWAAuthorizationCredentials lwaAuthorizationCredentials)
            {
                this.lwaAuthorizationCredentials = lwaAuthorizationCredentials;
                return this;
            }
            
            
            public Builder SetRateLimitConfiguration(RateLimitConfiguration rateLimitConfiguration)
            {
                this.rateLimitConfiguration = rateLimitConfiguration;
                return this;
            }

            public VendorDFSandboxtransactionstatusApi Build() 
            {
                if (lwaAuthorizationCredentials == null) 
                {
                    throw new NullReferenceException("LWAAuthoriztionCredentials not set");
                }

                
                spApiCsharpApp.swaggerClient.Client.Configuration configuration = new spApiCsharpApp.swaggerClient.Client.Configuration()
                {
                    AuthorizationCredentials = lwaAuthorizationCredentials,
                    RateLimitConfig = rateLimitConfiguration
                };

                // default HTTP connection timeout (in milliseconds)
                configuration.Timeout = 100000;

                return new VendorDFSandboxtransactionstatusApi(configuration);
            }
        }
    }
}
