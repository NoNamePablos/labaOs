using System;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormUser : Form
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                textBoxFirstName.Text = _user.CityName;
                dateTimePickerBd.Text = _user.CreateDate.ToLongDateString();
                textBoxSecondName.Text = _user.CityPopulation.ToString();
                textBoxCountryId.Text = _user.CountryId.ToString();
            }
        }
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User.CityName = textBoxFirstName.Text;
            User.CityPopulation = long.Parse(textBoxSecondName.Text);
            User.CountryId = int.Parse(textBoxCountryId.Text);
            User.CreateDate = dateTimePickerBd.Value;
        }
    }
}
