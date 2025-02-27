/*
* Management API
*
*
* The version of the OpenAPI document: 3
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
    /// Notification
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// The type of event notification sent when you select the notification button.
        /// </summary>
        /// <value>The type of event notification sent when you select the notification button.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum SaleWakeUp for value: SaleWakeUp
            /// </summary>
            [EnumMember(Value = "SaleWakeUp")]
            SaleWakeUp = 1,

            /// <summary>
            /// Enum KeyPressed for value: KeyPressed
            /// </summary>
            [EnumMember(Value = "KeyPressed")]
            KeyPressed = 2

        }


        /// <summary>
        /// The type of event notification sent when you select the notification button.
        /// </summary>
        /// <value>The type of event notification sent when you select the notification button.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="category">The type of event notification sent when you select the notification button..</param>
        /// <param name="details">The text shown in the prompt which opens when you select the notification button. For example, the description of the input box for pay-at-table..</param>
        /// <param name="enabled">Enables sending event notifications either by pressing the Confirm key on terminals with a keypad or by tapping the event notification button on the terminal screen..</param>
        /// <param name="showButton">Shows or hides the event notification button on the screen of terminal models that have a keypad..</param>
        /// <param name="title">The name of the notification button on the terminal screen..</param>
        public Notification(CategoryEnum? category = default(CategoryEnum?), string details = default(string), bool? enabled = default(bool?), bool? showButton = default(bool?), string title = default(string))
        {
            this.Category = category;
            this.Details = details;
            this.Enabled = enabled;
            this.ShowButton = showButton;
            this.Title = title;
        }

        /// <summary>
        /// The text shown in the prompt which opens when you select the notification button. For example, the description of the input box for pay-at-table.
        /// </summary>
        /// <value>The text shown in the prompt which opens when you select the notification button. For example, the description of the input box for pay-at-table.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Enables sending event notifications either by pressing the Confirm key on terminals with a keypad or by tapping the event notification button on the terminal screen.
        /// </summary>
        /// <value>Enables sending event notifications either by pressing the Confirm key on terminals with a keypad or by tapping the event notification button on the terminal screen.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Shows or hides the event notification button on the screen of terminal models that have a keypad.
        /// </summary>
        /// <value>Shows or hides the event notification button on the screen of terminal models that have a keypad.</value>
        [DataMember(Name = "showButton", EmitDefaultValue = false)]
        public bool? ShowButton { get; set; }

        /// <summary>
        /// The name of the notification button on the terminal screen.
        /// </summary>
        /// <value>The name of the notification button on the terminal screen.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ShowButton: ").Append(ShowButton).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ShowButton == input.ShowButton ||
                    this.ShowButton.Equals(input.ShowButton)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowButton.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
