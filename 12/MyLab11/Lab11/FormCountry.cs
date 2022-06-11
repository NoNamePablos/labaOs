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
    public partial class FormCountry : Form
    {
        private Comment _user;
        public Comment User
        {
            get { return _user; }
            set
            {
                _user = value;
                textBoxCountryName.Text = _user.CountryName;
                textBoxCountryPopulation.Text = _user.CountryPopulation.ToString();
            }
        }
        public FormCountry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.CountryName = textBoxCountryName.Text;
            User.CountryPopulation = long.Parse(textBoxCountryPopulation.Text);
        }
    }
}
