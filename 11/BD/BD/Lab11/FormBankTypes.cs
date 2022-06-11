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
    public partial class FormBankTypes : Form
    {

        private Bank_types _user;
        public Bank_types User
        {
            get { return _user; }
            set
            {
                _user = value;
                textBoxNameBank.Text = _user.Name;

            }
        }
        public FormBankTypes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBankSave_Click(object sender, EventArgs e)
        {
            User.Name= textBoxNameBank.Text;
        }
    }
}
