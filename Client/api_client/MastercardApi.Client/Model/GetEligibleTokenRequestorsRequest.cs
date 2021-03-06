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
    /// GetEligibleTokenRequestorsRequest
    /// </summary>
    [DataContract(Name = "GetEligibleTokenRequestorsRequest")]
    public partial class GetEligibleTokenRequestorsRequest : IEquatable<GetEligibleTokenRequestorsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleTokenRequestorsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEligibleTokenRequestorsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleTokenRequestorsRequest" /> class.
        /// </summary>
        /// <param name="requestId">Unique identifier for the request.  __Max Length:__ 64  (required).</param>
        /// <param name="accountRanges">Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25  (required).</param>
        /// <param name="supportsTokenConnect">A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of: * true - Token Connect is supported * false - Token Connect is not supported .</param>
        public GetEligibleTokenRequestorsRequest(string requestId = default(string), List<string> accountRanges = default(List<string>), bool supportsTokenConnect = default(bool))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null) {
                throw new ArgumentNullException("requestId is a required property for GetEligibleTokenRequestorsRequest and cannot be null");
            }
            this.RequestId = requestId;
            // to ensure "accountRanges" is required (not null)
            if (accountRanges == null) {
                throw new ArgumentNullException("accountRanges is a required property for GetEligibleTokenRequestorsRequest and cannot be null");
            }
            this.AccountRanges = accountRanges;
            this.SupportsTokenConnect = supportsTokenConnect;
        }

        /// <summary>
        /// Unique identifier for the request.  __Max Length:__ 64 
        /// </summary>
        /// <value>Unique identifier for the request.  __Max Length:__ 64 </value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25 
        /// </summary>
        /// <value>Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25 </value>
        [DataMember(Name = "accountRanges", IsRequired = true, EmitDefaultValue = false)]
        public List<string> AccountRanges { get; set; }

        /// <summary>
        /// A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of: * true - Token Connect is supported * false - Token Connect is not supported 
        /// </summary>
        /// <value>A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of: * true - Token Connect is supported * false - Token Connect is not supported </value>
        [DataMember(Name = "supportsTokenConnect", EmitDefaultValue = true)]
        public bool SupportsTokenConnect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEligibleTokenRequestorsRequest {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  AccountRanges: ").Append(AccountRanges).Append("\n");
            sb.Append("  SupportsTokenConnect: ").Append(SupportsTokenConnect).Append("\n");
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
            return this.Equals(input as GetEligibleTokenRequestorsRequest);
        }

        /// <summary>
        /// Returns true if GetEligibleTokenRequestorsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEligibleTokenRequestorsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEligibleTokenRequestorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.AccountRanges == input.AccountRanges ||
                    this.AccountRanges != null &&
                    input.AccountRanges != null &&
                    this.AccountRanges.SequenceEqual(input.AccountRanges)
                ) && 
                (
                    this.SupportsTokenConnect == input.SupportsTokenConnect ||
                    this.SupportsTokenConnect.Equals(input.SupportsTokenConnect)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.AccountRanges != null)
                    hashCode = hashCode * 59 + this.AccountRanges.GetHashCode();
                hashCode = hashCode * 59 + this.SupportsTokenConnect.GetHashCode();
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
