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
    /// ResponseChat
    /// </summary>
    [DataContract]
        public partial class ResponseChat :  IEquatable<ResponseChat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseChat" /> class.
        /// </summary>
        /// <param name="id">Идентификатор контакта или группы в формате WhatsApp.</param>
        /// <param name="name">Имя контакта или группы.</param>
        /// <param name="isGroup">Является ли чат контактом или группой.</param>
        /// <param name="isReadOnly">Является ли чат ReadOnly.</param>
        /// <param name="unreadCount">Количество непрочитанных сообщений в чате.</param>
        /// <param name="timestamp">Время последней активночти в чате.</param>
        /// <param name="pinned">Является ли чат закрепленным.</param>
        /// <param name="isMuted">Выключен ли у чата звук.</param>
        /// <param name="muteExpiration">Время, оставшееся до включения звука.</param>
        /// <param name="groupMetadata">groupMetadata.</param>
        public ResponseChat(string id = default(string), string name = default(string), bool? isGroup = default(bool?), bool? isReadOnly = default(bool?), int? unreadCount = default(int?), int? timestamp = default(int?), bool? pinned = default(bool?), bool? isMuted = default(bool?), bool? muteExpiration = default(bool?), ResponseChatGroupMetadata groupMetadata = default(ResponseChatGroupMetadata))
        {
            this.Id = id;
            this.Name = name;
            this.IsGroup = isGroup;
            this.IsReadOnly = isReadOnly;
            this.UnreadCount = unreadCount;
            this.Timestamp = timestamp;
            this.Pinned = pinned;
            this.IsMuted = isMuted;
            this.MuteExpiration = muteExpiration;
            this.GroupMetadata = groupMetadata;
        }
        
        /// <summary>
        /// Идентификатор контакта или группы в формате WhatsApp
        /// </summary>
        /// <value>Идентификатор контакта или группы в формате WhatsApp</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Имя контакта или группы
        /// </summary>
        /// <value>Имя контакта или группы</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Является ли чат контактом или группой
        /// </summary>
        /// <value>Является ли чат контактом или группой</value>
        [DataMember(Name="isGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Является ли чат ReadOnly
        /// </summary>
        /// <value>Является ли чат ReadOnly</value>
        [DataMember(Name="isReadOnly", EmitDefaultValue=false)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Количество непрочитанных сообщений в чате
        /// </summary>
        /// <value>Количество непрочитанных сообщений в чате</value>
        [DataMember(Name="unreadCount", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }

        /// <summary>
        /// Время последней активночти в чате
        /// </summary>
        /// <value>Время последней активночти в чате</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// Является ли чат закрепленным
        /// </summary>
        /// <value>Является ли чат закрепленным</value>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Выключен ли у чата звук
        /// </summary>
        /// <value>Выключен ли у чата звук</value>
        [DataMember(Name="isMuted", EmitDefaultValue=false)]
        public bool? IsMuted { get; set; }

        /// <summary>
        /// Время, оставшееся до включения звука
        /// </summary>
        /// <value>Время, оставшееся до включения звука</value>
        [DataMember(Name="muteExpiration", EmitDefaultValue=false)]
        public bool? MuteExpiration { get; set; }

        /// <summary>
        /// Gets or Sets GroupMetadata
        /// </summary>
        [DataMember(Name="groupMetadata", EmitDefaultValue=false)]
        public ResponseChatGroupMetadata GroupMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseChat {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  IsMuted: ").Append(IsMuted).Append("\n");
            sb.Append("  MuteExpiration: ").Append(MuteExpiration).Append("\n");
            sb.Append("  GroupMetadata: ").Append(GroupMetadata).Append("\n");
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
            return this.Equals(input as ResponseChat);
        }

        /// <summary>
        /// Returns true if ResponseChat instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseChat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseChat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    (this.IsGroup != null &&
                    this.IsGroup.Equals(input.IsGroup))
                ) && 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.UnreadCount == input.UnreadCount ||
                    (this.UnreadCount != null &&
                    this.UnreadCount.Equals(input.UnreadCount))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
                ) && 
                (
                    this.IsMuted == input.IsMuted ||
                    (this.IsMuted != null &&
                    this.IsMuted.Equals(input.IsMuted))
                ) && 
                (
                    this.MuteExpiration == input.MuteExpiration ||
                    (this.MuteExpiration != null &&
                    this.MuteExpiration.Equals(input.MuteExpiration))
                ) && 
                (
                    this.GroupMetadata == input.GroupMetadata ||
                    (this.GroupMetadata != null &&
                    this.GroupMetadata.Equals(input.GroupMetadata))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsGroup != null)
                    hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.UnreadCount != null)
                    hashCode = hashCode * 59 + this.UnreadCount.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
                if (this.IsMuted != null)
                    hashCode = hashCode * 59 + this.IsMuted.GetHashCode();
                if (this.MuteExpiration != null)
                    hashCode = hashCode * 59 + this.MuteExpiration.GetHashCode();
                if (this.GroupMetadata != null)
                    hashCode = hashCode * 59 + this.GroupMetadata.GetHashCode();
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