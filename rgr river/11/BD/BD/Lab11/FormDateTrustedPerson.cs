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
    public partial class FormDateTrustedPerson : Form
    {
        private DateTrustedPerson Client;
        private List<TrustedFio> MyUser;
        public FormDateTrustedPerson(DateTrustedPerson client, List<TrustedFio> user)
        {
            MyUser = user;
            Client = client;
            InitializeComponent();
            foreach (var item in user)
            {
                string ss = item.Family + " " + item.Name + " " + item.LastName;
                comboBoxTrusted.Items.Add(ss);
            }
            dateTimePickerFirstdate.CustomFormat = "MMMM dd, HH::mm::ss";
            dateTimePickerFirstdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFirstdate.Value = Client.FirstDate;
            dateTimePickerLastDate.CustomFormat = "MMMM dd, HH::mm::ss";
            dateTimePickerLastDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastDate.Value = Client.LastDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (var person in MyUser)
            {
                string phrase = comboBoxTrusted.SelectedItem.ToString();
                string[] words = phrase.Split(' ');
                if (person.Family == words[0] && person.Name == words[1] && person.LastName == words[2])
                {
                    Client.IdClient = person.IdTrusted;
                }
            }
            Client.FirstDate = dateTimePickerFirstdate.Value;
            Client.LastDate = dateTimePickerLastDate.Value;
        }
    }
}
