using System.Text.Json.Serialization;

namespace Dtat.Ollama.Models;

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
