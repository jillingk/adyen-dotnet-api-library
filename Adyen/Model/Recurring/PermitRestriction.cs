/*
* Adyen Recurring API
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

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// PermitRestriction
    /// </summary>
    [DataContract(Name = "PermitRestriction")]
    public partial class PermitRestriction : IEquatable<PermitRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermitRestriction" /> class.
        /// </summary>
        /// <param name="maxAmount">maxAmount.</param>
        /// <param name="singleTransactionLimit">singleTransactionLimit.</param>
        /// <param name="singleUse">Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed..</param>
        public PermitRestriction(Amount maxAmount = default(Amount), Amount singleTransactionLimit = default(Amount), bool singleUse = default(bool))
        {
            this.MaxAmount = maxAmount;
            this.SingleTransactionLimit = singleTransactionLimit;
            this.SingleUse = singleUse;
        }

        /// <summary>
        /// Gets or Sets MaxAmount
        /// </summary>
        [DataMember(Name = "maxAmount", EmitDefaultValue = false)]
        public Amount MaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets SingleTransactionLimit
        /// </summary>
        [DataMember(Name = "singleTransactionLimit", EmitDefaultValue = false)]
        public Amount SingleTransactionLimit { get; set; }

        /// <summary>
        /// Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.
        /// </summary>
        /// <value>Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.</value>
        [DataMember(Name = "singleUse", EmitDefaultValue = false)]
        public bool SingleUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermitRestriction {\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  SingleTransactionLimit: ").Append(SingleTransactionLimit).Append("\n");
            sb.Append("  SingleUse: ").Append(SingleUse).Append("\n");
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
            return this.Equals(input as PermitRestriction);
        }

        /// <summary>
        /// Returns true if PermitRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of PermitRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermitRestriction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.SingleTransactionLimit == input.SingleTransactionLimit ||
                    (this.SingleTransactionLimit != null &&
                    this.SingleTransactionLimit.Equals(input.SingleTransactionLimit))
                ) && 
                (
                    this.SingleUse == input.SingleUse ||
                    this.SingleUse.Equals(input.SingleUse)
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
                if (this.MaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MaxAmount.GetHashCode();
                }
                if (this.SingleTransactionLimit != null)
                {
                    hashCode = (hashCode * 59) + this.SingleTransactionLimit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SingleUse.GetHashCode();
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
