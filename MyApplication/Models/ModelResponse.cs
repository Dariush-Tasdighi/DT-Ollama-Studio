using System.Text.Json.Serialization;

namespace MyApplication.Models;

public class ModelResponse : object
{
	[JsonPropertyName(name: "models")]
	public IList<Model>? Models { get; set; }
}
