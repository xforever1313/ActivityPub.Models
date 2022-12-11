//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public record class FollowingCollection
    {
        [JsonPropertyName( "@context" )]
        public string Context => "https://www.w3.org/ns/activitystreams";

        [JsonPropertyName( "summary" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Summary { get; init; }

        [JsonPropertyName( "type" )]
        public string Type => "OrderedCollection";

        [JsonPropertyName( "id" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Id { get; init; }

        [JsonPropertyName( "totalItems" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public int? TotalItems
        {
            get
            {
                if( this.Following is null )
                {
                    return null;
                }
                else
                {
                    return this.Following.Length;
                }
            }
        }

        [JsonPropertyName( "orderedItems" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Following[]? Following { get; init; }
    }
}
