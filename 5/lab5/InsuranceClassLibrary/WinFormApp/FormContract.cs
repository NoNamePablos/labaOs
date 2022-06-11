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
    public partial class FormContract : Form
    {
        public Contract Contract { get; }
        //public InsuranceTypes it { get; }
        //public Departament dep { get; }
        public FormContract(Contract cntr)
        {
            InitializeComponent();
            Contract = cntr;
            foreach (var item in Insurance.Clients) {
                var client = item.Value;
                comboBox1.Items.Add(client);

            }
            foreach (var item in Insurance.Rooms)
            {
                var client = item.Value;
                comboBox2.Items.Add(client);

            }
           
            textBox1.Text = Contract.numberContract;
            numericUpDown1.Value = (int)Contract.insuranceAmount;
            numericUpDown2.Value = (int)Contract.tariffRate;

        }

        private void FormContract_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contract.LocalInsuranceTypes= (InsuranceTypes)comboBox2.SelectedItem;
            Contract.localDepartament = (Departament)comboBox1.SelectedItem;
            Contract.numberContract = textBox1.Text;
            Contract.insuranceAmount=(int)numericUpDown1.Value;
            Contract.tariffRate= (int)numericUpDown2.Value;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
