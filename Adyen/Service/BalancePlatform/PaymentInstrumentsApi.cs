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
using Newtonsoft.Json;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentInstrumentsApi : AbstractService
    {
        public PaymentInstrumentsApi(Client client) : base(client) {}

        /// <summary>
        /// Get a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument GetPaymentInstrumentsId(string id, RequestOptions requestOptions = default)
        {
            return GetPaymentInstrumentsIdAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> GetPaymentInstrumentsIdAsync(string id, RequestOptions requestOptions = default)
        {
            var endpoint = $"/paymentInstruments/{id}";
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrument>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TransactionRulesResponse</returns>
        public TransactionRulesResponse GetPaymentInstrumentsIdTransactionRules(string id, RequestOptions requestOptions = default)
        {
            return GetPaymentInstrumentsIdTransactionRulesAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all transaction rules for a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TransactionRulesResponse</returns>
        public async Task<TransactionRulesResponse> GetPaymentInstrumentsIdTransactionRulesAsync(string id, RequestOptions requestOptions = default)
        {
            var endpoint = $"/paymentInstruments/{id}/transactionRules";
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<TransactionRulesResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Update a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument PatchPaymentInstrumentsId(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default)
        {
            return PatchPaymentInstrumentsIdAsync(id, paymentInstrumentUpdateRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a payment instrument
        /// </summary>
        /// <param name="id">The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> PatchPaymentInstrumentsIdAsync(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default)
        {
            var endpoint = $"/paymentInstruments/{id}";
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrument>(paymentInstrumentUpdateRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
        }

        /// <summary>
        /// Create a payment instrument
        /// </summary>
        /// <param name="paymentInstrumentInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentInstrument</returns>
        public PaymentInstrument PostPaymentInstruments(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default)
        {
            return PostPaymentInstrumentsAsync(paymentInstrumentInfo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a payment instrument
        /// </summary>
        /// <param name="paymentInstrumentInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentInstrument</returns>
        public async Task<PaymentInstrument> PostPaymentInstrumentsAsync(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default)
        {
            var endpoint = "/paymentInstruments";
            var resource = new BalancePlatformResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrument>(paymentInstrumentInfo.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}