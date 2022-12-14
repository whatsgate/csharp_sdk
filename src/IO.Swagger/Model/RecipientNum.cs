/* 
 * API whatsgate.ru
 *
 * Интерфейс для взаимодействия с клиентом Whatsapp
 *
 * OpenAPI spec version: 1.0.0
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
    /// RecipientNum
    /// </summary>
    [DataContract]
        public partial class RecipientNum :  IEquatable<RecipientNum>, IValidatableObject
    {
        /// <summary>
        /// Recipient type, group or contact
        /// </summary>
        /// <value>Recipient type, group or contact</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 1,
            /// <summary>
            /// Enum Contact for value: contact
            /// </summary>
            [EnumMember(Value = "contact")]
            Contact = 2        }
        /// <summary>
        /// Recipient type, group or contact
        /// </summary>
        /// <value>Recipient type, group or contact</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientNum" /> class.
        /// </summary>
        /// <param name="number">Recipient number (required).</param>
        /// <param name="type">Recipient type, group or contact (default to TypeEnum.Contact).</param>
        public RecipientNum(string number = default(string), TypeEnum? type = TypeEnum.Contact)
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for RecipientNum and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Contact;
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Recipient number
        /// </summary>
        /// <value>Recipient number</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientNum {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RecipientNum);
        }

        /// <summary>
        /// Returns true if RecipientNum instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipientNum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientNum input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
