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
    /// ThreeDSAvailabilityResponse
    /// </summary>
    [DataContract]
    public partial class ThreeDSAvailabilityResponse :  IEquatable<ThreeDSAvailabilityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSAvailabilityResponse" /> class.
        /// </summary>
        /// <param name="binDetails">binDetails.</param>
        /// <param name="dsPublicKeys">List of Directory Server (DS) public keys..</param>
        /// <param name="threeDS1Supported">Indicator if 3D Secure 1 is supported..</param>
        /// <param name="threeDS2CardRangeDetails">List of brand and card range pairs..</param>
        /// <param name="threeDS2supported">Indicator if 3D Secure 2 is supported..</param>
        public ThreeDSAvailabilityResponse(BinDetail binDetails = default(BinDetail), List<DSPublicKeyDetail> dsPublicKeys = default(List<DSPublicKeyDetail>), bool threeDS1Supported = default(bool), List<ThreeDS2CardRangeDetail> threeDS2CardRangeDetails = default(List<ThreeDS2CardRangeDetail>), bool threeDS2supported = default(bool))
        {
            this.BinDetails = binDetails;
            this.DsPublicKeys = dsPublicKeys;
            this.ThreeDS1Supported = threeDS1Supported;
            this.ThreeDS2CardRangeDetails = threeDS2CardRangeDetails;
            this.ThreeDS2supported = threeDS2supported;
        }

        /// <summary>
        /// Gets or Sets BinDetails
        /// </summary>
        [DataMember(Name="binDetails", EmitDefaultValue=false)]
        public BinDetail BinDetails { get; set; }

        /// <summary>
        /// List of Directory Server (DS) public keys.
        /// </summary>
        /// <value>List of Directory Server (DS) public keys.</value>
        [DataMember(Name="dsPublicKeys", EmitDefaultValue=false)]
        public List<DSPublicKeyDetail> DsPublicKeys { get; set; }

        /// <summary>
        /// Indicator if 3D Secure 1 is supported.
        /// </summary>
        /// <value>Indicator if 3D Secure 1 is supported.</value>
        [DataMember(Name="threeDS1Supported", EmitDefaultValue=false)]
        public bool ThreeDS1Supported { get; set; }

        /// <summary>
        /// List of brand and card range pairs.
        /// </summary>
        /// <value>List of brand and card range pairs.</value>
        [DataMember(Name="threeDS2CardRangeDetails", EmitDefaultValue=false)]
        public List<ThreeDS2CardRangeDetail> ThreeDS2CardRangeDetails { get; set; }

        /// <summary>
        /// Indicator if 3D Secure 2 is supported.
        /// </summary>
        /// <value>Indicator if 3D Secure 2 is supported.</value>
        [DataMember(Name="threeDS2supported", EmitDefaultValue=false)]
        public bool ThreeDS2supported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDSAvailabilityResponse {\n");
            sb.Append("  BinDetails: ").Append(BinDetails).Append("\n");
            sb.Append("  DsPublicKeys: ").Append(DsPublicKeys).Append("\n");
            sb.Append("  ThreeDS1Supported: ").Append(ThreeDS1Supported).Append("\n");
            sb.Append("  ThreeDS2CardRangeDetails: ").Append(ThreeDS2CardRangeDetails).Append("\n");
            sb.Append("  ThreeDS2supported: ").Append(ThreeDS2supported).Append("\n");
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
            return this.Equals(input as ThreeDSAvailabilityResponse);
        }

        /// <summary>
        /// Returns true if ThreeDSAvailabilityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSAvailabilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSAvailabilityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BinDetails == input.BinDetails ||
                    (this.BinDetails != null &&
                    this.BinDetails.Equals(input.BinDetails))
                ) && 
                (
                    this.DsPublicKeys == input.DsPublicKeys ||
                    this.DsPublicKeys != null &&
                    input.DsPublicKeys != null &&
                    this.DsPublicKeys.SequenceEqual(input.DsPublicKeys)
                ) && 
                (
                    this.ThreeDS1Supported == input.ThreeDS1Supported ||
                    (this.ThreeDS1Supported != null &&
                    this.ThreeDS1Supported.Equals(input.ThreeDS1Supported))
                ) && 
                (
                    this.ThreeDS2CardRangeDetails == input.ThreeDS2CardRangeDetails ||
                    this.ThreeDS2CardRangeDetails != null &&
                    input.ThreeDS2CardRangeDetails != null &&
                    this.ThreeDS2CardRangeDetails.SequenceEqual(input.ThreeDS2CardRangeDetails)
                ) && 
                (
                    this.ThreeDS2supported == input.ThreeDS2supported ||
                    (this.ThreeDS2supported != null &&
                    this.ThreeDS2supported.Equals(input.ThreeDS2supported))
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
                if (this.BinDetails != null)
                    hashCode = hashCode * 59 + this.BinDetails.GetHashCode();
                if (this.DsPublicKeys != null)
                    hashCode = hashCode * 59 + this.DsPublicKeys.GetHashCode();
                if (this.ThreeDS1Supported != null)
                    hashCode = hashCode * 59 + this.ThreeDS1Supported.GetHashCode();
                if (this.ThreeDS2CardRangeDetails != null)
                    hashCode = hashCode * 59 + this.ThreeDS2CardRangeDetails.GetHashCode();
                if (this.ThreeDS2supported != null)
                    hashCode = hashCode * 59 + this.ThreeDS2supported.GetHashCode();
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
