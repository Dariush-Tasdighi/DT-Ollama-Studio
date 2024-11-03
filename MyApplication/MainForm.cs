using System.Net;
using System.Text;
using System.Text.Json;
using MyApplication.Models;

namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private List<ChatMessage> ChatMessages { get; set; } = [];

	private void MainForm_Load(object sender, EventArgs e)
	{
		Text =
			"DT Ollama Studio - Version 1.1";

		DisableControls();
		getModelsButton.Enabled = true;
	}

	private async void GetModelsButton_Click(object sender, EventArgs e)
	{
		if(string.IsNullOrWhiteSpace(value: endpointTextBox.Text))
		{
			MessageBox.Show(text: "You did not specify Endpoint!");
			return;
		}

		DisableControls();

		var ollamaTagsEndpoint = "/api/tags";

		var ollamaClient = new HttpClient
		{
			BaseAddress =
				new Uri(uriString: endpointTextBox.Text),
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

					if (string.IsNullOrWhiteSpace(value: model.Name) == false)
					{
						modelsComboBox.Items.Add(item: model.Name);
					}
				}
			}
		}

		EnableControls();

		modelsComboBox.Focus();
	}

	private async void SubmitButton_Click(object sender, EventArgs e)
	{
		await SubmitAsync();
	}

	private async void PromptTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control && e.KeyCode == Keys.Enter)
		{
			e.Handled = true;
			await SubmitAsync();
		}
	}

	private async Task SubmitAsync()
	{
		if (string.IsNullOrWhiteSpace(value: endpointTextBox.Text))
		{
			MessageBox.Show(text: "You did not specify Endpoint!");
			return;
		}

		var model =
			modelsComboBox.SelectedItem;

		if (model is null)
		{
			MessageBox.Show(text: "You did not select model!");
			modelsComboBox.Focus();
			return;
		}

		var userPrompt =
			promptTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: userPrompt))
		{
			MessageBox.Show(text: "You did not write any prompt!");
			promptTextBox.Focus();
			return;
		}

		userPrompt = userPrompt.Trim();

		DisableControls();

		// **************************************************
		if (rememberCheckBox.Checked == false)
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

		var ollamaChatEndpoint = "/api/chat";

		var ollamaClient = new HttpClient
		{
			BaseAddress =
				new Uri(uriString: endpointTextBox.Text),
		};

		var chatRequest =
			new ChatRequest
			{
				Stream = false,
				Model = model.ToString(),
				Messages = ChatMessages,
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
				var message =
					modelResponse.Message;

				if (message is not null)
				{
					responseTextBox.Text = message.Content;

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

		EnableControls();

		promptTextBox.Focus();
	}

	private void DisableControls()
	{
		submitButton.Enabled = false;
		promptTextBox.Enabled = false;
		modelsComboBox.Enabled = false;
		getModelsButton.Enabled = false;
	}

	private void EnableControls()
	{
		submitButton.Enabled = true;
		promptTextBox.Enabled = true;
		modelsComboBox.Enabled = true;
		getModelsButton.Enabled = true;
	}
}
