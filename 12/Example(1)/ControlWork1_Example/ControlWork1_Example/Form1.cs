using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ControlWork1_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.categoriesTableAdapter.Update(this.usersDBDataSet.Categories);

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDBDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersDBDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDBDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.usersDBDataSet.Categories);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)usersBindingSource.Current;
            usersDBDataSet.UsersRow ur = (usersDBDataSet.UsersRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabel1.Text = "Фотография загружена успешно";
            }
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)usersBindingSource.Current;
            usersDBDataSet.UsersRow ur = (usersDBDataSet.UsersRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (photoPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    photoPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel1.Text = "Фотография успешно сохранена";
                }
            }
     
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.usersTableAdapter.Update(this.usersDBDataSet.Users);
        }

        private void загрузитьТаблицуПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.usersDBDataSet.Users);
        }

        private void загрузитьТаблицуКатегорииПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.usersDBDataSet.Categories);
        }
    }
}
