using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceClassLibrary;

namespace WinFormApp
{
    public partial class FormDepartament : Form
    {
        public Departament dep { get; }
        public FormDepartament(Departament depp)
        {
            InitializeComponent();
            dep = depp;
            textBox1.Text = dep.depName;
            textBox2.Text = dep.address;
            textBox3.Text = dep.telephone;
        }

        private void FormDepartament_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             dep.depName= textBox1.Text ;
             dep.address = textBox2.Text;
             dep.telephone = textBox3.Text;

        }
    }
}
