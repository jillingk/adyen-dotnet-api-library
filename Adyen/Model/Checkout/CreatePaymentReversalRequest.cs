/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CreatePaymentReversalRequest
    /// </summary>
    [DataContract(Name = "CreatePaymentReversalRequest")]
    public partial class CreatePaymentReversalRequest : IEquatable<CreatePaymentReversalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentReversalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePaymentReversalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentReversalRequest" /> class.
        /// </summary>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="reference">Your reference for the reversal request. Maximum length: 80 characters..</param>
        public CreatePaymentReversalRequest(string merchantAccount = default(string), string reference = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
        }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference for the reversal request. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the reversal request. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePaymentReversalRequest {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as CreatePaymentReversalRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentReversalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePaymentReversalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentReversalRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
