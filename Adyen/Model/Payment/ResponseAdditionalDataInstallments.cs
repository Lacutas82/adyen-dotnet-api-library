/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ResponseAdditionalDataInstallments
    /// </summary>
    [DataContract(Name = "ResponseAdditionalDataInstallments")]
    public partial class ResponseAdditionalDataInstallments : IEquatable<ResponseAdditionalDataInstallments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataInstallments" /> class.
        /// </summary>
        /// <param name="installmentPaymentDataInstallmentType">Type of installment. The value of &#x60;installmentType&#x60; should be **IssuerFinanced**..</param>
        /// <param name="installmentPaymentDataOptionItemNrAnnualPercentageRate">Annual interest rate..</param>
        /// <param name="installmentPaymentDataOptionItemNrFirstInstallmentAmount">First Installment Amount in minor units..</param>
        /// <param name="installmentPaymentDataOptionItemNrInstallmentFee">Installment fee amount in minor units..</param>
        /// <param name="installmentPaymentDataOptionItemNrInterestRate">Interest rate for the installment period..</param>
        /// <param name="installmentPaymentDataOptionItemNrMaximumNumberOfInstallments">Maximum number of installments possible for this payment..</param>
        /// <param name="installmentPaymentDataOptionItemNrMinimumNumberOfInstallments">Minimum number of installments possible for this payment..</param>
        /// <param name="installmentPaymentDataOptionItemNrNumberOfInstallments">Total number of installments possible for this payment..</param>
        /// <param name="installmentPaymentDataOptionItemNrSubsequentInstallmentAmount">Subsequent Installment Amount in minor units..</param>
        /// <param name="installmentPaymentDataOptionItemNrTotalAmountDue">Total amount in minor units..</param>
        /// <param name="installmentPaymentDataPaymentOptions">Possible values: * PayInInstallmentsOnly * PayInFullOnly * PayInFullOrInstallments.</param>
        /// <param name="installmentsValue">The number of installments that the payment amount should be charged with.  Example: 5 &gt; Only relevant for card payments in countries that support installments..</param>
        public ResponseAdditionalDataInstallments(string installmentPaymentDataInstallmentType = default(string), string installmentPaymentDataOptionItemNrAnnualPercentageRate = default(string), string installmentPaymentDataOptionItemNrFirstInstallmentAmount = default(string), string installmentPaymentDataOptionItemNrInstallmentFee = default(string), string installmentPaymentDataOptionItemNrInterestRate = default(string), string installmentPaymentDataOptionItemNrMaximumNumberOfInstallments = default(string), string installmentPaymentDataOptionItemNrMinimumNumberOfInstallments = default(string), string installmentPaymentDataOptionItemNrNumberOfInstallments = default(string), string installmentPaymentDataOptionItemNrSubsequentInstallmentAmount = default(string), string installmentPaymentDataOptionItemNrTotalAmountDue = default(string), string installmentPaymentDataPaymentOptions = default(string), string installmentsValue = default(string))
        {
            this.InstallmentPaymentDataInstallmentType = installmentPaymentDataInstallmentType;
            this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate = installmentPaymentDataOptionItemNrAnnualPercentageRate;
            this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount = installmentPaymentDataOptionItemNrFirstInstallmentAmount;
            this.InstallmentPaymentDataOptionItemNrInstallmentFee = installmentPaymentDataOptionItemNrInstallmentFee;
            this.InstallmentPaymentDataOptionItemNrInterestRate = installmentPaymentDataOptionItemNrInterestRate;
            this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments = installmentPaymentDataOptionItemNrMaximumNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments = installmentPaymentDataOptionItemNrMinimumNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrNumberOfInstallments = installmentPaymentDataOptionItemNrNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount = installmentPaymentDataOptionItemNrSubsequentInstallmentAmount;
            this.InstallmentPaymentDataOptionItemNrTotalAmountDue = installmentPaymentDataOptionItemNrTotalAmountDue;
            this.InstallmentPaymentDataPaymentOptions = installmentPaymentDataPaymentOptions;
            this.InstallmentsValue = installmentsValue;
        }

        /// <summary>
        /// Type of installment. The value of &#x60;installmentType&#x60; should be **IssuerFinanced**.
        /// </summary>
        /// <value>Type of installment. The value of &#x60;installmentType&#x60; should be **IssuerFinanced**.</value>
        [DataMember(Name = "installmentPaymentData.installmentType", EmitDefaultValue = false)]
        public string InstallmentPaymentDataInstallmentType { get; set; }

        /// <summary>
        /// Annual interest rate.
        /// </summary>
        /// <value>Annual interest rate.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].annualPercentageRate", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrAnnualPercentageRate { get; set; }

        /// <summary>
        /// First Installment Amount in minor units.
        /// </summary>
        /// <value>First Installment Amount in minor units.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].firstInstallmentAmount", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrFirstInstallmentAmount { get; set; }

        /// <summary>
        /// Installment fee amount in minor units.
        /// </summary>
        /// <value>Installment fee amount in minor units.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].installmentFee", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrInstallmentFee { get; set; }

        /// <summary>
        /// Interest rate for the installment period.
        /// </summary>
        /// <value>Interest rate for the installment period.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].interestRate", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrInterestRate { get; set; }

        /// <summary>
        /// Maximum number of installments possible for this payment.
        /// </summary>
        /// <value>Maximum number of installments possible for this payment.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].maximumNumberOfInstallments", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments { get; set; }

        /// <summary>
        /// Minimum number of installments possible for this payment.
        /// </summary>
        /// <value>Minimum number of installments possible for this payment.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].minimumNumberOfInstallments", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments { get; set; }

        /// <summary>
        /// Total number of installments possible for this payment.
        /// </summary>
        /// <value>Total number of installments possible for this payment.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].numberOfInstallments", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrNumberOfInstallments { get; set; }

        /// <summary>
        /// Subsequent Installment Amount in minor units.
        /// </summary>
        /// <value>Subsequent Installment Amount in minor units.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].subsequentInstallmentAmount", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount { get; set; }

        /// <summary>
        /// Total amount in minor units.
        /// </summary>
        /// <value>Total amount in minor units.</value>
        [DataMember(Name = "installmentPaymentData.option[itemNr].totalAmountDue", EmitDefaultValue = false)]
        public string InstallmentPaymentDataOptionItemNrTotalAmountDue { get; set; }

        /// <summary>
        /// Possible values: * PayInInstallmentsOnly * PayInFullOnly * PayInFullOrInstallments
        /// </summary>
        /// <value>Possible values: * PayInInstallmentsOnly * PayInFullOnly * PayInFullOrInstallments</value>
        [DataMember(Name = "installmentPaymentData.paymentOptions", EmitDefaultValue = false)]
        public string InstallmentPaymentDataPaymentOptions { get; set; }

        /// <summary>
        /// The number of installments that the payment amount should be charged with.  Example: 5 &gt; Only relevant for card payments in countries that support installments.
        /// </summary>
        /// <value>The number of installments that the payment amount should be charged with.  Example: 5 &gt; Only relevant for card payments in countries that support installments.</value>
        [DataMember(Name = "installments.value", EmitDefaultValue = false)]
        public string InstallmentsValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataInstallments {\n");
            sb.Append("  InstallmentPaymentDataInstallmentType: ").Append(InstallmentPaymentDataInstallmentType).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrAnnualPercentageRate: ").Append(InstallmentPaymentDataOptionItemNrAnnualPercentageRate).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrFirstInstallmentAmount: ").Append(InstallmentPaymentDataOptionItemNrFirstInstallmentAmount).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrInstallmentFee: ").Append(InstallmentPaymentDataOptionItemNrInstallmentFee).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrInterestRate: ").Append(InstallmentPaymentDataOptionItemNrInterestRate).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrNumberOfInstallments: ").Append(InstallmentPaymentDataOptionItemNrNumberOfInstallments).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount: ").Append(InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount).Append("\n");
            sb.Append("  InstallmentPaymentDataOptionItemNrTotalAmountDue: ").Append(InstallmentPaymentDataOptionItemNrTotalAmountDue).Append("\n");
            sb.Append("  InstallmentPaymentDataPaymentOptions: ").Append(InstallmentPaymentDataPaymentOptions).Append("\n");
            sb.Append("  InstallmentsValue: ").Append(InstallmentsValue).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataInstallments);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataInstallments instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataInstallments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataInstallments input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstallmentPaymentDataInstallmentType == input.InstallmentPaymentDataInstallmentType ||
                    (this.InstallmentPaymentDataInstallmentType != null &&
                    this.InstallmentPaymentDataInstallmentType.Equals(input.InstallmentPaymentDataInstallmentType))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate == input.InstallmentPaymentDataOptionItemNrAnnualPercentageRate ||
                    (this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate != null &&
                    this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate.Equals(input.InstallmentPaymentDataOptionItemNrAnnualPercentageRate))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount == input.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount ||
                    (this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount != null &&
                    this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount.Equals(input.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrInstallmentFee == input.InstallmentPaymentDataOptionItemNrInstallmentFee ||
                    (this.InstallmentPaymentDataOptionItemNrInstallmentFee != null &&
                    this.InstallmentPaymentDataOptionItemNrInstallmentFee.Equals(input.InstallmentPaymentDataOptionItemNrInstallmentFee))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrInterestRate == input.InstallmentPaymentDataOptionItemNrInterestRate ||
                    (this.InstallmentPaymentDataOptionItemNrInterestRate != null &&
                    this.InstallmentPaymentDataOptionItemNrInterestRate.Equals(input.InstallmentPaymentDataOptionItemNrInterestRate))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments == input.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments ||
                    (this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments != null &&
                    this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments.Equals(input.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments == input.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments ||
                    (this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments != null &&
                    this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments.Equals(input.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrNumberOfInstallments == input.InstallmentPaymentDataOptionItemNrNumberOfInstallments ||
                    (this.InstallmentPaymentDataOptionItemNrNumberOfInstallments != null &&
                    this.InstallmentPaymentDataOptionItemNrNumberOfInstallments.Equals(input.InstallmentPaymentDataOptionItemNrNumberOfInstallments))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount == input.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount ||
                    (this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount != null &&
                    this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount.Equals(input.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount))
                ) && 
                (
                    this.InstallmentPaymentDataOptionItemNrTotalAmountDue == input.InstallmentPaymentDataOptionItemNrTotalAmountDue ||
                    (this.InstallmentPaymentDataOptionItemNrTotalAmountDue != null &&
                    this.InstallmentPaymentDataOptionItemNrTotalAmountDue.Equals(input.InstallmentPaymentDataOptionItemNrTotalAmountDue))
                ) && 
                (
                    this.InstallmentPaymentDataPaymentOptions == input.InstallmentPaymentDataPaymentOptions ||
                    (this.InstallmentPaymentDataPaymentOptions != null &&
                    this.InstallmentPaymentDataPaymentOptions.Equals(input.InstallmentPaymentDataPaymentOptions))
                ) && 
                (
                    this.InstallmentsValue == input.InstallmentsValue ||
                    (this.InstallmentsValue != null &&
                    this.InstallmentsValue.Equals(input.InstallmentsValue))
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
                if (this.InstallmentPaymentDataInstallmentType != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataInstallmentType.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrInstallmentFee != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrInstallmentFee.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrInterestRate != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrInterestRate.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrNumberOfInstallments != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrNumberOfInstallments.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount.GetHashCode();
                }
                if (this.InstallmentPaymentDataOptionItemNrTotalAmountDue != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataOptionItemNrTotalAmountDue.GetHashCode();
                }
                if (this.InstallmentPaymentDataPaymentOptions != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataPaymentOptions.GetHashCode();
                }
                if (this.InstallmentsValue != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentsValue.GetHashCode();
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
