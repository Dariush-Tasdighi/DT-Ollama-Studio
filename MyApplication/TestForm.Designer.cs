namespace MyApplication
{
	partial class TestForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			step01Button = new Button();
			step02Button = new Button();
			step03Button = new Button();
			SuspendLayout();
			// 
			// step01Button
			// 
			step01Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			step01Button.Location = new Point(12, 12);
			step01Button.Name = "step01Button";
			step01Button.Size = new Size(470, 29);
			step01Button.TabIndex = 0;
			step01Button.Text = "Step (1)";
			step01Button.UseVisualStyleBackColor = true;
			step01Button.Click += Step01Button_Click;
			// 
			// step02Button
			// 
			step02Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			step02Button.Location = new Point(12, 47);
			step02Button.Name = "step02Button";
			step02Button.Size = new Size(470, 29);
			step02Button.TabIndex = 1;
			step02Button.Text = "Step (2)";
			step02Button.UseVisualStyleBackColor = true;
			step02Button.Click += Step02Button_Click;
			// 
			// step03Button
			// 
			step03Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			step03Button.Location = new Point(12, 82);
			step03Button.Name = "step03Button";
			step03Button.Size = new Size(470, 29);
			step03Button.TabIndex = 2;
			step03Button.Text = "Step (3)";
			step03Button.UseVisualStyleBackColor = true;
			step03Button.Click += Step03Button_Click;
			// 
			// TestForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(494, 361);
			Controls.Add(step03Button);
			Controls.Add(step02Button);
			Controls.Add(step01Button);
			Name = "TestForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Test";
			Load += TestForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button step01Button;
		private Button step02Button;
		private Button step03Button;
	}
}
