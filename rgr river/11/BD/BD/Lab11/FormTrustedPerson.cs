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
    public partial class FormTrustedPerson : Form
    {
        private TrustedPerson Person;
        private List<User> User;
        private List<TrustedFio> TrustedFios;
        public FormTrustedPerson(TrustedPerson person,List<User>users, List<TrustedFio> trustedFio)
        {
            User = users;
            Person = person;
            TrustedFios = trustedFio;
            InitializeComponent();
            foreach (var item in trustedFio)
            {
                var client = item.Family+" "+item.Name+" "+item.LastName;
                comboBoxTrusetdPerson.Items.Add(client);

            }
            foreach (var item in users)
            {
                var client = item.Family + " " + item.Name + " " + item.LastName;
                comboBoxClient.Items.Add(client);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
          
            foreach (var select in TrustedFios)
            {
                string phrase = comboBoxTrusetdPerson.SelectedItem.ToString();
                string[] words = phrase.Split(' ');
                if (select.Family == words[0]&&select.Name==words[1]&&select.LastName==words[2])
                {
                    Person.IdTrusted = select.IdTrusted;
                }
            }
            foreach (var select in User)
            {
                string phrase = comboBoxClient.SelectedItem.ToString();
                string[] words = phrase.Split(' ');
                if (select.Family == words[0] && select.Name == words[1] && select.LastName == words[2])
                {
                    Person.IdClient = select.IdClient;
                }
            }
        }
    }
}
