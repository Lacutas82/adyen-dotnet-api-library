/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AndroidPayDetails
    /// </summary>
    [DataContract(Name = "AndroidPayDetails")]
    public partial class AndroidPayDetails : IEquatable<AndroidPayDetails>, IValidatableObject
    {
        /// <summary>
        /// **androidpay**
        /// </summary>
        /// <value>**androidpay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Androidpay for value: androidpay
            /// </summary>
            [EnumMember(Value = "androidpay")]
            Androidpay = 1

        }


        /// <summary>
        /// **androidpay**
        /// </summary>
        /// <value>**androidpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidPayDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="type">**androidpay** (default to TypeEnum.Androidpay).</param>
        public AndroidPayDetails(string checkoutAttemptId = default(string), TypeEnum? type = TypeEnum.Androidpay)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AndroidPayDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
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
            return this.Equals(input as AndroidPayDetails);
        }

        /// <summary>
        /// Returns true if AndroidPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidPayDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
