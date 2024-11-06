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
			chatButton = new Button();
			rememberHistoryCheckBox = new CheckBox();
			baseAddressTextBox = new TextBox();
			baseAddressLabel = new Label();
			SuspendLayout();
			// 
			// getModelsButton
			// 
			getModelsButton.BackColor = Color.Khaki;
			getModelsButton.FlatAppearance.BorderSize = 0;
			getModelsButton.FlatStyle = FlatStyle.Flat;
			getModelsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			getModelsButton.Location = new Point(13, 46);
			getModelsButton.Margin = new Padding(4);
			getModelsButton.Name = "getModelsButton";
			getModelsButton.Size = new Size(164, 36);
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
			modelsComboBox.Location = new Point(185, 46);
			modelsComboBox.Margin = new Padding(4);
			modelsComboBox.Name = "modelsComboBox";
			modelsComboBox.Size = new Size(375, 36);
			modelsComboBox.TabIndex = 3;
			// 
			// promptTextBox
			// 
			promptTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			promptTextBox.BorderStyle = BorderStyle.None;
			promptTextBox.Location = new Point(13, 90);
			promptTextBox.Margin = new Padding(4);
			promptTextBox.Multiline = true;
			promptTextBox.Name = "promptTextBox";
			promptTextBox.ScrollBars = ScrollBars.Vertical;
			promptTextBox.Size = new Size(547, 139);
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
			responseTextBox.Size = new Size(548, 159);
			responseTextBox.TabIndex = 5;
			// 
			// chatButton
			// 
			chatButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			chatButton.BackColor = Color.Khaki;
			chatButton.FlatAppearance.BorderSize = 0;
			chatButton.FlatStyle = FlatStyle.Flat;
			chatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			chatButton.Location = new Point(396, 404);
			chatButton.Margin = new Padding(4);
			chatButton.Name = "chatButton";
			chatButton.Size = new Size(164, 36);
			chatButton.TabIndex = 7;
			chatButton.Text = "&Chat";
			chatButton.UseVisualStyleBackColor = false;
			chatButton.Click += ChatButton_Click;
			// 
			// rememberHistoryCheckBox
			// 
			rememberHistoryCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			rememberHistoryCheckBox.AutoSize = true;
			rememberHistoryCheckBox.Location = new Point(12, 407);
			rememberHistoryCheckBox.Name = "rememberHistoryCheckBox";
			rememberHistoryCheckBox.Size = new Size(212, 32);
			rememberHistoryCheckBox.TabIndex = 6;
			rememberHistoryCheckBox.Text = "&Remember History";
			rememberHistoryCheckBox.UseVisualStyleBackColor = true;
			// 
			// baseAddressTextBox
			// 
			baseAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			baseAddressTextBox.BorderStyle = BorderStyle.None;
			baseAddressTextBox.Location = new Point(185, 12);
			baseAddressTextBox.Name = "baseAddressTextBox";
			baseAddressTextBox.Size = new Size(375, 27);
			baseAddressTextBox.TabIndex = 1;
			baseAddressTextBox.Text = "http://127.0.0.1:11434";
			// 
			// baseAddressLabel
			// 
			baseAddressLabel.AutoSize = true;
			baseAddressLabel.Location = new Point(13, 12);
			baseAddressLabel.Name = "baseAddressLabel";
			baseAddressLabel.Size = new Size(137, 28);
			baseAddressLabel.TabIndex = 0;
			baseAddressLabel.Text = "&Base Address";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(12F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(572, 453);
			Controls.Add(baseAddressLabel);
			Controls.Add(baseAddressTextBox);
			Controls.Add(rememberHistoryCheckBox);
			Controls.Add(chatButton);
			Controls.Add(responseTextBox);
			Controls.Add(promptTextBox);
			Controls.Add(modelsComboBox);
			Controls.Add(getModelsButton);
			Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			MinimumSize = new Size(590, 500);
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
		private Button chatButton;
		private CheckBox rememberHistoryCheckBox;
		private TextBox baseAddressTextBox;
		private Label baseAddressLabel;
	}
}