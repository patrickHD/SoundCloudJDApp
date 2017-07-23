namespace WindowsFormsTest
{
	partial class Form1
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
			this.openButton = new System.Windows.Forms.Button();
			this.outText = new System.Windows.Forms.TextBox();
			this.dispRadio = new System.Windows.Forms.RadioButton();
			this.tagRadio = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(12, 12);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(207, 41);
			this.openButton.TabIndex = 0;
			this.openButton.Text = "Open Folder";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// outText
			// 
			this.outText.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.outText.Location = new System.Drawing.Point(0, 60);
			this.outText.Multiline = true;
			this.outText.Name = "outText";
			this.outText.Size = new System.Drawing.Size(322, 420);
			this.outText.TabIndex = 1;
			// 
			// dispRadio
			// 
			this.dispRadio.AutoSize = true;
			this.dispRadio.Checked = true;
			this.dispRadio.Location = new System.Drawing.Point(225, 12);
			this.dispRadio.Name = "dispRadio";
			this.dispRadio.Size = new System.Drawing.Size(89, 17);
			this.dispRadio.TabIndex = 2;
			this.dispRadio.TabStop = true;
			this.dispRadio.Text = "Display Mode";
			this.dispRadio.UseVisualStyleBackColor = true;
			// 
			// tagRadio
			// 
			this.tagRadio.AutoSize = true;
			this.tagRadio.Location = new System.Drawing.Point(225, 36);
			this.tagRadio.Name = "tagRadio";
			this.tagRadio.Size = new System.Drawing.Size(74, 17);
			this.tagRadio.TabIndex = 3;
			this.tagRadio.Text = "Tag Mode";
			this.tagRadio.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 480);
			this.Controls.Add(this.tagRadio);
			this.Controls.Add(this.dispRadio);
			this.Controls.Add(this.outText);
			this.Controls.Add(this.openButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.TextBox outText;
		private System.Windows.Forms.RadioButton dispRadio;
		private System.Windows.Forms.RadioButton tagRadio;
	}
}

