/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlatformApi : AbstractService
    {
        public PlatformApi(Client client) : base(client) {}

        /// <summary>
        /// Get a balance platform
        /// </summary>
        /// <param name="id">The unique identifier of the balance platform.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>BalancePlatform</returns>
        public Model.BalancePlatform.BalancePlatform GetBalancePlatformsId(string id, RequestOptions requestOptions = default)
        {
            return GetBalancePlatformsIdAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a balance platform
        /// </summary>
        /// <param name="id">The unique identifier of the balance platform.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of BalancePlatform</returns>
        public async Task<Model.BalancePlatform.BalancePlatform> GetBalancePlatformsIdAsync(string id, RequestOptions requestOptions = default)
        {
            var endpoint = $"/balancePlatforms/{id}";
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.BalancePlatform>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get all account holders under a balance platform
        /// </summary>
        /// <param name="id">The unique identifier of the balance platform.</param>
        /// <param name="offset">The number of items that you want to skip.</param>
        /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaginatedAccountHoldersResponse</returns>
        public PaginatedAccountHoldersResponse GetBalancePlatformsIdAccountHolders(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            return GetBalancePlatformsIdAccountHoldersAsync(id, offset, limit, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all account holders under a balance platform
        /// </summary>
        /// <param name="id">The unique identifier of the balance platform.</param>
        /// <param name="offset">The number of items that you want to skip.</param>
        /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaginatedAccountHoldersResponse</returns>
        public async Task<PaginatedAccountHoldersResponse> GetBalancePlatformsIdAccountHoldersAsync(string id, int? offset = default, int? limit = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (offset != null) queryParams.Add("offset", offset.ToString());
            if (limit != null) queryParams.Add("limit", limit.ToString());
            var endpoint = $"/balancePlatforms/{id}/accountHolders" + ToQueryString(queryParams);
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<PaginatedAccountHoldersResponse>(null, requestOptions, new HttpMethod("GET"));
        }

    }
}