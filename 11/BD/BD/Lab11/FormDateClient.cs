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
    public partial class FormDateClient : Form
    {
        private DateClient Client;
        private List<User> MyUser;

        public FormDateClient(DateClient client, List<User> user)
        {
            Client = client;
            MyUser = user;
            InitializeComponent();
            foreach (var item in user) {
                string ss = item.Family + " " + item.Name + " " + item.LastName;
                comboBoxClient.Items.Add(ss);
            }
            dateTimePickerFirstDate.CustomFormat = "MMMM dd, HH::mm::ss";
            dateTimePickerFirstDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFirstDate.Value = Client.FirstDate;
            dateTimePickerLastDate.CustomFormat = "MMMM dd, HH::mm::ss";
            dateTimePickerLastDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastDate.Value = Client.LastDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (var person in MyUser) {
                string phrase =comboBoxClient.SelectedItem.ToString();
                string[] words = phrase.Split(' ');
                if (person.Family == words[0] && person.Name == words[1] && person.LastName == words[2]) {
                    Client.IdClient = person.IdClient;
                }
            }
            Client.FirstDate = dateTimePickerFirstDate.Value;
            Client.LastDate = dateTimePickerLastDate.Value;
        }

        private void dateTimePickerFirstDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
