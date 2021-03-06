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
    /// Here are all of the properties you can expect for Caller ID objects:
    /// </summary>
    [DataContract]
    public partial class CallerIdPhoneNumber :  IEquatable<CallerIdPhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerIdPhoneNumber" /> class.
        /// </summary>
        /// <param name="Name">Name that this number will be associated with. Must be no longer than 15 characters, and can only contain English letters, numbers, spaces, and commas..</param>
        /// <param name="Type">Can be \&quot;business\&quot; or \&quot;personal\&quot;.</param>
        public CallerIdPhoneNumber(string Name = default(string), string Type = default(string))
        {
            this.Name = Name;
            this.Type = Type;
        }
        
        /// <summary>
        /// Name that this number will be associated with. Must be no longer than 15 characters, and can only contain English letters, numbers, spaces, and commas.
        /// </summary>
        /// <value>Name that this number will be associated with. Must be no longer than 15 characters, and can only contain English letters, numbers, spaces, and commas.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Can be \&quot;business\&quot; or \&quot;personal\&quot;
        /// </summary>
        /// <value>Can be \&quot;business\&quot; or \&quot;personal\&quot;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallerIdPhoneNumber {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as CallerIdPhoneNumber);
        }

        /// <summary>
        /// Returns true if CallerIdPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of CallerIdPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallerIdPhoneNumber other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
            Regex regexType = new Regex(@"business|personal", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
