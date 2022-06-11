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
        public Departament dep { get; }
        public FormContract(Contract cntr, Departament depp)
        {
            InitializeComponent();
            Contract = cntr;
            dep = depp;
            comboBox2.Items.Add(InsyranceTypes.PersonInsuarance);
            comboBox2.Items.Add(InsyranceTypes.PropertyInsurance);
            comboBox1.Items.Add(depp);
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
            Contract.LocalInsuranceTypes= (InsyranceTypes)comboBox2.SelectedItem;
            Contract.localDepartament = (Departament)comboBox1.SelectedItem;
            Contract.numberContract = textBox1.Text;
            Contract.insuranceAmount=(int)numericUpDown1.Value;
            Contract.tariffRate= (int)numericUpDown2.Value;
            
        }
    }
}
