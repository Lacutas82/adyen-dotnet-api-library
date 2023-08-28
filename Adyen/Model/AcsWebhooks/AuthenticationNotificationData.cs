/*
* Authentication webhooks
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

namespace Adyen.Model.AcsWebhooks
{
    /// <summary>
    /// AuthenticationNotificationData
    /// </summary>
    [DataContract(Name = "AuthenticationNotificationData")]
    public partial class AuthenticationNotificationData : IEquatable<AuthenticationNotificationData>, IValidatableObject
    {
        /// <summary>
        /// Outcome of the authentication. Allowed values: * authenticated * rejected * error
        /// </summary>
        /// <value>Outcome of the authentication. Allowed values: * authenticated * rejected * error</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Authenticated for value: authenticated
            /// </summary>
            [EnumMember(Value = "authenticated")]
            Authenticated = 1,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 2,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 3

        }


        /// <summary>
        /// Outcome of the authentication. Allowed values: * authenticated * rejected * error
        /// </summary>
        /// <value>Outcome of the authentication. Allowed values: * authenticated * rejected * error</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationNotificationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationNotificationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationNotificationData" /> class.
        /// </summary>
        /// <param name="authentication">authentication (required).</param>
        /// <param name="balancePlatform">The unique identifier of the balance platform..</param>
        /// <param name="id">Unique identifier of the authentication. (required).</param>
        /// <param name="paymentInstrumentId">Unique identifier of the payment instrument that was used for the authentication. (required).</param>
        /// <param name="purchase">purchase (required).</param>
        /// <param name="status">Outcome of the authentication. Allowed values: * authenticated * rejected * error (required).</param>
        public AuthenticationNotificationData(AuthenticationInfo authentication = default(AuthenticationInfo), string balancePlatform = default(string), string id = default(string), string paymentInstrumentId = default(string), PurchaseInfo purchase = default(PurchaseInfo), StatusEnum status = default(StatusEnum))
        {
            this.Authentication = authentication;
            this.Id = id;
            this.PaymentInstrumentId = paymentInstrumentId;
            this.Purchase = purchase;
            this.Status = status;
            this.BalancePlatform = balancePlatform;
        }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", IsRequired = false, EmitDefaultValue = false)]
        public AuthenticationInfo Authentication { get; set; }

        /// <summary>
        /// The unique identifier of the balance platform.
        /// </summary>
        /// <value>The unique identifier of the balance platform.</value>
        [DataMember(Name = "balancePlatform", EmitDefaultValue = false)]
        public string BalancePlatform { get; set; }

        /// <summary>
        /// Unique identifier of the authentication.
        /// </summary>
        /// <value>Unique identifier of the authentication.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of the payment instrument that was used for the authentication.
        /// </summary>
        /// <value>Unique identifier of the payment instrument that was used for the authentication.</value>
        [DataMember(Name = "paymentInstrumentId", IsRequired = false, EmitDefaultValue = false)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Gets or Sets Purchase
        /// </summary>
        [DataMember(Name = "purchase", IsRequired = false, EmitDefaultValue = false)]
        public PurchaseInfo Purchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticationNotificationData {\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  BalancePlatform: ").Append(BalancePlatform).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PaymentInstrumentId: ").Append(PaymentInstrumentId).Append("\n");
            sb.Append("  Purchase: ").Append(Purchase).Append("\n");
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
            return this.Equals(input as AuthenticationNotificationData);
        }

        /// <summary>
        /// Returns true if AuthenticationNotificationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationNotificationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationNotificationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.BalancePlatform == input.BalancePlatform ||
                    (this.BalancePlatform != null &&
                    this.BalancePlatform.Equals(input.BalancePlatform))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PaymentInstrumentId == input.PaymentInstrumentId ||
                    (this.PaymentInstrumentId != null &&
                    this.PaymentInstrumentId.Equals(input.PaymentInstrumentId))
                ) && 
                (
                    this.Purchase == input.Purchase ||
                    (this.Purchase != null &&
                    this.Purchase.Equals(input.Purchase))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Authentication != null)
                {
                    hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                }
                if (this.BalancePlatform != null)
                {
                    hashCode = (hashCode * 59) + this.BalancePlatform.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.PaymentInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentId.GetHashCode();
                }
                if (this.Purchase != null)
                {
                    hashCode = (hashCode * 59) + this.Purchase.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
