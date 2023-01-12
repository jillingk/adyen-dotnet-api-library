/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AllowedOriginsMerchantLevelApi : AbstractService
    {
        public AllowedOriginsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public void DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId, string apiCredentialId, string originId, RequestOptions requestOptions = null)
        {
            DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(merchantId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public async Task DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(string merchantId, string apiCredentialId, string originId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            await resource.RequestAsync(jsonRequest, null, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOriginsResponse</returns>
        public AllowedOriginsResponse GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsAsync(merchantId, apiCredentialId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of allowed origins
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOriginsResponse</returns>
        public async Task<AllowedOriginsResponse> GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<AllowedOriginsResponse>(jsonResult);
        }

        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOrigin</returns>
        public AllowedOrigin GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId, string apiCredentialId, string originId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(merchantId, apiCredentialId, originId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="originId">Unique identifier of the allowed origin.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOrigin</returns>
        public async Task<AllowedOrigin> GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(string merchantId, string apiCredentialId, string originId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<AllowedOrigin>(jsonResult);
        }

        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>AllowedOriginsResponse</returns>
        public AllowedOriginsResponse PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsAsync(merchantId, apiCredentialId, allowedOrigin, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an allowed origin
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="allowedOrigin"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of AllowedOriginsResponse</returns>
        public async Task<AllowedOriginsResponse> PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsAsync(string merchantId, string apiCredentialId, AllowedOrigin allowedOrigin, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins";
            string jsonRequest = allowedOrigin.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<AllowedOriginsResponse>(jsonResult);
        }

    }
}
