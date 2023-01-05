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
    /// Nexo
    /// </summary>
    [DataContract]
    public partial class Nexo :  IEquatable<Nexo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nexo" /> class.
        /// </summary>
        /// <param name="eventUrls">eventUrls.</param>
        /// <param name="nexoEventUrls">@deprecated One or more URLs to send event messages to when using Terminal API..</param>
        public Nexo(EventUrl eventUrls = default(EventUrl), List<string> nexoEventUrls = default(List<string>))
        {
            this.EventUrls = eventUrls;
            this.NexoEventUrls = nexoEventUrls;
        }

        /// <summary>
        /// Gets or Sets EventUrls
        /// </summary>
        [DataMember(Name="eventUrls", EmitDefaultValue=false)]
        public EventUrl EventUrls { get; set; }

        /// <summary>
        /// @deprecated One or more URLs to send event messages to when using Terminal API.
        /// </summary>
        /// <value>@deprecated One or more URLs to send event messages to when using Terminal API.</value>
        [DataMember(Name="nexoEventUrls", EmitDefaultValue=false)]
        [Obsolete]
        public List<string> NexoEventUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Nexo {\n");
            sb.Append("  EventUrls: ").Append(EventUrls).Append("\n");
            sb.Append("  NexoEventUrls: ").Append(NexoEventUrls).Append("\n");
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
            return this.Equals(input as Nexo);
        }

        /// <summary>
        /// Returns true if Nexo instances are equal
        /// </summary>
        /// <param name="input">Instance of Nexo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Nexo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventUrls == input.EventUrls ||
                    (this.EventUrls != null &&
                    this.EventUrls.Equals(input.EventUrls))
                ) && 
                (
                    this.NexoEventUrls == input.NexoEventUrls ||
                    this.NexoEventUrls != null &&
                    input.NexoEventUrls != null &&
                    this.NexoEventUrls.SequenceEqual(input.NexoEventUrls)
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
                if (this.EventUrls != null)
                    hashCode = hashCode * 59 + this.EventUrls.GetHashCode();
                if (this.NexoEventUrls != null)
                    hashCode = hashCode * 59 + this.NexoEventUrls.GetHashCode();
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
