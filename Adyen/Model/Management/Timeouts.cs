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
    /// Timeouts
    /// </summary>
    [DataContract]
    public partial class Timeouts :  IEquatable<Timeouts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts" /> class.
        /// </summary>
        /// <param name="fromActiveToSleep">Indicates the number of seconds of inactivity after which the terminal display goes into sleep mode..</param>
        public Timeouts(int fromActiveToSleep = default(int))
        {
            this.FromActiveToSleep = fromActiveToSleep;
        }

        /// <summary>
        /// Indicates the number of seconds of inactivity after which the terminal display goes into sleep mode.
        /// </summary>
        /// <value>Indicates the number of seconds of inactivity after which the terminal display goes into sleep mode.</value>
        [DataMember(Name="fromActiveToSleep", EmitDefaultValue=false)]
        public int FromActiveToSleep { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timeouts {\n");
            sb.Append("  FromActiveToSleep: ").Append(FromActiveToSleep).Append("\n");
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
            return this.Equals(input as Timeouts);
        }

        /// <summary>
        /// Returns true if Timeouts instances are equal
        /// </summary>
        /// <param name="input">Instance of Timeouts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Timeouts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromActiveToSleep == input.FromActiveToSleep ||
                    (this.FromActiveToSleep != null &&
                    this.FromActiveToSleep.Equals(input.FromActiveToSleep))
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
                if (this.FromActiveToSleep != null)
                    hashCode = hashCode * 59 + this.FromActiveToSleep.GetHashCode();
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
