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
    /// Webhook
    /// </summary>
    [DataContract]
    public partial class Webhook :  IEquatable<Webhook>, IValidatableObject
    {
        /// <summary>
        /// Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** 
        /// </summary>
        /// <value>Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommunicationFormatEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            [EnumMember(Value = "HTTP")]
            HTTP = 1,

            /// <summary>
            /// Enum JSON for value: JSON
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON = 2,

            /// <summary>
            /// Enum SOAP for value: SOAP
            /// </summary>
            [EnumMember(Value = "SOAP")]
            SOAP = 3

        }

        /// <summary>
        /// Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** 
        /// </summary>
        /// <value>Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json** </value>
        [DataMember(Name="communicationFormat", EmitDefaultValue=true)]
        public CommunicationFormatEnum CommunicationFormat { get; set; }
        /// <summary>
        /// Shows how merchant accounts are included in company-level webhooks. Possible values: * **includeAccounts** * **excludeAccounts** * **allAccounts**: Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;.
        /// </summary>
        /// <value>Shows how merchant accounts are included in company-level webhooks. Possible values: * **includeAccounts** * **excludeAccounts** * **allAccounts**: Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FilterMerchantAccountTypeEnum
        {
            /// <summary>
            /// Enum EXCLUDELIST for value: EXCLUDE_LIST
            /// </summary>
            [EnumMember(Value = "EXCLUDE_LIST")]
            EXCLUDELIST = 1,

            /// <summary>
            /// Enum INCLUDEALL for value: INCLUDE_ALL
            /// </summary>
            [EnumMember(Value = "INCLUDE_ALL")]
            INCLUDEALL = 2,

            /// <summary>
            /// Enum INCLUDELIST for value: INCLUDE_LIST
            /// </summary>
            [EnumMember(Value = "INCLUDE_LIST")]
            INCLUDELIST = 3

        }

        /// <summary>
        /// Shows how merchant accounts are included in company-level webhooks. Possible values: * **includeAccounts** * **excludeAccounts** * **allAccounts**: Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;.
        /// </summary>
        /// <value>Shows how merchant accounts are included in company-level webhooks. Possible values: * **includeAccounts** * **excludeAccounts** * **allAccounts**: Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;.</value>
        [DataMember(Name="filterMerchantAccountType", EmitDefaultValue=false)]
        public FilterMerchantAccountTypeEnum? FilterMerchantAccountType { get; set; }
        /// <summary>
        /// Network type for Terminal API details webhooks.
        /// </summary>
        /// <value>Network type for Terminal API details webhooks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkTypeEnum
        {
            /// <summary>
            /// Enum LOCAL for value: LOCAL
            /// </summary>
            [EnumMember(Value = "LOCAL")]
            LOCAL = 1,

            /// <summary>
            /// Enum PUBLIC for value: PUBLIC
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            PUBLIC = 2

        }

        /// <summary>
        /// Network type for Terminal API details webhooks.
        /// </summary>
        /// <value>Network type for Terminal API details webhooks.</value>
        [DataMember(Name="networkType", EmitDefaultValue=false)]
        public NetworkTypeEnum? NetworkType { get; set; }
        /// <summary>
        /// SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.
        /// </summary>
        /// <value>SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SslVersionEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            [EnumMember(Value = "HTTP")]
            HTTP = 1,

            /// <summary>
            /// Enum SSL for value: SSL
            /// </summary>
            [EnumMember(Value = "SSL")]
            SSL = 2,

            /// <summary>
            /// Enum SSLV3 for value: SSLV3
            /// </summary>
            [EnumMember(Value = "SSLV3")]
            SSLV3 = 3,

            /// <summary>
            /// Enum SSLINSECURECIPHERS for value: SSL_INSECURE_CIPHERS
            /// </summary>
            [EnumMember(Value = "SSL_INSECURE_CIPHERS")]
            SSLINSECURECIPHERS = 4,

            /// <summary>
            /// Enum TLS for value: TLS
            /// </summary>
            [EnumMember(Value = "TLS")]
            TLS = 5,

            /// <summary>
            /// Enum TLSV1 for value: TLSV1
            /// </summary>
            [EnumMember(Value = "TLSV1")]
            TLSV1 = 6,

            /// <summary>
            /// Enum TLSV11 for value: TLSV1_1
            /// </summary>
            [EnumMember(Value = "TLSV1_1")]
            TLSV11 = 7,

            /// <summary>
            /// Enum TLSV12 for value: TLSV1_2
            /// </summary>
            [EnumMember(Value = "TLSV1_2")]
            TLSV12 = 8,

            /// <summary>
            /// Enum TLSV13 for value: TLSV1_3
            /// </summary>
            [EnumMember(Value = "TLSV1_3")]
            TLSV13 = 9,

            /// <summary>
            /// Enum TLSV1INSECURECIPHERS for value: TLSV1_INSECURE_CIPHERS
            /// </summary>
            [EnumMember(Value = "TLSV1_INSECURE_CIPHERS")]
            TLSV1INSECURECIPHERS = 10

        }

        /// <summary>
        /// SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.
        /// </summary>
        /// <value>SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**.</value>
        [DataMember(Name="sslVersion", EmitDefaultValue=false)]
        public SslVersionEnum? SslVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Webhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="acceptsExpiredCertificate">Indicates if expired SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="acceptsSelfSignedCertificate">Indicates if self-signed SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="acceptsUntrustedRootCertificate">Indicates if untrusted SSL certificates are accepted. Default value: **false**..</param>
        /// <param name="accountReference">Reference to the account the webook is set on..</param>
        /// <param name="active">Indicates if the webhook configuration is active. The field must be **true** for you to receive webhooks about events related an account. (required).</param>
        /// <param name="additionalSettings">additionalSettings.</param>
        /// <param name="certificateAlias">The alias of our SSL certificate. When you receive a notification from us, the alias from the HMAC signature will match this alias..</param>
        /// <param name="communicationFormat">Format or protocol for receiving webhooks. Possible values: * **soap** * **http** * **json**  (required).</param>
        /// <param name="description">Your description for this webhook configuration..</param>
        /// <param name="filterMerchantAccountType">Shows how merchant accounts are included in company-level webhooks. Possible values: * **includeAccounts** * **excludeAccounts** * **allAccounts**: Includes all merchant accounts, and does not require specifying &#x60;filterMerchantAccounts&#x60;..</param>
        /// <param name="filterMerchantAccounts">A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**..</param>
        /// <param name="hasError">Indicates if the webhook configuration has errors that need troubleshooting. If the value is **true**, troubleshoot the configuration using the [testing endpoint](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookid}/test)..</param>
        /// <param name="hasPassword">Indicates if the webhook is password protected..</param>
        /// <param name="hmacKeyCheckValue">The [checksum](https://en.wikipedia.org/wiki/Key_checksum_value) of the HMAC key generated for this webhook. You can use this value to uniquely identify the HMAC key configured for this webhook..</param>
        /// <param name="id">Unique identifier for this webhook..</param>
        /// <param name="networkType">Network type for Terminal API details webhooks..</param>
        /// <param name="populateSoapActionHeader">Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**..</param>
        /// <param name="sslVersion">SSL version to access the public webhook URL specified in the &#x60;url&#x60; field. Possible values: * **TLSv1.3** * **TLSv1.2** * **HTTP** - Only allowed on Test environment.  If not specified, the webhook will use &#x60;sslVersion&#x60;: **TLSv1.2**..</param>
        /// <param name="type">The type of webhook. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **terminal-api-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications). (required).</param>
        /// <param name="url">Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**. (required).</param>
        /// <param name="username">Username to access the webhook URL..</param>
        public Webhook(WebhookLinks links = default(WebhookLinks), bool acceptsExpiredCertificate = default(bool), bool acceptsSelfSignedCertificate = default(bool), bool acceptsUntrustedRootCertificate = default(bool), string accountReference = default(string), bool active = default(bool), AdditionalSettingsResponse additionalSettings = default(AdditionalSettingsResponse), string certificateAlias = default(string), CommunicationFormatEnum communicationFormat = default(CommunicationFormatEnum), string description = default(string), FilterMerchantAccountTypeEnum? filterMerchantAccountType = default(FilterMerchantAccountTypeEnum?), List<string> filterMerchantAccounts = default(List<string>), bool hasError = default(bool), bool hasPassword = default(bool), string hmacKeyCheckValue = default(string), string id = default(string), NetworkTypeEnum? networkType = default(NetworkTypeEnum?), bool populateSoapActionHeader = default(bool), SslVersionEnum? sslVersion = default(SslVersionEnum?), string type = default(string), string url = default(string), string username = default(string))
        {
            this.Links = links;
            this.AcceptsExpiredCertificate = acceptsExpiredCertificate;
            this.AcceptsSelfSignedCertificate = acceptsSelfSignedCertificate;
            this.AcceptsUntrustedRootCertificate = acceptsUntrustedRootCertificate;
            this.AccountReference = accountReference;
            this.Active = active;
            this.AdditionalSettings = additionalSettings;
            this.CertificateAlias = certificateAlias;
            this.CommunicationFormat = communicationFormat;
            this.Description = description;
            this.FilterMerchantAccountType = filterMerchantAccountType;
            this.FilterMerchantAccounts = filterMerchantAccounts;
            this.HasError = hasError;
            this.HasPassword = hasPassword;
            this.HmacKeyCheckValue = hmacKeyCheckValue;
            this.Id = id;
            this.NetworkType = networkType;
            this.PopulateSoapActionHeader = populateSoapActionHeader;
            this.SslVersion = sslVersion;
            this.Type = type;
            this.Url = url;
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public WebhookLinks Links { get; set; }

        /// <summary>
        /// Indicates if expired SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if expired SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name="acceptsExpiredCertificate", EmitDefaultValue=false)]
        public bool AcceptsExpiredCertificate { get; set; }

        /// <summary>
        /// Indicates if self-signed SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if self-signed SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name="acceptsSelfSignedCertificate", EmitDefaultValue=false)]
        public bool AcceptsSelfSignedCertificate { get; set; }

        /// <summary>
        /// Indicates if untrusted SSL certificates are accepted. Default value: **false**.
        /// </summary>
        /// <value>Indicates if untrusted SSL certificates are accepted. Default value: **false**.</value>
        [DataMember(Name="acceptsUntrustedRootCertificate", EmitDefaultValue=false)]
        public bool AcceptsUntrustedRootCertificate { get; set; }

        /// <summary>
        /// Reference to the account the webook is set on.
        /// </summary>
        /// <value>Reference to the account the webook is set on.</value>
        [DataMember(Name="accountReference", EmitDefaultValue=false)]
        public string AccountReference { get; set; }

        /// <summary>
        /// Indicates if the webhook configuration is active. The field must be **true** for you to receive webhooks about events related an account.
        /// </summary>
        /// <value>Indicates if the webhook configuration is active. The field must be **true** for you to receive webhooks about events related an account.</value>
        [DataMember(Name="active", EmitDefaultValue=true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalSettings
        /// </summary>
        [DataMember(Name="additionalSettings", EmitDefaultValue=false)]
        public AdditionalSettingsResponse AdditionalSettings { get; set; }

        /// <summary>
        /// The alias of our SSL certificate. When you receive a notification from us, the alias from the HMAC signature will match this alias.
        /// </summary>
        /// <value>The alias of our SSL certificate. When you receive a notification from us, the alias from the HMAC signature will match this alias.</value>
        [DataMember(Name="certificateAlias", EmitDefaultValue=false)]
        public string CertificateAlias { get; set; }


        /// <summary>
        /// Your description for this webhook configuration.
        /// </summary>
        /// <value>Your description for this webhook configuration.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**.
        /// </summary>
        /// <value>A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for &#x60;filterMerchantAccountType&#x60;.  Required if &#x60;filterMerchantAccountType&#x60; is either: * **includeAccounts** * **excludeAccounts**  Not needed for &#x60;filterMerchantAccountType&#x60;: **allAccounts**.</value>
        [DataMember(Name="filterMerchantAccounts", EmitDefaultValue=false)]
        public List<string> FilterMerchantAccounts { get; set; }

        /// <summary>
        /// Indicates if the webhook configuration has errors that need troubleshooting. If the value is **true**, troubleshoot the configuration using the [testing endpoint](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookid}/test).
        /// </summary>
        /// <value>Indicates if the webhook configuration has errors that need troubleshooting. If the value is **true**, troubleshoot the configuration using the [testing endpoint](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookid}/test).</value>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool HasError { get; set; }

        /// <summary>
        /// Indicates if the webhook is password protected.
        /// </summary>
        /// <value>Indicates if the webhook is password protected.</value>
        [DataMember(Name="hasPassword", EmitDefaultValue=false)]
        public bool HasPassword { get; set; }

        /// <summary>
        /// The [checksum](https://en.wikipedia.org/wiki/Key_checksum_value) of the HMAC key generated for this webhook. You can use this value to uniquely identify the HMAC key configured for this webhook.
        /// </summary>
        /// <value>The [checksum](https://en.wikipedia.org/wiki/Key_checksum_value) of the HMAC key generated for this webhook. You can use this value to uniquely identify the HMAC key configured for this webhook.</value>
        [DataMember(Name="hmacKeyCheckValue", EmitDefaultValue=false)]
        public string HmacKeyCheckValue { get; set; }

        /// <summary>
        /// Unique identifier for this webhook.
        /// </summary>
        /// <value>Unique identifier for this webhook.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**.
        /// </summary>
        /// <value>Indicates if the SOAP action header needs to be populated. Default value: **false**.  Only applies if &#x60;communicationFormat&#x60;: **soap**.</value>
        [DataMember(Name="populateSoapActionHeader", EmitDefaultValue=false)]
        public bool PopulateSoapActionHeader { get; set; }


        /// <summary>
        /// The type of webhook. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **terminal-api-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications).
        /// </summary>
        /// <value>The type of webhook. Possible values are:  - **standard** - **account-settings-notification** - **banktransfer-notification** - **boletobancario-notification** - **directdebit-notification** - **pending-notification** - **ideal-notification** - **ideal-pending-notification** - **report-notification** - **terminal-api-notification**  Find out more about [standard notification webhooks](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes) and [other types of notifications](https://docs.adyen.com/development-resources/webhooks/understand-notifications#other-notifications).</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**.
        /// </summary>
        /// <value>Public URL where webhooks will be sent, for example **https://www.domain.com/webhook-endpoint**.</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Username to access the webhook URL.
        /// </summary>
        /// <value>Username to access the webhook URL.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Webhook {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  AcceptsExpiredCertificate: ").Append(AcceptsExpiredCertificate).Append("\n");
            sb.Append("  AcceptsSelfSignedCertificate: ").Append(AcceptsSelfSignedCertificate).Append("\n");
            sb.Append("  AcceptsUntrustedRootCertificate: ").Append(AcceptsUntrustedRootCertificate).Append("\n");
            sb.Append("  AccountReference: ").Append(AccountReference).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AdditionalSettings: ").Append(AdditionalSettings).Append("\n");
            sb.Append("  CertificateAlias: ").Append(CertificateAlias).Append("\n");
            sb.Append("  CommunicationFormat: ").Append(CommunicationFormat).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FilterMerchantAccountType: ").Append(FilterMerchantAccountType).Append("\n");
            sb.Append("  FilterMerchantAccounts: ").Append(FilterMerchantAccounts).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
            sb.Append("  HmacKeyCheckValue: ").Append(HmacKeyCheckValue).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
            sb.Append("  PopulateSoapActionHeader: ").Append(PopulateSoapActionHeader).Append("\n");
            sb.Append("  SslVersion: ").Append(SslVersion).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as Webhook);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.AcceptsExpiredCertificate == input.AcceptsExpiredCertificate ||
                    (this.AcceptsExpiredCertificate != null &&
                    this.AcceptsExpiredCertificate.Equals(input.AcceptsExpiredCertificate))
                ) && 
                (
                    this.AcceptsSelfSignedCertificate == input.AcceptsSelfSignedCertificate ||
                    (this.AcceptsSelfSignedCertificate != null &&
                    this.AcceptsSelfSignedCertificate.Equals(input.AcceptsSelfSignedCertificate))
                ) && 
                (
                    this.AcceptsUntrustedRootCertificate == input.AcceptsUntrustedRootCertificate ||
                    (this.AcceptsUntrustedRootCertificate != null &&
                    this.AcceptsUntrustedRootCertificate.Equals(input.AcceptsUntrustedRootCertificate))
                ) && 
                (
                    this.AccountReference == input.AccountReference ||
                    (this.AccountReference != null &&
                    this.AccountReference.Equals(input.AccountReference))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.AdditionalSettings == input.AdditionalSettings ||
                    (this.AdditionalSettings != null &&
                    this.AdditionalSettings.Equals(input.AdditionalSettings))
                ) && 
                (
                    this.CertificateAlias == input.CertificateAlias ||
                    (this.CertificateAlias != null &&
                    this.CertificateAlias.Equals(input.CertificateAlias))
                ) && 
                (
                    this.CommunicationFormat == input.CommunicationFormat ||
                    (this.CommunicationFormat != null &&
                    this.CommunicationFormat.Equals(input.CommunicationFormat))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FilterMerchantAccountType == input.FilterMerchantAccountType ||
                    (this.FilterMerchantAccountType != null &&
                    this.FilterMerchantAccountType.Equals(input.FilterMerchantAccountType))
                ) && 
                (
                    this.FilterMerchantAccounts == input.FilterMerchantAccounts ||
                    this.FilterMerchantAccounts != null &&
                    input.FilterMerchantAccounts != null &&
                    this.FilterMerchantAccounts.SequenceEqual(input.FilterMerchantAccounts)
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
                ) && 
                (
                    this.HasPassword == input.HasPassword ||
                    (this.HasPassword != null &&
                    this.HasPassword.Equals(input.HasPassword))
                ) && 
                (
                    this.HmacKeyCheckValue == input.HmacKeyCheckValue ||
                    (this.HmacKeyCheckValue != null &&
                    this.HmacKeyCheckValue.Equals(input.HmacKeyCheckValue))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    (this.NetworkType != null &&
                    this.NetworkType.Equals(input.NetworkType))
                ) && 
                (
                    this.PopulateSoapActionHeader == input.PopulateSoapActionHeader ||
                    (this.PopulateSoapActionHeader != null &&
                    this.PopulateSoapActionHeader.Equals(input.PopulateSoapActionHeader))
                ) && 
                (
                    this.SslVersion == input.SslVersion ||
                    (this.SslVersion != null &&
                    this.SslVersion.Equals(input.SslVersion))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.AcceptsExpiredCertificate != null)
                    hashCode = hashCode * 59 + this.AcceptsExpiredCertificate.GetHashCode();
                if (this.AcceptsSelfSignedCertificate != null)
                    hashCode = hashCode * 59 + this.AcceptsSelfSignedCertificate.GetHashCode();
                if (this.AcceptsUntrustedRootCertificate != null)
                    hashCode = hashCode * 59 + this.AcceptsUntrustedRootCertificate.GetHashCode();
                if (this.AccountReference != null)
                    hashCode = hashCode * 59 + this.AccountReference.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.AdditionalSettings != null)
                    hashCode = hashCode * 59 + this.AdditionalSettings.GetHashCode();
                if (this.CertificateAlias != null)
                    hashCode = hashCode * 59 + this.CertificateAlias.GetHashCode();
                if (this.CommunicationFormat != null)
                    hashCode = hashCode * 59 + this.CommunicationFormat.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FilterMerchantAccountType != null)
                    hashCode = hashCode * 59 + this.FilterMerchantAccountType.GetHashCode();
                if (this.FilterMerchantAccounts != null)
                    hashCode = hashCode * 59 + this.FilterMerchantAccounts.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.HasPassword != null)
                    hashCode = hashCode * 59 + this.HasPassword.GetHashCode();
                if (this.HmacKeyCheckValue != null)
                    hashCode = hashCode * 59 + this.HmacKeyCheckValue.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NetworkType != null)
                    hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.PopulateSoapActionHeader != null)
                    hashCode = hashCode * 59 + this.PopulateSoapActionHeader.GetHashCode();
                if (this.SslVersion != null)
                    hashCode = hashCode * 59 + this.SslVersion.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
