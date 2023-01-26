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
    /// MerchantDevice
    /// </summary>
    [DataContract(Name = "MerchantDevice")]
    public partial class MerchantDevice : IEquatable<MerchantDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantDevice" /> class.
        /// </summary>
        /// <param name="os">Operating system running on the merchant device..</param>
        /// <param name="osVersion">Version of the operating system on the merchant device..</param>
        /// <param name="reference">Merchant device reference..</param>
        public MerchantDevice(string os = default(string), string osVersion = default(string), string reference = default(string))
        {
            this.Os = os;
            this.OsVersion = osVersion;
            this.Reference = reference;
        }

        /// <summary>
        /// Operating system running on the merchant device.
        /// </summary>
        /// <value>Operating system running on the merchant device.</value>
        [DataMember(Name = "os", EmitDefaultValue = false)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the merchant device.
        /// </summary>
        /// <value>Version of the operating system on the merchant device.</value>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Merchant device reference.
        /// </summary>
        /// <value>Merchant device reference.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantDevice {\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
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
            return this.Equals(input as MerchantDevice);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantDevice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
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
                if (this.Os != null)
                {
                    hashCode = (hashCode * 59) + this.Os.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
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
