using System.Net;
using System.Text;
using System.Text.Json;
using Dtat.Ollama.Models;

namespace Dtat.Ollama;

public class OllamaHelper : object
{
	public OllamaHelper(string baseAddress) : base()
	{
		BaseAddress = baseAddress;

		TagsEndpoint = "/api/tags";
		ChatEndpoint = "/api/chat";
	}

	public string BaseAddress { get; set; }
	public string TagsEndpoint { get; set; }
	public string ChatEndpoint { get; set; }

	public List<ChatMessage> ChatMessages { get; set; } = [];

	public async Task<List<string>> GetModelsAsync()
	{
		var result =
			new List<string>();

		var ollamaClient = new HttpClient
		{
			BaseAddress =
				new Uri(uriString: BaseAddress),
		};

		var responseMessage =
			await
			ollamaClient.GetAsync(requestUri: TagsEndpoint);

		var responseContent =
			await
			responseMessage.Content.ReadAsStringAsync();

		if (responseMessage.StatusCode == HttpStatusCode.OK &&
			string.IsNullOrWhiteSpace(value: responseContent) == false)
		{
			var modelResponse =
				JsonSerializer.Deserialize<ModelResponse>(json: responseContent);

			if (modelResponse is not null &&
				modelResponse.Models is not null &&
				modelResponse.Models.Count > 0)
			{
				for (var index = 0; index <= modelResponse.Models.Count - 1; index++)
				{
					var model =
						modelResponse.Models[index];

					if (string.IsNullOrWhiteSpace(value: model.Name) == false)
					{
						result.Add(item: model.Name);
					}
				}
			}
		}

		return result;
	}

	public async Task<string?> ChatAsync(string modelName, string userPrompt, bool remember)
	{
		string? result = null;

		// **************************************************
		if (remember == false)
		{
			ChatMessages.Clear();
		}

		var chatMessage =
			new ChatMessage
			{
				Role = "user",
				Content = userPrompt,
			};

		ChatMessages.Add(item: chatMessage);
		// **************************************************

		var ollamaClient = new HttpClient
		{
			BaseAddress =
				new Uri(uriString: BaseAddress),
		};

		var chatRequest =
			new ChatRequest
			{
				Stream = false,
				Model = modelName,
				Messages = ChatMessages,
			};

		var chatRequestJson =
			JsonSerializer.Serialize(value: chatRequest);

		var content = new StringContent(content: chatRequestJson,
			encoding: Encoding.UTF8, mediaType: "application/json");

		var responseMessage =
			await
			ollamaClient.PostAsync
			(requestUri: ChatEndpoint, content: content);

		var responseContent =
			await
			responseMessage.Content.ReadAsStringAsync();

		if (responseMessage.StatusCode == HttpStatusCode.OK &&
			string.IsNullOrWhiteSpace(value: responseContent) == false)
		{
			var modelResponse =
				JsonSerializer.Deserialize<ChatResponse>(json: responseContent);

			if (modelResponse is not null)
			{
				var message =
					modelResponse.Message;

				if (message is not null)
				{
					result =
						message.Content;

					// **************************************************
					chatMessage =
						new ChatMessage
						{
							Role = "assistant",
							Content = message.Content,
						};

					ChatMessages.Add(item: chatMessage);
					// **************************************************
				}
			}
		}

		return result;
	}
}
