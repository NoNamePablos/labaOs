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
    public partial class FormTypes : Form
    {
        public InsuranceTypes it { get; }
        public FormTypes(InsuranceTypes iss)
        {
            InitializeComponent();
            it = iss;
            textBox1.Text = it.insuranceType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            it.insuranceType = textBox1.Text;
            string ss = textBox1.Text;
            it.insuranceType = ss;
           

        }
    }
}
