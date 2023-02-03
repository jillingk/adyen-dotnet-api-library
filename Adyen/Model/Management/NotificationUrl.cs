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
    /// NotificationUrl
    /// </summary>
    [DataContract]
    public partial class NotificationUrl :  IEquatable<NotificationUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationUrl" /> class.
        /// </summary>
        /// <param name="localUrls">One or more local URLs to send notifications to when using Terminal API..</param>
        /// <param name="publicUrls">One or more public URLs to send notifications to when using Terminal API..</param>
        public NotificationUrl(List<Url> localUrls = default(List<Url>), List<Url> publicUrls = default(List<Url>))
        {
            this.LocalUrls = localUrls;
            this.PublicUrls = publicUrls;
        }

        /// <summary>
        /// One or more local URLs to send notifications to when using Terminal API.
        /// </summary>
        /// <value>One or more local URLs to send notifications to when using Terminal API.</value>
        [DataMember(Name="localUrls", EmitDefaultValue=false)]
        public List<Url> LocalUrls { get; set; }

        /// <summary>
        /// One or more public URLs to send notifications to when using Terminal API.
        /// </summary>
        /// <value>One or more public URLs to send notifications to when using Terminal API.</value>
        [DataMember(Name="publicUrls", EmitDefaultValue=false)]
        public List<Url> PublicUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationUrl {\n");
            sb.Append("  LocalUrls: ").Append(LocalUrls).Append("\n");
            sb.Append("  PublicUrls: ").Append(PublicUrls).Append("\n");
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
            return this.Equals(input as NotificationUrl);
        }

        /// <summary>
        /// Returns true if NotificationUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalUrls == input.LocalUrls ||
                    this.LocalUrls != null &&
                    input.LocalUrls != null &&
                    this.LocalUrls.SequenceEqual(input.LocalUrls)
                ) && 
                (
                    this.PublicUrls == input.PublicUrls ||
                    this.PublicUrls != null &&
                    input.PublicUrls != null &&
                    this.PublicUrls.SequenceEqual(input.PublicUrls)
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
                if (this.LocalUrls != null)
                    hashCode = hashCode * 59 + this.LocalUrls.GetHashCode();
                if (this.PublicUrls != null)
                    hashCode = hashCode * 59 + this.PublicUrls.GetHashCode();
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
