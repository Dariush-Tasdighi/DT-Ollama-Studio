using System.Text.Json.Serialization;

namespace Dtat.Ollama.Models;

public class ModelDetails : object
{
	public ModelDetails() : base()
	{
	}

	[JsonPropertyName(name: "parent_model")]
	public string? ParentModel { get; set; }

	[JsonPropertyName(name: "format")]
	public string? Format { get; set; }

	[JsonPropertyName(name: "family")]
	public string? Family { get; set; }

	[JsonPropertyName(name: "families")]
	public string[]? Families { get; set; }

	[JsonPropertyName(name: "parameter_size")]
	public string? ParameterSize { get; set; }

	[JsonPropertyName(name: "quantization_level")]
	public string? QuantizationLevel { get; set; }
}
