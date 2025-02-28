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
    /// ExternalTerminalAction
    /// </summary>
    [DataContract]
    public partial class ExternalTerminalAction :  IEquatable<ExternalTerminalAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTerminalAction" /> class.
        /// </summary>
        /// <param name="actionType">The type of terminal action: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, or **UninstallAndroidCertificate**..</param>
        /// <param name="config">Technical information about the terminal action..</param>
        /// <param name="confirmedAt">The date and time when the action was carried out..</param>
        /// <param name="id">The unique ID of the terminal action..</param>
        /// <param name="result">The result message for the action..</param>
        /// <param name="scheduledAt">The date and time when the action was scheduled to happen..</param>
        /// <param name="status">The status of the terminal action: **pending**, **successful**, **failed**, **cancelled**, or **tryLater**..</param>
        /// <param name="terminalId">The unique ID of the terminal that the action applies to..</param>
        public ExternalTerminalAction(string actionType = default(string), string config = default(string), DateTime confirmedAt = default(DateTime), string id = default(string), string result = default(string), DateTime scheduledAt = default(DateTime), string status = default(string), string terminalId = default(string))
        {
            this.ActionType = actionType;
            this.Config = config;
            this.ConfirmedAt = confirmedAt;
            this.Id = id;
            this.Result = result;
            this.ScheduledAt = scheduledAt;
            this.Status = status;
            this.TerminalId = terminalId;
        }

        /// <summary>
        /// The type of terminal action: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, or **UninstallAndroidCertificate**.
        /// </summary>
        /// <value>The type of terminal action: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, or **UninstallAndroidCertificate**.</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// Technical information about the terminal action.
        /// </summary>
        /// <value>Technical information about the terminal action.</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public string Config { get; set; }

        /// <summary>
        /// The date and time when the action was carried out.
        /// </summary>
        /// <value>The date and time when the action was carried out.</value>
        [DataMember(Name="confirmedAt", EmitDefaultValue=false)]
        public DateTime ConfirmedAt { get; set; }

        /// <summary>
        /// The unique ID of the terminal action.
        /// </summary>
        /// <value>The unique ID of the terminal action.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The result message for the action.
        /// </summary>
        /// <value>The result message for the action.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// The date and time when the action was scheduled to happen.
        /// </summary>
        /// <value>The date and time when the action was scheduled to happen.</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public DateTime ScheduledAt { get; set; }

        /// <summary>
        /// The status of the terminal action: **pending**, **successful**, **failed**, **cancelled**, or **tryLater**.
        /// </summary>
        /// <value>The status of the terminal action: **pending**, **successful**, **failed**, **cancelled**, or **tryLater**.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the terminal that the action applies to.
        /// </summary>
        /// <value>The unique ID of the terminal that the action applies to.</value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalTerminalAction {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  ConfirmedAt: ").Append(ConfirmedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
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
            return this.Equals(input as ExternalTerminalAction);
        }

        /// <summary>
        /// Returns true if ExternalTerminalAction instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalTerminalAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTerminalAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.ConfirmedAt == input.ConfirmedAt ||
                    (this.ConfirmedAt != null &&
                    this.ConfirmedAt.Equals(input.ConfirmedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
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
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.ConfirmedAt != null)
                    hashCode = hashCode * 59 + this.ConfirmedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
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
