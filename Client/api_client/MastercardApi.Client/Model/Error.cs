/*
 * Token Connect API
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed. All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded. 
 *
 * The version of the OpenAPI document: 2.03
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = MastercardApi.Client.Client.OpenAPIDateConverter;

namespace MastercardApi.Client.Model
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="source">An element used to indicate the source of the issue causing this error. __Max Length:__ 32. Must be either:  * __INPUT__: Service input data triggered an error  * __MDES__: MDES reported an error  (required).</param>
        /// <param name="reasonCode">A reason code for the error that has occurred. See Error Reason Code definitions for the appropriate API service. __Max Length:__ 100  (required).</param>
        /// <param name="description">Description of the reason why the operation failed. __Max Length:__ 256 .</param>
        /// <param name="errorCode">Only generated by Open API. See Open API documentation for use cases. __Max Length:__ 100 .</param>
        /// <param name="recoverable">Only generated by Open API. See Open API documentation. .</param>
        public Error(string source = default(string), string reasonCode = default(string), string description = default(string), string errorCode = default(string), bool recoverable = default(bool))
        {
            // to ensure "source" is required (not null)
            if (source == null) {
                throw new ArgumentNullException("source is a required property for Error and cannot be null");
            }
            this.Source = source;
            // to ensure "reasonCode" is required (not null)
            if (reasonCode == null) {
                throw new ArgumentNullException("reasonCode is a required property for Error and cannot be null");
            }
            this.ReasonCode = reasonCode;
            this.Description = description;
            this.ErrorCode = errorCode;
            this.Recoverable = recoverable;
        }

        /// <summary>
        /// An element used to indicate the source of the issue causing this error. __Max Length:__ 32. Must be either:  * __INPUT__: Service input data triggered an error  * __MDES__: MDES reported an error 
        /// </summary>
        /// <value>An element used to indicate the source of the issue causing this error. __Max Length:__ 32. Must be either:  * __INPUT__: Service input data triggered an error  * __MDES__: MDES reported an error </value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// A reason code for the error that has occurred. See Error Reason Code definitions for the appropriate API service. __Max Length:__ 100 
        /// </summary>
        /// <value>A reason code for the error that has occurred. See Error Reason Code definitions for the appropriate API service. __Max Length:__ 100 </value>
        [DataMember(Name = "reasonCode", IsRequired = true, EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Description of the reason why the operation failed. __Max Length:__ 256 
        /// </summary>
        /// <value>Description of the reason why the operation failed. __Max Length:__ 256 </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Only generated by Open API. See Open API documentation for use cases. __Max Length:__ 100 
        /// </summary>
        /// <value>Only generated by Open API. See Open API documentation for use cases. __Max Length:__ 100 </value>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Only generated by Open API. See Open API documentation. 
        /// </summary>
        /// <value>Only generated by Open API. See Open API documentation. </value>
        [DataMember(Name = "recoverable", EmitDefaultValue = true)]
        public bool Recoverable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Recoverable: ").Append(Recoverable).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Recoverable == input.Recoverable ||
                    this.Recoverable.Equals(input.Recoverable)
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                hashCode = hashCode * 59 + this.Recoverable.GetHashCode();
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