namespace MediaRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.browseInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFileString = new System.Windows.Forms.TextBox();
            this.outputFileString = new System.Windows.Forms.TextBox();
            this.browseOutput = new System.Windows.Forms.Button();
            this.renameFilesButton = new System.Windows.Forms.Button();
            this.renameFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // browseInput
            // 
            this.browseInput.Location = new System.Drawing.Point(315, 29);
            this.browseInput.Name = "browseInput";
            this.browseInput.Size = new System.Drawing.Size(75, 22);
            this.browseInput.TabIndex = 0;
            this.browseInput.Text = "Browse";
            this.browseInput.UseVisualStyleBackColor = true;
            this.browseInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rename Folder Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rename Folder Output (Optional)";
            // 
            // inputFileString
            // 
            this.inputFileString.Location = new System.Drawing.Point(16, 30);
            this.inputFileString.Name = "inputFileString";
            this.inputFileString.Size = new System.Drawing.Size(301, 20);
            this.inputFileString.TabIndex = 3;
            // 
            // outputFileString
            // 
            this.outputFileString.Location = new System.Drawing.Point(16, 74);
            this.outputFileString.Name = "outputFileString";
            this.outputFileString.Size = new System.Drawing.Size(301, 20);
            this.outputFileString.TabIndex = 5;
            // 
            // browseOutput
            // 
            this.browseOutput.Location = new System.Drawing.Point(315, 73);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(75, 22);
            this.browseOutput.TabIndex = 4;
            this.browseOutput.Text = "Browse";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.browseOutput_Click);
            // 
            // renameFilesButton
            // 
            this.renameFilesButton.Location = new System.Drawing.Point(305, 124);
            this.renameFilesButton.Name = "renameFilesButton";
            this.renameFilesButton.Size = new System.Drawing.Size(85, 23);
            this.renameFilesButton.TabIndex = 6;
            this.renameFilesButton.Text = "Rename Files";
            this.renameFilesButton.UseVisualStyleBackColor = true;
            this.renameFilesButton.Click += new System.EventHandler(this.renameFilesButton_Click);
            // 
            // renameFolderCheckBox
            // 
            this.renameFolderCheckBox.AutoSize = true;
            this.renameFolderCheckBox.Location = new System.Drawing.Point(16, 128);
            this.renameFolderCheckBox.Name = "renameFolderCheckBox";
            this.renameFolderCheckBox.Size = new System.Drawing.Size(147, 17);
            this.renameFolderCheckBox.TabIndex = 7;
            this.renameFolderCheckBox.Text = "Rename All Files in Folder";
            this.renameFolderCheckBox.UseVisualStyleBackColor = true;
            this.renameFolderCheckBox.CheckedChanged += new System.EventHandler(this.renameFolderCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 159);
            this.Controls.Add(this.renameFolderCheckBox);
            this.Controls.Add(this.renameFilesButton);
            this.Controls.Add(this.outputFileString);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.inputFileString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Media Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFileString;
        private System.Windows.Forms.TextBox outputFileString;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.Button renameFilesButton;
        private System.Windows.Forms.CheckBox renameFolderCheckBox;
    }
}

