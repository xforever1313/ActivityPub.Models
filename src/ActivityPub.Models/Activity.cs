//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public abstract record class Activity
    {
        [JsonPropertyName( "@context" )]
        public string Context => "https://www.w3.org/ns/activitystreams";

        [JsonPropertyName( "summary" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Summary { get; init; }

        [JsonPropertyName( "type" )]
        public abstract string Type { get; }

        [JsonPropertyName( "id" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Id { get; init; }

        [JsonPropertyName( "actor" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Actor { get; init; }

        [JsonPropertyName( "object" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public LinkType? Object { get; init; }
    }
}
