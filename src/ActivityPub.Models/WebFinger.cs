//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public record class WebFinger
    {
        [JsonPropertyName( "subject" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Subject { get; set; }

        [JsonPropertyName( "links" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public WebFingerLinks? Links { get; set; }
    }
}
