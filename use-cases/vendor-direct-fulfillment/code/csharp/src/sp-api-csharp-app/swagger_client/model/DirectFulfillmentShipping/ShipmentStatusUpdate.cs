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
    /// ShipmentStatusUpdate
    /// </summary>
    [DataContract]
    public partial class ShipmentStatusUpdate :  IEquatable<ShipmentStatusUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentStatusUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentStatusUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentStatusUpdate" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">Purchase order number of the shipment for which to update the shipment status. (required).</param>
        /// <param name="sellingParty">ID of the selling party or vendor. (required).</param>
        /// <param name="shipFromParty">Warehouse code of vendor. (required).</param>
        /// <param name="statusUpdateDetails">Provide the details about the status of the shipment at that particular point of time. (required).</param>
        public ShipmentStatusUpdate(string purchaseOrderNumber = default(string), PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipFromParty = default(PartyIdentification), StatusUpdateDetails statusUpdateDetails = default(StatusUpdateDetails))
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new InvalidDataException("purchaseOrderNumber is a required property for ShipmentStatusUpdate and cannot be null");
            }
            else
            {
                this.PurchaseOrderNumber = purchaseOrderNumber;
            }
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for ShipmentStatusUpdate and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for ShipmentStatusUpdate and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            // to ensure "statusUpdateDetails" is required (not null)
            if (statusUpdateDetails == null)
            {
                throw new InvalidDataException("statusUpdateDetails is a required property for ShipmentStatusUpdate and cannot be null");
            }
            else
            {
                this.StatusUpdateDetails = statusUpdateDetails;
            }
        }
        
        /// <summary>
        /// Purchase order number of the shipment for which to update the shipment status.
        /// </summary>
        /// <value>Purchase order number of the shipment for which to update the shipment status.</value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// ID of the selling party or vendor.
        /// </summary>
        /// <value>ID of the selling party or vendor.</value>
        [DataMember(Name="sellingParty", EmitDefaultValue=false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Warehouse code of vendor.
        /// </summary>
        /// <value>Warehouse code of vendor.</value>
        [DataMember(Name="shipFromParty", EmitDefaultValue=false)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// Provide the details about the status of the shipment at that particular point of time.
        /// </summary>
        /// <value>Provide the details about the status of the shipment at that particular point of time.</value>
        [DataMember(Name="statusUpdateDetails", EmitDefaultValue=false)]
        public StatusUpdateDetails StatusUpdateDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentStatusUpdate {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  StatusUpdateDetails: ").Append(StatusUpdateDetails).Append("\n");
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
            return this.Equals(input as ShipmentStatusUpdate);
        }

        /// <summary>
        /// Returns true if ShipmentStatusUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentStatusUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentStatusUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.SellingParty == input.SellingParty ||
                    (this.SellingParty != null &&
                    this.SellingParty.Equals(input.SellingParty))
                ) && 
                (
                    this.ShipFromParty == input.ShipFromParty ||
                    (this.ShipFromParty != null &&
                    this.ShipFromParty.Equals(input.ShipFromParty))
                ) && 
                (
                    this.StatusUpdateDetails == input.StatusUpdateDetails ||
                    (this.StatusUpdateDetails != null &&
                    this.StatusUpdateDetails.Equals(input.StatusUpdateDetails))
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
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.SellingParty != null)
                    hashCode = hashCode * 59 + this.SellingParty.GetHashCode();
                if (this.ShipFromParty != null)
                    hashCode = hashCode * 59 + this.ShipFromParty.GetHashCode();
                if (this.StatusUpdateDetails != null)
                    hashCode = hashCode * 59 + this.StatusUpdateDetails.GetHashCode();
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
            // PurchaseOrderNumber (string) pattern
            Regex regexPurchaseOrderNumber = new Regex(@"^[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexPurchaseOrderNumber.Match(this.PurchaseOrderNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderNumber, must match a pattern of " + regexPurchaseOrderNumber, new [] { "PurchaseOrderNumber" });
            }

            yield break;
        }
    }

}