/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdContactsLabels200Ok :  IEquatable<GetCharactersCharacterIdContactsLabels200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContactsLabels200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdContactsLabels200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContactsLabels200Ok" /> class.
        /// </summary>
        /// <param name="LabelId">label_id integer (required).</param>
        /// <param name="LabelName">label_name string (required).</param>
        public GetCharactersCharacterIdContactsLabels200Ok(long? LabelId = default(long?), string LabelName = default(string))
        {
            // to ensure "LabelId" is required (not null)
            if (LabelId == null)
            {
                throw new InvalidDataException("LabelId is a required property for GetCharactersCharacterIdContactsLabels200Ok and cannot be null");
            }
            else
            {
                this.LabelId = LabelId;
            }
            // to ensure "LabelName" is required (not null)
            if (LabelName == null)
            {
                throw new InvalidDataException("LabelName is a required property for GetCharactersCharacterIdContactsLabels200Ok and cannot be null");
            }
            else
            {
                this.LabelName = LabelName;
            }
        }
        
        /// <summary>
        /// label_id integer
        /// </summary>
        /// <value>label_id integer</value>
        [DataMember(Name="label_id", EmitDefaultValue=false)]
        public long? LabelId { get; set; }

        /// <summary>
        /// label_name string
        /// </summary>
        /// <value>label_name string</value>
        [DataMember(Name="label_name", EmitDefaultValue=false)]
        public string LabelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdContactsLabels200Ok {\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  LabelName: ").Append(LabelName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetCharactersCharacterIdContactsLabels200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdContactsLabels200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdContactsLabels200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdContactsLabels200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelId == input.LabelId ||
                    (this.LabelId != null &&
                    this.LabelId.Equals(input.LabelId))
                ) && 
                (
                    this.LabelName == input.LabelName ||
                    (this.LabelName != null &&
                    this.LabelName.Equals(input.LabelName))
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
                if (this.LabelId != null)
                    hashCode = hashCode * 59 + this.LabelId.GetHashCode();
                if (this.LabelName != null)
                    hashCode = hashCode * 59 + this.LabelName.GetHashCode();
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
