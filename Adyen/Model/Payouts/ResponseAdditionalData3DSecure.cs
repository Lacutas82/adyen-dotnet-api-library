/*
* Adyen Payout API
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

namespace Adyen.Model.Payouts
{
    /// <summary>
    /// ResponseAdditionalData3DSecure
    /// </summary>
    [DataContract(Name = "ResponseAdditionalData3DSecure")]
    public partial class ResponseAdditionalData3DSecure : IEquatable<ResponseAdditionalData3DSecure>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalData3DSecure" /> class.
        /// </summary>
        /// <param name="cardHolderInfo">Information provided by the issuer to the cardholder. If this field is present, you need to display this information to the cardholder. .</param>
        /// <param name="cavv">The Cardholder Authentication Verification Value (CAVV) for the 3D Secure authentication session, as a Base64-encoded 20-byte array..</param>
        /// <param name="cavvAlgorithm">The CAVV algorithm used..</param>
        /// <param name="scaExemptionRequested">Shows the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that Adyen requested for the payment.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** .</param>
        /// <param name="threeds2CardEnrolled">Indicates whether a card is enrolled for 3D Secure 2..</param>
        public ResponseAdditionalData3DSecure(string cardHolderInfo = default(string), string cavv = default(string), string cavvAlgorithm = default(string), string scaExemptionRequested = default(string), bool threeds2CardEnrolled = default(bool))
        {
            this.CardHolderInfo = cardHolderInfo;
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ScaExemptionRequested = scaExemptionRequested;
            this.Threeds2CardEnrolled = threeds2CardEnrolled;
        }

        /// <summary>
        /// Information provided by the issuer to the cardholder. If this field is present, you need to display this information to the cardholder. 
        /// </summary>
        /// <value>Information provided by the issuer to the cardholder. If this field is present, you need to display this information to the cardholder. </value>
        [DataMember(Name = "cardHolderInfo", EmitDefaultValue = false)]
        public string CardHolderInfo { get; set; }

        /// <summary>
        /// The Cardholder Authentication Verification Value (CAVV) for the 3D Secure authentication session, as a Base64-encoded 20-byte array.
        /// </summary>
        /// <value>The Cardholder Authentication Verification Value (CAVV) for the 3D Secure authentication session, as a Base64-encoded 20-byte array.</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used.
        /// </summary>
        /// <value>The CAVV algorithm used.</value>
        [DataMember(Name = "cavvAlgorithm", EmitDefaultValue = false)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Shows the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that Adyen requested for the payment.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** 
        /// </summary>
        /// <value>Shows the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that Adyen requested for the payment.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** </value>
        [DataMember(Name = "scaExemptionRequested", EmitDefaultValue = false)]
        public string ScaExemptionRequested { get; set; }

        /// <summary>
        /// Indicates whether a card is enrolled for 3D Secure 2.
        /// </summary>
        /// <value>Indicates whether a card is enrolled for 3D Secure 2.</value>
        [DataMember(Name = "threeds2.cardEnrolled", EmitDefaultValue = false)]
        public bool Threeds2CardEnrolled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseAdditionalData3DSecure {\n");
            sb.Append("  CardHolderInfo: ").Append(CardHolderInfo).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  ScaExemptionRequested: ").Append(ScaExemptionRequested).Append("\n");
            sb.Append("  Threeds2CardEnrolled: ").Append(Threeds2CardEnrolled).Append("\n");
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
            return this.Equals(input as ResponseAdditionalData3DSecure);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalData3DSecure instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalData3DSecure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalData3DSecure input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardHolderInfo == input.CardHolderInfo ||
                    (this.CardHolderInfo != null &&
                    this.CardHolderInfo.Equals(input.CardHolderInfo))
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.ScaExemptionRequested == input.ScaExemptionRequested ||
                    (this.ScaExemptionRequested != null &&
                    this.ScaExemptionRequested.Equals(input.ScaExemptionRequested))
                ) && 
                (
                    this.Threeds2CardEnrolled == input.Threeds2CardEnrolled ||
                    this.Threeds2CardEnrolled.Equals(input.Threeds2CardEnrolled)
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
                if (this.CardHolderInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CardHolderInfo.GetHashCode();
                }
                if (this.Cavv != null)
                {
                    hashCode = (hashCode * 59) + this.Cavv.GetHashCode();
                }
                if (this.CavvAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.CavvAlgorithm.GetHashCode();
                }
                if (this.ScaExemptionRequested != null)
                {
                    hashCode = (hashCode * 59) + this.ScaExemptionRequested.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Threeds2CardEnrolled.GetHashCode();
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
