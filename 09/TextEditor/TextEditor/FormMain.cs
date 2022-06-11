using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace TextEditor
{
    public partial class FormMain : Form
    {
        private string FilePath { get; set; } = "";
        private FileSystemWatcher Watcher { get; set; }
        private Encoding CurrentEncoding = Encoding.Default;

        private delegate void UpdateTextDelegate();

        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateText()
        {
            textBox.Text = "";

            if (FilePath != "")
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (TextReader reader = new StreamReader(fs, CurrentEncoding))
                {
                    while (reader.Peek() > -1)
                        textBox.Text += reader.ReadLine() + "\r\n";
                }
            }
        }

        private void FileChanged(object sender, EventArgs e)
        {
            Invoke(new UpdateTextDelegate(UpdateText));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                Watcher = new FileSystemWatcher(openFileDialog.FileName.Substring(0, openFileDialog.FileName.Length - openFileDialog.SafeFileName.Length), openFileDialog.SafeFileName);
                Watcher.Changed += FileChanged;
                UpdateText();
                Watcher.EnableRaisingEvents = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath != "")
            {
                Watcher.EnableRaisingEvents = false;

                using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.Read))
                using (TextWriter writter = new StreamWriter(fs, CurrentEncoding))
                {
                    foreach (string line in textBox.Lines)
                        writter.WriteLine(line);
                }

                UpdateText();
                Watcher.EnableRaisingEvents = true;
            }
        }

        private void utf8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("utf-8");
            UpdateText();
        }

        private void utf16LEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("utf-16");
            UpdateText();
        }

        private void utf16BEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("unicodeFFFE");
            UpdateText();
        }

        private void westernWindows1252ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("Windows-1252");
            UpdateText();
        }

        private void westernISO88591ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-1");
            UpdateText();
        }

        private void westernISO88593ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-3");
            UpdateText();
        }

        private void westernISO885915ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-15");
            UpdateText();
        }

        private void arabicWindows1256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("windows-1256");
            UpdateText();
        }

        private void arabicISO88596ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-6");
            UpdateText();
        }

        private void balticWindows1257ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("windows-1257");
            UpdateText();
        }

        private void balticISO88594ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-4");
            UpdateText();
        }

        private void centralEuropeanWindows1250ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("windows-1250");
            UpdateText();
        }

        private void centralEuropeanISO88592ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-2");
            UpdateText();
        }

        private void cyrillicWindows1251ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("windows-1251");
            UpdateText();
        }

        private void cyrillicISO88595ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("iso-8859-5");
            UpdateText();
        }

        private void cyrillicKOI8RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("koi8-r");
            UpdateText();
        }

        private void cyrillicKOI8UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEncoding = Encoding.GetEncoding("koi8-u");
            UpdateText();
        }
    }
}
