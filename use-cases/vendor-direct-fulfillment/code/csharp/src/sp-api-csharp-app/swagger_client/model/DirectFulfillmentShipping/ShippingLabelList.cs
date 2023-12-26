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
    /// ShippingLabelList
    /// </summary>
    [DataContract]
    public partial class ShippingLabelList :  IEquatable<ShippingLabelList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLabelList" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="shippingLabels">shippingLabels.</param>
        public ShippingLabelList(Pagination pagination = default(Pagination), List<ShippingLabel> shippingLabels = default(List<ShippingLabel>))
        {
            this.Pagination = pagination;
            this.ShippingLabels = shippingLabels;
        }
        
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets ShippingLabels
        /// </summary>
        [DataMember(Name="shippingLabels", EmitDefaultValue=false)]
        public List<ShippingLabel> ShippingLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingLabelList {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  ShippingLabels: ").Append(ShippingLabels).Append("\n");
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
            return this.Equals(input as ShippingLabelList);
        }

        /// <summary>
        /// Returns true if ShippingLabelList instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingLabelList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingLabelList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.ShippingLabels == input.ShippingLabels ||
                    this.ShippingLabels != null &&
                    this.ShippingLabels.SequenceEqual(input.ShippingLabels)
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
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.ShippingLabels != null)
                    hashCode = hashCode * 59 + this.ShippingLabels.GetHashCode();
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
