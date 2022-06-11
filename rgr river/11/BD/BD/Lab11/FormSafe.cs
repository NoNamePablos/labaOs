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
    public partial class FormSafe : Form
    {
        private User _user;
        private ClientSafes Safe { get; }
        private List<User> Banks_types;
        public FormSafe(ClientSafes safe, List<User> banks_types)
        {
            Safe = safe;
            Banks_types = banks_types;
             
            InitializeComponent();
            foreach (var item in banks_types)
            {
                var client = item.Name;
                comboBoxClient.Items.Add(client);

            }
            comboBoxSafe.Items.Add("Дома");
            comboBoxSafe.Items.Add("Банк");
        }

        private void buttonSafe_Click(object sender, EventArgs e)
        {
            Safe.NumKey = ClientSafes.GetRandom();
            foreach (var select in Banks_types)
            {
                if (select.Name == comboBoxClient.SelectedItem.ToString())
                {
                    Safe.IdClient = select.IdClient;
                }
            }
            Safe.PositionKey = comboBoxSafe.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
