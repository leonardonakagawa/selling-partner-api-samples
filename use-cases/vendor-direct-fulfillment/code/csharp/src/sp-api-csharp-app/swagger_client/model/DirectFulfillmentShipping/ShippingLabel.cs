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
    /// ShippingLabel
    /// </summary>
    [DataContract]
    public partial class ShippingLabel :  IEquatable<ShippingLabel>, IValidatableObject
    {
        /// <summary>
        /// Format of the label.
        /// </summary>
        /// <value>Format of the label.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelFormatEnum
        {
            
            /// <summary>
            /// Enum PNG for value: PNG
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG = 1,
            
            /// <summary>
            /// Enum ZPL for value: ZPL
            /// </summary>
            [EnumMember(Value = "ZPL")]
            ZPL = 2
        }

        /// <summary>
        /// Format of the label.
        /// </summary>
        /// <value>Format of the label.</value>
        [DataMember(Name="labelFormat", EmitDefaultValue=false)]
        public LabelFormatEnum LabelFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLabel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingLabel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLabel" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">This field will contain the Purchase Order Number for this order. (required).</param>
        /// <param name="sellingParty">ID of the selling party or vendor. (required).</param>
        /// <param name="shipFromParty">Warehouse code of vendor. (required).</param>
        /// <param name="labelFormat">Format of the label. (required).</param>
        /// <param name="labelData">Provides the details of the packages in this shipment. (required).</param>
        public ShippingLabel(string purchaseOrderNumber = default(string), PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipFromParty = default(PartyIdentification), LabelFormatEnum labelFormat = default(LabelFormatEnum), List<LabelData> labelData = default(List<LabelData>))
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new InvalidDataException("purchaseOrderNumber is a required property for ShippingLabel and cannot be null");
            }
            else
            {
                this.PurchaseOrderNumber = purchaseOrderNumber;
            }
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new InvalidDataException("sellingParty is a required property for ShippingLabel and cannot be null");
            }
            else
            {
                this.SellingParty = sellingParty;
            }
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new InvalidDataException("shipFromParty is a required property for ShippingLabel and cannot be null");
            }
            else
            {
                this.ShipFromParty = shipFromParty;
            }
            // to ensure "labelFormat" is required (not null)
            if (labelFormat == null)
            {
                throw new InvalidDataException("labelFormat is a required property for ShippingLabel and cannot be null");
            }
            else
            {
                this.LabelFormat = labelFormat;
            }
            // to ensure "labelData" is required (not null)
            if (labelData == null)
            {
                throw new InvalidDataException("labelData is a required property for ShippingLabel and cannot be null");
            }
            else
            {
                this.LabelData = labelData;
            }
        }
        
        /// <summary>
        /// This field will contain the Purchase Order Number for this order.
        /// </summary>
        /// <value>This field will contain the Purchase Order Number for this order.</value>
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
        /// Provides the details of the packages in this shipment.
        /// </summary>
        /// <value>Provides the details of the packages in this shipment.</value>
        [DataMember(Name="labelData", EmitDefaultValue=false)]
        public List<LabelData> LabelData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingLabel {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
            sb.Append("  LabelData: ").Append(LabelData).Append("\n");
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
            return this.Equals(input as ShippingLabel);
        }

        /// <summary>
        /// Returns true if ShippingLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingLabel input)
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
                    this.LabelFormat == input.LabelFormat ||
                    (this.LabelFormat != null &&
                    this.LabelFormat.Equals(input.LabelFormat))
                ) && 
                (
                    this.LabelData == input.LabelData ||
                    this.LabelData != null &&
                    this.LabelData.SequenceEqual(input.LabelData)
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
                if (this.LabelFormat != null)
                    hashCode = hashCode * 59 + this.LabelFormat.GetHashCode();
                if (this.LabelData != null)
                    hashCode = hashCode * 59 + this.LabelData.GetHashCode();
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
