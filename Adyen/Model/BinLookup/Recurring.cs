/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 52
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.Model.Client.OpenAPIDateConverter;

namespace Adyen.Model.BinLookup
{
    /// <summary>
    /// Recurring
    /// </summary>
    [DataContract]
    public partial class Recurring :  IEquatable<Recurring>, IValidatableObject
    {
        /// <summary>
        /// The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid). * &#x60;RECURRING&#x60; – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp). * &#x60;ONECLICK,RECURRING&#x60; – Payment details can be used regardless of whether the shopper is on your site or not. * &#x60;PAYOUT&#x60; – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts).
        /// </summary>
        /// <value>The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid). * &#x60;RECURRING&#x60; – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp). * &#x60;ONECLICK,RECURRING&#x60; – Payment details can be used regardless of whether the shopper is on your site or not. * &#x60;PAYOUT&#x60; – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractEnum
        {
            /// <summary>
            /// Enum ONECLICK for value: ONECLICK
            /// </summary>
            [EnumMember(Value = "ONECLICK")]
            ONECLICK = 1,

            /// <summary>
            /// Enum RECURRING for value: RECURRING
            /// </summary>
            [EnumMember(Value = "RECURRING")]
            RECURRING = 2,

            /// <summary>
            /// Enum PAYOUT for value: PAYOUT
            /// </summary>
            [EnumMember(Value = "PAYOUT")]
            PAYOUT = 3

        }

        /// <summary>
        /// The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid). * &#x60;RECURRING&#x60; – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp). * &#x60;ONECLICK,RECURRING&#x60; – Payment details can be used regardless of whether the shopper is on your site or not. * &#x60;PAYOUT&#x60; – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts).
        /// </summary>
        /// <value>The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid). * &#x60;RECURRING&#x60; – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp). * &#x60;ONECLICK,RECURRING&#x60; – Payment details can be used regardless of whether the shopper is on your site or not. * &#x60;PAYOUT&#x60; – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts).</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public ContractEnum? Contract { get; set; }
        /// <summary>
        /// The name of the token service.
        /// </summary>
        /// <value>The name of the token service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TokenServiceEnum
        {
            /// <summary>
            /// Enum VISATOKENSERVICE for value: VISATOKENSERVICE
            /// </summary>
            [EnumMember(Value = "VISATOKENSERVICE")]
            VISATOKENSERVICE = 1,

            /// <summary>
            /// Enum MCTOKENSERVICE for value: MCTOKENSERVICE
            /// </summary>
            [EnumMember(Value = "MCTOKENSERVICE")]
            MCTOKENSERVICE = 2

        }

        /// <summary>
        /// The name of the token service.
        /// </summary>
        /// <value>The name of the token service.</value>
        [DataMember(Name="tokenService", EmitDefaultValue=false)]
        public TokenServiceEnum? TokenService { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recurring" /> class.
        /// </summary>
        /// <param name="contract">The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid). * &#x60;RECURRING&#x60; – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp). * &#x60;ONECLICK,RECURRING&#x60; – Payment details can be used regardless of whether the shopper is on your site or not. * &#x60;PAYOUT&#x60; – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts)..</param>
        /// <param name="recurringDetailName">A descriptive name for this detail..</param>
        /// <param name="recurringExpiry">Date after which no further authorisations shall be performed. Only for 3D Secure 2..</param>
        /// <param name="recurringFrequency">Minimum number of days between authorisations. Only for 3D Secure 2..</param>
        /// <param name="tokenService">The name of the token service..</param>
        public Recurring(ContractEnum? contract = default(ContractEnum?), string recurringDetailName = default(string), DateTime recurringExpiry = default(DateTime), string recurringFrequency = default(string), TokenServiceEnum? tokenService = default(TokenServiceEnum?))
        {
            this.Contract = contract;
            this.RecurringDetailName = recurringDetailName;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.TokenService = tokenService;
        }


        /// <summary>
        /// A descriptive name for this detail.
        /// </summary>
        /// <value>A descriptive name for this detail.</value>
        [DataMember(Name="recurringDetailName", EmitDefaultValue=false)]
        public string RecurringDetailName { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
        [DataMember(Name="recurringExpiry", EmitDefaultValue=false)]
        public DateTime RecurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
        [DataMember(Name="recurringFrequency", EmitDefaultValue=false)]
        public string RecurringFrequency { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Recurring {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  RecurringDetailName: ").Append(RecurringDetailName).Append("\n");
            sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
            sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
            sb.Append("  TokenService: ").Append(TokenService).Append("\n");
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
            return this.Equals(input as Recurring);
        }

        /// <summary>
        /// Returns true if Recurring instances are equal
        /// </summary>
        /// <param name="input">Instance of Recurring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recurring input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.RecurringDetailName == input.RecurringDetailName ||
                    (this.RecurringDetailName != null &&
                    this.RecurringDetailName.Equals(input.RecurringDetailName))
                ) && 
                (
                    this.RecurringExpiry == input.RecurringExpiry ||
                    (this.RecurringExpiry != null &&
                    this.RecurringExpiry.Equals(input.RecurringExpiry))
                ) && 
                (
                    this.RecurringFrequency == input.RecurringFrequency ||
                    (this.RecurringFrequency != null &&
                    this.RecurringFrequency.Equals(input.RecurringFrequency))
                ) && 
                (
                    this.TokenService == input.TokenService ||
                    (this.TokenService != null &&
                    this.TokenService.Equals(input.TokenService))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.RecurringDetailName != null)
                    hashCode = hashCode * 59 + this.RecurringDetailName.GetHashCode();
                if (this.RecurringExpiry != null)
                    hashCode = hashCode * 59 + this.RecurringExpiry.GetHashCode();
                if (this.RecurringFrequency != null)
                    hashCode = hashCode * 59 + this.RecurringFrequency.GetHashCode();
                if (this.TokenService != null)
                    hashCode = hashCode * 59 + this.TokenService.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
