/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 54
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

namespace Adyen.Model.BinLookup
{
    /// <summary>
    /// DSPublicKeyDetail
    /// </summary>
    [DataContract(Name = "DSPublicKeyDetail")]
    public partial class DSPublicKeyDetail : IEquatable<DSPublicKeyDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DSPublicKeyDetail" /> class.
        /// </summary>
        /// <param name="brand">Card brand..</param>
        /// <param name="directoryServerId">Directory Server (DS) identifier..</param>
        /// <param name="fromSDKVersion">The version of the mobile 3D Secure 2 SDK. For the possible values, refer to the versions in [Adyen 3DS2 Android](https://github.com/Adyen/adyen-3ds2-android/releases) and [Adyen 3DS2 iOS](https://github.com/Adyen/adyen-3ds2-ios/releases)..</param>
        /// <param name="publicKey">Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key..</param>
        public DSPublicKeyDetail(string brand = default(string), string directoryServerId = default(string), string fromSDKVersion = default(string), byte[] publicKey = default(byte[]))
        {
            this.Brand = brand;
            this.DirectoryServerId = directoryServerId;
            this.FromSDKVersion = fromSDKVersion;
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Directory Server (DS) identifier.
        /// </summary>
        /// <value>Directory Server (DS) identifier.</value>
        [DataMember(Name = "directoryServerId", EmitDefaultValue = false)]
        public string DirectoryServerId { get; set; }

        /// <summary>
        /// The version of the mobile 3D Secure 2 SDK. For the possible values, refer to the versions in [Adyen 3DS2 Android](https://github.com/Adyen/adyen-3ds2-android/releases) and [Adyen 3DS2 iOS](https://github.com/Adyen/adyen-3ds2-ios/releases).
        /// </summary>
        /// <value>The version of the mobile 3D Secure 2 SDK. For the possible values, refer to the versions in [Adyen 3DS2 Android](https://github.com/Adyen/adyen-3ds2-android/releases) and [Adyen 3DS2 iOS](https://github.com/Adyen/adyen-3ds2-ios/releases).</value>
        [DataMember(Name = "fromSDKVersion", EmitDefaultValue = false)]
        public string FromSDKVersion { get; set; }

        /// <summary>
        /// Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key.
        /// </summary>
        /// <value>Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key.</value>
        [DataMember(Name = "publicKey", EmitDefaultValue = false)]
        public byte[] PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DSPublicKeyDetail {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  DirectoryServerId: ").Append(DirectoryServerId).Append("\n");
            sb.Append("  FromSDKVersion: ").Append(FromSDKVersion).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as DSPublicKeyDetail);
        }

        /// <summary>
        /// Returns true if DSPublicKeyDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DSPublicKeyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSPublicKeyDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.DirectoryServerId == input.DirectoryServerId ||
                    (this.DirectoryServerId != null &&
                    this.DirectoryServerId.Equals(input.DirectoryServerId))
                ) && 
                (
                    this.FromSDKVersion == input.FromSDKVersion ||
                    (this.FromSDKVersion != null &&
                    this.FromSDKVersion.Equals(input.FromSDKVersion))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.DirectoryServerId != null)
                {
                    hashCode = (hashCode * 59) + this.DirectoryServerId.GetHashCode();
                }
                if (this.FromSDKVersion != null)
                {
                    hashCode = (hashCode * 59) + this.FromSDKVersion.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
