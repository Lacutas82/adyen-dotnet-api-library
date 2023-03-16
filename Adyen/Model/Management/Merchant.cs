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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Management
{
    /// <summary>
    /// Merchant
    /// </summary>
    [DataContract(Name = "Merchant")]
    public partial class Merchant : IEquatable<Merchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="captureDelay">The [capture delay](https://docs.adyen.com/online-payments/capture#capture-delay) set for the merchant account.  Possible values: * **Immediate** * **Manual** * Number of days from **1** to **29**.</param>
        /// <param name="companyId">The unique identifier of the company account this merchant belongs to.</param>
        /// <param name="dataCenters">List of available data centers.  Adyen has several data centers around the world.In the URL that you use for making API requests, we recommend you use the live URL prefix from the data center closest to your shoppers..</param>
        /// <param name="defaultShopperInteraction">The default [&#x60;shopperInteraction&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/v68/post/payments__reqParam_shopperInteraction) value used when processing payments through this merchant account..</param>
        /// <param name="description">Your description for the merchant account, maximum 300 characters.</param>
        /// <param name="id">The unique identifier of the merchant account..</param>
        /// <param name="merchantCity">The city where the legal entity of this merchant account is registered..</param>
        /// <param name="name">The name of the legal entity associated with the merchant account..</param>
        /// <param name="pricingPlan">Only applies to merchant accounts managed by Adyen&#39;s partners. The name of the pricing plan assigned to the merchant account..</param>
        /// <param name="primarySettlementCurrency">The currency of the country where the legal entity of this merchant account is registered. Format: [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). For example, a legal entity based in the United States has USD as the primary settlement currency..</param>
        /// <param name="reference">Reference of the merchant account..</param>
        /// <param name="shopWebAddress">The URL for the ecommerce website used with this merchant account..</param>
        /// <param name="status">The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. You cannot process new payments but you can still modify payments, for example issue refunds. You can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled..</param>
        public Merchant(MerchantLinks links = default(MerchantLinks), string captureDelay = default(string), string companyId = default(string), List<DataCenter> dataCenters = default(List<DataCenter>), string defaultShopperInteraction = default(string), string description = default(string), string id = default(string), string merchantCity = default(string), string name = default(string), string pricingPlan = default(string), string primarySettlementCurrency = default(string), string reference = default(string), string shopWebAddress = default(string), string status = default(string))
        {
            this.Links = links;
            this.CaptureDelay = captureDelay;
            this.CompanyId = companyId;
            this.DataCenters = dataCenters;
            this.DefaultShopperInteraction = defaultShopperInteraction;
            this.Description = description;
            this.Id = id;
            this.MerchantCity = merchantCity;
            this.Name = name;
            this.PricingPlan = pricingPlan;
            this.PrimarySettlementCurrency = primarySettlementCurrency;
            this.Reference = reference;
            this.ShopWebAddress = shopWebAddress;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public MerchantLinks Links { get; set; }

        /// <summary>
        /// The [capture delay](https://docs.adyen.com/online-payments/capture#capture-delay) set for the merchant account.  Possible values: * **Immediate** * **Manual** * Number of days from **1** to **29**
        /// </summary>
        /// <value>The [capture delay](https://docs.adyen.com/online-payments/capture#capture-delay) set for the merchant account.  Possible values: * **Immediate** * **Manual** * Number of days from **1** to **29**</value>
        [DataMember(Name = "captureDelay", EmitDefaultValue = false)]
        public string CaptureDelay { get; set; }

        /// <summary>
        /// The unique identifier of the company account this merchant belongs to
        /// </summary>
        /// <value>The unique identifier of the company account this merchant belongs to</value>
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// List of available data centers.  Adyen has several data centers around the world.In the URL that you use for making API requests, we recommend you use the live URL prefix from the data center closest to your shoppers.
        /// </summary>
        /// <value>List of available data centers.  Adyen has several data centers around the world.In the URL that you use for making API requests, we recommend you use the live URL prefix from the data center closest to your shoppers.</value>
        [DataMember(Name = "dataCenters", EmitDefaultValue = false)]
        public List<DataCenter> DataCenters { get; set; }

        /// <summary>
        /// The default [&#x60;shopperInteraction&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/v68/post/payments__reqParam_shopperInteraction) value used when processing payments through this merchant account.
        /// </summary>
        /// <value>The default [&#x60;shopperInteraction&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/v68/post/payments__reqParam_shopperInteraction) value used when processing payments through this merchant account.</value>
        [DataMember(Name = "defaultShopperInteraction", EmitDefaultValue = false)]
        public string DefaultShopperInteraction { get; set; }

        /// <summary>
        /// Your description for the merchant account, maximum 300 characters
        /// </summary>
        /// <value>Your description for the merchant account, maximum 300 characters</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the merchant account.
        /// </summary>
        /// <value>The unique identifier of the merchant account.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The city where the legal entity of this merchant account is registered.
        /// </summary>
        /// <value>The city where the legal entity of this merchant account is registered.</value>
        [DataMember(Name = "merchantCity", EmitDefaultValue = false)]
        public string MerchantCity { get; set; }

        /// <summary>
        /// The name of the legal entity associated with the merchant account.
        /// </summary>
        /// <value>The name of the legal entity associated with the merchant account.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Only applies to merchant accounts managed by Adyen&#39;s partners. The name of the pricing plan assigned to the merchant account.
        /// </summary>
        /// <value>Only applies to merchant accounts managed by Adyen&#39;s partners. The name of the pricing plan assigned to the merchant account.</value>
        [DataMember(Name = "pricingPlan", EmitDefaultValue = false)]
        public string PricingPlan { get; set; }

        /// <summary>
        /// The currency of the country where the legal entity of this merchant account is registered. Format: [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). For example, a legal entity based in the United States has USD as the primary settlement currency.
        /// </summary>
        /// <value>The currency of the country where the legal entity of this merchant account is registered. Format: [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). For example, a legal entity based in the United States has USD as the primary settlement currency.</value>
        [DataMember(Name = "primarySettlementCurrency", EmitDefaultValue = false)]
        public string PrimarySettlementCurrency { get; set; }

        /// <summary>
        /// Reference of the merchant account.
        /// </summary>
        /// <value>Reference of the merchant account.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The URL for the ecommerce website used with this merchant account.
        /// </summary>
        /// <value>The URL for the ecommerce website used with this merchant account.</value>
        [DataMember(Name = "shopWebAddress", EmitDefaultValue = false)]
        public string ShopWebAddress { get; set; }

        /// <summary>
        /// The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. You cannot process new payments but you can still modify payments, for example issue refunds. You can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.
        /// </summary>
        /// <value>The status of the merchant account.  Possible values:  * **PreActive**: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments. * **Active**: Users can access the merchant account in the Customer Area. If the company account is also **Active**, then payment processing and payouts are enabled. * **InactiveWithModifications**: Users can access the merchant account in the Customer Area. You cannot process new payments but you can still modify payments, for example issue refunds. You can still receive payouts. * **Inactive**: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled. * **Closed**: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Merchant {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  CaptureDelay: ").Append(CaptureDelay).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DataCenters: ").Append(DataCenters).Append("\n");
            sb.Append("  DefaultShopperInteraction: ").Append(DefaultShopperInteraction).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MerchantCity: ").Append(MerchantCity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PricingPlan: ").Append(PricingPlan).Append("\n");
            sb.Append("  PrimarySettlementCurrency: ").Append(PrimarySettlementCurrency).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopWebAddress: ").Append(ShopWebAddress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Merchant);
        }

        /// <summary>
        /// Returns true if Merchant instances are equal
        /// </summary>
        /// <param name="input">Instance of Merchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Merchant input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.CaptureDelay == input.CaptureDelay ||
                    (this.CaptureDelay != null &&
                    this.CaptureDelay.Equals(input.CaptureDelay))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.DataCenters == input.DataCenters ||
                    this.DataCenters != null &&
                    input.DataCenters != null &&
                    this.DataCenters.SequenceEqual(input.DataCenters)
                ) && 
                (
                    this.DefaultShopperInteraction == input.DefaultShopperInteraction ||
                    (this.DefaultShopperInteraction != null &&
                    this.DefaultShopperInteraction.Equals(input.DefaultShopperInteraction))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MerchantCity == input.MerchantCity ||
                    (this.MerchantCity != null &&
                    this.MerchantCity.Equals(input.MerchantCity))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PricingPlan == input.PricingPlan ||
                    (this.PricingPlan != null &&
                    this.PricingPlan.Equals(input.PricingPlan))
                ) && 
                (
                    this.PrimarySettlementCurrency == input.PrimarySettlementCurrency ||
                    (this.PrimarySettlementCurrency != null &&
                    this.PrimarySettlementCurrency.Equals(input.PrimarySettlementCurrency))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ShopWebAddress == input.ShopWebAddress ||
                    (this.ShopWebAddress != null &&
                    this.ShopWebAddress.Equals(input.ShopWebAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.CaptureDelay != null)
                {
                    hashCode = (hashCode * 59) + this.CaptureDelay.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.DataCenters != null)
                {
                    hashCode = (hashCode * 59) + this.DataCenters.GetHashCode();
                }
                if (this.DefaultShopperInteraction != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultShopperInteraction.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MerchantCity != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCity.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PricingPlan != null)
                {
                    hashCode = (hashCode * 59) + this.PricingPlan.GetHashCode();
                }
                if (this.PrimarySettlementCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.PrimarySettlementCurrency.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ShopWebAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShopWebAddress.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
