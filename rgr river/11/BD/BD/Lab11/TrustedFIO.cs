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
    public partial class TrustedFIO : Form
    {
        private TrustedFio _user;
        public TrustedFIO(TrustedFio user)
        {
            _user = user;
            InitializeComponent();
            textBoxName.Text = _user.Name;
            textBoxFamily.Text = _user.Family;
            textBoxLastName.Text = _user.LastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user.Name = textBoxName.Text;
            _user.Family = textBoxFamily.Text;
            _user.LastName = textBoxLastName.Text;
        }
    }
}
