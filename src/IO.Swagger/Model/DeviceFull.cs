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
    /// The Full Device Object includes the properties in the Device Summary Object, along with the following:
    /// </summary>
    [DataContract]
    public partial class DeviceFull :  IEquatable<DeviceFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFull" /> class.
        /// </summary>
        /// <param name="Id">ID.</param>
        /// <param name="Name">User-supplied name, otherwise NULL.</param>
        /// <param name="SipAuthentication">SipAuthentication.</param>
        /// <param name="Lines">Array of Line Objects showing which extensions are attached to this device, and their assigned line numbers. See below for details..</param>
        public DeviceFull(int? Id = default(int?), string Name = default(string), SipAuthentication SipAuthentication = default(SipAuthentication), List<Line> Lines = default(List<Line>))
        {
            this.Id = Id;
            this.Name = Name;
            this.SipAuthentication = SipAuthentication;
            this.Lines = Lines;
        }
        
        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User-supplied name, otherwise NULL
        /// </summary>
        /// <value>User-supplied name, otherwise NULL</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SipAuthentication
        /// </summary>
        [DataMember(Name="sip_authentication", EmitDefaultValue=false)]
        public SipAuthentication SipAuthentication { get; set; }

        /// <summary>
        /// Array of Line Objects showing which extensions are attached to this device, and their assigned line numbers. See below for details.
        /// </summary>
        /// <value>Array of Line Objects showing which extensions are attached to this device, and their assigned line numbers. See below for details.</value>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public List<Line> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SipAuthentication: ").Append(SipAuthentication).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(obj as DeviceFull);
        }

        /// <summary>
        /// Returns true if DeviceFull instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceFull other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SipAuthentication == other.SipAuthentication ||
                    this.SipAuthentication != null &&
                    this.SipAuthentication.Equals(other.SipAuthentication)
                ) && 
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(other.Lines)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SipAuthentication != null)
                    hash = hash * 59 + this.SipAuthentication.GetHashCode();
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
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
