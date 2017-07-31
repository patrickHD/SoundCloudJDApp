namespace WindowsFormsTest
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
            this.openButton = new System.Windows.Forms.Button();
            this.outText = new System.Windows.Forms.TextBox();
            this.dispRadio = new System.Windows.Forms.RadioButton();
            this.tagRadio = new System.Windows.Forms.RadioButton();
            this.folderRadio = new System.Windows.Forms.RadioButton();
            this.fileRadio = new System.Windows.Forms.RadioButton();
            this.modeGroup = new System.Windows.Forms.GroupBox();
            this.artCheck = new System.Windows.Forms.CheckBox();
            this.artButton = new System.Windows.Forms.Button();
            this.modeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 36);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // outText
            // 
            this.outText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outText.Location = new System.Drawing.Point(0, 94);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(322, 369);
            this.outText.TabIndex = 1;
            // 
            // dispRadio
            // 
            this.dispRadio.AutoSize = true;
            this.dispRadio.Location = new System.Drawing.Point(6, 19);
            this.dispRadio.Name = "dispRadio";
            this.dispRadio.Size = new System.Drawing.Size(89, 17);
            this.dispRadio.TabIndex = 2;
            this.dispRadio.Text = "Display Mode";
            this.dispRadio.UseVisualStyleBackColor = true;
            // 
            // tagRadio
            // 
            this.tagRadio.AutoSize = true;
            this.tagRadio.Checked = true;
            this.tagRadio.Location = new System.Drawing.Point(6, 36);
            this.tagRadio.Name = "tagRadio";
            this.tagRadio.Size = new System.Drawing.Size(74, 17);
            this.tagRadio.TabIndex = 3;
            this.tagRadio.TabStop = true;
            this.tagRadio.Text = "Tag Mode";
            this.tagRadio.UseVisualStyleBackColor = true;
            // 
            // folderRadio
            // 
            this.folderRadio.AutoSize = true;
            this.folderRadio.Checked = true;
            this.folderRadio.Location = new System.Drawing.Point(12, 54);
            this.folderRadio.Name = "folderRadio";
            this.folderRadio.Size = new System.Drawing.Size(87, 17);
            this.folderRadio.TabIndex = 4;
            this.folderRadio.TabStop = true;
            this.folderRadio.Text = "Folder Select";
            this.folderRadio.UseVisualStyleBackColor = true;
            // 
            // fileRadio
            // 
            this.fileRadio.AutoSize = true;
            this.fileRadio.Location = new System.Drawing.Point(118, 54);
            this.fileRadio.Name = "fileRadio";
            this.fileRadio.Size = new System.Drawing.Size(85, 17);
            this.fileRadio.TabIndex = 5;
            this.fileRadio.Text = "File(s) Select";
            this.fileRadio.UseVisualStyleBackColor = true;
            // 
            // modeGroup
            // 
            this.modeGroup.Controls.Add(this.artCheck);
            this.modeGroup.Controls.Add(this.dispRadio);
            this.modeGroup.Controls.Add(this.tagRadio);
            this.modeGroup.Location = new System.Drawing.Point(225, 12);
            this.modeGroup.Name = "modeGroup";
            this.modeGroup.Size = new System.Drawing.Size(97, 82);
            this.modeGroup.TabIndex = 6;
            this.modeGroup.TabStop = false;
            this.modeGroup.Text = "Mode";
            // 
            // artCheck
            // 
            this.artCheck.AutoSize = true;
            this.artCheck.Location = new System.Drawing.Point(6, 59);
            this.artCheck.Name = "artCheck";
            this.artCheck.Size = new System.Drawing.Size(63, 17);
            this.artCheck.TabIndex = 7;
            this.artCheck.Text = "Art Only";
            this.artCheck.UseVisualStyleBackColor = true;
            // 
            // artButton
            // 
            this.artButton.Location = new System.Drawing.Point(118, 12);
            this.artButton.Name = "artButton";
            this.artButton.Size = new System.Drawing.Size(100, 36);
            this.artButton.TabIndex = 7;
            this.artButton.Text = "Select Art";
            this.artButton.UseVisualStyleBackColor = true;
            this.artButton.Click += new System.EventHandler(this.artButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 463);
            this.Controls.Add(this.artButton);
            this.Controls.Add(this.modeGroup);
            this.Controls.Add(this.fileRadio);
            this.Controls.Add(this.folderRadio);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.openButton);
            this.Name = "MainForm";
            this.Text = "Tagging App";
            this.modeGroup.ResumeLayout(false);
            this.modeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.TextBox outText;
		private System.Windows.Forms.RadioButton dispRadio;
		private System.Windows.Forms.RadioButton tagRadio;
        private System.Windows.Forms.RadioButton folderRadio;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.GroupBox modeGroup;
        private System.Windows.Forms.CheckBox artCheck;
        private System.Windows.Forms.Button artButton;
    }
}

