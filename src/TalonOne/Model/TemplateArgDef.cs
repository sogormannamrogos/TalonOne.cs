/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// TemplateArgDef
    /// </summary>
    [DataContract]
    public partial class TemplateArgDef :  IEquatable<TemplateArgDef>, IValidatableObject
    {
        /// <summary>
        /// The type of value this argument expects.
        /// </summary>
        /// <value>The type of value this argument expects.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,
            
            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 2,
            
            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3,
            
            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 4
        }

        /// <summary>
        /// The type of value this argument expects.
        /// </summary>
        /// <value>The type of value this argument expects.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateArgDef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateArgDef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateArgDef" /> class.
        /// </summary>
        /// <param name="type">The type of value this argument expects. (required).</param>
        /// <param name="description">A campaigner-friendly description of the argument, this will also be shown in the rule editor. (required).</param>
        /// <param name="title">A campaigner friendly name for the argument, this will be shown in the rule editor. (required).</param>
        /// <param name="ui">Arbitrary metadata that may be used to render an input for this argument. (required).</param>
        public TemplateArgDef(TypeEnum type = default(TypeEnum), string description = default(string), string title = default(string), Object ui = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TemplateArgDef and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for TemplateArgDef and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TemplateArgDef and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "ui" is required (not null)
            if (ui == null)
            {
                throw new InvalidDataException("ui is a required property for TemplateArgDef and cannot be null");
            }
            else
            {
                this.Ui = ui;
            }
        }
        

        /// <summary>
        /// A campaigner-friendly description of the argument, this will also be shown in the rule editor.
        /// </summary>
        /// <value>A campaigner-friendly description of the argument, this will also be shown in the rule editor.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A campaigner friendly name for the argument, this will be shown in the rule editor.
        /// </summary>
        /// <value>A campaigner friendly name for the argument, this will be shown in the rule editor.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Arbitrary metadata that may be used to render an input for this argument.
        /// </summary>
        /// <value>Arbitrary metadata that may be used to render an input for this argument.</value>
        [DataMember(Name="ui", EmitDefaultValue=false)]
        public Object Ui { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateArgDef {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Ui: ").Append(Ui).Append("\n");
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
            return this.Equals(input as TemplateArgDef);
        }

        /// <summary>
        /// Returns true if TemplateArgDef instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateArgDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateArgDef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Ui == input.Ui ||
                    (this.Ui != null &&
                    this.Ui.Equals(input.Ui))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Ui != null)
                    hashCode = hashCode * 59 + this.Ui.GetHashCode();
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
            // Type (string) minLength
            if(this.Type != default(TypeEnum))
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}