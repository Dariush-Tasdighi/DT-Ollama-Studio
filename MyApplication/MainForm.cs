using Dtat.Ollama;

namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private OllamaHelper? MyOllamaHelper { get; set; }

	private void MainForm_Load(object sender, EventArgs e)
	{
		Text = "DT Ollama Studio - Version 2.0";

		DisableControls();

		getModelsButton.Enabled = true;
		baseAddressTextBox.Enabled = true;
	}

	private async void GetModelsButton_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(value: baseAddressTextBox.Text))
		{
			MessageBox.Show(text: "You did not specify base address!");
			return;
		}

		DisableControls();

		// همیشه باید در این حالت ایجاد شود
		MyOllamaHelper =
			new OllamaHelper(baseAddress: baseAddressTextBox.Text);

		var models =
			await
			MyOllamaHelper.GetModelsAsync();

		modelsComboBox.DataSource = models;

		EnableControls();
		modelsComboBox.Focus();
	}

	private async void ChatButton_Click(object sender, EventArgs e)
	{
		await ChatAsync();
	}

	private async void PromptTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		// CTRL + ENTER
		if (e.Control && e.KeyCode == Keys.Enter)
		{
			e.Handled = true;
			await ChatAsync();
		}
	}

	private async Task ChatAsync()
	{
		if (string.IsNullOrWhiteSpace(value: baseAddressTextBox.Text))
		{
			MessageBox.Show(text: "You did not specify base address!");
			return;
		}

		var modelName =
			modelsComboBox.SelectedItem;

		if (modelName is null)
		{
			MessageBox.Show(text: "You did not specify model!");
			modelsComboBox.Focus();
			return;
		}

		var userPrompt =
			promptTextBox.Text;

		if (string.IsNullOrWhiteSpace(value: userPrompt))
		{
			MessageBox.Show(text: "You did specify prompt!");
			promptTextBox.Focus();
			return;
		}

		DisableControls();

		userPrompt =
			userPrompt.Trim();

		responseTextBox.Text =
			await
			MyOllamaHelper!.ChatAsync(modelName: modelName.ToString()!,
			userPrompt: userPrompt, remember: rememberCheckBox.Checked);

		EnableControls();
		promptTextBox.Focus();
	}

	private void DisableControls()
	{
		chatButton.Enabled = false;
		promptTextBox.Enabled = false;
		modelsComboBox.Enabled = false;
		getModelsButton.Enabled = false;
		baseAddressTextBox.Enabled = false;
	}

	private void EnableControls()
	{
		chatButton.Enabled = true;
		promptTextBox.Enabled = true;
		modelsComboBox.Enabled = true;
		getModelsButton.Enabled = true;
		baseAddressTextBox.Enabled = true;
	}
}
