/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// USLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "USLocalAccountIdentification")]
    public partial class USLocalAccountIdentification : IEquatable<USLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.
        /// </summary>
        /// <value>The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 1,

            /// <summary>
            /// Enum Savings for value: savings
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings = 2

        }


        /// <summary>
        /// The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.
        /// </summary>
        /// <value>The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// **usLocal**
        /// </summary>
        /// <value>**usLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum UsLocal for value: usLocal
            /// </summary>
            [EnumMember(Value = "usLocal")]
            UsLocal = 1

        }


        /// <summary>
        /// **usLocal**
        /// </summary>
        /// <value>**usLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="USLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected USLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="USLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The bank account number, without separators or whitespace. (required).</param>
        /// <param name="accountType">The bank account type.  Possible values: **checking** or **savings**. Defaults to **checking**. (default to AccountTypeEnum.Checking).</param>
        /// <param name="routingNumber">The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or whitespace. (required).</param>
        /// <param name="type">**usLocal** (required) (default to TypeEnum.UsLocal).</param>
        public USLocalAccountIdentification(string accountNumber = default(string), AccountTypeEnum? accountType = AccountTypeEnum.Checking, string routingNumber = default(string), TypeEnum type = TypeEnum.UsLocal)
        {
            this.AccountNumber = accountNumber;
            this.RoutingNumber = routingNumber;
            this.Type = type;
            this.AccountType = accountType;
        }

        /// <summary>
        /// The bank account number, without separators or whitespace.
        /// </summary>
        /// <value>The bank account number, without separators or whitespace.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or whitespace.
        /// </summary>
        /// <value>The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or whitespace.</value>
        [DataMember(Name = "routingNumber", IsRequired = false, EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class USLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
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
            return this.Equals(input as USLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if USLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of USLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(USLocalAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
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
            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 18.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 2.", new [] { "AccountNumber" });
            }

            // RoutingNumber (string) maxLength
            if (this.RoutingNumber != null && this.RoutingNumber.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be less than 9.", new [] { "RoutingNumber" });
            }

            // RoutingNumber (string) minLength
            if (this.RoutingNumber != null && this.RoutingNumber.Length < 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be greater than 9.", new [] { "RoutingNumber" });
            }

            yield break;
        }
    }

}
