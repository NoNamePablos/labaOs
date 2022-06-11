using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string buffer = "";

                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (TextReader reader = new StreamReader(fs))
                {
                    while (reader.Peek() > -1)
                        buffer += reader.ReadLine() + "\r\n";
                }

                string pattern = @"((((private|public|protected)\s)?static)|(static\s(private|public|protected)?))\s(partial\s)?class\s(\w+)";
                Regex regex = new Regex(pattern);
                textBox.Text = "";
                
                foreach (Match match in regex.Matches(buffer))
                {
                    textBox.Text += match.Groups[match.Groups.Count - 1].Value + "\r\n";
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
