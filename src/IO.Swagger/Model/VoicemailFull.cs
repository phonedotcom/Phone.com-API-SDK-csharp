/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
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
    /// The Full Voicemail Object includes all of the properties in the Voicemail Summary Object.
    /// </summary>
    [DataContract]
    public partial class VoicemailFull :  IEquatable<VoicemailFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailFull" /> class.
        /// </summary>
        /// <param name="Id">Unique Voicemail ID. Read-only..</param>
        /// <param name="DownloadUrl">Name. Required..</param>
        /// <param name="Extension">Extension where the voicemail is saved into..</param>
        /// <param name="From">The caller&#39;s information.</param>
        /// <param name="To">The phone number where the caller is calling.</param>
        /// <param name="IsNew">True when Voicemail is new; False when Voicemail has been listened.</param>
        /// <param name="CreatedAt">Date string representing the UTC time that the object was created in the Phone.com API system..</param>
        /// <param name="Folder">Folder name where voicemail is saved.</param>
        /// <param name="Duration">Length of voicemail in seconds.</param>
        public VoicemailFull(string Id = default(string), string DownloadUrl = default(string), ExtensionSummary Extension = default(ExtensionSummary), FromObject From = default(FromObject), string To = default(string), bool? IsNew = default(bool?), int? CreatedAt = default(int?), string Folder = default(string), int? Duration = default(int?))
        {
            this.Id = Id;
            this.DownloadUrl = DownloadUrl;
            this.Extension = Extension;
            this.From = From;
            this.To = To;
            this.IsNew = IsNew;
            this.CreatedAt = CreatedAt;
            this.Folder = Folder;
            this.Duration = Duration;
        }
        
        /// <summary>
        /// Unique Voicemail ID. Read-only.
        /// </summary>
        /// <value>Unique Voicemail ID. Read-only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name. Required.
        /// </summary>
        /// <value>Name. Required.</value>
        [DataMember(Name="download_url", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Extension where the voicemail is saved into.
        /// </summary>
        /// <value>Extension where the voicemail is saved into.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public ExtensionSummary Extension { get; set; }

        /// <summary>
        /// The caller&#39;s information
        /// </summary>
        /// <value>The caller&#39;s information</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public FromObject From { get; set; }

        /// <summary>
        /// The phone number where the caller is calling
        /// </summary>
        /// <value>The phone number where the caller is calling</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// True when Voicemail is new; False when Voicemail has been listened
        /// </summary>
        /// <value>True when Voicemail is new; False when Voicemail has been listened</value>
        [DataMember(Name="is_new", EmitDefaultValue=false)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// Date string representing the UTC time that the object was created in the Phone.com API system.
        /// </summary>
        /// <value>Date string representing the UTC time that the object was created in the Phone.com API system.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Folder name where voicemail is saved
        /// </summary>
        /// <value>Folder name where voicemail is saved</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public string Folder { get; set; }

        /// <summary>
        /// Length of voicemail in seconds
        /// </summary>
        /// <value>Length of voicemail in seconds</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VoicemailFull);
        }

        /// <summary>
        /// Returns true if VoicemailFull instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailFull other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.IsNew == other.IsNew ||
                    this.IsNew != null &&
                    this.IsNew.Equals(other.IsNew)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.IsNew != null)
                    hash = hash * 59 + this.IsNew.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                return hash;
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
