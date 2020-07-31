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
    /// notifications to notify CAMA user about
    /// </summary>
    [DataContract]
    public partial class UserFeedNotifications :  IEquatable<UserFeedNotifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedNotifications" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserFeedNotifications() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedNotifications" /> class.
        /// </summary>
        /// <param name="lastUpdate">Timestamp of the last request for this list (required).</param>
        /// <param name="notifications">List of all notifications to notify the user about (required).</param>
        public UserFeedNotifications(DateTime lastUpdate = default(DateTime), List<FeedNotification> notifications = default(List<FeedNotification>))
        {
            // to ensure "lastUpdate" is required (not null)
            if (lastUpdate == null)
            {
                throw new InvalidDataException("lastUpdate is a required property for UserFeedNotifications and cannot be null");
            }
            else
            {
                this.LastUpdate = lastUpdate;
            }
            
            // to ensure "notifications" is required (not null)
            if (notifications == null)
            {
                throw new InvalidDataException("notifications is a required property for UserFeedNotifications and cannot be null");
            }
            else
            {
                this.Notifications = notifications;
            }
            
        }
        
        /// <summary>
        /// Timestamp of the last request for this list
        /// </summary>
        /// <value>Timestamp of the last request for this list</value>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// List of all notifications to notify the user about
        /// </summary>
        /// <value>List of all notifications to notify the user about</value>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<FeedNotification> Notifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserFeedNotifications {\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
            return this.Equals(input as UserFeedNotifications);
        }

        /// <summary>
        /// Returns true if UserFeedNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of UserFeedNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserFeedNotifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
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
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
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