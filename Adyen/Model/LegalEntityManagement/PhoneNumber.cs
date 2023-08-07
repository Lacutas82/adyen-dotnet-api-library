/*
* Legal Entity Management API
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// PhoneNumber
    /// </summary>
    [DataContract(Name = "PhoneNumber")]
    public partial class PhoneNumber : IEquatable<PhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="number">The full phone number, including the country code. For example, **+3112345678**. (required).</param>
        /// <param name="type">The type of phone number.  Possible values: **mobile**, **landline**, **sip**, **fax.** .</param>
        public PhoneNumber(string number = default(string), string type = default(string))
        {
            this.Number = number;
            this.Type = type;
        }

        /// <summary>
        /// The full phone number, including the country code. For example, **+3112345678**.
        /// </summary>
        /// <value>The full phone number, including the country code. For example, **+3112345678**.</value>
        [DataMember(Name = "number", IsRequired = false, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The type of phone number.  Possible values: **mobile**, **landline**, **sip**, **fax.** 
        /// </summary>
        /// <value>The type of phone number.  Possible values: **mobile**, **landline**, **sip**, **fax.** </value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as PhoneNumber);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
