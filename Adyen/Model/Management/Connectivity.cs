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
    /// Connectivity
    /// </summary>
    [DataContract]
    public partial class Connectivity :  IEquatable<Connectivity>, IValidatableObject
    {
        /// <summary>
        /// Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.  Possible values: * **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings. * **INVENTORY**: the SIM card is not activated. The terminal can&#39;t use cellular connectivity.
        /// </summary>
        /// <value>Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.  Possible values: * **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings. * **INVENTORY**: the SIM card is not activated. The terminal can&#39;t use cellular connectivity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SimcardStatusEnum
        {
            /// <summary>
            /// Enum ACTIVATED for value: ACTIVATED
            /// </summary>
            [EnumMember(Value = "ACTIVATED")]
            ACTIVATED = 1,

            /// <summary>
            /// Enum INVENTORY for value: INVENTORY
            /// </summary>
            [EnumMember(Value = "INVENTORY")]
            INVENTORY = 2

        }

        /// <summary>
        /// Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.  Possible values: * **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings. * **INVENTORY**: the SIM card is not activated. The terminal can&#39;t use cellular connectivity.
        /// </summary>
        /// <value>Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.  Possible values: * **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings. * **INVENTORY**: the SIM card is not activated. The terminal can&#39;t use cellular connectivity.</value>
        [DataMember(Name="simcardStatus", EmitDefaultValue=false)]
        public SimcardStatusEnum? SimcardStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connectivity" /> class.
        /// </summary>
        /// <param name="simcardStatus">Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.  Possible values: * **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings. * **INVENTORY**: the SIM card is not activated. The terminal can&#39;t use cellular connectivity..</param>
        public Connectivity(SimcardStatusEnum? simcardStatus = default(SimcardStatusEnum?))
        {
            this.SimcardStatus = simcardStatus;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Connectivity {\n");
            sb.Append("  SimcardStatus: ").Append(SimcardStatus).Append("\n");
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
            return this.Equals(input as Connectivity);
        }

        /// <summary>
        /// Returns true if Connectivity instances are equal
        /// </summary>
        /// <param name="input">Instance of Connectivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connectivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimcardStatus == input.SimcardStatus ||
                    (this.SimcardStatus != null &&
                    this.SimcardStatus.Equals(input.SimcardStatus))
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
                if (this.SimcardStatus != null)
                    hashCode = hashCode * 59 + this.SimcardStatus.GetHashCode();
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
