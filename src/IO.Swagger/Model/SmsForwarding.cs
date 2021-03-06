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
    /// SMS Forwarding Object, or NULL
    /// </summary>
    [DataContract]
    public partial class SmsForwarding :  IEquatable<SmsForwarding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsForwarding" /> class.
        /// </summary>
        /// <param name="Type">Can be \&quot;extension\&quot; or \&quot;application\&quot;.</param>
        /// <param name="Extension">Required if type &#x3D; \&quot;extension\&quot;. Extension that messages should be directed to. Output is an Extension Summary Object. Input must be an Extension Lookup Object..</param>
        /// <param name="Application">Required if type &#x3D; \&quot;application\&quot;. Application that messages should be directed to. Output is an Application Summary Object. Input must be an Application Lookup Object..</param>
        public SmsForwarding(string Type = default(string), ExtensionSummary Extension = default(ExtensionSummary), ApplicationSummary Application = default(ApplicationSummary))
        {
            this.Type = Type;
            this.Extension = Extension;
            this.Application = Application;
        }
        
        /// <summary>
        /// Can be \&quot;extension\&quot; or \&quot;application\&quot;
        /// </summary>
        /// <value>Can be \&quot;extension\&quot; or \&quot;application\&quot;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Required if type &#x3D; \&quot;extension\&quot;. Extension that messages should be directed to. Output is an Extension Summary Object. Input must be an Extension Lookup Object.
        /// </summary>
        /// <value>Required if type &#x3D; \&quot;extension\&quot;. Extension that messages should be directed to. Output is an Extension Summary Object. Input must be an Extension Lookup Object.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public ExtensionSummary Extension { get; set; }

        /// <summary>
        /// Required if type &#x3D; \&quot;application\&quot;. Application that messages should be directed to. Output is an Application Summary Object. Input must be an Application Lookup Object.
        /// </summary>
        /// <value>Required if type &#x3D; \&quot;application\&quot;. Application that messages should be directed to. Output is an Application Summary Object. Input must be an Application Lookup Object.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public ApplicationSummary Application { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsForwarding {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
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
            return this.Equals(obj as SmsForwarding);
        }

        /// <summary>
        /// Returns true if SmsForwarding instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsForwarding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsForwarding other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"extension|application", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
