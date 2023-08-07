/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Passcodes
    /// </summary>
    [DataContract(Name = "Passcodes")]
    public partial class Passcodes : IEquatable<Passcodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Passcodes" /> class.
        /// </summary>
        /// <param name="adminMenuPin">The passcode for the Admin menu and the Settings menu..</param>
        /// <param name="refundPin">The passcode for unreferenced refunds on standalone terminals..</param>
        /// <param name="screenLockPin">The passcode to unlock the terminal screen after a timeout..</param>
        /// <param name="txMenuPin">The passcode for the Transactions menu..</param>
        public Passcodes(string adminMenuPin = default(string), string refundPin = default(string), string screenLockPin = default(string), string txMenuPin = default(string))
        {
            this.AdminMenuPin = adminMenuPin;
            this.RefundPin = refundPin;
            this.ScreenLockPin = screenLockPin;
            this.TxMenuPin = txMenuPin;
        }

        /// <summary>
        /// The passcode for the Admin menu and the Settings menu.
        /// </summary>
        /// <value>The passcode for the Admin menu and the Settings menu.</value>
        [DataMember(Name = "adminMenuPin", EmitDefaultValue = false)]
        public string AdminMenuPin { get; set; }

        /// <summary>
        /// The passcode for unreferenced refunds on standalone terminals.
        /// </summary>
        /// <value>The passcode for unreferenced refunds on standalone terminals.</value>
        [DataMember(Name = "refundPin", EmitDefaultValue = false)]
        public string RefundPin { get; set; }

        /// <summary>
        /// The passcode to unlock the terminal screen after a timeout.
        /// </summary>
        /// <value>The passcode to unlock the terminal screen after a timeout.</value>
        [DataMember(Name = "screenLockPin", EmitDefaultValue = false)]
        public string ScreenLockPin { get; set; }

        /// <summary>
        /// The passcode for the Transactions menu.
        /// </summary>
        /// <value>The passcode for the Transactions menu.</value>
        [DataMember(Name = "txMenuPin", EmitDefaultValue = false)]
        public string TxMenuPin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Passcodes {\n");
            sb.Append("  AdminMenuPin: ").Append(AdminMenuPin).Append("\n");
            sb.Append("  RefundPin: ").Append(RefundPin).Append("\n");
            sb.Append("  ScreenLockPin: ").Append(ScreenLockPin).Append("\n");
            sb.Append("  TxMenuPin: ").Append(TxMenuPin).Append("\n");
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
            return this.Equals(input as Passcodes);
        }

        /// <summary>
        /// Returns true if Passcodes instances are equal
        /// </summary>
        /// <param name="input">Instance of Passcodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Passcodes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdminMenuPin == input.AdminMenuPin ||
                    (this.AdminMenuPin != null &&
                    this.AdminMenuPin.Equals(input.AdminMenuPin))
                ) && 
                (
                    this.RefundPin == input.RefundPin ||
                    (this.RefundPin != null &&
                    this.RefundPin.Equals(input.RefundPin))
                ) && 
                (
                    this.ScreenLockPin == input.ScreenLockPin ||
                    (this.ScreenLockPin != null &&
                    this.ScreenLockPin.Equals(input.ScreenLockPin))
                ) && 
                (
                    this.TxMenuPin == input.TxMenuPin ||
                    (this.TxMenuPin != null &&
                    this.TxMenuPin.Equals(input.TxMenuPin))
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
                if (this.AdminMenuPin != null)
                {
                    hashCode = (hashCode * 59) + this.AdminMenuPin.GetHashCode();
                }
                if (this.RefundPin != null)
                {
                    hashCode = (hashCode * 59) + this.RefundPin.GetHashCode();
                }
                if (this.ScreenLockPin != null)
                {
                    hashCode = (hashCode * 59) + this.ScreenLockPin.GetHashCode();
                }
                if (this.TxMenuPin != null)
                {
                    hashCode = (hashCode * 59) + this.TxMenuPin.GetHashCode();
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
            // AdminMenuPin (string) maxLength
            if (this.AdminMenuPin != null && this.AdminMenuPin.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdminMenuPin, length must be less than 6.", new [] { "AdminMenuPin" });
            }

            // RefundPin (string) maxLength
            if (this.RefundPin != null && this.RefundPin.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefundPin, length must be less than 6.", new [] { "RefundPin" });
            }

            // ScreenLockPin (string) maxLength
            if (this.ScreenLockPin != null && this.ScreenLockPin.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScreenLockPin, length must be less than 6.", new [] { "ScreenLockPin" });
            }

            // ScreenLockPin (string) minLength
            if (this.ScreenLockPin != null && this.ScreenLockPin.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScreenLockPin, length must be greater than 4.", new [] { "ScreenLockPin" });
            }

            // TxMenuPin (string) maxLength
            if (this.TxMenuPin != null && this.TxMenuPin.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TxMenuPin, length must be less than 6.", new [] { "TxMenuPin" });
            }

            yield break;
        }
    }

}
