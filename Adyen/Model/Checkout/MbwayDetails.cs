/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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
    /// MbwayDetails
    /// </summary>
    [DataContract(Name = "MbwayDetails")]
    public partial class MbwayDetails : IEquatable<MbwayDetails>, IValidatableObject
    {
        /// <summary>
        /// **mbway**
        /// </summary>
        /// <value>**mbway**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Mbway for value: mbway
            /// </summary>
            [EnumMember(Value = "mbway")]
            Mbway = 1

        }


        /// <summary>
        /// **mbway**
        /// </summary>
        /// <value>**mbway**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MbwayDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MbwayDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MbwayDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="shopperEmail">shopperEmail (required).</param>
        /// <param name="telephoneNumber">telephoneNumber (required).</param>
        /// <param name="type">**mbway** (default to TypeEnum.Mbway).</param>
        public MbwayDetails(string checkoutAttemptId = default(string), string shopperEmail = default(string), string telephoneNumber = default(string), TypeEnum? type = TypeEnum.Mbway)
        {
            this.ShopperEmail = shopperEmail;
            this.TelephoneNumber = telephoneNumber;
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
        /// Gets or Sets ShopperEmail
        /// </summary>
        [DataMember(Name = "shopperEmail", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneNumber
        /// </summary>
        [DataMember(Name = "telephoneNumber", IsRequired = false, EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MbwayDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as MbwayDetails);
        }

        /// <summary>
        /// Returns true if MbwayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MbwayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MbwayDetails input)
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
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
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
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                if (this.TelephoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TelephoneNumber.GetHashCode();
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
