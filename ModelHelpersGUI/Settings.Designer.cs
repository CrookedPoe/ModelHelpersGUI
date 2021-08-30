
namespace ModelHelpersGUI
{
    partial class Settings
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
            this.exeGroupBox = new System.Windows.Forms.GroupBox();
            this.unpackModelsBrowseButton = new System.Windows.Forms.Button();
            this.unpackModelsTextBox = new System.Windows.Forms.TextBox();
            this.unpackModelsLabel = new System.Windows.Forms.Label();
            this.packModelsBrowseButton = new System.Windows.Forms.Button();
            this.packModelsTextBox = new System.Windows.Forms.TextBox();
            this.packModelsLabel = new System.Windows.Forms.Label();
            this.dolphinGroupBox = new System.Windows.Forms.GroupBox();
            this.dolphinProjectBrowseButton = new System.Windows.Forms.Button();
            this.dolphinProjectTextBox = new System.Windows.Forms.TextBox();
            this.dolphinProjectLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.exeGroupBox.SuspendLayout();
            this.dolphinGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exeGroupBox
            // 
            this.exeGroupBox.Controls.Add(this.unpackModelsBrowseButton);
            this.exeGroupBox.Controls.Add(this.unpackModelsTextBox);
            this.exeGroupBox.Controls.Add(this.unpackModelsLabel);
            this.exeGroupBox.Controls.Add(this.packModelsBrowseButton);
            this.exeGroupBox.Controls.Add(this.packModelsTextBox);
            this.exeGroupBox.Controls.Add(this.packModelsLabel);
            this.exeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.exeGroupBox.Name = "exeGroupBox";
            this.exeGroupBox.Size = new System.Drawing.Size(289, 119);
            this.exeGroupBox.TabIndex = 0;
            this.exeGroupBox.TabStop = false;
            this.exeGroupBox.Text = "Model Helper Executables";
            // 
            // unpackModelsBrowseButton
            // 
            this.unpackModelsBrowseButton.Location = new System.Drawing.Point(246, 81);
            this.unpackModelsBrowseButton.Name = "unpackModelsBrowseButton";
            this.unpackModelsBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.unpackModelsBrowseButton.TabIndex = 6;
            this.unpackModelsBrowseButton.Text = "...";
            this.unpackModelsBrowseButton.UseVisualStyleBackColor = true;
            this.unpackModelsBrowseButton.Click += new System.EventHandler(this.unpackModelsBrowseButton_Click);
            // 
            // unpackModelsTextBox
            // 
            this.unpackModelsTextBox.Location = new System.Drawing.Point(6, 81);
            this.unpackModelsTextBox.Name = "unpackModelsTextBox";
            this.unpackModelsTextBox.Size = new System.Drawing.Size(234, 23);
            this.unpackModelsTextBox.TabIndex = 5;
            // 
            // unpackModelsLabel
            // 
            this.unpackModelsLabel.AutoSize = true;
            this.unpackModelsLabel.Location = new System.Drawing.Point(6, 63);
            this.unpackModelsLabel.Name = "unpackModelsLabel";
            this.unpackModelsLabel.Size = new System.Drawing.Size(111, 15);
            this.unpackModelsLabel.TabIndex = 4;
            this.unpackModelsLabel.Text = "unpack_models.exe";
            // 
            // packModelsBrowseButton
            // 
            this.packModelsBrowseButton.Location = new System.Drawing.Point(246, 37);
            this.packModelsBrowseButton.Name = "packModelsBrowseButton";
            this.packModelsBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.packModelsBrowseButton.TabIndex = 3;
            this.packModelsBrowseButton.Text = "...";
            this.packModelsBrowseButton.UseVisualStyleBackColor = true;
            this.packModelsBrowseButton.Click += new System.EventHandler(this.packModelsBrowseButton_Click);
            // 
            // packModelsTextBox
            // 
            this.packModelsTextBox.Location = new System.Drawing.Point(6, 37);
            this.packModelsTextBox.Name = "packModelsTextBox";
            this.packModelsTextBox.Size = new System.Drawing.Size(234, 23);
            this.packModelsTextBox.TabIndex = 2;
            // 
            // packModelsLabel
            // 
            this.packModelsLabel.AutoSize = true;
            this.packModelsLabel.Location = new System.Drawing.Point(6, 19);
            this.packModelsLabel.Name = "packModelsLabel";
            this.packModelsLabel.Size = new System.Drawing.Size(97, 15);
            this.packModelsLabel.TabIndex = 1;
            this.packModelsLabel.Text = "pack_models.exe";
            // 
            // dolphinGroupBox
            // 
            this.dolphinGroupBox.Controls.Add(this.dolphinProjectBrowseButton);
            this.dolphinGroupBox.Controls.Add(this.dolphinProjectTextBox);
            this.dolphinGroupBox.Controls.Add(this.dolphinProjectLabel);
            this.dolphinGroupBox.Location = new System.Drawing.Point(12, 137);
            this.dolphinGroupBox.Name = "dolphinGroupBox";
            this.dolphinGroupBox.Size = new System.Drawing.Size(289, 73);
            this.dolphinGroupBox.TabIndex = 1;
            this.dolphinGroupBox.TabStop = false;
            this.dolphinGroupBox.Text = "Dolphin";
            // 
            // dolphinProjectBrowseButton
            // 
            this.dolphinProjectBrowseButton.Location = new System.Drawing.Point(246, 37);
            this.dolphinProjectBrowseButton.Name = "dolphinProjectBrowseButton";
            this.dolphinProjectBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.dolphinProjectBrowseButton.TabIndex = 6;
            this.dolphinProjectBrowseButton.Text = "...";
            this.dolphinProjectBrowseButton.UseVisualStyleBackColor = true;
            this.dolphinProjectBrowseButton.Click += new System.EventHandler(this.dolphinProjectBrowseButton_Click);
            // 
            // dolphinProjectTextBox
            // 
            this.dolphinProjectTextBox.Location = new System.Drawing.Point(6, 37);
            this.dolphinProjectTextBox.Name = "dolphinProjectTextBox";
            this.dolphinProjectTextBox.Size = new System.Drawing.Size(234, 23);
            this.dolphinProjectTextBox.TabIndex = 5;
            // 
            // dolphinProjectLabel
            // 
            this.dolphinProjectLabel.AutoSize = true;
            this.dolphinProjectLabel.Location = new System.Drawing.Point(6, 19);
            this.dolphinProjectLabel.Name = "dolphinProjectLabel";
            this.dolphinProjectLabel.Size = new System.Drawing.Size(80, 15);
            this.dolphinProjectLabel.TabIndex = 4;
            this.dolphinProjectLabel.Text = "Project Folder";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(226, 216);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.dolphinGroupBox);
            this.Controls.Add(this.exeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.exeGroupBox.ResumeLayout(false);
            this.exeGroupBox.PerformLayout();
            this.dolphinGroupBox.ResumeLayout(false);
            this.dolphinGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox exeGroupBox;
        private System.Windows.Forms.Button unpackModelsBrowseButton;
        private System.Windows.Forms.TextBox unpackModelsTextBox;
        private System.Windows.Forms.Label unpackModelsLabel;
        private System.Windows.Forms.Button packModelsBrowseButton;
        private System.Windows.Forms.TextBox packModelsTextBox;
        private System.Windows.Forms.Label packModelsLabel;
        private System.Windows.Forms.GroupBox dolphinGroupBox;
        private System.Windows.Forms.Button dolphinProjectBrowseButton;
        private System.Windows.Forms.TextBox dolphinProjectTextBox;
        private System.Windows.Forms.Label dolphinProjectLabel;
        private System.Windows.Forms.Button saveSettingsButton;
    }
}