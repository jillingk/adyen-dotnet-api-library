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
    /// PaymentMethodSetupInfo
    /// </summary>
    [DataContract]
    public partial class PaymentMethodSetupInfo :  IEquatable<PaymentMethodSetupInfo>, IValidatableObject
    {
        /// <summary>
        /// The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.  Possible values: **eCommerce**, **pos**, **contAuth**, and **moto**. 
        /// </summary>
        /// <value>The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.  Possible values: **eCommerce**, **pos**, **contAuth**, and **moto**. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum ECommerce for value: eCommerce
            /// </summary>
            [EnumMember(Value = "eCommerce")]
            ECommerce = 1,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 2,

            /// <summary>
            /// Enum Moto for value: moto
            /// </summary>
            [EnumMember(Value = "moto")]
            Moto = 3,

            /// <summary>
            /// Enum ContAuth for value: contAuth
            /// </summary>
            [EnumMember(Value = "contAuth")]
            ContAuth = 4

        }

        /// <summary>
        /// The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.  Possible values: **eCommerce**, **pos**, **contAuth**, and **moto**. 
        /// </summary>
        /// <value>The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.  Possible values: **eCommerce**, **pos**, **contAuth**, and **moto**. </value>
        [DataMember(Name="shopperInteraction", EmitDefaultValue=false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }
        /// <summary>
        /// Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).
        /// </summary>
        /// <value>Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Alipay for value: alipay
            /// </summary>
            [EnumMember(Value = "alipay")]
            Alipay = 1,

            /// <summary>
            /// Enum Amex for value: amex
            /// </summary>
            [EnumMember(Value = "amex")]
            Amex = 2,

            /// <summary>
            /// Enum Applepay for value: applepay
            /// </summary>
            [EnumMember(Value = "applepay")]
            Applepay = 3,

            /// <summary>
            /// Enum Bcmc for value: bcmc
            /// </summary>
            [EnumMember(Value = "bcmc")]
            Bcmc = 4,

            /// <summary>
            /// Enum Blik for value: blik
            /// </summary>
            [EnumMember(Value = "blik")]
            Blik = 5,

            /// <summary>
            /// Enum Cartebancaire for value: cartebancaire
            /// </summary>
            [EnumMember(Value = "cartebancaire")]
            Cartebancaire = 6,

            /// <summary>
            /// Enum Cup for value: cup
            /// </summary>
            [EnumMember(Value = "cup")]
            Cup = 7,

            /// <summary>
            /// Enum Diners for value: diners
            /// </summary>
            [EnumMember(Value = "diners")]
            Diners = 8,

            /// <summary>
            /// Enum DirectEbanking for value: directEbanking
            /// </summary>
            [EnumMember(Value = "directEbanking")]
            DirectEbanking = 9,

            /// <summary>
            /// Enum DirectdebitGB for value: directdebit_GB
            /// </summary>
            [EnumMember(Value = "directdebit_GB")]
            DirectdebitGB = 10,

            /// <summary>
            /// Enum Discover for value: discover
            /// </summary>
            [EnumMember(Value = "discover")]
            Discover = 11,

            /// <summary>
            /// Enum EbankingFI for value: ebanking_FI
            /// </summary>
            [EnumMember(Value = "ebanking_FI")]
            EbankingFI = 12,

            /// <summary>
            /// Enum Eftposaustralia for value: eftpos_australia
            /// </summary>
            [EnumMember(Value = "eftpos_australia")]
            Eftposaustralia = 13,

            /// <summary>
            /// Enum Girocard for value: girocard
            /// </summary>
            [EnumMember(Value = "girocard")]
            Girocard = 14,

            /// <summary>
            /// Enum Giropay for value: giropay
            /// </summary>
            [EnumMember(Value = "giropay")]
            Giropay = 15,

            /// <summary>
            /// Enum Googlepay for value: googlepay
            /// </summary>
            [EnumMember(Value = "googlepay")]
            Googlepay = 16,

            /// <summary>
            /// Enum Ideal for value: ideal
            /// </summary>
            [EnumMember(Value = "ideal")]
            Ideal = 17,

            /// <summary>
            /// Enum Interaccard for value: interac_card
            /// </summary>
            [EnumMember(Value = "interac_card")]
            Interaccard = 18,

            /// <summary>
            /// Enum Jcb for value: jcb
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb = 19,

            /// <summary>
            /// Enum Klarna for value: klarna
            /// </summary>
            [EnumMember(Value = "klarna")]
            Klarna = 20,

            /// <summary>
            /// Enum Klarnaaccount for value: klarna_account
            /// </summary>
            [EnumMember(Value = "klarna_account")]
            Klarnaaccount = 21,

            /// <summary>
            /// Enum Klarnapaynow for value: klarna_paynow
            /// </summary>
            [EnumMember(Value = "klarna_paynow")]
            Klarnapaynow = 22,

            /// <summary>
            /// Enum Maestro for value: maestro
            /// </summary>
            [EnumMember(Value = "maestro")]
            Maestro = 23,

            /// <summary>
            /// Enum Mbway for value: mbway
            /// </summary>
            [EnumMember(Value = "mbway")]
            Mbway = 24,

            /// <summary>
            /// Enum Mc for value: mc
            /// </summary>
            [EnumMember(Value = "mc")]
            Mc = 25,

            /// <summary>
            /// Enum Mobilepay for value: mobilepay
            /// </summary>
            [EnumMember(Value = "mobilepay")]
            Mobilepay = 26,

            /// <summary>
            /// Enum Multibanco for value: multibanco
            /// </summary>
            [EnumMember(Value = "multibanco")]
            Multibanco = 27,

            /// <summary>
            /// Enum Paypal for value: paypal
            /// </summary>
            [EnumMember(Value = "paypal")]
            Paypal = 28,

            /// <summary>
            /// Enum Payshop for value: payshop
            /// </summary>
            [EnumMember(Value = "payshop")]
            Payshop = 29,

            /// <summary>
            /// Enum Swish for value: swish
            /// </summary>
            [EnumMember(Value = "swish")]
            Swish = 30,

            /// <summary>
            /// Enum Trustly for value: trustly
            /// </summary>
            [EnumMember(Value = "trustly")]
            Trustly = 31,

            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 32,

            /// <summary>
            /// Enum Wechatpay for value: wechatpay
            /// </summary>
            [EnumMember(Value = "wechatpay")]
            Wechatpay = 33,

            /// <summary>
            /// Enum Wechatpaypos for value: wechatpay_pos
            /// </summary>
            [EnumMember(Value = "wechatpay_pos")]
            Wechatpaypos = 34

        }

        /// <summary>
        /// Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).
        /// </summary>
        /// <value>Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodSetupInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodSetupInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodSetupInfo" /> class.
        /// </summary>
        /// <param name="applePay">applePay.</param>
        /// <param name="bcmc">bcmc.</param>
        /// <param name="businessLineId">The unique identifier of the business line..</param>
        /// <param name="cartesBancaires">cartesBancaires.</param>
        /// <param name="countries">The list of countries where a payment method is available. By default, all countries supported by the payment method..</param>
        /// <param name="currencies">The list of currencies that a payment method supports. By default, all currencies supported by the payment method..</param>
        /// <param name="giroPay">giroPay.</param>
        /// <param name="googlePay">googlePay.</param>
        /// <param name="klarna">klarna.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="shopperInteraction">The sales channel. Required if the merchant account does not have a sales channel. When you provide this field, it overrides the default sales channel set on the merchant account.  Possible values: **eCommerce**, **pos**, **contAuth**, and **moto**. .</param>
        /// <param name="sofort">sofort.</param>
        /// <param name="storeId">The ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/post/stores__resParam_id), if any..</param>
        /// <param name="swish">swish.</param>
        /// <param name="type">Payment method [variant](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api). (required).</param>
        public PaymentMethodSetupInfo(ApplePayInfo applePay = default(ApplePayInfo), BcmcInfo bcmc = default(BcmcInfo), string businessLineId = default(string), CartesBancairesInfo cartesBancaires = default(CartesBancairesInfo), List<string> countries = default(List<string>), List<string> currencies = default(List<string>), GiroPayInfo giroPay = default(GiroPayInfo), GooglePayInfo googlePay = default(GooglePayInfo), KlarnaInfo klarna = default(KlarnaInfo), PayPalInfo paypal = default(PayPalInfo), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), SofortInfo sofort = default(SofortInfo), string storeId = default(string), SwishInfo swish = default(SwishInfo), TypeEnum type = default(TypeEnum))
        {
            this.ApplePay = applePay;
            this.Bcmc = bcmc;
            this.BusinessLineId = businessLineId;
            this.CartesBancaires = cartesBancaires;
            this.Countries = countries;
            this.Currencies = currencies;
            this.GiroPay = giroPay;
            this.GooglePay = googlePay;
            this.Klarna = klarna;
            this.Paypal = paypal;
            this.ShopperInteraction = shopperInteraction;
            this.Sofort = sofort;
            this.StoreId = storeId;
            this.Swish = swish;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets ApplePay
        /// </summary>
        [DataMember(Name="applePay", EmitDefaultValue=false)]
        public ApplePayInfo ApplePay { get; set; }

        /// <summary>
        /// Gets or Sets Bcmc
        /// </summary>
        [DataMember(Name="bcmc", EmitDefaultValue=false)]
        public BcmcInfo Bcmc { get; set; }

        /// <summary>
        /// The unique identifier of the business line.
        /// </summary>
        /// <value>The unique identifier of the business line.</value>
        [DataMember(Name="businessLineId", EmitDefaultValue=false)]
        public string BusinessLineId { get; set; }

        /// <summary>
        /// Gets or Sets CartesBancaires
        /// </summary>
        [DataMember(Name="cartesBancaires", EmitDefaultValue=false)]
        public CartesBancairesInfo CartesBancaires { get; set; }

        /// <summary>
        /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
        /// </summary>
        /// <value>The list of countries where a payment method is available. By default, all countries supported by the payment method.</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
        /// </summary>
        /// <value>The list of currencies that a payment method supports. By default, all currencies supported by the payment method.</value>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Gets or Sets GiroPay
        /// </summary>
        [DataMember(Name="giroPay", EmitDefaultValue=false)]
        public GiroPayInfo GiroPay { get; set; }

        /// <summary>
        /// Gets or Sets GooglePay
        /// </summary>
        [DataMember(Name="googlePay", EmitDefaultValue=false)]
        public GooglePayInfo GooglePay { get; set; }

        /// <summary>
        /// Gets or Sets Klarna
        /// </summary>
        [DataMember(Name="klarna", EmitDefaultValue=false)]
        public KlarnaInfo Klarna { get; set; }

        /// <summary>
        /// Gets or Sets Paypal
        /// </summary>
        [DataMember(Name="paypal", EmitDefaultValue=false)]
        public PayPalInfo Paypal { get; set; }


        /// <summary>
        /// Gets or Sets Sofort
        /// </summary>
        [DataMember(Name="sofort", EmitDefaultValue=false)]
        public SofortInfo Sofort { get; set; }

        /// <summary>
        /// The ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/post/stores__resParam_id), if any.
        /// </summary>
        /// <value>The ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/post/stores__resParam_id), if any.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets Swish
        /// </summary>
        [DataMember(Name="swish", EmitDefaultValue=false)]
        public SwishInfo Swish { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodSetupInfo {\n");
            sb.Append("  ApplePay: ").Append(ApplePay).Append("\n");
            sb.Append("  Bcmc: ").Append(Bcmc).Append("\n");
            sb.Append("  BusinessLineId: ").Append(BusinessLineId).Append("\n");
            sb.Append("  CartesBancaires: ").Append(CartesBancaires).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  GiroPay: ").Append(GiroPay).Append("\n");
            sb.Append("  GooglePay: ").Append(GooglePay).Append("\n");
            sb.Append("  Klarna: ").Append(Klarna).Append("\n");
            sb.Append("  Paypal: ").Append(Paypal).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  Sofort: ").Append(Sofort).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Swish: ").Append(Swish).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentMethodSetupInfo);
        }

        /// <summary>
        /// Returns true if PaymentMethodSetupInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodSetupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodSetupInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplePay == input.ApplePay ||
                    (this.ApplePay != null &&
                    this.ApplePay.Equals(input.ApplePay))
                ) && 
                (
                    this.Bcmc == input.Bcmc ||
                    (this.Bcmc != null &&
                    this.Bcmc.Equals(input.Bcmc))
                ) && 
                (
                    this.BusinessLineId == input.BusinessLineId ||
                    (this.BusinessLineId != null &&
                    this.BusinessLineId.Equals(input.BusinessLineId))
                ) && 
                (
                    this.CartesBancaires == input.CartesBancaires ||
                    (this.CartesBancaires != null &&
                    this.CartesBancaires.Equals(input.CartesBancaires))
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    input.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.GiroPay == input.GiroPay ||
                    (this.GiroPay != null &&
                    this.GiroPay.Equals(input.GiroPay))
                ) && 
                (
                    this.GooglePay == input.GooglePay ||
                    (this.GooglePay != null &&
                    this.GooglePay.Equals(input.GooglePay))
                ) && 
                (
                    this.Klarna == input.Klarna ||
                    (this.Klarna != null &&
                    this.Klarna.Equals(input.Klarna))
                ) && 
                (
                    this.Paypal == input.Paypal ||
                    (this.Paypal != null &&
                    this.Paypal.Equals(input.Paypal))
                ) && 
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    (this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction))
                ) && 
                (
                    this.Sofort == input.Sofort ||
                    (this.Sofort != null &&
                    this.Sofort.Equals(input.Sofort))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.Swish == input.Swish ||
                    (this.Swish != null &&
                    this.Swish.Equals(input.Swish))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ApplePay != null)
                    hashCode = hashCode * 59 + this.ApplePay.GetHashCode();
                if (this.Bcmc != null)
                    hashCode = hashCode * 59 + this.Bcmc.GetHashCode();
                if (this.BusinessLineId != null)
                    hashCode = hashCode * 59 + this.BusinessLineId.GetHashCode();
                if (this.CartesBancaires != null)
                    hashCode = hashCode * 59 + this.CartesBancaires.GetHashCode();
                if (this.Countries != null)
                    hashCode = hashCode * 59 + this.Countries.GetHashCode();
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
                if (this.GiroPay != null)
                    hashCode = hashCode * 59 + this.GiroPay.GetHashCode();
                if (this.GooglePay != null)
                    hashCode = hashCode * 59 + this.GooglePay.GetHashCode();
                if (this.Klarna != null)
                    hashCode = hashCode * 59 + this.Klarna.GetHashCode();
                if (this.Paypal != null)
                    hashCode = hashCode * 59 + this.Paypal.GetHashCode();
                if (this.ShopperInteraction != null)
                    hashCode = hashCode * 59 + this.ShopperInteraction.GetHashCode();
                if (this.Sofort != null)
                    hashCode = hashCode * 59 + this.Sofort.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Swish != null)
                    hashCode = hashCode * 59 + this.Swish.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
