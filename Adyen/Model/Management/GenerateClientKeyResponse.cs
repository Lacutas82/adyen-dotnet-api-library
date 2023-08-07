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
    /// GenerateClientKeyResponse
    /// </summary>
    [DataContract(Name = "GenerateClientKeyResponse")]
    public partial class GenerateClientKeyResponse : IEquatable<GenerateClientKeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateClientKeyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateClientKeyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateClientKeyResponse" /> class.
        /// </summary>
        /// <param name="clientKey">Generated client key (required).</param>
        public GenerateClientKeyResponse(string clientKey = default(string))
        {
            this.ClientKey = clientKey;
        }

        /// <summary>
        /// Generated client key
        /// </summary>
        /// <value>Generated client key</value>
        [DataMember(Name = "clientKey", IsRequired = false, EmitDefaultValue = false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateClientKeyResponse {\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
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
            return this.Equals(input as GenerateClientKeyResponse);
        }

        /// <summary>
        /// Returns true if GenerateClientKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateClientKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateClientKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientKey == input.ClientKey ||
                    (this.ClientKey != null &&
                    this.ClientKey.Equals(input.ClientKey))
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
                if (this.ClientKey != null)
                {
                    hashCode = (hashCode * 59) + this.ClientKey.GetHashCode();
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
