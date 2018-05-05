/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

// ReSharper disable RedundantUsingDirective
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Models
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateSpeakerDraftParameters : IEquatable<CreateSpeakerDraftParameters>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSpeakerDraftParameters {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        // ReSharper disable once UnusedMember.Global
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
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, obj)) return false;
#pragma warning restore IDE0041 // Use 'is null' check
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CreateSpeakerDraftParameters)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if CreateSpeakerDraftParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSpeakerDraftParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSpeakerDraftParameters other)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, other)) return false;
#pragma warning restore IDE0041 // Use 'is null' check
            if (ReferenceEquals(this, other)) return true;

#pragma warning disable CA1309 // Use ordinal stringcomparison
#pragma warning disable CA1307 // Specify StringComparison
            return 
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Id, other.Id) ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(FirstName, other.FirstName) ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(LastName, other.LastName) ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                );
#pragma warning restore CA1307 // Specify StringComparison
#pragma warning restore CA1309 // Use ordinal stringcomparison
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Id != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Id.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (FirstName != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (LastName != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + LastName.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateSpeakerDraftParameters left, CreateSpeakerDraftParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateSpeakerDraftParameters left, CreateSpeakerDraftParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
