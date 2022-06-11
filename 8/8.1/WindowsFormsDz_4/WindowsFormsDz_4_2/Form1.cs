using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_3_2
{
    //Написать программу «Проводник»
    //■■ При первом запуске программа отображает список доступных дисков;
    //■■ Программа должна содержать дерево дисков, строку адреса, меню, панель инструментов и окно 
    //для отображения содержимого папки;
    //■■ Дерево дисков отображает только диски и папки(можно реализовать с помощью ListBox);
    //■■ При двойном щелчке по папке – окно содержимого отображаются файлы и подпапки;
    //■■ Программа должна иметь развернутое меню, контекстное меню и возможность работы с горячими клавишами.
    public partial class Form1 : Form
    {
        List<string> path;
        public Form1()
        {
            InitializeComponent();
            path = new List<string>();
            serchDisk();//поиск дисков

            listBox1.DoubleClick += ListBox1_DoubleClick;
            listBox2.DoubleClick += ListBox1_DoubleClick;

            listBox1.Click += ListBox1_Click;
            listBox2.Click += ListBox2_Click;

            backToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            backContextToolStripItem.Click += BackToolStripMenuItem_Click;
            backToglToolStripMenuItem.Click += BackToolStripMenuItem_Click;

            openToolStripItem.Click += OpenToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
        }

        private void ListBox2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                pathToolStripTextBox.Text = listBox2.SelectedItem.ToString();
                listBox1.ClearSelected();
            }
        }
        private void ListBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "...")
            {
                return;
            }
            if (listBox1.SelectedIndex != -1)
            {
                pathToolStripTextBox.Text = listBox1.SelectedItem.ToString();
                listBox2.ClearSelected();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex != -1)
                {
                    path.Add(listBox2.SelectedItem.ToString());
                    if (File.Exists(path[path.Count - 1]))//проверка на файл или папку
                    {
                        Process.Start(path[path.Count - 1]);//запуск файла
                    }
                    else
                    {
                        serchFile();//поиск файлов, папок
                    }
                }
                if (listBox1.SelectedIndex != -1)
                {
                    path.Add(listBox1.SelectedItem.ToString());
                    if (File.Exists(path[path.Count - 1]))//проверка на файл или папку
                    {
                        Process.Start(path[path.Count - 1]);//запуск файла
                    }
                    else
                    {
                        serchFile();//поиск файлов, папок
                    }
                }
            }
            catch (Exception)
            {
                path.Clear();
                pathToolStripTextBox.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                serchDisk();//поиск дисков
                MessageBox.Show("Невозможно открыть директорию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path.Count == 0)
            {
                return;
            }
            if (path.Count == 1)
            {
                path.RemoveAt(path.Count - 1);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                serchDisk();//поиск дисков
                pathToolStripTextBox.Visible = false;
                pathToolStripTextBox.Text = "";
            }
            else
            {
                path.RemoveAt(path.Count - 1);
                serchFile();//поиск файлов, папок
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem == "...")
                {
                    path.RemoveAt(path.Count - 1);
                    serchFile();//поиск файлов, папок
                }
                if (listBox1.SelectedIndex != -1)//двойной клик по файлам в Дереве дисков!
                {
                    path.Add(listBox1.SelectedItem.ToString());
                    serchFile();//поиск файлов, папок
                    pathToolStripTextBox.Visible = true;
                }
                if (listBox2.SelectedIndex != -1)//двойной клик по файлам в Окне содержимого!
                {
                    path.Add(listBox2.SelectedItem.ToString());
                    if (File.Exists(path[path.Count - 1]))//проверка на файл или папку
                    {
                        Process.Start(path[path.Count - 1]);//запуск файла
                    }
                    else
                    {
                        serchFile();//поиск файлов, папок
                    }
                }
            }
            catch (Exception)
            {
                path.Clear();
                pathToolStripTextBox.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                serchDisk();//поиск дисков
                MessageBox.Show("Невозможно открыть директорию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void serchFile()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[] dir = Directory.GetDirectories(path[path.Count - 1]);
            string[] file = Directory.GetFiles(path[path.Count - 1]);
            if (dir.Length < 1)
            {
                listBox1.Items.Add($"...");
            }
            foreach (var item in dir)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Add(item);
            }
            foreach (var item in file)
            {
                listBox2.Items.Add(item);
            }
            if (listBox1.Items[0] == "...")colElementToolStripLabel.Text = $"Элементов: 0";
            else colElementToolStripLabel.Text = $"Элементов: {listBox1.Items.Count}";

            col2ElementToolStripLabel.Text = $"Элементов: {listBox2.Items.Count}";
            pathToolStripTextBox.Text = path[path.Count - 1];
        }
        public void serchDisk()
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            colElementToolStripLabel.Text = $"Элементов: {drive.Length}";
            col2ElementToolStripLabel.Text = $"Элементов: 0";
            foreach (DriveInfo item in drive)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
