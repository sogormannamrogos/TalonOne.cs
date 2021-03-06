/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// The properties specific to the \&quot;addLoyaltyPoints\&quot; effect. This gets triggered whenever a validated rule contained an \&quot;add loyalty\&quot; effect. These points are automatically stored and managed inside Talon.One.
    /// </summary>
    [DataContract]
    public partial class AddLoyaltyPointsEffectProps :  IEquatable<AddLoyaltyPointsEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPointsEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddLoyaltyPointsEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPointsEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name/description of this loyalty point addition (required).</param>
        /// <param name="programId">The ID of the loyalty program where these points were added (required).</param>
        /// <param name="subLedgerId">The ID of the subledger within the loyalty program where these points were added (required).</param>
        /// <param name="value">The amount of points that were added (required).</param>
        /// <param name="recipientIntegrationId">The user for whom these points were added (required).</param>
        /// <param name="startDate">Date after which points will be valid.</param>
        /// <param name="expiryDate">Date after which points will expire.</param>
        public AddLoyaltyPointsEffectProps(string name = default(string), int programId = default(int), string subLedgerId = default(string), decimal value = default(decimal), string recipientIntegrationId = default(string), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "programId" is required (not null)
            if (programId == null)
            {
                throw new InvalidDataException("programId is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            }
            else
            {
                this.ProgramId = programId;
            }
            
            // to ensure "subLedgerId" is required (not null)
            if (subLedgerId == null)
            {
                throw new InvalidDataException("subLedgerId is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            }
            else
            {
                this.SubLedgerId = subLedgerId;
            }
            
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
            // to ensure "recipientIntegrationId" is required (not null)
            if (recipientIntegrationId == null)
            {
                throw new InvalidDataException("recipientIntegrationId is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            }
            else
            {
                this.RecipientIntegrationId = recipientIntegrationId;
            }
            
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
        }
        
        /// <summary>
        /// The name/description of this loyalty point addition
        /// </summary>
        /// <value>The name/description of this loyalty point addition</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the loyalty program where these points were added
        /// </summary>
        /// <value>The ID of the loyalty program where these points were added</value>
        [DataMember(Name="programId", EmitDefaultValue=true)]
        public int ProgramId { get; set; }

        /// <summary>
        /// The ID of the subledger within the loyalty program where these points were added
        /// </summary>
        /// <value>The ID of the subledger within the loyalty program where these points were added</value>
        [DataMember(Name="subLedgerId", EmitDefaultValue=true)]
        public string SubLedgerId { get; set; }

        /// <summary>
        /// The amount of points that were added
        /// </summary>
        /// <value>The amount of points that were added</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public decimal Value { get; set; }

        /// <summary>
        /// The user for whom these points were added
        /// </summary>
        /// <value>The user for whom these points were added</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=true)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Date after which points will be valid
        /// </summary>
        /// <value>Date after which points will be valid</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Date after which points will expire
        /// </summary>
        /// <value>Date after which points will expire</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddLoyaltyPointsEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  SubLedgerId: ").Append(SubLedgerId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as AddLoyaltyPointsEffectProps);
        }

        /// <summary>
        /// Returns true if AddLoyaltyPointsEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of AddLoyaltyPointsEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLoyaltyPointsEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProgramId == input.ProgramId ||
                    (this.ProgramId != null &&
                    this.ProgramId.Equals(input.ProgramId))
                ) && 
                (
                    this.SubLedgerId == input.SubLedgerId ||
                    (this.SubLedgerId != null &&
                    this.SubLedgerId.Equals(input.SubLedgerId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProgramId != null)
                    hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.SubLedgerId != null)
                    hashCode = hashCode * 59 + this.SubLedgerId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
