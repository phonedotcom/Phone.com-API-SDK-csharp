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
    /// The Full Account Object includes all of the properties in the Account Summary Object, along with the following:
    /// </summary>
    [DataContract]
    public partial class AccountFull :  IEquatable<AccountFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountFull" /> class.
        /// </summary>
        /// <param name="Id">Account ID. Sometimes referred to as \&quot;Voip ID\&quot; or \&quot;voip_id\&quot;..</param>
        /// <param name="Name">Name on the account. Read-only..</param>
        /// <param name="Username">Account user name.</param>
        /// <param name="Password">Account password. For security reason, this is masked as \&quot;**\&quot;.</param>
        /// <param name="MasterAccount">If this account is a subaccount, this property shows the master account that it belongs to. Otherwise it is NULL. Read-only. Output is an Account Summary Object..</param>
        /// <param name="Contact">Contact Object. See below for details..</param>
        /// <param name="BillingContact">Contact Object for billing purposes. See below for details..</param>
        public AccountFull(int? Id = default(int?), string Name = default(string), string Username = default(string), string Password = default(string), AccountSummary MasterAccount = default(AccountSummary), ContactAccount Contact = default(ContactAccount), ContactAccount BillingContact = default(ContactAccount))
        {
            this.Id = Id;
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.MasterAccount = MasterAccount;
            this.Contact = Contact;
            this.BillingContact = BillingContact;
        }
        
        /// <summary>
        /// Account ID. Sometimes referred to as \&quot;Voip ID\&quot; or \&quot;voip_id\&quot;.
        /// </summary>
        /// <value>Account ID. Sometimes referred to as \&quot;Voip ID\&quot; or \&quot;voip_id\&quot;.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name on the account. Read-only.
        /// </summary>
        /// <value>Name on the account. Read-only.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Account user name
        /// </summary>
        /// <value>Account user name</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Account password. For security reason, this is masked as \&quot;**\&quot;
        /// </summary>
        /// <value>Account password. For security reason, this is masked as \&quot;**\&quot;</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// If this account is a subaccount, this property shows the master account that it belongs to. Otherwise it is NULL. Read-only. Output is an Account Summary Object.
        /// </summary>
        /// <value>If this account is a subaccount, this property shows the master account that it belongs to. Otherwise it is NULL. Read-only. Output is an Account Summary Object.</value>
        [DataMember(Name="master_account", EmitDefaultValue=false)]
        public AccountSummary MasterAccount { get; set; }

        /// <summary>
        /// Contact Object. See below for details.
        /// </summary>
        /// <value>Contact Object. See below for details.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactAccount Contact { get; set; }

        /// <summary>
        /// Contact Object for billing purposes. See below for details.
        /// </summary>
        /// <value>Contact Object for billing purposes. See below for details.</value>
        [DataMember(Name="billing_contact", EmitDefaultValue=false)]
        public ContactAccount BillingContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  MasterAccount: ").Append(MasterAccount).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  BillingContact: ").Append(BillingContact).Append("\n");
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
            return this.Equals(obj as AccountFull);
        }

        /// <summary>
        /// Returns true if AccountFull instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountFull other)
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
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.MasterAccount == other.MasterAccount ||
                    this.MasterAccount != null &&
                    this.MasterAccount.Equals(other.MasterAccount)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.BillingContact == other.BillingContact ||
                    this.BillingContact != null &&
                    this.BillingContact.Equals(other.BillingContact)
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
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.MasterAccount != null)
                    hash = hash * 59 + this.MasterAccount.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.BillingContact != null)
                    hash = hash * 59 + this.BillingContact.GetHashCode();
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
