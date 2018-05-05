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
    public class TalkDraft : IEquatable<TalkDraft>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SlidesUrl
        /// </summary>
        [DataMember(Name="SlidesUrl")]
        public string SlidesUrl { get; set; }

        /// <summary>
        /// Gets or Sets VideoUrl
        /// </summary>
        [DataMember(Name="VideoUrl")]
        public string VideoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Meetups
        /// </summary>
        [DataMember(Name="Meetups")]
        public Collection<MeetupReference> Meetups { get; set; }

        /// <summary>
        /// Gets or Sets Speakers
        /// </summary>
        [DataMember(Name="Speakers")]
        public Collection<SpeakerReference> Speakers { get; set; }

        /// <summary>
        /// Gets or Sets Friends
        /// </summary>
        [DataMember(Name="Friends")]
        public Collection<FriendReference> Friends { get; set; }

        /// <summary>
        /// Gets or Sets Venues
        /// </summary>
        [DataMember(Name="Venues")]
        public Collection<VenueReference> Venues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TalkDraft {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SlidesUrl: ").Append(SlidesUrl).Append("\n");
            sb.Append("  VideoUrl: ").Append(VideoUrl).Append("\n");
            sb.Append("  Meetups: ").Append(Meetups).Append("\n");
            sb.Append("  Speakers: ").Append(Speakers).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
            sb.Append("  Venues: ").Append(Venues).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TalkDraft)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if TalkDraft instances are equal
        /// </summary>
        /// <param name="other">Instance of TalkDraft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TalkDraft other)
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
                    string.Equals(Description, other.Description) ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(SlidesUrl, other.SlidesUrl) ||
                    SlidesUrl != null &&
                    SlidesUrl.Equals(other.SlidesUrl)
                ) && 
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(VideoUrl, other.VideoUrl) ||
                    VideoUrl != null &&
                    VideoUrl.Equals(other.VideoUrl)
                ) && 
                (
                    Meetups == other.Meetups ||
                    Meetups != null &&
                    Meetups.SequenceEqual(other.Meetups)
                ) && 
                (
                    Speakers == other.Speakers ||
                    Speakers != null &&
                    Speakers.SequenceEqual(other.Speakers)
                ) && 
                (
                    Friends == other.Friends ||
                    Friends != null &&
                    Friends.SequenceEqual(other.Friends)
                ) && 
                (
                    Venues == other.Venues ||
                    Venues != null &&
                    Venues.SequenceEqual(other.Venues)
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
                    if (Description != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Description.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (SlidesUrl != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + SlidesUrl.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (VideoUrl != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + VideoUrl.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Meetups != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Meetups.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Speakers != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Speakers.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Friends != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Friends.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Venues != null)
#pragma warning disable CA1307 // Specify StringComparison
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = hashCode * 59 + Venues.GetHashCode();
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TalkDraft left, TalkDraft right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TalkDraft left, TalkDraft right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
