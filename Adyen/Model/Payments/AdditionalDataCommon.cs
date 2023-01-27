/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Payments
{
    /// <summary>
    /// AdditionalDataCommon
    /// </summary>
    [DataContract(Name = "AdditionalDataCommon")]
    public partial class AdditionalDataCommon : IEquatable<AdditionalDataCommon>, IValidatableObject
    {
        /// <summary>
        /// In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.
        /// </summary>
        /// <value>In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndustryUsageEnum
        {
            /// <summary>
            /// Enum NoShow for value: NoShow
            /// </summary>
            [EnumMember(Value = "NoShow")]
            NoShow = 1,

            /// <summary>
            /// Enum DelayedCharge for value: DelayedCharge
            /// </summary>
            [EnumMember(Value = "DelayedCharge")]
            DelayedCharge = 2

        }


        /// <summary>
        /// In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.
        /// </summary>
        /// <value>In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.</value>
        [DataMember(Name = "industryUsage", EmitDefaultValue = false)]
        public IndustryUsageEnum? IndustryUsage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCommon" /> class.
        /// </summary>
        /// <param name="requestedTestErrorResponseCode">Triggers test scenarios that allow to replicate certain communication errors.  Allowed values: * **NO_CONNECTION_AVAILABLE** – There wasn&#39;t a connection available to service the outgoing communication. This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request. * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response. This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response..</param>
        /// <param name="authorisationType">Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types).  Allowed values: * **PreAuth** – flags the payment request to be handled as a pre-authorisation. * **FinalAuth** – flags the payment request to be handled as a final authorisation..</param>
        /// <param name="customRoutingFlag">Allows you to determine or override the acquirer account that should be used for the transaction.  If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request&#39;s additional data to target a specific acquirer.  To enable this functionality, contact [Support](https://www.adyen.help/hc/en-us/requests/new)..</param>
        /// <param name="industryUsage">In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.  Possible values:   * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.   * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed..</param>
        /// <param name="networkTxReference">Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.  Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.  Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.  Make sure you are sending &#x60;shopperInteraction&#x60; **ContAuth** and &#x60;recurringProcessingModel&#x60; **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT..</param>
        /// <param name="overwriteBrand">Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the &#x60;selectedBrand&#x60; value to specify how to process the transaction..</param>
        /// <param name="subMerchantCity">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 13 characters..</param>
        /// <param name="subMerchantCountry">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant&#39;s address. * Format: alpha-numeric. * Fixed length: 3 characters..</param>
        /// <param name="subMerchantID">This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.  A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator. * Format: alpha-numeric. * Fixed length: 15 characters..</param>
        /// <param name="subMerchantName">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant. * Format: alpha-numeric. * Maximum length: 22 characters..</param>
        /// <param name="subMerchantPostalCode">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 10 characters..</param>
        /// <param name="subMerchantState">This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 3 characters..</param>
        /// <param name="subMerchantStreet">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 60 characters..</param>
        /// <param name="subMerchantTaxId">This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant. * Format: alpha-numeric. * Fixed length: 11 or 14 characters..</param>
        public AdditionalDataCommon(string requestedTestErrorResponseCode = default(string), string authorisationType = default(string), string customRoutingFlag = default(string), IndustryUsageEnum? industryUsage = default(IndustryUsageEnum?), string networkTxReference = default(string), string overwriteBrand = default(string), string subMerchantCity = default(string), string subMerchantCountry = default(string), string subMerchantID = default(string), string subMerchantName = default(string), string subMerchantPostalCode = default(string), string subMerchantState = default(string), string subMerchantStreet = default(string), string subMerchantTaxId = default(string))
        {
            this.RequestedTestErrorResponseCode = requestedTestErrorResponseCode;
            this.AuthorisationType = authorisationType;
            this.CustomRoutingFlag = customRoutingFlag;
            this.IndustryUsage = industryUsage;
            this.NetworkTxReference = networkTxReference;
            this.OverwriteBrand = overwriteBrand;
            this.SubMerchantCity = subMerchantCity;
            this.SubMerchantCountry = subMerchantCountry;
            this.SubMerchantID = subMerchantID;
            this.SubMerchantName = subMerchantName;
            this.SubMerchantPostalCode = subMerchantPostalCode;
            this.SubMerchantState = subMerchantState;
            this.SubMerchantStreet = subMerchantStreet;
            this.SubMerchantTaxId = subMerchantTaxId;
        }

        /// <summary>
        /// Triggers test scenarios that allow to replicate certain communication errors.  Allowed values: * **NO_CONNECTION_AVAILABLE** – There wasn&#39;t a connection available to service the outgoing communication. This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request. * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response. This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.
        /// </summary>
        /// <value>Triggers test scenarios that allow to replicate certain communication errors.  Allowed values: * **NO_CONNECTION_AVAILABLE** – There wasn&#39;t a connection available to service the outgoing communication. This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request. * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response. This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.</value>
        [DataMember(Name = "RequestedTestErrorResponseCode", EmitDefaultValue = false)]
        public string RequestedTestErrorResponseCode { get; set; }

        /// <summary>
        /// Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types).  Allowed values: * **PreAuth** – flags the payment request to be handled as a pre-authorisation. * **FinalAuth** – flags the payment request to be handled as a final authorisation.
        /// </summary>
        /// <value>Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types).  Allowed values: * **PreAuth** – flags the payment request to be handled as a pre-authorisation. * **FinalAuth** – flags the payment request to be handled as a final authorisation.</value>
        [DataMember(Name = "authorisationType", EmitDefaultValue = false)]
        public string AuthorisationType { get; set; }

        /// <summary>
        /// Allows you to determine or override the acquirer account that should be used for the transaction.  If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request&#39;s additional data to target a specific acquirer.  To enable this functionality, contact [Support](https://www.adyen.help/hc/en-us/requests/new).
        /// </summary>
        /// <value>Allows you to determine or override the acquirer account that should be used for the transaction.  If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request&#39;s additional data to target a specific acquirer.  To enable this functionality, contact [Support](https://www.adyen.help/hc/en-us/requests/new).</value>
        [DataMember(Name = "customRoutingFlag", EmitDefaultValue = false)]
        public string CustomRoutingFlag { get; set; }

        /// <summary>
        /// Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.  Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.  Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.  Make sure you are sending &#x60;shopperInteraction&#x60; **ContAuth** and &#x60;recurringProcessingModel&#x60; **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT.
        /// </summary>
        /// <value>Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.  Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.  Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.  Make sure you are sending &#x60;shopperInteraction&#x60; **ContAuth** and &#x60;recurringProcessingModel&#x60; **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT.</value>
        [DataMember(Name = "networkTxReference", EmitDefaultValue = false)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the &#x60;selectedBrand&#x60; value to specify how to process the transaction.
        /// </summary>
        /// <value>Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the &#x60;selectedBrand&#x60; value to specify how to process the transaction.</value>
        [DataMember(Name = "overwriteBrand", EmitDefaultValue = false)]
        public string OverwriteBrand { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 13 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 13 characters.</value>
        [DataMember(Name = "subMerchantCity", EmitDefaultValue = false)]
        public string SubMerchantCity { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant&#39;s address. * Format: alpha-numeric. * Fixed length: 3 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant&#39;s address. * Format: alpha-numeric. * Fixed length: 3 characters.</value>
        [DataMember(Name = "subMerchantCountry", EmitDefaultValue = false)]
        public string SubMerchantCountry { get; set; }

        /// <summary>
        /// This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.  A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator. * Format: alpha-numeric. * Fixed length: 15 characters.
        /// </summary>
        /// <value>This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.  A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator. * Format: alpha-numeric. * Fixed length: 15 characters.</value>
        [DataMember(Name = "subMerchantID", EmitDefaultValue = false)]
        public string SubMerchantID { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant. * Format: alpha-numeric. * Maximum length: 22 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant. * Format: alpha-numeric. * Maximum length: 22 characters.</value>
        [DataMember(Name = "subMerchantName", EmitDefaultValue = false)]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 10 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 10 characters.</value>
        [DataMember(Name = "subMerchantPostalCode", EmitDefaultValue = false)]
        public string SubMerchantPostalCode { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 3 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 3 characters.</value>
        [DataMember(Name = "subMerchantState", EmitDefaultValue = false)]
        public string SubMerchantState { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 60 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant&#39;s address. * Format: alpha-numeric. * Maximum length: 60 characters.</value>
        [DataMember(Name = "subMerchantStreet", EmitDefaultValue = false)]
        public string SubMerchantStreet { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant. * Format: alpha-numeric. * Fixed length: 11 or 14 characters.
        /// </summary>
        /// <value>This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant. * Format: alpha-numeric. * Fixed length: 11 or 14 characters.</value>
        [DataMember(Name = "subMerchantTaxId", EmitDefaultValue = false)]
        public string SubMerchantTaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataCommon {\n");
            sb.Append("  RequestedTestErrorResponseCode: ").Append(RequestedTestErrorResponseCode).Append("\n");
            sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
            sb.Append("  CustomRoutingFlag: ").Append(CustomRoutingFlag).Append("\n");
            sb.Append("  IndustryUsage: ").Append(IndustryUsage).Append("\n");
            sb.Append("  NetworkTxReference: ").Append(NetworkTxReference).Append("\n");
            sb.Append("  OverwriteBrand: ").Append(OverwriteBrand).Append("\n");
            sb.Append("  SubMerchantCity: ").Append(SubMerchantCity).Append("\n");
            sb.Append("  SubMerchantCountry: ").Append(SubMerchantCountry).Append("\n");
            sb.Append("  SubMerchantID: ").Append(SubMerchantID).Append("\n");
            sb.Append("  SubMerchantName: ").Append(SubMerchantName).Append("\n");
            sb.Append("  SubMerchantPostalCode: ").Append(SubMerchantPostalCode).Append("\n");
            sb.Append("  SubMerchantState: ").Append(SubMerchantState).Append("\n");
            sb.Append("  SubMerchantStreet: ").Append(SubMerchantStreet).Append("\n");
            sb.Append("  SubMerchantTaxId: ").Append(SubMerchantTaxId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalDataCommon);
        }

        /// <summary>
        /// Returns true if AdditionalDataCommon instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataCommon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataCommon input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestedTestErrorResponseCode == input.RequestedTestErrorResponseCode ||
                    (this.RequestedTestErrorResponseCode != null &&
                    this.RequestedTestErrorResponseCode.Equals(input.RequestedTestErrorResponseCode))
                ) && 
                (
                    this.AuthorisationType == input.AuthorisationType ||
                    (this.AuthorisationType != null &&
                    this.AuthorisationType.Equals(input.AuthorisationType))
                ) && 
                (
                    this.CustomRoutingFlag == input.CustomRoutingFlag ||
                    (this.CustomRoutingFlag != null &&
                    this.CustomRoutingFlag.Equals(input.CustomRoutingFlag))
                ) && 
                (
                    this.IndustryUsage == input.IndustryUsage ||
                    this.IndustryUsage.Equals(input.IndustryUsage)
                ) && 
                (
                    this.NetworkTxReference == input.NetworkTxReference ||
                    (this.NetworkTxReference != null &&
                    this.NetworkTxReference.Equals(input.NetworkTxReference))
                ) && 
                (
                    this.OverwriteBrand == input.OverwriteBrand ||
                    (this.OverwriteBrand != null &&
                    this.OverwriteBrand.Equals(input.OverwriteBrand))
                ) && 
                (
                    this.SubMerchantCity == input.SubMerchantCity ||
                    (this.SubMerchantCity != null &&
                    this.SubMerchantCity.Equals(input.SubMerchantCity))
                ) && 
                (
                    this.SubMerchantCountry == input.SubMerchantCountry ||
                    (this.SubMerchantCountry != null &&
                    this.SubMerchantCountry.Equals(input.SubMerchantCountry))
                ) && 
                (
                    this.SubMerchantID == input.SubMerchantID ||
                    (this.SubMerchantID != null &&
                    this.SubMerchantID.Equals(input.SubMerchantID))
                ) && 
                (
                    this.SubMerchantName == input.SubMerchantName ||
                    (this.SubMerchantName != null &&
                    this.SubMerchantName.Equals(input.SubMerchantName))
                ) && 
                (
                    this.SubMerchantPostalCode == input.SubMerchantPostalCode ||
                    (this.SubMerchantPostalCode != null &&
                    this.SubMerchantPostalCode.Equals(input.SubMerchantPostalCode))
                ) && 
                (
                    this.SubMerchantState == input.SubMerchantState ||
                    (this.SubMerchantState != null &&
                    this.SubMerchantState.Equals(input.SubMerchantState))
                ) && 
                (
                    this.SubMerchantStreet == input.SubMerchantStreet ||
                    (this.SubMerchantStreet != null &&
                    this.SubMerchantStreet.Equals(input.SubMerchantStreet))
                ) && 
                (
                    this.SubMerchantTaxId == input.SubMerchantTaxId ||
                    (this.SubMerchantTaxId != null &&
                    this.SubMerchantTaxId.Equals(input.SubMerchantTaxId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RequestedTestErrorResponseCode != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedTestErrorResponseCode.GetHashCode();
                }
                if (this.AuthorisationType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorisationType.GetHashCode();
                }
                if (this.CustomRoutingFlag != null)
                {
                    hashCode = (hashCode * 59) + this.CustomRoutingFlag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IndustryUsage.GetHashCode();
                if (this.NetworkTxReference != null)
                {
                    hashCode = (hashCode * 59) + this.NetworkTxReference.GetHashCode();
                }
                if (this.OverwriteBrand != null)
                {
                    hashCode = (hashCode * 59) + this.OverwriteBrand.GetHashCode();
                }
                if (this.SubMerchantCity != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantCity.GetHashCode();
                }
                if (this.SubMerchantCountry != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantCountry.GetHashCode();
                }
                if (this.SubMerchantID != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantID.GetHashCode();
                }
                if (this.SubMerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantName.GetHashCode();
                }
                if (this.SubMerchantPostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantPostalCode.GetHashCode();
                }
                if (this.SubMerchantState != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantState.GetHashCode();
                }
                if (this.SubMerchantStreet != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantStreet.GetHashCode();
                }
                if (this.SubMerchantTaxId != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantTaxId.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
