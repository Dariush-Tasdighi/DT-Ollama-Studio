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
			SuspendLayout();
			// 
			// getModelsButton
			// 
			getModelsButton.BackColor = Color.Khaki;
			getModelsButton.FlatAppearance.BorderSize = 0;
			getModelsButton.FlatStyle = FlatStyle.Flat;
			getModelsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			getModelsButton.Location = new Point(15, 13);
			getModelsButton.Margin = new Padding(4);
			getModelsButton.Name = "getModelsButton";
			getModelsButton.Size = new Size(129, 36);
			getModelsButton.TabIndex = 0;
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
			modelsComboBox.Location = new Point(150, 13);
			modelsComboBox.Margin = new Padding(4);
			modelsComboBox.Name = "modelsComboBox";
			modelsComboBox.Size = new Size(507, 36);
			modelsComboBox.TabIndex = 1;
			// 
			// promptTextBox
			// 
			promptTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			promptTextBox.BorderStyle = BorderStyle.None;
			promptTextBox.Location = new Point(15, 57);
			promptTextBox.Margin = new Padding(4);
			promptTextBox.Name = "promptTextBox";
			promptTextBox.Size = new Size(641, 27);
			promptTextBox.TabIndex = 2;
			// 
			// responseTextBox
			// 
			responseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			responseTextBox.BorderStyle = BorderStyle.None;
			responseTextBox.Location = new Point(16, 92);
			responseTextBox.Margin = new Padding(4);
			responseTextBox.Multiline = true;
			responseTextBox.Name = "responseTextBox";
			responseTextBox.ReadOnly = true;
			responseTextBox.ScrollBars = ScrollBars.Both;
			responseTextBox.Size = new Size(641, 301);
			responseTextBox.TabIndex = 3;
			// 
			// submitButton
			// 
			submitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			submitButton.BackColor = Color.Khaki;
			submitButton.FlatAppearance.BorderSize = 0;
			submitButton.FlatStyle = FlatStyle.Flat;
			submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			submitButton.Location = new Point(527, 401);
			submitButton.Margin = new Padding(4);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(129, 36);
			submitButton.TabIndex = 5;
			submitButton.Text = "&Submit";
			submitButton.UseVisualStyleBackColor = false;
			submitButton.Click += SubmitButton_Click;
			// 
			// rememberCheckBox
			// 
			rememberCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			rememberCheckBox.AutoSize = true;
			rememberCheckBox.Location = new Point(16, 406);
			rememberCheckBox.Name = "rememberCheckBox";
			rememberCheckBox.Size = new Size(128, 32);
			rememberCheckBox.TabIndex = 4;
			rememberCheckBox.Text = "&Remember";
			rememberCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AcceptButton = submitButton;
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			ClientSize = new Size(670, 450);
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
	}
}