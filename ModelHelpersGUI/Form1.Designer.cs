
namespace ModelHelpersGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackGroupBox = new System.Windows.Forms.GroupBox();
            this.unpackSourceButton = new System.Windows.Forms.Button();
            this.unpackSourceBrowseButton = new System.Windows.Forms.Button();
            this.unpackSourceTextBox = new System.Windows.Forms.TextBox();
            this.unpackSourceLabel = new System.Windows.Forms.Label();
            this.packGroupBox = new System.Windows.Forms.GroupBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.packButton = new System.Windows.Forms.Button();
            this.rarcnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customFolderBrowseButton = new System.Windows.Forms.Button();
            this.customFolderTextBox = new System.Windows.Forms.TextBox();
            this.customFolderLabel = new System.Windows.Forms.Label();
            this.cleanFolderBrowseButton = new System.Windows.Forms.Button();
            this.cleanFolderTextBox = new System.Windows.Forms.TextBox();
            this.cleanFolderLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fauxConsoleTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.unpackGroupBox.SuspendLayout();
            this.packGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Checked = true;
            this.consoleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // unpackGroupBox
            // 
            this.unpackGroupBox.Controls.Add(this.unpackSourceButton);
            this.unpackGroupBox.Controls.Add(this.unpackSourceBrowseButton);
            this.unpackGroupBox.Controls.Add(this.unpackSourceTextBox);
            this.unpackGroupBox.Controls.Add(this.unpackSourceLabel);
            this.unpackGroupBox.Location = new System.Drawing.Point(12, 27);
            this.unpackGroupBox.Name = "unpackGroupBox";
            this.unpackGroupBox.Size = new System.Drawing.Size(295, 104);
            this.unpackGroupBox.TabIndex = 1;
            this.unpackGroupBox.TabStop = false;
            this.unpackGroupBox.Text = "Unpack Models";
            // 
            // unpackSourceButton
            // 
            this.unpackSourceButton.Location = new System.Drawing.Point(173, 66);
            this.unpackSourceButton.Name = "unpackSourceButton";
            this.unpackSourceButton.Size = new System.Drawing.Size(107, 23);
            this.unpackSourceButton.TabIndex = 7;
            this.unpackSourceButton.Text = "Unpack";
            this.unpackSourceButton.UseVisualStyleBackColor = true;
            this.unpackSourceButton.Click += new System.EventHandler(this.unpackSourceButton_Click);
            // 
            // unpackSourceBrowseButton
            // 
            this.unpackSourceBrowseButton.Location = new System.Drawing.Point(246, 37);
            this.unpackSourceBrowseButton.Name = "unpackSourceBrowseButton";
            this.unpackSourceBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.unpackSourceBrowseButton.TabIndex = 6;
            this.unpackSourceBrowseButton.Text = "...";
            this.unpackSourceBrowseButton.UseVisualStyleBackColor = true;
            this.unpackSourceBrowseButton.Click += new System.EventHandler(this.unpackSourceBrowseButton_Click);
            // 
            // unpackSourceTextBox
            // 
            this.unpackSourceTextBox.Location = new System.Drawing.Point(6, 37);
            this.unpackSourceTextBox.Name = "unpackSourceTextBox";
            this.unpackSourceTextBox.Size = new System.Drawing.Size(234, 23);
            this.unpackSourceTextBox.TabIndex = 5;
            // 
            // unpackSourceLabel
            // 
            this.unpackSourceLabel.AutoSize = true;
            this.unpackSourceLabel.Location = new System.Drawing.Point(6, 19);
            this.unpackSourceLabel.Name = "unpackSourceLabel";
            this.unpackSourceLabel.Size = new System.Drawing.Size(86, 15);
            this.unpackSourceLabel.TabIndex = 4;
            this.unpackSourceLabel.Text = "Source Archive";
            // 
            // packGroupBox
            // 
            this.packGroupBox.Controls.Add(this.moveButton);
            this.packGroupBox.Controls.Add(this.packButton);
            this.packGroupBox.Controls.Add(this.rarcnameTextBox);
            this.packGroupBox.Controls.Add(this.label1);
            this.packGroupBox.Controls.Add(this.customFolderBrowseButton);
            this.packGroupBox.Controls.Add(this.customFolderTextBox);
            this.packGroupBox.Controls.Add(this.customFolderLabel);
            this.packGroupBox.Controls.Add(this.cleanFolderBrowseButton);
            this.packGroupBox.Controls.Add(this.cleanFolderTextBox);
            this.packGroupBox.Controls.Add(this.cleanFolderLabel);
            this.packGroupBox.Location = new System.Drawing.Point(12, 137);
            this.packGroupBox.Name = "packGroupBox";
            this.packGroupBox.Size = new System.Drawing.Size(295, 222);
            this.packGroupBox.TabIndex = 2;
            this.packGroupBox.TabStop = false;
            this.packGroupBox.Text = "Pack Models";
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(173, 183);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(107, 23);
            this.moveButton.TabIndex = 16;
            this.moveButton.Text = "Move to Dolphin";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(173, 154);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(107, 23);
            this.packButton.TabIndex = 15;
            this.packButton.Text = "Pack";
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // rarcnameTextBox
            // 
            this.rarcnameTextBox.Location = new System.Drawing.Point(7, 125);
            this.rarcnameTextBox.Name = "rarcnameTextBox";
            this.rarcnameTextBox.Size = new System.Drawing.Size(234, 23);
            this.rarcnameTextBox.TabIndex = 14;
            this.rarcnameTextBox.TextChanged += new System.EventHandler(this.rarcnameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Output Archive Name";
            // 
            // customFolderBrowseButton
            // 
            this.customFolderBrowseButton.Location = new System.Drawing.Point(246, 81);
            this.customFolderBrowseButton.Name = "customFolderBrowseButton";
            this.customFolderBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.customFolderBrowseButton.TabIndex = 12;
            this.customFolderBrowseButton.Text = "...";
            this.customFolderBrowseButton.UseVisualStyleBackColor = true;
            this.customFolderBrowseButton.Click += new System.EventHandler(this.customFolderBrowseButton_Click);
            // 
            // customFolderTextBox
            // 
            this.customFolderTextBox.Location = new System.Drawing.Point(6, 81);
            this.customFolderTextBox.Name = "customFolderTextBox";
            this.customFolderTextBox.Size = new System.Drawing.Size(234, 23);
            this.customFolderTextBox.TabIndex = 11;
            // 
            // customFolderLabel
            // 
            this.customFolderLabel.AutoSize = true;
            this.customFolderLabel.Location = new System.Drawing.Point(6, 63);
            this.customFolderLabel.Name = "customFolderLabel";
            this.customFolderLabel.Size = new System.Drawing.Size(85, 15);
            this.customFolderLabel.TabIndex = 10;
            this.customFolderLabel.Text = "Custom Folder";
            // 
            // cleanFolderBrowseButton
            // 
            this.cleanFolderBrowseButton.Location = new System.Drawing.Point(246, 37);
            this.cleanFolderBrowseButton.Name = "cleanFolderBrowseButton";
            this.cleanFolderBrowseButton.Size = new System.Drawing.Size(34, 23);
            this.cleanFolderBrowseButton.TabIndex = 9;
            this.cleanFolderBrowseButton.Text = "...";
            this.cleanFolderBrowseButton.UseVisualStyleBackColor = true;
            this.cleanFolderBrowseButton.Click += new System.EventHandler(this.cleanFolderBrowseButton_Click);
            // 
            // cleanFolderTextBox
            // 
            this.cleanFolderTextBox.Location = new System.Drawing.Point(6, 37);
            this.cleanFolderTextBox.Name = "cleanFolderTextBox";
            this.cleanFolderTextBox.Size = new System.Drawing.Size(234, 23);
            this.cleanFolderTextBox.TabIndex = 8;
            // 
            // cleanFolderLabel
            // 
            this.cleanFolderLabel.AutoSize = true;
            this.cleanFolderLabel.Location = new System.Drawing.Point(6, 19);
            this.cleanFolderLabel.Name = "cleanFolderLabel";
            this.cleanFolderLabel.Size = new System.Drawing.Size(73, 15);
            this.cleanFolderLabel.TabIndex = 7;
            this.cleanFolderLabel.Text = "Clean Folder";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fauxConsoleTextBox
            // 
            this.fauxConsoleTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fauxConsoleTextBox.Location = new System.Drawing.Point(313, 38);
            this.fauxConsoleTextBox.Multiline = true;
            this.fauxConsoleTextBox.Name = "fauxConsoleTextBox";
            this.fauxConsoleTextBox.ReadOnly = true;
            this.fauxConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fauxConsoleTextBox.Size = new System.Drawing.Size(100, 23);
            this.fauxConsoleTextBox.TabIndex = 3;
            this.fauxConsoleTextBox.TextChanged += new System.EventHandler(this.fauxConsoleTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 377);
            this.Controls.Add(this.fauxConsoleTextBox);
            this.Controls.Add(this.packGroupBox);
            this.Controls.Add(this.unpackGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Model Helpers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.unpackGroupBox.ResumeLayout(false);
            this.unpackGroupBox.PerformLayout();
            this.packGroupBox.ResumeLayout(false);
            this.packGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox unpackGroupBox;
        private System.Windows.Forms.GroupBox packGroupBox;
        private System.Windows.Forms.Button unpackSourceButton;
        private System.Windows.Forms.Button unpackSourceBrowseButton;
        private System.Windows.Forms.TextBox unpackSourceTextBox;
        private System.Windows.Forms.Label unpackSourceLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox fauxConsoleTextBox;
        private System.Windows.Forms.Button customFolderBrowseButton;
        private System.Windows.Forms.TextBox customFolderTextBox;
        private System.Windows.Forms.Label customFolderLabel;
        private System.Windows.Forms.Button cleanFolderBrowseButton;
        private System.Windows.Forms.TextBox cleanFolderTextBox;
        private System.Windows.Forms.Label cleanFolderLabel;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button packButton;
        private System.Windows.Forms.TextBox rarcnameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

