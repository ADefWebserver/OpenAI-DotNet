using System.Text.Json.Serialization;

namespace OpenAI.Chat
{
    public sealed class Message
    {
        /// <summary>
        /// Creates a new message to insert into a chat conversation.
        /// </summary>
        /// <param name="role">
        /// The <see cref="Chat.Role"/> of the author of this message.
        /// </param>
        /// <param name="content">
        /// The contents of the message.
        /// </param>
        /// <param name="name">
        /// Optional, The name of the author of this message.<br/>
        /// May contain a-z, A-Z, 0-9, and underscores, with a maximum length of 64 characters.
        /// </param>
        public Message(Role role, string content, string name = null)
        {
            Role = role;
            Content = content;
            Name = name;
        }

        /// <summary>
        /// The <see cref="Chat.Role"/> of the author of this message.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("role")]
        public Role Role { get; private set; }

        /// <summary>
        /// The contents of the message.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("content")]
        public string Content { get; private set; }

        /// <summary>
        /// Optional, The name of the author of this message.<br/>
        /// May contain a-z, A-Z, 0-9, and underscores, with a maximum length of 64 characters.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        public override string ToString() => Content ?? string.Empty;

        public static implicit operator string(Message message) => message.ToString();
    }
}
