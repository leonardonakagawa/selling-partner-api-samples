/* 
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * The Selling Partner API for Direct Fulfillment Shipping provides programmatic access to a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = spApiCsharpApp.swaggerClient.Client.SwaggerDateConverter;

namespace spApiCsharpApp.swaggerClient.Model.DirectFulfillmentShipping
{
    /// <summary>
    /// Details about a shipment.
    /// </summary>
    [DataContract]
    public partial class ShipmentDetails :  IEquatable<ShipmentDetails>, IValidatableObject
    {
        /// <summary>
        /// Indicate the shipment status.
        /// </summary>
        /// <value>Indicate the shipment status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentStatusEnum
        {
            
            /// <summary>
            /// Enum SHIPPED for value: SHIPPED
            /// </summary>
            [EnumMember(Value = "SHIPPED")]
            SHIPPED = 1,
            
            /// <summary>
            /// Enum FLOORDENIAL for value: FLOOR_DENIAL
            /// </summary>
            [EnumMember(Value = "FLOOR_DENIAL")]
            FLOORDENIAL = 2
        }

        /// <summary>
        /// Indicate the shipment status.
        /// </summary>
        /// <value>Indicate the shipment status.</value>
        [DataMember(Name="shipmentStatus", EmitDefaultValue=false)]
        public ShipmentStatusEnum ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDetails" /> class.
        /// </summary>
        /// <param name="shippedDate">This field indicates the date of the departure of the shipment from vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Amazon destination warehouse, whichever is sooner. Shipped date mentioned in the Shipment Confirmation should not be in the future. (required).</param>
        /// <param name="shipmentStatus">Indicate the shipment status. (required).</param>
        /// <param name="isPriorityShipment">Provide the priority of the shipment..</param>
        /// <param name="vendorOrderNumber">The vendor order number is a unique identifier generated by a vendor for their reference..</param>
        /// <param name="estimatedDeliveryDate">Date on which the shipment is expected to reach the buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between the ship-from location and the destination. The exact appointment time will be provided by buyer and is potentially not known when creating the shipment confirmation..</param>
        public ShipmentDetails(DateTime? shippedDate = default(DateTime?), ShipmentStatusEnum shipmentStatus = default(ShipmentStatusEnum), bool? isPriorityShipment = default(bool?), string vendorOrderNumber = default(string), DateTime? estimatedDeliveryDate = default(DateTime?))
        {
            // to ensure "shippedDate" is required (not null)
            if (shippedDate == null)
            {
                throw new InvalidDataException("shippedDate is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShippedDate = shippedDate;
            }
            // to ensure "shipmentStatus" is required (not null)
            if (shipmentStatus == null)
            {
                throw new InvalidDataException("shipmentStatus is a required property for ShipmentDetails and cannot be null");
            }
            else
            {
                this.ShipmentStatus = shipmentStatus;
            }
            this.IsPriorityShipment = isPriorityShipment;
            this.VendorOrderNumber = vendorOrderNumber;
            this.EstimatedDeliveryDate = estimatedDeliveryDate;
        }
        
        /// <summary>
        /// This field indicates the date of the departure of the shipment from vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Amazon destination warehouse, whichever is sooner. Shipped date mentioned in the Shipment Confirmation should not be in the future.
        /// </summary>
        /// <value>This field indicates the date of the departure of the shipment from vendor&#39;s location. Vendors are requested to send ASNs within 30 minutes of departure from their warehouse/distribution center or at least 6 hours prior to the appointment time at the Amazon destination warehouse, whichever is sooner. Shipped date mentioned in the Shipment Confirmation should not be in the future.</value>
        [DataMember(Name="shippedDate", EmitDefaultValue=false)]
        public DateTime? ShippedDate { get; set; }


        /// <summary>
        /// Provide the priority of the shipment.
        /// </summary>
        /// <value>Provide the priority of the shipment.</value>
        [DataMember(Name="isPriorityShipment", EmitDefaultValue=false)]
        public bool? IsPriorityShipment { get; set; }

        /// <summary>
        /// The vendor order number is a unique identifier generated by a vendor for their reference.
        /// </summary>
        /// <value>The vendor order number is a unique identifier generated by a vendor for their reference.</value>
        [DataMember(Name="vendorOrderNumber", EmitDefaultValue=false)]
        public string VendorOrderNumber { get; set; }

        /// <summary>
        /// Date on which the shipment is expected to reach the buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between the ship-from location and the destination. The exact appointment time will be provided by buyer and is potentially not known when creating the shipment confirmation.
        /// </summary>
        /// <value>Date on which the shipment is expected to reach the buyer&#39;s warehouse. It needs to be an estimate based on the average transit time between the ship-from location and the destination. The exact appointment time will be provided by buyer and is potentially not known when creating the shipment confirmation.</value>
        [DataMember(Name="estimatedDeliveryDate", EmitDefaultValue=false)]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentDetails {\n");
            sb.Append("  ShippedDate: ").Append(ShippedDate).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  IsPriorityShipment: ").Append(IsPriorityShipment).Append("\n");
            sb.Append("  VendorOrderNumber: ").Append(VendorOrderNumber).Append("\n");
            sb.Append("  EstimatedDeliveryDate: ").Append(EstimatedDeliveryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipmentDetails);
        }

        /// <summary>
        /// Returns true if ShipmentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShippedDate == input.ShippedDate ||
                    (this.ShippedDate != null &&
                    this.ShippedDate.Equals(input.ShippedDate))
                ) && 
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    (this.ShipmentStatus != null &&
                    this.ShipmentStatus.Equals(input.ShipmentStatus))
                ) && 
                (
                    this.IsPriorityShipment == input.IsPriorityShipment ||
                    (this.IsPriorityShipment != null &&
                    this.IsPriorityShipment.Equals(input.IsPriorityShipment))
                ) && 
                (
                    this.VendorOrderNumber == input.VendorOrderNumber ||
                    (this.VendorOrderNumber != null &&
                    this.VendorOrderNumber.Equals(input.VendorOrderNumber))
                ) && 
                (
                    this.EstimatedDeliveryDate == input.EstimatedDeliveryDate ||
                    (this.EstimatedDeliveryDate != null &&
                    this.EstimatedDeliveryDate.Equals(input.EstimatedDeliveryDate))
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
                if (this.ShippedDate != null)
                    hashCode = hashCode * 59 + this.ShippedDate.GetHashCode();
                if (this.ShipmentStatus != null)
                    hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                if (this.IsPriorityShipment != null)
                    hashCode = hashCode * 59 + this.IsPriorityShipment.GetHashCode();
                if (this.VendorOrderNumber != null)
                    hashCode = hashCode * 59 + this.VendorOrderNumber.GetHashCode();
                if (this.EstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.EstimatedDeliveryDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
