using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormDepartament : Form
    {
        private Bank_types _user;
        private Departament Dep { get;  }
        private List<Bank_types> banks_types;
        public FormDepartament(Departament dep, List<Bank_types > banks)
        {
            InitializeComponent();
            Dep = dep;
            banks_types = banks;
            foreach (var item in banks)
            {
                var client = item.Name;
                comboBoxBank.Items.Add(client);

            }
            textBoxDepName.Text = Dep.Name;
            textBoxAddres.Text = Dep.Address;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSaveDep_Click(object sender, EventArgs e)
        {

            Dep.Name = textBoxDepName.Text;
            Dep.Address = textBoxAddres.Text;
            foreach (var select in banks_types)
            {
                if (select.Name == comboBoxBank.SelectedItem.ToString())
                {
                    Dep.IdBank = select.IdBank;
                }
            }
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
