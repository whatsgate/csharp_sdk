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
    /// CheckBody
    /// </summary>
    [DataContract]
        public partial class CheckBody :  IEquatable<CheckBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBody" /> class.
        /// </summary>
        /// <param name="whatsappID">Идентификатор Whatsapp ID.</param>
        /// <param name="number">Номер в формате 79999999999.</param>
        public CheckBody(string whatsappID = default(string), string number = default(string))
        {
            this.WhatsappID = whatsappID;
            this.Number = number;
        }
        
        /// <summary>
        /// Идентификатор Whatsapp ID
        /// </summary>
        /// <value>Идентификатор Whatsapp ID</value>
        [DataMember(Name="WhatsappID", EmitDefaultValue=false)]
        public string WhatsappID { get; set; }

        /// <summary>
        /// Номер в формате 79999999999
        /// </summary>
        /// <value>Номер в формате 79999999999</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckBody {\n");
            sb.Append("  WhatsappID: ").Append(WhatsappID).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as CheckBody);
        }

        /// <summary>
        /// Returns true if CheckBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WhatsappID == input.WhatsappID ||
                    (this.WhatsappID != null &&
                    this.WhatsappID.Equals(input.WhatsappID))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.WhatsappID != null)
                    hashCode = hashCode * 59 + this.WhatsappID.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
