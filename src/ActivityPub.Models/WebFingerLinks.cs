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
    public record class WebFingerLinks
    {
        [JsonPropertyName( "rel" )]
        public string Rel => "self";

        [JsonPropertyName( "type" )]
        public string Type => "application/activity+json";

        [JsonPropertyName( "href" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Href { get; set; }
    }
}
