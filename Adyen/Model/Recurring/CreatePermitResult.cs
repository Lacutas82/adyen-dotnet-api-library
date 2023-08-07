/*
* Adyen Recurring API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// CreatePermitResult
    /// </summary>
    [DataContract(Name = "CreatePermitResult")]
    public partial class CreatePermitResult : IEquatable<CreatePermitResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePermitResult" /> class.
        /// </summary>
        /// <param name="permitResultList">List of new permits..</param>
        /// <param name="pspReference">A unique reference associated with the request. This value is globally unique; quote it when communicating with us about this request..</param>
        public CreatePermitResult(List<PermitResult> permitResultList = default(List<PermitResult>), string pspReference = default(string))
        {
            this.PermitResultList = permitResultList;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// List of new permits.
        /// </summary>
        /// <value>List of new permits.</value>
        [DataMember(Name = "permitResultList", EmitDefaultValue = false)]
        public List<PermitResult> PermitResultList { get; set; }

        /// <summary>
        /// A unique reference associated with the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>A unique reference associated with the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePermitResult {\n");
            sb.Append("  PermitResultList: ").Append(PermitResultList).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as CreatePermitResult);
        }

        /// <summary>
        /// Returns true if CreatePermitResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePermitResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePermitResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PermitResultList == input.PermitResultList ||
                    this.PermitResultList != null &&
                    input.PermitResultList != null &&
                    this.PermitResultList.SequenceEqual(input.PermitResultList)
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
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
                if (this.PermitResultList != null)
                {
                    hashCode = (hashCode * 59) + this.PermitResultList.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
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
