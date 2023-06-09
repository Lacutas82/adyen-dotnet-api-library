/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ThreeDS1Result
    /// </summary>
    [DataContract(Name = "ThreeDS1Result")]
    public partial class ThreeDS1Result : IEquatable<ThreeDS1Result>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS1Result" /> class.
        /// </summary>
        /// <param name="cavv">The cardholder authentication value (base64 encoded)..</param>
        /// <param name="cavvAlgorithm">The CAVV algorithm used..</param>
        /// <param name="eci">3D Secure Electronic Commerce Indicator (ECI)..</param>
        /// <param name="threeDAuthenticatedResponse">The authentication response from the ACS..</param>
        /// <param name="threeDOfferedResponse">Whether 3D Secure was offered or not..</param>
        /// <param name="xid">A unique transaction identifier generated by the MPI on behalf of the merchant to identify the 3D Secure transaction, in &#x60;Base64&#x60; encoding..</param>
        public ThreeDS1Result(string cavv = default(string), string cavvAlgorithm = default(string), string eci = default(string), string threeDAuthenticatedResponse = default(string), string threeDOfferedResponse = default(string), string xid = default(string))
        {
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.Eci = eci;
            this.ThreeDAuthenticatedResponse = threeDAuthenticatedResponse;
            this.ThreeDOfferedResponse = threeDOfferedResponse;
            this.Xid = xid;
        }

        /// <summary>
        /// The cardholder authentication value (base64 encoded).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded).</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public string Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used.
        /// </summary>
        /// <value>The CAVV algorithm used.</value>
        [DataMember(Name = "cavvAlgorithm", EmitDefaultValue = false)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// 3D Secure Electronic Commerce Indicator (ECI).
        /// </summary>
        /// <value>3D Secure Electronic Commerce Indicator (ECI).</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// The authentication response from the ACS.
        /// </summary>
        /// <value>The authentication response from the ACS.</value>
        [DataMember(Name = "threeDAuthenticatedResponse", EmitDefaultValue = false)]
        public string ThreeDAuthenticatedResponse { get; set; }

        /// <summary>
        /// Whether 3D Secure was offered or not.
        /// </summary>
        /// <value>Whether 3D Secure was offered or not.</value>
        [DataMember(Name = "threeDOfferedResponse", EmitDefaultValue = false)]
        public string ThreeDOfferedResponse { get; set; }

        /// <summary>
        /// A unique transaction identifier generated by the MPI on behalf of the merchant to identify the 3D Secure transaction, in &#x60;Base64&#x60; encoding.
        /// </summary>
        /// <value>A unique transaction identifier generated by the MPI on behalf of the merchant to identify the 3D Secure transaction, in &#x60;Base64&#x60; encoding.</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public string Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDS1Result {\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  ThreeDAuthenticatedResponse: ").Append(ThreeDAuthenticatedResponse).Append("\n");
            sb.Append("  ThreeDOfferedResponse: ").Append(ThreeDOfferedResponse).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as ThreeDS1Result);
        }

        /// <summary>
        /// Returns true if ThreeDS1Result instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS1Result to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS1Result input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.ThreeDAuthenticatedResponse == input.ThreeDAuthenticatedResponse ||
                    (this.ThreeDAuthenticatedResponse != null &&
                    this.ThreeDAuthenticatedResponse.Equals(input.ThreeDAuthenticatedResponse))
                ) && 
                (
                    this.ThreeDOfferedResponse == input.ThreeDOfferedResponse ||
                    (this.ThreeDOfferedResponse != null &&
                    this.ThreeDOfferedResponse.Equals(input.ThreeDOfferedResponse))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
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
                if (this.Cavv != null)
                {
                    hashCode = (hashCode * 59) + this.Cavv.GetHashCode();
                }
                if (this.CavvAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.CavvAlgorithm.GetHashCode();
                }
                if (this.Eci != null)
                {
                    hashCode = (hashCode * 59) + this.Eci.GetHashCode();
                }
                if (this.ThreeDAuthenticatedResponse != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDAuthenticatedResponse.GetHashCode();
                }
                if (this.ThreeDOfferedResponse != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDOfferedResponse.GetHashCode();
                }
                if (this.Xid != null)
                {
                    hashCode = (hashCode * 59) + this.Xid.GetHashCode();
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
