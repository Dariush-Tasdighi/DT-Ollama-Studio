using System.Text.Json.Serialization;

namespace Dtat.Ollama.Models;

public class ModelResponse : object
{
	[JsonPropertyName(name: "models")]
	public IList<Model>? Models { get; set; }
}
