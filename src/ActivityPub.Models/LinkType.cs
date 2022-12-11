//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System;
using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public abstract record class LinkType
    {
        [JsonPropertyName( "@context" )]
        public string Context => "https://www.w3.org/ns/activitystreams";

        [JsonPropertyName( "type" )]
        public abstract string Type { get; }

        [JsonPropertyName( "id" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Id { get; init; }

        [JsonPropertyName( "content" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Content { get; init; }

        [JsonPropertyName( "name" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Name { get; init; }

        [JsonPropertyName( "summary" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Summary { get; init; }

        [JsonPropertyName( "sensitive" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public bool? Sensitive { get; init; }

        [JsonPropertyName( "published" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public DateTime? Published { get; init; }

        [JsonPropertyName( "url" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Url { get; init; }

        [JsonPropertyName( "attributedTo" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? AttributedTo { get; init; }

        [JsonPropertyName( "to" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string[]? To { get; init; }

        [JsonPropertyName( "cc" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string[]? Cc { get; init; }
    }
}
