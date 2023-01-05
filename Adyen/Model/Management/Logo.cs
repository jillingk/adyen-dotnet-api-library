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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Logo
    /// </summary>
    [DataContract]
    public partial class Logo :  IEquatable<Logo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logo" /> class.
        /// </summary>
        /// <param name="data">The image file, converted to a Base64-encoded string, of the logo to be shown on the terminal..</param>
        public Logo(string data = default(string))
        {
            this.Data = data;
        }

        /// <summary>
        /// The image file, converted to a Base64-encoded string, of the logo to be shown on the terminal.
        /// </summary>
        /// <value>The image file, converted to a Base64-encoded string, of the logo to be shown on the terminal.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Logo {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as Logo);
        }

        /// <summary>
        /// Returns true if Logo instances are equal
        /// </summary>
        /// <param name="input">Instance of Logo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Logo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
            // Data (string) maxLength
            if(this.Data != null && this.Data.Length > 350000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be less than 350000.", new [] { "Data" });
            }


            yield break;
        }
    }

}
