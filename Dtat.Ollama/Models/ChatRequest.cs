using System.Text.Json.Serialization;

namespace Dtat.Ollama.Models;

public class ChatRequest : object
{
	public ChatRequest() : base()
	{
	}

	[JsonPropertyName(name: "model")]
	public string? Model { get; set; }

	[JsonPropertyName(name: "messages")]
	public List<ChatMessage>? Messages { get; set; }

	[JsonPropertyName(name: "stream")]
	public bool Stream { get; set; }
}
