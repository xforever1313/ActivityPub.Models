//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Text.Json.Serialization;

namespace ActivityPub.Models
{
    public record class Profile
    {
        [JsonPropertyName( "@context" )]
        public string[] Context => new string[]
        {
            "https://www.w3.org/ns/activitystreams",
            "https://w3id.org/security/v1"
        };

        [JsonPropertyName( "outbox" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? OutBox { get; init; }

        [JsonPropertyName( "inbox" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Inbox { get; init; }

        [JsonPropertyName( "outbox" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Outbox { get; init; }

        [JsonPropertyName( "preferredUsername" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? PreferredUserName { get; init; }

        [JsonPropertyName( "attachment" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Attachment[]? Attachments { get; init; }

        [JsonPropertyName( "url" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Url { get; init; }

        [JsonPropertyName( "icon" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public Uri? Icon { get; init; }

        public DateTime? PublishedDate { get; init; }

        [JsonPropertyName( "published" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Published => this.PublishedDate?.ToString( "O" ) ?? null;

        [JsonPropertyName( "summary" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Summary { get; init; }

        [JsonPropertyName( "id" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Id { get; init; }

        [JsonPropertyName( "name" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Name { get; init; }

        [JsonPropertyName( "discoverable" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public bool? Discoverable { get; init; }

        [JsonPropertyName( "manuallyApprovesFollowers" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public bool? ManuallyApprovesFollowers { get; init; }

        [JsonPropertyName( "type" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public string? Type { get; init; }

        [JsonPropertyName( "publicKey" )]
        [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
        public ProfilePublicKey? PublicKey { get; init; }
    }
}
