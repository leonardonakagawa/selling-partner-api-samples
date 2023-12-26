/* 
 * Selling Partner API for Tokens 
 *
 * The Selling Partner API for Tokens provides a secure way to access a customer's PII (Personally Identifiable Information). You can call the Tokens API to get a Restricted Data Token (RDT) for one or more restricted resources that you specify. The RDT authorizes subsequent calls to restricted operations that correspond to the restricted resources that you specified.  For more information, see the [Tokens API Use Case Guide](doc:tokens-api-use-case-guide).
 *
 * OpenAPI spec version: 2021-03-01
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

namespace spApiCsharpApp.swaggerClient.Model.Tokens
{
    /// <summary>
    /// The request schema for the createRestrictedDataToken operation.
    /// </summary>
    [DataContract]
    public partial class CreateRestrictedDataTokenRequest :  IEquatable<CreateRestrictedDataTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRestrictedDataTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRestrictedDataTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRestrictedDataTokenRequest" /> class.
        /// </summary>
        /// <param name="targetApplication">The application ID for the target application to which access is being delegated..</param>
        /// <param name="restrictedResources">A list of restricted resources. Maximum: 50 (required).</param>
        public CreateRestrictedDataTokenRequest(string targetApplication = default(string), List<RestrictedResource> restrictedResources = default(List<RestrictedResource>))
        {
            // to ensure "restrictedResources" is required (not null)
            if (restrictedResources == null)
            {
                throw new InvalidDataException("restrictedResources is a required property for CreateRestrictedDataTokenRequest and cannot be null");
            }
            else
            {
                this.RestrictedResources = restrictedResources;
            }
            this.TargetApplication = targetApplication;
        }
        
        /// <summary>
        /// The application ID for the target application to which access is being delegated.
        /// </summary>
        /// <value>The application ID for the target application to which access is being delegated.</value>
        [DataMember(Name="targetApplication", EmitDefaultValue=false)]
        public string TargetApplication { get; set; }

        /// <summary>
        /// A list of restricted resources. Maximum: 50
        /// </summary>
        /// <value>A list of restricted resources. Maximum: 50</value>
        [DataMember(Name="restrictedResources", EmitDefaultValue=false)]
        public List<RestrictedResource> RestrictedResources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRestrictedDataTokenRequest {\n");
            sb.Append("  TargetApplication: ").Append(TargetApplication).Append("\n");
            sb.Append("  RestrictedResources: ").Append(RestrictedResources).Append("\n");
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
            return this.Equals(input as CreateRestrictedDataTokenRequest);
        }

        /// <summary>
        /// Returns true if CreateRestrictedDataTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRestrictedDataTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRestrictedDataTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetApplication == input.TargetApplication ||
                    (this.TargetApplication != null &&
                    this.TargetApplication.Equals(input.TargetApplication))
                ) && 
                (
                    this.RestrictedResources == input.RestrictedResources ||
                    this.RestrictedResources != null &&
                    this.RestrictedResources.SequenceEqual(input.RestrictedResources)
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
                if (this.TargetApplication != null)
                    hashCode = hashCode * 59 + this.TargetApplication.GetHashCode();
                if (this.RestrictedResources != null)
                    hashCode = hashCode * 59 + this.RestrictedResources.GetHashCode();
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
