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
    /// Information about the action to take.
    /// </summary>
    [DataContract]
    public partial class ScheduleTerminalActionsRequestActionDetails :  IEquatable<ScheduleTerminalActionsRequestActionDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of terminal action: Uninstall an Android certificate.
        /// </summary>
        /// <value>Type of terminal action: Uninstall an Android certificate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum UninstallAndroidCertificate for value: UninstallAndroidCertificate
            /// </summary>
            [EnumMember(Value = "UninstallAndroidCertificate")]
            UninstallAndroidCertificate = 1

        }

        /// <summary>
        /// Type of terminal action: Uninstall an Android certificate.
        /// </summary>
        /// <value>Type of terminal action: Uninstall an Android certificate.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTerminalActionsRequestActionDetails" /> class.
        /// </summary>
        /// <param name="appId">The unique identifier of the app to be uninstalled..</param>
        /// <param name="type">Type of terminal action: Uninstall an Android certificate. (default to TypeEnum.UninstallAndroidCertificate).</param>
        /// <param name="certificateId">The unique identifier of the certificate to be uninstalled..</param>
        /// <param name="updateAtFirstMaintenanceCall">Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time..</param>
        public ScheduleTerminalActionsRequestActionDetails(string appId = default(string), TypeEnum? type = TypeEnum.UninstallAndroidCertificate, string certificateId = default(string), bool updateAtFirstMaintenanceCall = default(bool))
        {
            this.AppId = appId;
            this.Type = type;
            this.CertificateId = certificateId;
            this.UpdateAtFirstMaintenanceCall = updateAtFirstMaintenanceCall;
        }

        /// <summary>
        /// The unique identifier of the app to be uninstalled.
        /// </summary>
        /// <value>The unique identifier of the app to be uninstalled.</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }


        /// <summary>
        /// The unique identifier of the certificate to be uninstalled.
        /// </summary>
        /// <value>The unique identifier of the certificate to be uninstalled.</value>
        [DataMember(Name="certificateId", EmitDefaultValue=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.
        /// </summary>
        /// <value>Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.</value>
        [DataMember(Name="updateAtFirstMaintenanceCall", EmitDefaultValue=false)]
        public bool UpdateAtFirstMaintenanceCall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleTerminalActionsRequestActionDetails {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CertificateId: ").Append(CertificateId).Append("\n");
            sb.Append("  UpdateAtFirstMaintenanceCall: ").Append(UpdateAtFirstMaintenanceCall).Append("\n");
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
            return this.Equals(input as ScheduleTerminalActionsRequestActionDetails);
        }

        /// <summary>
        /// Returns true if ScheduleTerminalActionsRequestActionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleTerminalActionsRequestActionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleTerminalActionsRequestActionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CertificateId == input.CertificateId ||
                    (this.CertificateId != null &&
                    this.CertificateId.Equals(input.CertificateId))
                ) && 
                (
                    this.UpdateAtFirstMaintenanceCall == input.UpdateAtFirstMaintenanceCall ||
                    (this.UpdateAtFirstMaintenanceCall != null &&
                    this.UpdateAtFirstMaintenanceCall.Equals(input.UpdateAtFirstMaintenanceCall))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CertificateId != null)
                    hashCode = hashCode * 59 + this.CertificateId.GetHashCode();
                if (this.UpdateAtFirstMaintenanceCall != null)
                    hashCode = hashCode * 59 + this.UpdateAtFirstMaintenanceCall.GetHashCode();
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
