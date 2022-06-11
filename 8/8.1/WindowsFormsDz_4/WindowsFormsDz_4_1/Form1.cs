using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_4
{
    //Разработать текстовый редактор, организовать открытие/сохранение текстовых файлов.
    //■■ В панели инструментов расположить кнопки(Открыть, сохранить, новый документ, копировать, вырезать, вставить, 
    //отменить, кнопка настройки редактора(цвет шрифта, цвет фона, шрифт)).
    //■■ Меню должно дублировать панель инструментов(+ выделить все, + сохранить как);
    //■■ В Заголовке окна находится полный путь к файлу;
    //■■ Организовать контекстное меню для окна редактора(Копировать, Вырезать, Вставить, Отменить).
    public partial class Form1 : Form
    {
        public string path { get; set; } = ""; 
        public Form1()
        {
            InitializeComponent();
            openFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            openFileToolStripButton.Click += OpenFileToolStripMenuItem_Click;

            newFileToolStripMenuItem.Click += NewFileToolStripMenuItem_Click;
            newToolStripButton.Click += NewFileToolStripMenuItem_Click;

            saveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            saveToolStripButton.Click += SaveFileToolStripMenuItem_Click;

            saveFileAsToolStripMenuItem.Click += SaveFileAsToolStripMenuItem_Click;

            selectAllToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;

            copyToolStripButton.Click += CopyToolStripButton_Click;
            copyContextToolStrip.Click += CopyToolStripButton_Click;
            copyToolStripMenuItem.Click += CopyToolStripButton_Click;

            insertContextToolStrip.Click += InsertToolStripButton_Click;
            insertToolStripButton.Click += InsertToolStripButton_Click;
            insertToolStripMenuItem.Click += InsertToolStripButton_Click;

            cutContextToolStrip.Click += CutToolStripButton_Click;
            cutToolStripButton.Click += CutToolStripButton_Click;
            cutToolStripMenuItem.Click += CutToolStripButton_Click;

            cancelContextToolStrip.Click += CancelContextToolStrip_Click;

            colorFontToolStripButton.Click += ColorFontToolStripButton_Click;
            colorFontToolStripMenuItem.Click += ColorFontToolStripButton_Click;

            colorBackToolStripButton.Click += ColorBackToolStripButton_Click;
            colorBackToolStripMenuItem.Click += ColorBackToolStripButton_Click;

            fontToolStripButton.Click += FontToolStripButton_Click;
            fontToolStripMenuItem.Click += FontToolStripButton_Click;
        }

        private void FontToolStripButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = dialog.Font;
            }

        }

        private void ColorBackToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = dialog.Color;
            }
        }

        private void ColorFontToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = dialog.Color;
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void CancelContextToolStrip_Click(object sender, EventArgs e)
        {
            if (textBox.CanUndo == true)
            {
                textBox.Undo();
                textBox.ClearUndo();
            }
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void InsertToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Text = $"Текстовый редактор - {dialog.FileName}";
                path = dialog.FileName;
                StreamWriter writing = new StreamWriter(dialog.FileName, false, Encoding.Default);
                writing.Write(textBox.Text);
                writing.Close();
            }
        }
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                StreamWriter writing = new StreamWriter(path, false, Encoding.Default);
                writing.Write(textBox.Text);
                writing.Close();
            }
            else MessageBox.Show("Файл не выбран","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ReadOnly = false;
                contextMenuStrip.Enabled = true;
                saveFileAsToolStripMenuItem.Enabled = true;
                saveFileToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                insertToolStripMenuItem.Enabled = true;
                cancelToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                saveToolStripButton.Enabled = true;
                copyToolStripButton.Enabled = true;
                cutToolStripButton.Enabled = true;
                insertToolStripButton.Enabled = true;
                path = dialog.FileName;
                Text = $"Текстовый редактор - {path}";
                StreamWriter writing = new StreamWriter(path, false, Encoding.Default);
                writing.Write(textBox.Text);
                writing.Close();
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
         {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ReadOnly = false;
                contextMenuStrip.Enabled = true;
                saveFileAsToolStripMenuItem.Enabled = true;
                saveFileToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                insertToolStripMenuItem.Enabled = true;
                cancelToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                saveToolStripButton.Enabled = true;
                copyToolStripButton.Enabled = true;
                cutToolStripButton.Enabled = true;
                insertToolStripButton.Enabled = true;
                path = dialog.FileName;
                Text = $"Текстовый редактор - {path}";
                StreamReader reading = new StreamReader(dialog.FileName, Encoding.Default);
                textBox.Text = reading.ReadToEnd();
                reading.Close();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
          
        }

    }
  
    }

