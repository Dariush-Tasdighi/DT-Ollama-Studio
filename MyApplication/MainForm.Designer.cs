namespace MyApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			getModelsButton = new Button();
			modelsComboBox = new ComboBox();
			promptTextBox = new TextBox();
			responseTextBox = new TextBox();
			submitButton = new Button();
			rememberCheckBox = new CheckBox();
			endpointTextBox = new TextBox();
			endpointLabel = new Label();
			SuspendLayout();
			// 
			// getModelsButton
			// 
			getModelsButton.BackColor = Color.Khaki;
			getModelsButton.FlatAppearance.BorderSize = 0;
			getModelsButton.FlatStyle = FlatStyle.Flat;
			getModelsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			getModelsButton.Location = new Point(12, 46);
			getModelsButton.Margin = new Padding(4);
			getModelsButton.Name = "getModelsButton";
			getModelsButton.Size = new Size(150, 36);
			getModelsButton.TabIndex = 2;
			getModelsButton.Text = "&Get Models";
			getModelsButton.UseVisualStyleBackColor = false;
			getModelsButton.Click += GetModelsButton_Click;
			// 
			// modelsComboBox
			// 
			modelsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			modelsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			modelsComboBox.FlatStyle = FlatStyle.Flat;
			modelsComboBox.FormattingEnabled = true;
			modelsComboBox.Location = new Point(170, 46);
			modelsComboBox.Margin = new Padding(4);
			modelsComboBox.Name = "modelsComboBox";
			modelsComboBox.Size = new Size(488, 36);
			modelsComboBox.TabIndex = 3;
			// 
			// promptTextBox
			// 
			promptTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			promptTextBox.BorderStyle = BorderStyle.None;
			promptTextBox.Location = new Point(12, 90);
			promptTextBox.Margin = new Padding(4);
			promptTextBox.Multiline = true;
			promptTextBox.Name = "promptTextBox";
			promptTextBox.ScrollBars = ScrollBars.Vertical;
			promptTextBox.Size = new Size(646, 139);
			promptTextBox.TabIndex = 4;
			promptTextBox.KeyDown += PromptTextBox_KeyDown;
			// 
			// responseTextBox
			// 
			responseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			responseTextBox.BorderStyle = BorderStyle.None;
			responseTextBox.Location = new Point(12, 237);
			responseTextBox.Margin = new Padding(4);
			responseTextBox.Multiline = true;
			responseTextBox.Name = "responseTextBox";
			responseTextBox.ReadOnly = true;
			responseTextBox.ScrollBars = ScrollBars.Vertical;
			responseTextBox.Size = new Size(646, 267);
			responseTextBox.TabIndex = 5;
			// 
			// submitButton
			// 
			submitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			submitButton.BackColor = Color.Khaki;
			submitButton.FlatAppearance.BorderSize = 0;
			submitButton.FlatStyle = FlatStyle.Flat;
			submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			submitButton.Location = new Point(506, 512);
			submitButton.Margin = new Padding(4);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(150, 36);
			submitButton.TabIndex = 7;
			submitButton.Text = "&Submit";
			submitButton.UseVisualStyleBackColor = false;
			submitButton.Click += SubmitButton_Click;
			// 
			// rememberCheckBox
			// 
			rememberCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			rememberCheckBox.AutoSize = true;
			rememberCheckBox.Location = new Point(16, 517);
			rememberCheckBox.Name = "rememberCheckBox";
			rememberCheckBox.Size = new Size(128, 32);
			rememberCheckBox.TabIndex = 6;
			rememberCheckBox.Text = "&Remember";
			rememberCheckBox.UseVisualStyleBackColor = true;
			// 
			// endpointTextBox
			// 
			endpointTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			endpointTextBox.BorderStyle = BorderStyle.None;
			endpointTextBox.Location = new Point(170, 12);
			endpointTextBox.Name = "endpointTextBox";
			endpointTextBox.Size = new Size(488, 27);
			endpointTextBox.TabIndex = 1;
			endpointTextBox.Text = "http://127.0.0.1:11434";
			// 
			// endpointLabel
			// 
			endpointLabel.AutoSize = true;
			endpointLabel.Location = new Point(12, 11);
			endpointLabel.Name = "endpointLabel";
			endpointLabel.Size = new Size(92, 28);
			endpointLabel.TabIndex = 0;
			endpointLabel.Text = "&Endpoint";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(670, 561);
			Controls.Add(endpointLabel);
			Controls.Add(endpointTextBox);
			Controls.Add(rememberCheckBox);
			Controls.Add(submitButton);
			Controls.Add(responseTextBox);
			Controls.Add(promptTextBox);
			Controls.Add(modelsComboBox);
			Controls.Add(getModelsButton);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button getModelsButton;
		private ComboBox modelsComboBox;
		private TextBox promptTextBox;
		private TextBox responseTextBox;
		private Button submitButton;
		private CheckBox rememberCheckBox;
		private TextBox endpointTextBox;
		private Label endpointLabel;
	}
}