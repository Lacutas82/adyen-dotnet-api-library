/*
* Adyen Stored Value API
*
*
* The version of the OpenAPI document: 46
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

namespace Adyen.Model.StoredValue
{
    /// <summary>
    /// StoredValueBalanceMergeResponse
    /// </summary>
    [DataContract(Name = "StoredValueBalanceMergeResponse")]
    public partial class StoredValueBalanceMergeResponse : IEquatable<StoredValueBalanceMergeResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the payment. Possible values:  * **Success** – The operation has been completed successfully.  * **Refused** – The operation was refused. The reason is given in the &#x60;refusalReason&#x60; field.  * **Error** – There was an error when the operation was processed. The reason is given in the &#x60;refusalReason&#x60; field.  * **NotEnoughBalance** – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.  
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **Success** – The operation has been completed successfully.  * **Refused** – The operation was refused. The reason is given in the &#x60;refusalReason&#x60; field.  * **Error** – There was an error when the operation was processed. The reason is given in the &#x60;refusalReason&#x60; field.  * **NotEnoughBalance** – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1,

            /// <summary>
            /// Enum Refused for value: Refused
            /// </summary>
            [EnumMember(Value = "Refused")]
            Refused = 2,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 3,

            /// <summary>
            /// Enum NotEnoughBalance for value: NotEnoughBalance
            /// </summary>
            [EnumMember(Value = "NotEnoughBalance")]
            NotEnoughBalance = 4

        }


        /// <summary>
        /// The result of the payment. Possible values:  * **Success** – The operation has been completed successfully.  * **Refused** – The operation was refused. The reason is given in the &#x60;refusalReason&#x60; field.  * **Error** – There was an error when the operation was processed. The reason is given in the &#x60;refusalReason&#x60; field.  * **NotEnoughBalance** – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.  
        /// </summary>
        /// <value>The result of the payment. Possible values:  * **Success** – The operation has been completed successfully.  * **Refused** – The operation was refused. The reason is given in the &#x60;refusalReason&#x60; field.  * **Error** – There was an error when the operation was processed. The reason is given in the &#x60;refusalReason&#x60; field.  * **NotEnoughBalance** – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.  </value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredValueBalanceMergeResponse" /> class.
        /// </summary>
        /// <param name="authCode">Authorisation code: * When the payment is authorised, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty..</param>
        /// <param name="currentBalance">currentBalance.</param>
        /// <param name="pspReference">Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request..</param>
        /// <param name="refusalReason">If the transaction is refused or an error occurs, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values..</param>
        /// <param name="resultCode">The result of the payment. Possible values:  * **Success** – The operation has been completed successfully.  * **Refused** – The operation was refused. The reason is given in the &#x60;refusalReason&#x60; field.  * **Error** – There was an error when the operation was processed. The reason is given in the &#x60;refusalReason&#x60; field.  * **NotEnoughBalance** – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.  .</param>
        /// <param name="thirdPartyRefusalReason">Raw refusal reason received from the third party, where available.</param>
        public StoredValueBalanceMergeResponse(string authCode = default(string), Amount currentBalance = default(Amount), string pspReference = default(string), string refusalReason = default(string), ResultCodeEnum? resultCode = default(ResultCodeEnum?), string thirdPartyRefusalReason = default(string))
        {
            this.AuthCode = authCode;
            this.CurrentBalance = currentBalance;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.ResultCode = resultCode;
            this.ThirdPartyRefusalReason = thirdPartyRefusalReason;
        }

        /// <summary>
        /// Authorisation code: * When the payment is authorised, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.
        /// </summary>
        /// <value>Authorisation code: * When the payment is authorised, this field holds the authorisation code for the payment. * When the payment is not authorised, this field is empty.</value>
        [DataMember(Name = "authCode", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        [DataMember(Name = "currentBalance", EmitDefaultValue = false)]
        public Amount CurrentBalance { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the transaction is refused or an error occurs, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.
        /// </summary>
        /// <value>If the transaction is refused or an error occurs, this field holds Adyen&#39;s mapped reason for the refusal or a description of the error.  When a transaction fails, the authorisation response includes &#x60;resultCode&#x60; and &#x60;refusalReason&#x60; values.</value>
        [DataMember(Name = "refusalReason", EmitDefaultValue = false)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// Raw refusal reason received from the third party, where available
        /// </summary>
        /// <value>Raw refusal reason received from the third party, where available</value>
        [DataMember(Name = "thirdPartyRefusalReason", EmitDefaultValue = false)]
        public string ThirdPartyRefusalReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoredValueBalanceMergeResponse {\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  RefusalReason: ").Append(RefusalReason).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ThirdPartyRefusalReason: ").Append(ThirdPartyRefusalReason).Append("\n");
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
            return this.Equals(input as StoredValueBalanceMergeResponse);
        }

        /// <summary>
        /// Returns true if StoredValueBalanceMergeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredValueBalanceMergeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredValueBalanceMergeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.RefusalReason == input.RefusalReason ||
                    (this.RefusalReason != null &&
                    this.RefusalReason.Equals(input.RefusalReason))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
                ) && 
                (
                    this.ThirdPartyRefusalReason == input.ThirdPartyRefusalReason ||
                    (this.ThirdPartyRefusalReason != null &&
                    this.ThirdPartyRefusalReason.Equals(input.ThirdPartyRefusalReason))
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
                if (this.AuthCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthCode.GetHashCode();
                }
                if (this.CurrentBalance != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBalance.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.RefusalReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefusalReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                if (this.ThirdPartyRefusalReason != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyRefusalReason.GetHashCode();
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
