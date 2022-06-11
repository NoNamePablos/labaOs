using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormUser : Form
    {
        private User _user;
        private List<Departament> deps;
        public FormUser(User user, List<Departament> dep) 
        {
            InitializeComponent();
            _user = user;
            deps = dep;
            foreach (var item in deps)
            {
                var client = item.Name;
                comboBoxDeps.Items.Add(client);

            }
            textBoxFirstName.Text=_user.Family;
            textBoxSecondName.Text=_user.Name;
            textBoxLastName.Text=_user.LastName ;
            textBoxAdress.Text = _user.AddressClient;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _user.Family = textBoxFirstName.Text;
            _user.Name = textBoxSecondName.Text;
            _user.LastName = textBoxLastName.Text;
           
            foreach (var select in deps)
            {
                if (select.Name == comboBoxDeps.SelectedItem.ToString())
                {
                    _user.IdDepartamnet = select.IdDepartament;
                }
            }
            _user.AddressClient = textBoxAdress.Text;
        }
    }
}
