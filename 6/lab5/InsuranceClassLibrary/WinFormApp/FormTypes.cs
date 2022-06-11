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
        private InsuranceTypes _type;
        public InsuranceTypes Type {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                textBox1.Text = Type.insuranceType;
            }
        }
        public FormTypes()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _type.insuranceType = textBox1.Text;
            string ss = textBox1.Text;
            _type.insuranceType = ss;
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
