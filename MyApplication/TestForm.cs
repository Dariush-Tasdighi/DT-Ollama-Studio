using System.Net;
using System.Text;
using System.Text.Json;
using MyApplication.Models;

namespace MyApplication;

public partial class TestForm : Form
{
	public TestForm()
	{
		InitializeComponent();
	}

	private void TestForm_Load(object sender, EventArgs e)
	{
	}

	private async void Step01Button_Click(object sender, EventArgs e)
	{
		var ollamaTagsEndpoint = "/api/tags";
		var ollamaBaseAddressEndpoint = "http://127.0.0.1:11434";

		var ollamaClient = new HttpClient
		{
			BaseAddress = new Uri(ollamaBaseAddressEndpoint)
		};

		var responseMessage =
			await
			ollamaClient.GetAsync(requestUri: ollamaTagsEndpoint);

		var responseContent =
			await
			responseMessage.Content.ReadAsStringAsync();

		//MessageBox.Show(text: responseContent);

		if (responseMessage.StatusCode == HttpStatusCode.OK &&
			string.IsNullOrWhiteSpace(value: responseContent) == false)
		{
			MessageBox.Show(text: responseContent);
		}
	}

	private async void Step02Button_Click(object sender, EventArgs e)
	{
		var ollamaTagsEndpoint = "/api/tags";
		var ollamaBaseAddressEndpoint = "http://127.0.0.1:11434";

		var ollamaClient = new HttpClient
		{
			BaseAddress = new Uri(ollamaBaseAddressEndpoint)
		};

		var responseMessage =
			await
			ollamaClient.GetAsync(requestUri: ollamaTagsEndpoint);

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

					MessageBox.Show(text: model.Name);
				}
			}
		}
	}

	private async void Step03Button_Click(object sender, EventArgs e)
	{
		var ollamaChatEndpoint = "/api/chat";
		var ollamaBaseAddressEndpoint = "http://127.0.0.1:11434";

		var ollamaClient = new HttpClient
		{
			BaseAddress = new Uri(ollamaBaseAddressEndpoint)
		};

		var chatRequest =
			new ChatRequest
			{
				Model = "llama3.2:latest",
				Messages =
				[
					new ChatMessage
					{
						Role = "user",
						Content = "Hello, Ollama!",
					},
				],
				Stream = false,
			};

		var chatRequestJson =
			JsonSerializer.Serialize(value: chatRequest);

		var content = new StringContent(content: chatRequestJson,
			encoding: Encoding.UTF8, mediaType: "application/json");

		var responseMessage =
			await
			ollamaClient.PostAsync
			(requestUri: ollamaChatEndpoint, content: content);

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
				var message = modelResponse.Message;

				if (message is not null)
				{
					var result =
						$"{message.Role}: {message.Content}";

					MessageBox.Show(text: result);
				}
			}
		}
	}
}
