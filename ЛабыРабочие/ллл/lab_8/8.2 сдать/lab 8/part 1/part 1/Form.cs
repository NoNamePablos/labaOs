using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace part_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        private String filePath;
        private FileSystemWatcher watcher;
        private bool isSaving = false;

        public Form()
        {
            InitializeComponent();
        }

        private void openFileMenuItemClick(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "";
                openFileDialog.Filter = "All files|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (var reader = new StreamReader(fileStream))
                    {
                        textBox.Text = reader.ReadToEnd();
                    }
                }
            }

            if (watcher != null)
                watcher.Dispose();
            var fileName = Path.GetFileName(filePath);
            var directoryPath = filePath.Substring(0, filePath.Length - fileName.Length);
            watcher = new FileSystemWatcher(directoryPath, fileName);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.SynchronizingObject = this;
            watcher.Changed += (obj, evnt) => {
                if (isSaving)
                {
                    isSaving = false;
                    return;
                }
                var result = MessageBox.Show("File has been changed, do you want to reload it?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        textBox.Text = reader.ReadToEnd();
                    }
                }
            };
        }

        private void saveFileMenuItemClick(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                MessageBox.Show("There is no opened file");
                return;
            }

            isSaving = true;
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var writer = new StreamWriter(fs);
                writer.Write(textBox.Text);
                writer.Close();
            }
        }

        private void closeFileItemClick(object sender, EventArgs e)
        {
            textBox.Text = "";
            filePath = null;
        }
    }
}
