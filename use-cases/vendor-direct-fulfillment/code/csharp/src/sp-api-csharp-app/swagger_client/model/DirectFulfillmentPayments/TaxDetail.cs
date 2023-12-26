/* 
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
 *
 * OpenAPI spec version: v1
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

namespace spApiCsharpApp.swaggerClient.Model.DirectFulfillmentPayments
{
    /// <summary>
    /// Details of tax amount applied.
    /// </summary>
    [DataContract]
    public partial class TaxDetail :  IEquatable<TaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Type of the tax applied.
        /// </summary>
        /// <value>Type of the tax applied.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxTypeEnum
        {
            
            /// <summary>
            /// Enum CGST for value: CGST
            /// </summary>
            [EnumMember(Value = "CGST")]
            CGST = 1,
            
            /// <summary>
            /// Enum SGST for value: SGST
            /// </summary>
            [EnumMember(Value = "SGST")]
            SGST = 2,
            
            /// <summary>
            /// Enum CESS for value: CESS
            /// </summary>
            [EnumMember(Value = "CESS")]
            CESS = 3,
            
            /// <summary>
            /// Enum UTGST for value: UTGST
            /// </summary>
            [EnumMember(Value = "UTGST")]
            UTGST = 4,
            
            /// <summary>
            /// Enum IGST for value: IGST
            /// </summary>
            [EnumMember(Value = "IGST")]
            IGST = 5,
            
            /// <summary>
            /// Enum MwSt for value: MwSt.
            /// </summary>
            [EnumMember(Value = "MwSt.")]
            MwSt = 6,
            
            /// <summary>
            /// Enum PST for value: PST
            /// </summary>
            [EnumMember(Value = "PST")]
            PST = 7,
            
            /// <summary>
            /// Enum TVA for value: TVA
            /// </summary>
            [EnumMember(Value = "TVA")]
            TVA = 8,
            
            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 9,
            
            /// <summary>
            /// Enum GST for value: GST
            /// </summary>
            [EnumMember(Value = "GST")]
            GST = 10,
            
            /// <summary>
            /// Enum ST for value: ST
            /// </summary>
            [EnumMember(Value = "ST")]
            ST = 11,
            
            /// <summary>
            /// Enum Consumption for value: Consumption
            /// </summary>
            [EnumMember(Value = "Consumption")]
            Consumption = 12,
            
            /// <summary>
            /// Enum MutuallyDefined for value: MutuallyDefined
            /// </summary>
            [EnumMember(Value = "MutuallyDefined")]
            MutuallyDefined = 13,
            
            /// <summary>
            /// Enum DomesticVAT for value: DomesticVAT
            /// </summary>
            [EnumMember(Value = "DomesticVAT")]
            DomesticVAT = 14
        }

        /// <summary>
        /// Type of the tax applied.
        /// </summary>
        /// <value>Type of the tax applied.</value>
        [DataMember(Name="taxType", EmitDefaultValue=false)]
        public TaxTypeEnum TaxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDetail" /> class.
        /// </summary>
        /// <param name="taxType">Type of the tax applied. (required).</param>
        /// <param name="taxRate">Tax percentage applied. Percentage must be expressed in decimal..</param>
        /// <param name="taxAmount">Total tax amount applied on invoice total or an item total. (required).</param>
        /// <param name="taxableAmount">This field will contain the invoice amount that is taxable at the rate specified in the tax rate field..</param>
        public TaxDetail(TaxTypeEnum taxType = default(TaxTypeEnum), Decimal taxRate = default(Decimal), Money taxAmount = default(Money), Money taxableAmount = default(Money))
        {
            // to ensure "taxType" is required (not null)
            if (taxType == null)
            {
                throw new InvalidDataException("taxType is a required property for TaxDetail and cannot be null");
            }
            else
            {
                this.TaxType = taxType;
            }
            // to ensure "taxAmount" is required (not null)
            if (taxAmount == null)
            {
                throw new InvalidDataException("taxAmount is a required property for TaxDetail and cannot be null");
            }
            else
            {
                this.TaxAmount = taxAmount;
            }
            this.TaxRate = taxRate;
            this.TaxableAmount = taxableAmount;
        }
        

        /// <summary>
        /// Tax percentage applied. Percentage must be expressed in decimal.
        /// </summary>
        /// <value>Tax percentage applied. Percentage must be expressed in decimal.</value>
        [DataMember(Name="taxRate", EmitDefaultValue=false)]
        public Decimal TaxRate { get; set; }

        /// <summary>
        /// Total tax amount applied on invoice total or an item total.
        /// </summary>
        /// <value>Total tax amount applied on invoice total or an item total.</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public Money TaxAmount { get; set; }

        /// <summary>
        /// This field will contain the invoice amount that is taxable at the rate specified in the tax rate field.
        /// </summary>
        /// <value>This field will contain the invoice amount that is taxable at the rate specified in the tax rate field.</value>
        [DataMember(Name="taxableAmount", EmitDefaultValue=false)]
        public Money TaxableAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxDetail {\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
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
            return this.Equals(input as TaxDetail);
        }

        /// <summary>
        /// Returns true if TaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
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
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxableAmount != null)
                    hashCode = hashCode * 59 + this.TaxableAmount.GetHashCode();
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
