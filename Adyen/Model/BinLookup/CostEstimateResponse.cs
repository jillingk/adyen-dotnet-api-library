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
    /// CostEstimateResponse
    /// </summary>
    [DataContract]
    public partial class CostEstimateResponse :  IEquatable<CostEstimateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateResponse" /> class.
        /// </summary>
        /// <param name="cardBin">cardBin.</param>
        /// <param name="costEstimateAmount">costEstimateAmount.</param>
        /// <param name="costEstimateReference">Adyen&#39;s 16-character reference associated with the request..</param>
        /// <param name="resultCode">The result of the cost estimation..</param>
        /// <param name="surchargeType">Indicates the way the charges can be passed on to the cardholder. The following values are possible: * &#x60;ZERO&#x60; - the charges are not allowed to pass on * &#x60;PASSTHROUGH&#x60; - the charges can be passed on * &#x60;UNLIMITED&#x60; - there is no limit on how much surcharge is passed on.</param>
        public CostEstimateResponse(CardBin cardBin = default(CardBin), Amount costEstimateAmount = default(Amount), string costEstimateReference = default(string), string resultCode = default(string), string surchargeType = default(string))
        {
            this.CardBin = cardBin;
            this.CostEstimateAmount = costEstimateAmount;
            this.CostEstimateReference = costEstimateReference;
            this.ResultCode = resultCode;
            this.SurchargeType = surchargeType;
        }

        /// <summary>
        /// Gets or Sets CardBin
        /// </summary>
        [DataMember(Name="cardBin", EmitDefaultValue=false)]
        public CardBin CardBin { get; set; }

        /// <summary>
        /// Gets or Sets CostEstimateAmount
        /// </summary>
        [DataMember(Name="costEstimateAmount", EmitDefaultValue=false)]
        public Amount CostEstimateAmount { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character reference associated with the request.
        /// </summary>
        /// <value>Adyen&#39;s 16-character reference associated with the request.</value>
        [DataMember(Name="costEstimateReference", EmitDefaultValue=false)]
        public string CostEstimateReference { get; set; }

        /// <summary>
        /// The result of the cost estimation.
        /// </summary>
        /// <value>The result of the cost estimation.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Indicates the way the charges can be passed on to the cardholder. The following values are possible: * &#x60;ZERO&#x60; - the charges are not allowed to pass on * &#x60;PASSTHROUGH&#x60; - the charges can be passed on * &#x60;UNLIMITED&#x60; - there is no limit on how much surcharge is passed on
        /// </summary>
        /// <value>Indicates the way the charges can be passed on to the cardholder. The following values are possible: * &#x60;ZERO&#x60; - the charges are not allowed to pass on * &#x60;PASSTHROUGH&#x60; - the charges can be passed on * &#x60;UNLIMITED&#x60; - there is no limit on how much surcharge is passed on</value>
        [DataMember(Name="surchargeType", EmitDefaultValue=false)]
        public string SurchargeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CostEstimateResponse {\n");
            sb.Append("  CardBin: ").Append(CardBin).Append("\n");
            sb.Append("  CostEstimateAmount: ").Append(CostEstimateAmount).Append("\n");
            sb.Append("  CostEstimateReference: ").Append(CostEstimateReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  SurchargeType: ").Append(SurchargeType).Append("\n");
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
            return this.Equals(input as CostEstimateResponse);
        }

        /// <summary>
        /// Returns true if CostEstimateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CostEstimateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostEstimateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardBin == input.CardBin ||
                    (this.CardBin != null &&
                    this.CardBin.Equals(input.CardBin))
                ) && 
                (
                    this.CostEstimateAmount == input.CostEstimateAmount ||
                    (this.CostEstimateAmount != null &&
                    this.CostEstimateAmount.Equals(input.CostEstimateAmount))
                ) && 
                (
                    this.CostEstimateReference == input.CostEstimateReference ||
                    (this.CostEstimateReference != null &&
                    this.CostEstimateReference.Equals(input.CostEstimateReference))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.SurchargeType == input.SurchargeType ||
                    (this.SurchargeType != null &&
                    this.SurchargeType.Equals(input.SurchargeType))
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
                if (this.CardBin != null)
                    hashCode = hashCode * 59 + this.CardBin.GetHashCode();
                if (this.CostEstimateAmount != null)
                    hashCode = hashCode * 59 + this.CostEstimateAmount.GetHashCode();
                if (this.CostEstimateReference != null)
                    hashCode = hashCode * 59 + this.CostEstimateReference.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.SurchargeType != null)
                    hashCode = hashCode * 59 + this.SurchargeType.GetHashCode();
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
