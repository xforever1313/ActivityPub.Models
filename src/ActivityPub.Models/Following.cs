//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public record class Following
    {
        [JsonPropertyName( "@context" )]
        public string Context => "https://www.w3.org/ns/activitystreams";

        [JsonPropertyName( "summary" )]
        public string Summary => $"{this.Actor ?? ""} followed {this.Object ?? ""}.";

        [JsonPropertyName( "type" )]
        public string Type => "Follow";

        [JsonPropertyName( "id" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Id { get; init; }

        /// <summary>
        /// Usually the person doing the following.
        /// </summary>
        [JsonPropertyName( "actor" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Actor { get; init; }

        /// <summary>
        /// Usually the person being followed.
        /// </summary>
        [JsonPropertyName( "object" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Object { get; init; }
    }
}
