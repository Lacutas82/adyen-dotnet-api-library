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
    /// TransferInstrument
    /// </summary>
    [DataContract(Name = "TransferInstrument")]
    public partial class TransferInstrument : IEquatable<TransferInstrument>, IValidatableObject
    {
        /// <summary>
        /// The type of transfer instrument.  Possible value: **bankAccount**.
        /// </summary>
        /// <value>The type of transfer instrument.  Possible value: **bankAccount**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bankAccount
            /// </summary>
            [EnumMember(Value = "bankAccount")]
            BankAccount = 1,

            /// <summary>
            /// Enum RecurringDetail for value: recurringDetail
            /// </summary>
            [EnumMember(Value = "recurringDetail")]
            RecurringDetail = 2

        }


        /// <summary>
        /// The type of transfer instrument.  Possible value: **bankAccount**.
        /// </summary>
        /// <value>The type of transfer instrument.  Possible value: **bankAccount**.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInstrument" /> class.
        /// </summary>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="capabilities">List of capabilities for this supporting entity..</param>
        /// <param name="documentDetails">List of documents uploaded for the transfer instrument..</param>
        /// <param name="legalEntityId">The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) that owns the transfer instrument. (required).</param>
        /// <param name="problems">List of the verification errors from capabilities for this supporting entity..</param>
        /// <param name="type">The type of transfer instrument.  Possible value: **bankAccount**. (required).</param>
        public TransferInstrument(BankAccountInfo bankAccount = default(BankAccountInfo), Dictionary<string, SupportingEntityCapability> capabilities = default(Dictionary<string, SupportingEntityCapability>), List<DocumentReference> documentDetails = default(List<DocumentReference>), string legalEntityId = default(string), List<CapabilityProblem> problems = default(List<CapabilityProblem>), TypeEnum type = default(TypeEnum))
        {
            this.BankAccount = bankAccount;
            this.LegalEntityId = legalEntityId;
            this.Type = type;
            this.Capabilities = capabilities;
            this.DocumentDetails = documentDetails;
            this.Problems = problems;
        }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bankAccount", IsRequired = false, EmitDefaultValue = false)]
        public BankAccountInfo BankAccount { get; set; }

        /// <summary>
        /// List of capabilities for this supporting entity.
        /// </summary>
        /// <value>List of capabilities for this supporting entity.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Dictionary<string, SupportingEntityCapability> Capabilities { get; set; }

        /// <summary>
        /// List of documents uploaded for the transfer instrument.
        /// </summary>
        /// <value>List of documents uploaded for the transfer instrument.</value>
        [DataMember(Name = "documentDetails", EmitDefaultValue = false)]
        public List<DocumentReference> DocumentDetails { get; set; }

        /// <summary>
        /// The unique identifier of the transfer instrument.
        /// </summary>
        /// <value>The unique identifier of the transfer instrument.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) that owns the transfer instrument.
        /// </summary>
        /// <value>The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id) that owns the transfer instrument.</value>
        [DataMember(Name = "legalEntityId", IsRequired = false, EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// List of the verification errors from capabilities for this supporting entity.
        /// </summary>
        /// <value>List of the verification errors from capabilities for this supporting entity.</value>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<CapabilityProblem> Problems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferInstrument {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
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
            return this.Equals(input as TransferInstrument);
        }

        /// <summary>
        /// Returns true if TransferInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferInstrument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.DocumentDetails == input.DocumentDetails ||
                    this.DocumentDetails != null &&
                    input.DocumentDetails != null &&
                    this.DocumentDetails.SequenceEqual(input.DocumentDetails)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
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
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.DocumentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentDetails.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
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
