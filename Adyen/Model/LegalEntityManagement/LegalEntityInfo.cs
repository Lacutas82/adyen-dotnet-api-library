/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// LegalEntityInfo
    /// </summary>
    [DataContract(Name = "LegalEntityInfo")]
    public partial class LegalEntityInfo : IEquatable<LegalEntityInfo>, IValidatableObject
    {
        /// <summary>
        /// The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.
        /// </summary>
        /// <value>The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Individual for value: individual
            /// </summary>
            [EnumMember(Value = "individual")]
            Individual = 1,

            /// <summary>
            /// Enum Organization for value: organization
            /// </summary>
            [EnumMember(Value = "organization")]
            Organization = 2,

            /// <summary>
            /// Enum SoleProprietorship for value: soleProprietorship
            /// </summary>
            [EnumMember(Value = "soleProprietorship")]
            SoleProprietorship = 3,

            /// <summary>
            /// Enum Trust for value: trust
            /// </summary>
            [EnumMember(Value = "trust")]
            Trust = 4,

            /// <summary>
            /// Enum UnincorporatedPartnership for value: unincorporatedPartnership
            /// </summary>
            [EnumMember(Value = "unincorporatedPartnership")]
            UnincorporatedPartnership = 5

        }


        /// <summary>
        /// The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.
        /// </summary>
        /// <value>The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntityInfo" /> class.
        /// </summary>
        /// <param name="entityAssociations">List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories..</param>
        /// <param name="individual">individual.</param>
        /// <param name="organization">organization.</param>
        /// <param name="reference">Your reference for the legal entity, maximum 150 characters..</param>
        /// <param name="soleProprietorship">soleProprietorship.</param>
        /// <param name="type">The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**..</param>
        public LegalEntityInfo(List<LegalEntityAssociation> entityAssociations = default(List<LegalEntityAssociation>), Individual individual = default(Individual), Organization organization = default(Organization), string reference = default(string), SoleProprietorship soleProprietorship = default(SoleProprietorship), TypeEnum? type = default(TypeEnum?))
        {
            this.EntityAssociations = entityAssociations;
            this.Individual = individual;
            this.Organization = organization;
            this.Reference = reference;
            this.SoleProprietorship = soleProprietorship;
            this.Type = type;
        }

        /// <summary>
        /// Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, **issueCard** for Issuing.The value is an object containing the settings for the capability.
        /// </summary>
        /// <value>Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, **issueCard** for Issuing.The value is an object containing the settings for the capability.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Dictionary<string, LegalEntityCapability> Capabilities { get; private set; }

        /// <summary>
        /// Returns false as Capabilities should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCapabilities()
        {
            return false;
        }
        /// <summary>
        /// List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
        /// </summary>
        /// <value>List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.</value>
        [DataMember(Name = "entityAssociations", EmitDefaultValue = false)]
        public List<LegalEntityAssociation> EntityAssociations { get; set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name = "individual", EmitDefaultValue = false)]
        public Individual Individual { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// Your reference for the legal entity, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the legal entity, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets SoleProprietorship
        /// </summary>
        [DataMember(Name = "soleProprietorship", EmitDefaultValue = false)]
        public SoleProprietorship SoleProprietorship { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LegalEntityInfo {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  EntityAssociations: ").Append(EntityAssociations).Append("\n");
            sb.Append("  Individual: ").Append(Individual).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SoleProprietorship: ").Append(SoleProprietorship).Append("\n");
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
            return this.Equals(input as LegalEntityInfo);
        }

        /// <summary>
        /// Returns true if LegalEntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalEntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalEntityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.EntityAssociations == input.EntityAssociations ||
                    this.EntityAssociations != null &&
                    input.EntityAssociations != null &&
                    this.EntityAssociations.SequenceEqual(input.EntityAssociations)
                ) && 
                (
                    this.Individual == input.Individual ||
                    (this.Individual != null &&
                    this.Individual.Equals(input.Individual))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SoleProprietorship == input.SoleProprietorship ||
                    (this.SoleProprietorship != null &&
                    this.SoleProprietorship.Equals(input.SoleProprietorship))
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
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.EntityAssociations != null)
                {
                    hashCode = (hashCode * 59) + this.EntityAssociations.GetHashCode();
                }
                if (this.Individual != null)
                {
                    hashCode = (hashCode * 59) + this.Individual.GetHashCode();
                }
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.SoleProprietorship != null)
                {
                    hashCode = (hashCode * 59) + this.SoleProprietorship.GetHashCode();
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
