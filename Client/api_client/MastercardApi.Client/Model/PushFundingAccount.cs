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
    /// PushFundingAccount
    /// </summary>
    [DataContract(Name = "PushFundingAccount")]
    public partial class PushFundingAccount : IEquatable<PushFundingAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushFundingAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushFundingAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushFundingAccount" /> class.
        /// </summary>
        /// <param name="encryptedPayload">encryptedPayload (required).</param>
        public PushFundingAccount(EncryptedPayload encryptedPayload = default(EncryptedPayload))
        {
            // to ensure "encryptedPayload" is required (not null)
            if (encryptedPayload == null) {
                throw new ArgumentNullException("encryptedPayload is a required property for PushFundingAccount and cannot be null");
            }
            this.EncryptedPayload = encryptedPayload;
        }

        /// <summary>
        /// Gets or Sets EncryptedPayload
        /// </summary>
        [DataMember(Name = "encryptedPayload", IsRequired = true, EmitDefaultValue = false)]
        public EncryptedPayload EncryptedPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushFundingAccount {\n");
            sb.Append("  EncryptedPayload: ").Append(EncryptedPayload).Append("\n");
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
            return this.Equals(input as PushFundingAccount);
        }

        /// <summary>
        /// Returns true if PushFundingAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of PushFundingAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushFundingAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptedPayload == input.EncryptedPayload ||
                    (this.EncryptedPayload != null &&
                    this.EncryptedPayload.Equals(input.EncryptedPayload))
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
                if (this.EncryptedPayload != null)
                    hashCode = hashCode * 59 + this.EncryptedPayload.GetHashCode();
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
