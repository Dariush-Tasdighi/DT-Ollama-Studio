using System.Text.Json.Serialization;

namespace MyApplication.Models;

public class ChatMessage : object
{
	public ChatMessage() : base()
	{
	}

	[JsonPropertyName(name: "role")]
	public string? Role { get; set; }

	[JsonPropertyName(name: "content")]
	public string? Content { get; set; }
}
