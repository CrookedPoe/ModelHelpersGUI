using System;
using System.IO;
using System.Windows.Forms;

namespace ModelHelpersGUI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Restore User Preferences
            unpackModelsTextBox.Text = Properties.Settings.Default["unpackDir"].ToString();
            packModelsTextBox.Text = Properties.Settings.Default["packDir"].ToString();
            dolphinProjectTextBox.Text = Properties.Settings.Default["dolphinDir"].ToString();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            // Save User Preferences
            Properties.Settings.Default["unpackDir"] = unpackModelsTextBox.Text;
            Properties.Settings.Default["packDir"] = packModelsTextBox.Text;
            Properties.Settings.Default["dolphinDir"] = dolphinProjectTextBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void browseForExecutable(OpenFileDialog dlg, TextBox txt)
        {
            using (dlg)
            {
                dlg.InitialDirectory = Environment.CurrentDirectory;
                dlg.Filter = "Executables (*.exe)|*.exe|All Files (*.*)|*.*";
                dlg.FilterIndex = 1;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt.Text = Path.GetFullPath(dlg.FileName);
                }
            }
        }

        private void packModelsBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog packDialog = new OpenFileDialog();
            browseForExecutable(packDialog, packModelsTextBox);
            packDialog.Dispose();
        }

        private void unpackModelsBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog unpackDialog = new OpenFileDialog();
            browseForExecutable(unpackDialog, unpackModelsTextBox);
            unpackDialog.Dispose();
        }

        private void dolphinProjectBrowseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dolphinProjectTextBox.Text = Path.GetFullPath(dlg.SelectedPath);
                }
            }
        }
    }
}
