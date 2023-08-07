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
    /// UpdateCompanyApiCredentialRequest
    /// </summary>
    [DataContract(Name = "UpdateCompanyApiCredentialRequest")]
    public partial class UpdateCompanyApiCredentialRequest : IEquatable<UpdateCompanyApiCredentialRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCompanyApiCredentialRequest" /> class.
        /// </summary>
        /// <param name="active">Indicates if the API credential is enabled..</param>
        /// <param name="allowedOrigins">The new list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential..</param>
        /// <param name="associatedMerchantAccounts">List of merchant accounts that the API credential has access to..</param>
        /// <param name="description">Description of the API credential..</param>
        /// <param name="roles">List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. Only roles assigned to &#39;ws@Company.&lt;CompanyName&gt;&#39; can be assigned to other API credentials..</param>
        public UpdateCompanyApiCredentialRequest(bool? active = default(bool?), List<string> allowedOrigins = default(List<string>), List<string> associatedMerchantAccounts = default(List<string>), string description = default(string), List<string> roles = default(List<string>))
        {
            this.Active = active;
            this.AllowedOrigins = allowedOrigins;
            this.AssociatedMerchantAccounts = associatedMerchantAccounts;
            this.Description = description;
            this.Roles = roles;
        }

        /// <summary>
        /// Indicates if the API credential is enabled.
        /// </summary>
        /// <value>Indicates if the API credential is enabled.</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The new list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential.
        /// </summary>
        /// <value>The new list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential.</value>
        [DataMember(Name = "allowedOrigins", EmitDefaultValue = false)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// List of merchant accounts that the API credential has access to.
        /// </summary>
        /// <value>List of merchant accounts that the API credential has access to.</value>
        [DataMember(Name = "associatedMerchantAccounts", EmitDefaultValue = false)]
        public List<string> AssociatedMerchantAccounts { get; set; }

        /// <summary>
        /// Description of the API credential.
        /// </summary>
        /// <value>Description of the API credential.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. Only roles assigned to &#39;ws@Company.&lt;CompanyName&gt;&#39; can be assigned to other API credentials.
        /// </summary>
        /// <value>List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. Only roles assigned to &#39;ws@Company.&lt;CompanyName&gt;&#39; can be assigned to other API credentials.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCompanyApiCredentialRequest {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  AssociatedMerchantAccounts: ").Append(AssociatedMerchantAccounts).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as UpdateCompanyApiCredentialRequest);
        }

        /// <summary>
        /// Returns true if UpdateCompanyApiCredentialRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCompanyApiCredentialRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCompanyApiCredentialRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AllowedOrigins == input.AllowedOrigins ||
                    this.AllowedOrigins != null &&
                    input.AllowedOrigins != null &&
                    this.AllowedOrigins.SequenceEqual(input.AllowedOrigins)
                ) && 
                (
                    this.AssociatedMerchantAccounts == input.AssociatedMerchantAccounts ||
                    this.AssociatedMerchantAccounts != null &&
                    input.AssociatedMerchantAccounts != null &&
                    this.AssociatedMerchantAccounts.SequenceEqual(input.AssociatedMerchantAccounts)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrigins.GetHashCode();
                }
                if (this.AssociatedMerchantAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedMerchantAccounts.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
