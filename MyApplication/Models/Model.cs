using System.Text.Json.Serialization;

namespace MyApplication.Models;

public class Model : object
{
	public Model() : base()
	{
	}

	[JsonPropertyName(name: "name")]
	public string? Name { get; set; }

	[JsonPropertyName(name: "model")]
	public string? ModelName { get; set; }

	[JsonPropertyName(name: "modified_at")]
	public DateTime ModifiedAt { get; set; }

	[JsonPropertyName(name: "size")]
	public long Size { get; set; }

	[JsonPropertyName(name: "digest")]
	public string? Digest { get; set; }

	[JsonPropertyName(name: "details")]
	public ModelDetails? Details { get; set; }
}
