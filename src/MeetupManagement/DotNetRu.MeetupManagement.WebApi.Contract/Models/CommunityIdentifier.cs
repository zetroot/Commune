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
    public class CommunityIdentifier : IEquatable<CommunityIdentifier>
    { 
        /// <summary>
        /// Gets or Sets CommunityId
        /// </summary>
        [Required]
        [DataMember(Name="CommunityId")]
        public string CommunityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunityIdentifier {\n");
            sb.Append("  CommunityId: ").Append(CommunityId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommunityIdentifier)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if CommunityIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CommunityIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunityIdentifier other)
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
                    string.Equals(CommunityId, other.CommunityId) ||
                    CommunityId != null &&
                    CommunityId.Equals(other.CommunityId)
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
                    if (CommunityId != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + CommunityId.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommunityIdentifier left, CommunityIdentifier right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommunityIdentifier left, CommunityIdentifier right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
