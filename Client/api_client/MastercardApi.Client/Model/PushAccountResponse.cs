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
    /// PushAccountResponse
    /// </summary>
    [DataContract(Name = "PushAccountResponse")]
    public partial class PushAccountResponse : IEquatable<PushAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushAccountResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountResponse" /> class.
        /// </summary>
        /// <param name="responseId">Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64  (required).</param>
        /// <param name="pushAccountReceipt">Receipt value to be passed to the Token Requestor. The pushAccountReceipt represents the pushed account details and expires after 15 minutes. __Conditional.__ Required if the push operation was successful. Not present otherwise. __Max Length:__ 64 characters. When valid, the receipt will consist of a 3-character prefix identifying the product associated to the funding account concatenated with a universally unique identifier, in the form prefix-UUID. The prefix is needed by some Token Requestors in preparation of performing a tokenization. Prefix values are:  * MCC: Mastercard Credit  * DMC: Mastercard Debit  * MSI: Maestro  * PVL: Private Label .</param>
        /// <param name="availablePushMethods">Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. .</param>
        /// <param name="errors">Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. .</param>
        public PushAccountResponse(string responseId = default(string), string pushAccountReceipt = default(string), List<PushMethod> availablePushMethods = default(List<PushMethod>), List<Error> errors = default(List<Error>))
        {
            // to ensure "responseId" is required (not null)
            if (responseId == null) {
                throw new ArgumentNullException("responseId is a required property for PushAccountResponse and cannot be null");
            }
            this.ResponseId = responseId;
            this.PushAccountReceipt = pushAccountReceipt;
            this.AvailablePushMethods = availablePushMethods;
            this.Errors = errors;
        }

        /// <summary>
        /// Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64 
        /// </summary>
        /// <value>Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64 </value>
        [DataMember(Name = "responseId", IsRequired = true, EmitDefaultValue = false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Receipt value to be passed to the Token Requestor. The pushAccountReceipt represents the pushed account details and expires after 15 minutes. __Conditional.__ Required if the push operation was successful. Not present otherwise. __Max Length:__ 64 characters. When valid, the receipt will consist of a 3-character prefix identifying the product associated to the funding account concatenated with a universally unique identifier, in the form prefix-UUID. The prefix is needed by some Token Requestors in preparation of performing a tokenization. Prefix values are:  * MCC: Mastercard Credit  * DMC: Mastercard Debit  * MSI: Maestro  * PVL: Private Label 
        /// </summary>
        /// <value>Receipt value to be passed to the Token Requestor. The pushAccountReceipt represents the pushed account details and expires after 15 minutes. __Conditional.__ Required if the push operation was successful. Not present otherwise. __Max Length:__ 64 characters. When valid, the receipt will consist of a 3-character prefix identifying the product associated to the funding account concatenated with a universally unique identifier, in the form prefix-UUID. The prefix is needed by some Token Requestors in preparation of performing a tokenization. Prefix values are:  * MCC: Mastercard Credit  * DMC: Mastercard Debit  * MSI: Maestro  * PVL: Private Label </value>
        [DataMember(Name = "pushAccountReceipt", EmitDefaultValue = false)]
        public string PushAccountReceipt { get; set; }

        /// <summary>
        /// Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. 
        /// </summary>
        /// <value>Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. </value>
        [DataMember(Name = "availablePushMethods", EmitDefaultValue = false)]
        public List<PushMethod> AvailablePushMethods { get; set; }

        /// <summary>
        /// Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. 
        /// </summary>
        /// <value>Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. </value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushAccountResponse {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  PushAccountReceipt: ").Append(PushAccountReceipt).Append("\n");
            sb.Append("  AvailablePushMethods: ").Append(AvailablePushMethods).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as PushAccountResponse);
        }

        /// <summary>
        /// Returns true if PushAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PushAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushAccountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                ) && 
                (
                    this.PushAccountReceipt == input.PushAccountReceipt ||
                    (this.PushAccountReceipt != null &&
                    this.PushAccountReceipt.Equals(input.PushAccountReceipt))
                ) && 
                (
                    this.AvailablePushMethods == input.AvailablePushMethods ||
                    this.AvailablePushMethods != null &&
                    input.AvailablePushMethods != null &&
                    this.AvailablePushMethods.SequenceEqual(input.AvailablePushMethods)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                if (this.PushAccountReceipt != null)
                    hashCode = hashCode * 59 + this.PushAccountReceipt.GetHashCode();
                if (this.AvailablePushMethods != null)
                    hashCode = hashCode * 59 + this.AvailablePushMethods.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
