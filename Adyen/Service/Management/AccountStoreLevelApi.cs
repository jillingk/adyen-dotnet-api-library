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
using System.Collections.Generic;
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
    public class AccountStoreLevelApi : AbstractService
    {
        public AccountStoreLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference">The reference of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListStoresResponse</returns>
        public ListStoresResponse ListStoresByMerchantId(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default)
        {
            return ListStoresByMerchantIdAsync(merchantId, pageNumber, pageSize, reference, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference">The reference of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListStoresResponse</returns>
        public async Task<ListStoresResponse> ListStoresByMerchantIdAsync(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (reference != null) queryParams.Add("reference", reference);
            var endpoint = $"/merchants/{merchantId}/stores" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListStoresResponse>(jsonResult);
        }

        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store GetStore(string merchantId, string storeId, RequestOptions requestOptions = default)
        {
            return GetStoreAsync(merchantId, storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> GetStoreAsync(string merchantId, string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{storeId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference">The reference of the store.</param>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListStoresResponse</returns>
        public ListStoresResponse ListStores(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default)
        {
            return ListStoresAsync(pageNumber, pageSize, reference, merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference">The reference of the store.</param>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListStoresResponse</returns>
        public async Task<ListStoresResponse> ListStoresAsync(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (reference != null) queryParams.Add("reference", reference);
            if (merchantId != null) queryParams.Add("merchantId", merchantId);
            var endpoint = "/stores" + ToQueryString(queryParams);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListStoresResponse>(jsonResult);
        }

        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store GetStoreById(string storeId, RequestOptions requestOptions = default)
        {
            return GetStoreByIdAsync(storeId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> GetStoreByIdAsync(string storeId, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, requestOptions, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store UpdateStore(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            return UpdateStoreAsync(merchantId, storeId, updateStoreRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> UpdateStoreAsync(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores/{storeId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updateStoreRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store UpdateStoreById(string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            return UpdateStoreByIdAsync(storeId, updateStoreRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="storeId">The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> UpdateStoreByIdAsync(string storeId, UpdateStoreRequest updateStoreRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/stores/{storeId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updateStoreRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store CreateStoreByMerchantId(string merchantId, StoreCreationRequest storeCreationRequest, RequestOptions requestOptions = default)
        {
            return CreateStoreByMerchantIdAsync(merchantId, storeCreationRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> CreateStoreByMerchantIdAsync(string merchantId, StoreCreationRequest storeCreationRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/merchants/{merchantId}/stores";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(storeCreationRequest.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="storeCreationWithMerchantCodeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Store</returns>
        public Store CreateStore(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest, RequestOptions requestOptions = default)
        {
            return CreateStoreAsync(storeCreationWithMerchantCodeRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="storeCreationWithMerchantCodeRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Store</returns>
        public async Task<Store> CreateStoreAsync(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest, RequestOptions requestOptions = default)
        {
            var endpoint = "/stores";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(storeCreationWithMerchantCodeRequest.ToJson(), requestOptions, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Store>(jsonResult);
        }

    }
}
