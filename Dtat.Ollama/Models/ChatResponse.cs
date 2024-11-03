using System.Text.Json.Serialization;

namespace Dtat.Ollama.Models;

public class ChatResponse : object
{
	public ChatResponse() : base()
	{
	}

	[JsonPropertyName(name: "model")]
	public string? Model { get; set; }

	[JsonPropertyName(name: "message")]
	public ChatMessage? Message { get; set; }

	[JsonPropertyName(name: "done")]
	public bool Done { get; set; }

	[JsonPropertyName(name: "total_duration")]
	public long TotalDuration { get; set; }

	[JsonPropertyName(name: "load_duration")]
	public long LoadDuration { get; set; }

	[JsonPropertyName(name: "prompt_eval_count")]
	public long PromptEvalCount { get; set; }

	[JsonPropertyName(name: "prompt_eval_duration")]
	public long PromptEvalDuration { get; set; }

	[JsonPropertyName(name: "eval_count")]
	public long EvalCount { get; set; }

	[JsonPropertyName(name: "eval_duration")]
	public long EvalDuration { get; set; }
}
