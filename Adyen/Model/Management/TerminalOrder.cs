/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// TerminalOrder
    /// </summary>
    [DataContract(Name = "TerminalOrder")]
    public partial class TerminalOrder : IEquatable<TerminalOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalOrder" /> class.
        /// </summary>
        /// <param name="billingEntity">billingEntity.</param>
        /// <param name="customerOrderReference">The merchant-defined purchase order number. This will be printed on the packing list..</param>
        /// <param name="id">The unique identifier of the order..</param>
        /// <param name="items">The products included in the order..</param>
        /// <param name="orderDate">The date and time that the order was placed, in UTC ISO 8601 format. For example, \&quot;2011-12-03T10:15:30Z\&quot;..</param>
        /// <param name="shippingLocation">shippingLocation.</param>
        /// <param name="status">The processing status of the order..</param>
        /// <param name="trackingUrl">The URL, provided by the carrier company, where the shipment can be tracked..</param>
        public TerminalOrder(BillingEntity billingEntity = default(BillingEntity), string customerOrderReference = default(string), string id = default(string), List<OrderItem> items = default(List<OrderItem>), string orderDate = default(string), ShippingLocation shippingLocation = default(ShippingLocation), string status = default(string), string trackingUrl = default(string))
        {
            this.BillingEntity = billingEntity;
            this.CustomerOrderReference = customerOrderReference;
            this.Id = id;
            this.Items = items;
            this.OrderDate = orderDate;
            this.ShippingLocation = shippingLocation;
            this.Status = status;
            this.TrackingUrl = trackingUrl;
        }

        /// <summary>
        /// Gets or Sets BillingEntity
        /// </summary>
        [DataMember(Name = "billingEntity", EmitDefaultValue = false)]
        public BillingEntity BillingEntity { get; set; }

        /// <summary>
        /// The merchant-defined purchase order number. This will be printed on the packing list.
        /// </summary>
        /// <value>The merchant-defined purchase order number. This will be printed on the packing list.</value>
        [DataMember(Name = "customerOrderReference", EmitDefaultValue = false)]
        public string CustomerOrderReference { get; set; }

        /// <summary>
        /// The unique identifier of the order.
        /// </summary>
        /// <value>The unique identifier of the order.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The products included in the order.
        /// </summary>
        /// <value>The products included in the order.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// The date and time that the order was placed, in UTC ISO 8601 format. For example, \&quot;2011-12-03T10:15:30Z\&quot;.
        /// </summary>
        /// <value>The date and time that the order was placed, in UTC ISO 8601 format. For example, \&quot;2011-12-03T10:15:30Z\&quot;.</value>
        [DataMember(Name = "orderDate", EmitDefaultValue = false)]
        public string OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets ShippingLocation
        /// </summary>
        [DataMember(Name = "shippingLocation", EmitDefaultValue = false)]
        public ShippingLocation ShippingLocation { get; set; }

        /// <summary>
        /// The processing status of the order.
        /// </summary>
        /// <value>The processing status of the order.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The URL, provided by the carrier company, where the shipment can be tracked.
        /// </summary>
        /// <value>The URL, provided by the carrier company, where the shipment can be tracked.</value>
        [DataMember(Name = "trackingUrl", EmitDefaultValue = false)]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalOrder {\n");
            sb.Append("  BillingEntity: ").Append(BillingEntity).Append("\n");
            sb.Append("  CustomerOrderReference: ").Append(CustomerOrderReference).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  ShippingLocation: ").Append(ShippingLocation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
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
            return this.Equals(input as TerminalOrder);
        }

        /// <summary>
        /// Returns true if TerminalOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillingEntity == input.BillingEntity ||
                    (this.BillingEntity != null &&
                    this.BillingEntity.Equals(input.BillingEntity))
                ) && 
                (
                    this.CustomerOrderReference == input.CustomerOrderReference ||
                    (this.CustomerOrderReference != null &&
                    this.CustomerOrderReference.Equals(input.CustomerOrderReference))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.ShippingLocation == input.ShippingLocation ||
                    (this.ShippingLocation != null &&
                    this.ShippingLocation.Equals(input.ShippingLocation))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TrackingUrl == input.TrackingUrl ||
                    (this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(input.TrackingUrl))
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
                if (this.BillingEntity != null)
                {
                    hashCode = (hashCode * 59) + this.BillingEntity.GetHashCode();
                }
                if (this.CustomerOrderReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerOrderReference.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.OrderDate != null)
                {
                    hashCode = (hashCode * 59) + this.OrderDate.GetHashCode();
                }
                if (this.ShippingLocation != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingLocation.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TrackingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingUrl.GetHashCode();
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
