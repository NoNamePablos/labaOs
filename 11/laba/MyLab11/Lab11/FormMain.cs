using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=country;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            listViewUsers.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewUsers.Items.Add(user.CityId.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.CityName);
                listListViewItem.SubItems.Add(user.CityPopulation.ToString());
                listListViewItem.SubItems.Add(user.CreateDate.ToLongDateString());
                listListViewItem.SubItems.Add(user.CountryId.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            FormUser formUser = new FormUser
            {
                User = new User()
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Insert(_connection, formUser.User);
            }
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            FormUser formUser = new FormUser
            {
                User = (User)listViewUsers.SelectedItems[0].Tag
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Update(_connection, formUser.User);
            }
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            User.Delete(_connection, ((User)listViewUsers.SelectedItems[0].Tag).CityId);
        }

        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {
            var users = Comment.List(_connection);
            listViewCountry.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listViewItem = listViewCountry.Items.Add(user.CountryId.ToString());
                listViewItem.Tag = user;

                listViewItem.SubItems.Add(user.CountryPopulation.ToString());
                listViewItem.SubItems.Add(user.CountryName);
            }
        }

        private void toolStripButton6_Click(object sender, System.EventArgs e)
        {
            FormCountry formUser = new FormCountry
            {
                User = new Comment()
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Comment.Insert(_connection, formUser.User);
            }
        }

        private void listViewUsers_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, System.EventArgs e)
        {
            FormCountry formUser = new FormCountry
            {
                User = (Comment)listViewCountry.SelectedItems[0].Tag
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Comment.Update(_connection, formUser.User);
            }
        }

        private void toolStripButton8_Click(object sender, System.EventArgs e)
        {
            Comment.Delete(_connection, ((Comment)listViewCountry.SelectedItems[0].Tag).CountryId);
        }
    }
}
