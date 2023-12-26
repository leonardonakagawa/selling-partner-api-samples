/* 
 * Selling Partner API for Direct Fulfillment Inventory Updates
 *
 * The Selling Partner API for Direct Fulfillment Inventory Updates provides programmatic access to a direct fulfillment vendor's inventory updates.
 *
 * OpenAPI spec version: v1
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

namespace spApiCsharpApp.swaggerClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpdateInventoryApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>SubmitInventoryUpdateResponse</returns>
        SubmitInventoryUpdateResponse SubmitInventoryUpdate (SubmitInventoryUpdateRequest body, string warehouseId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>ApiResponse of SubmitInventoryUpdateResponse</returns>
        ApiResponse<SubmitInventoryUpdateResponse> SubmitInventoryUpdateWithHttpInfo (SubmitInventoryUpdateRequest body, string warehouseId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>Task of SubmitInventoryUpdateResponse</returns>
        System.Threading.Tasks.Task<SubmitInventoryUpdateResponse> SubmitInventoryUpdateAsync (SubmitInventoryUpdateRequest body, string warehouseId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </remarks>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>Task of ApiResponse (SubmitInventoryUpdateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubmitInventoryUpdateResponse>> SubmitInventoryUpdateAsyncWithHttpInfo (SubmitInventoryUpdateRequest body, string warehouseId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UpdateInventoryApi : IUpdateInventoryApi
    {
        private spApiCsharpApp.swaggerClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInventoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UpdateInventoryApi(spApiCsharpApp.swaggerClient.Client.Configuration configuration)
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
        ///  Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>SubmitInventoryUpdateResponse</returns>
        public SubmitInventoryUpdateResponse SubmitInventoryUpdate (SubmitInventoryUpdateRequest body, string warehouseId)
        {
             ApiResponse<SubmitInventoryUpdateResponse> localVarResponse = SubmitInventoryUpdateWithHttpInfo(body, warehouseId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>ApiResponse of SubmitInventoryUpdateResponse</returns>
        public ApiResponse< SubmitInventoryUpdateResponse > SubmitInventoryUpdateWithHttpInfo (SubmitInventoryUpdateRequest body, string warehouseId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInventoryApi->SubmitInventoryUpdate");
            // verify the required parameter 'warehouseId' is set
            if (warehouseId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseId' when calling UpdateInventoryApi->SubmitInventoryUpdate");

            var localVarPath = "/vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items";
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

            if (warehouseId != null) localVarPathParams.Add("warehouseId", this.Configuration.ApiClient.ParameterToString(warehouseId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitInventoryUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmitInventoryUpdateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmitInventoryUpdateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmitInventoryUpdateResponse)));
        }

        /// <summary>
        ///  Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>Task of SubmitInventoryUpdateResponse</returns>
        public async System.Threading.Tasks.Task<SubmitInventoryUpdateResponse> SubmitInventoryUpdateAsync (SubmitInventoryUpdateRequest body, string warehouseId)
        {
             ApiResponse<SubmitInventoryUpdateResponse> localVarResponse = await SubmitInventoryUpdateAsyncWithHttpInfo(body, warehouseId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Submits inventory updates for the specified warehouse for either a partial or full feed of inventory items.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 10 | 10 |  The &#x60;x-amzn-RateLimit-Limit&#x60; response header returns the usage plan rate limits that were applied to the requested operation, when available. The table above indicates the default rate and burst values for this operation. Selling partners whose business demands require higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        /// <exception cref="spApiCsharpApp.swaggerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="warehouseId">Identifier for the warehouse for which to update inventory.</param>
        /// <returns>Task of ApiResponse (SubmitInventoryUpdateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubmitInventoryUpdateResponse>> SubmitInventoryUpdateAsyncWithHttpInfo (SubmitInventoryUpdateRequest body, string warehouseId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInventoryApi->SubmitInventoryUpdate");
            // verify the required parameter 'warehouseId' is set
            if (warehouseId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseId' when calling UpdateInventoryApi->SubmitInventoryUpdate");

            var localVarPath = "/vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items";
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

            if (warehouseId != null) localVarPathParams.Add("warehouseId", this.Configuration.ApiClient.ParameterToString(warehouseId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitInventoryUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmitInventoryUpdateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmitInventoryUpdateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmitInventoryUpdateResponse)));
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

            public UpdateInventoryApi Build() 
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

                return new UpdateInventoryApi(configuration);
            }
        }
    }
}
