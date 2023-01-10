/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// OnboardingThemes
    /// </summary>
    [DataContract]
    public partial class OnboardingThemes :  IEquatable<OnboardingThemes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingThemes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnboardingThemes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingThemes" /> class.
        /// </summary>
        /// <param name="next">The next page. Only present if there is a next page..</param>
        /// <param name="previous">The previous page. Only present if there is a previous page..</param>
        /// <param name="themes">List of onboarding themes. (required).</param>
        public OnboardingThemes(string next = default(string), string previous = default(string), List<OnboardingTheme> themes = default(List<OnboardingTheme>))
        {
            this.Next = next;
            this.Previous = previous;
            this.Themes = themes;
        }

        /// <summary>
        /// The next page. Only present if there is a next page.
        /// </summary>
        /// <value>The next page. Only present if there is a next page.</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// The previous page. Only present if there is a previous page.
        /// </summary>
        /// <value>The previous page. Only present if there is a previous page.</value>
        [DataMember(Name="previous", EmitDefaultValue=false)]
        public string Previous { get; set; }

        /// <summary>
        /// List of onboarding themes.
        /// </summary>
        /// <value>List of onboarding themes.</value>
        [DataMember(Name="themes", EmitDefaultValue=true)]
        public List<OnboardingTheme> Themes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OnboardingThemes {\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
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
            return this.Equals(input as OnboardingThemes);
        }

        /// <summary>
        /// Returns true if OnboardingThemes instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingThemes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingThemes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Previous == input.Previous ||
                    (this.Previous != null &&
                    this.Previous.Equals(input.Previous))
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
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
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Previous != null)
                    hashCode = hashCode * 59 + this.Previous.GetHashCode();
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
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
