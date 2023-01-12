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
    public class WebhooksCompanyLevelApi : AbstractService
    {
        public WebhooksCompanyLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public void DeleteCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            DeleteCompaniesCompanyIdWebhooksWebhookIdAsync(companyId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public async Task DeleteCompaniesCompanyIdWebhooksWebhookIdAsync(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks/{webhookId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            await resource.RequestAsync(jsonRequest, null, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>ListWebhooksResponse</returns>
        public ListWebhooksResponse GetCompaniesCompanyIdWebhooks(string companyId, RequestOptions requestOptions = null)
        {
            return GetCompaniesCompanyIdWebhooksAsync(companyId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of ListWebhooksResponse</returns>
        public async Task<ListWebhooksResponse> GetCompaniesCompanyIdWebhooksAsync(string companyId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks" + ToQueryString(requestOptions?.QueryParameters);
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListWebhooksResponse>(jsonResult);
        }

        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook GetCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            return GetCompaniesCompanyIdWebhooksWebhookIdAsync(companyId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> GetCompaniesCompanyIdWebhooksWebhookIdAsync(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks/{webhookId}";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook PatchCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            return PatchCompaniesCompanyIdWebhooksWebhookIdAsync(companyId, webhookId, updateCompanyWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> PatchCompaniesCompanyIdWebhooksWebhookIdAsync(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks/{webhookId}";
            string jsonRequest = updateCompanyWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="createCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook PostCompaniesCompanyIdWebhooks(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            return PostCompaniesCompanyIdWebhooksAsync(companyId, createCompanyWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="companyId">Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account).</param>
        /// <param name="createCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> PostCompaniesCompanyIdWebhooksAsync(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks";
            string jsonRequest = createCompanyWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Webhook>(jsonResult);
        }

        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GenerateHmacKeyResponse</returns>
        public GenerateHmacKeyResponse PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            return PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacAsync(companyId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GenerateHmacKeyResponse</returns>
        public async Task<GenerateHmacKeyResponse> PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacAsync(string companyId, string webhookId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks/{webhookId}/generateHmac";
            string jsonRequest = null;
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<GenerateHmacKeyResponse>(jsonResult);
        }

        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TestWebhookResponse</returns>
        public TestWebhookResponse PostCompaniesCompanyIdWebhooksWebhookIdTest(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            return PostCompaniesCompanyIdWebhooksWebhookIdTestAsync(companyId, webhookId, testCompanyWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="companyId">The unique identifier of the company account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testCompanyWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TestWebhookResponse</returns>
        public async Task<TestWebhookResponse> PostCompaniesCompanyIdWebhooksWebhookIdTestAsync(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/companies/{companyId}/webhooks/{webhookId}/test";
            string jsonRequest = testCompanyWebhookRequest.ToJson();
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(jsonRequest, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<TestWebhookResponse>(jsonResult);
        }

    }
}
