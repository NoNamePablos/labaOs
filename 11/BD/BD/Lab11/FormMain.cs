using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Lab11.Models;
using System.Linq;

namespace Lab11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public Font printFont;
       public    Bitmap bitmap;
        public int counter = 0; // сквозной номер строки в массиве строк, которые выводятся
        public int curPage; // текущая страница
        public FormMain()
        {
           
            InitializeComponent();
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=Bank;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            var deps = Departament.List(_connection);
            listViewUsers.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewUsers.Items.Add(user.IdClient.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.Family);
                listListViewItem.SubItems.Add(user.Name);
                listListViewItem.SubItems.Add(user.LastName);
                listListViewItem.SubItems.Add(user.AddressClient);
                foreach (var bank in deps)
                {
                    if (bank.IdDepartament == user.IdDepartamnet)
                    {
                        listListViewItem.SubItems.Add(bank.Name);
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            var users = Departament.List(_connection);
            var UserMy = new User();
            FormUser formUser = new FormUser(UserMy, users);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Insert(_connection, UserMy);
            }
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            var myuser = (User)listViewUsers.SelectedItems[0].Tag;
            var listDeps = Departament.List(_connection);
            FormUser formUser = new FormUser(myuser, listDeps);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                User.Update(_connection, myuser);
            }
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            User.Delete(_connection, ((User)listViewUsers.SelectedItems[0].Tag).IdClient);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //Bank_types
        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {
            var bank = Bank_types.List(_connection);
            listViewBankTypes.Items.Clear();
            for (int i = 0; i < bank.Count; i++)
            {
                var user = bank[i];
                var listListViewItem = listViewBankTypes.Items.Add(user.IdBank.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.Name);

            }
        }

        private void toolStripButton6_Click(object sender, System.EventArgs e)
        {
            FormBankTypes formUser = new FormBankTypes
            {
                User = new Bank_types()
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Bank_types.Insert(_connection, formUser.User);
            }
        }

        private void toolStripButton7_Click(object sender, System.EventArgs e)
        {
            FormBankTypes formUser = new FormBankTypes
            {
                User = (Bank_types)listViewBankTypes.SelectedItems[0].Tag
            };
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Bank_types.Update(_connection, formUser.User);
            }
        }

        private void toolStripButton8_Click(object sender, System.EventArgs e)
        {
            Bank_types.Delete(_connection, ((Bank_types)listViewBankTypes.SelectedItems[0].Tag).IdBank);
        }

        private void listViewBankTypes_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void listViewUsers_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, System.EventArgs e)
        {
            var users = Departament.List(_connection);
            var Banks = Bank_types.List(_connection);
            listViewDep.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewDep.Items.Add(user.IdDepartament.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.Name);
                listListViewItem.SubItems.Add(user.Address);
                foreach (var bank in Banks) {
                    if (bank.IdBank == user.IdBank) {
                        listListViewItem.SubItems.Add(bank.Name);
                    }
                }
            }
        }

        private void toolStripButton10_Click(object sender, System.EventArgs e)
        {
            var settlement = new Departament();
            var Banks = Bank_types.List(_connection);
            FormDepartament formUser = new FormDepartament(settlement, Banks);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Departament.Insert(_connection, settlement);
            }
          
        }

        private void toolStripButton11_Click(object sender, System.EventArgs e)
        {
            var myDep = (Departament)listViewDep.SelectedItems[0].Tag;
            var Banks = Bank_types.List(_connection);
            FormDepartament formUser = new FormDepartament(myDep, Banks);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                Departament.Update(_connection, myDep);
            }
        }

        private void toolStripButton13_Click(object sender, System.EventArgs e)
        {
            var users = ClientSafes.List(_connection);
            var deps = User.List(_connection);
            listViewSafe.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewSafe.Items.Add(user.NumKey.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.PositionKey);
                foreach (var bank in deps)
                {
                    if (bank.IdClient == user.IdClient)
                    {
                        string ss = bank.Family+" "+bank.Name + " " + bank.LastName;
                        listListViewItem.SubItems.Add(ss);
                    }
                }
            }
        }

        private void toolStripButton14_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            var UserMy = new ClientSafes();
            FormSafe formUser = new FormSafe(UserMy, users);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                ClientSafes.Insert(_connection, UserMy);
            }
        }

        private void toolStripButton15_Click(object sender, System.EventArgs e)
        {
        
            var myDep = (ClientSafes)listViewSafe.SelectedItems[0].Tag;
            var Banks = User.List(_connection);
            FormSafe formUser = new FormSafe(myDep, Banks);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                ClientSafes.Update(_connection, myDep);
            }
        }

        private void toolStripButton16_Click(object sender, System.EventArgs e)
        {
            ClientSafes.Delete(_connection, ((ClientSafes)listViewSafe.SelectedItems[0].Tag).IdSafe);
        }

        private void toolStripButton12_Click(object sender, System.EventArgs e)
        {
            Departament.Delete(_connection, ((Departament)listViewDep.SelectedItems[0].Tag).IdDepartament);
        }

        private void toolStripButton17_Click(object sender, System.EventArgs e)
        {
            var users = TrustedFio.List(_connection);
            listViewTrustedPerson.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                var listListViewItem = listViewTrustedPerson.Items.Add(user.Family.ToString());
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.Name);
                listListViewItem.SubItems.Add(user.LastName);
               
            }
        }

        private void listViewTrustedPerson_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void toolStripButton18_Click(object sender, System.EventArgs e)
        {
            var UserMy = new TrustedFio();
            TrustedFIO formUser = new TrustedFIO(UserMy);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                TrustedFio.Insert(_connection, UserMy);
            }
        }

        private void toolStripButton19_Click(object sender, System.EventArgs e)
        {
            var myuser = (TrustedFio)listViewTrustedPerson.SelectedItems[0].Tag;
         
            TrustedFIO formUser = new TrustedFIO(myuser);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                TrustedFio.Update(_connection, myuser);
            }
        }

        private void toolStripButton20_Click(object sender, System.EventArgs e)
        {
            TrustedFio.Delete(_connection, ((TrustedFio)listViewTrustedPerson.SelectedItems[0].Tag).IdTrusted);
        }

        private void toolStripButton21_Click(object sender, System.EventArgs e)
        {

            var users = User.List(_connection);
            var deps = TrustedFio.List(_connection);
            var Person = TrustedPerson.List(_connection);
            listViewPersons.Items.Clear();
            for (int i = 0; i < Person.Count; i++)
            {
                var user = Person[i];
                string name = "";
                string name1 = "";
               
                foreach (var MyUser in deps) {
                    if (MyUser.IdTrusted == user.IdTrusted) {
                        name = MyUser.Family+" "+MyUser.Name  + " " + MyUser.LastName;
                    }
                }

                foreach (var Myuser in users)
                {
                    if (Myuser.IdClient == user.IdClient)
                    {
                        name1 = Myuser.Family + " " + Myuser.Name + " " + Myuser.LastName;
                    }
                }
                var listListViewItem = listViewPersons.Items.Add(name1);
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(name);

            }
        }

        private void listViewPersons_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void toolStripButton22_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            var trustedPerson = new TrustedPerson();
            var trustedFio=TrustedFio.List(_connection);
          FormTrustedPerson formUser = new FormTrustedPerson(trustedPerson, users, trustedFio);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                TrustedPerson.Insert(_connection, trustedPerson);
            }
        }

        private void toolStripButton23_Click(object sender, System.EventArgs e)
        {
            var myuser = (TrustedPerson)listViewPersons.SelectedItems[0].Tag;
            var users = User.List(_connection);
            var trustedFio = TrustedFio.List(_connection);

            FormTrustedPerson formUser = new FormTrustedPerson(myuser, users, trustedFio);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                TrustedPerson.Update(_connection, myuser);
            }

        }

        private void toolStripButton24_Click(object sender, System.EventArgs e)
        {
            TrustedPerson.Delete(_connection, ((TrustedPerson)listViewPersons.SelectedItems[0].Tag).TrustedNumber);

        }

        private void toolStripButton25_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            var Clients = DateClient.List(_connection);
            listViewDateClient.Items.Clear();
            for (int i = 0; i < Clients.Count; i++)
            {
                var user = Clients[i];
                string name1 = "";
                foreach (var Myuser in users)
                {
                    if (Myuser.IdClient == user.IdClient)
                    {
                        name1 = Myuser.Family + " " + Myuser.Name + " " + Myuser.LastName;
                    }
                }

                var listListViewItem = listViewDateClient.Items.Add(name1);
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.FirstDate.ToString());
                listListViewItem.SubItems.Add(user.LastDate.ToString());
                
            }
        }

        private void toolStripButton26_Click(object sender, System.EventArgs e)
        {
            var users = User.List(_connection);
            var Client = new DateClient();
            FormDateClient formUser = new FormDateClient(Client, users);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                DateClient.Insert(_connection, Client);
            }
        }

        private void toolStripButton27_Click(object sender, System.EventArgs e)
        {
            var client = (DateClient)listViewDateClient.SelectedItems[0].Tag;
            var listDeps = User.List(_connection);
            FormDateClient formUser = new FormDateClient(client, listDeps);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                DateClient.Update(_connection, client);
            }
        }

        private void toolStripButton28_Click(object sender, System.EventArgs e)
        {
            DateClient.Delete(_connection, ((DateClient)listViewDateClient.SelectedItems[0].Tag).IdVisitedClient);

        }

        private void toolStripButton29_Click(object sender, System.EventArgs e)
        {
            var users = TrustedFio.List(_connection);
            var Clients = DateTrustedPerson.List(_connection);
            listViewDateTrusted.Items.Clear();
            for (int i = 0; i < Clients.Count; i++)
            {
                var user = Clients[i];
                string name1 = "";
                foreach (var Myuser in users)
                {
                    if (Myuser.IdTrusted == user.IdClient)
                    {
                        name1 = Myuser.Family + " " + Myuser.Name + " " + Myuser.LastName;
                    }
                }

                var listListViewItem = listViewDateTrusted.Items.Add(name1);
                listListViewItem.Tag = user;
                listListViewItem.SubItems.Add(user.FirstDate.ToString());
                listListViewItem.SubItems.Add(user.LastDate.ToString());

            }
        }

        private void toolStripButton30_Click(object sender, System.EventArgs e)
        {
            var users = TrustedFio.List(_connection);
            var Client = new DateTrustedPerson();
            FormDateTrustedPerson formUser = new FormDateTrustedPerson(Client, users);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                DateTrustedPerson.Insert(_connection, Client);
            }
        }

        private void toolStripButton31_Click(object sender, System.EventArgs e)
        {
            var client = (DateTrustedPerson)listViewDateTrusted.SelectedItems[0].Tag;
            var listDeps = TrustedFio.List(_connection);
            FormDateTrustedPerson formUser = new FormDateTrustedPerson(client, listDeps);
            if (formUser.ShowDialog() == DialogResult.OK)
            {
                DateTrustedPerson.Update(_connection, client);
            }
        }

        private void toolStripButton32_Click(object sender, System.EventArgs e)
        {
            DateTrustedPerson.Delete(_connection, ((DateTrustedPerson)listViewDateTrusted.SelectedItems[0].Tag).IdVisitedClient);

        }

        private void toolStripButton33_Click(object sender, System.EventArgs e)
        {
            //// Start maximized.
            //Form frm = ppdListView1 as Form;
            //frm.WindowState = FormWindowState.Maximized;

            //// Start at 100% scale.
            //ppdListView1.PrintPreviewControl.Zoom = 1.0;

            //// Display.
            //ppdListView1.ShowDialog();
            // Start maximized.
            Form frm = ppdListView as Form;
            frm.WindowState = FormWindowState.Maximized;

            // Start at 100% scale.
            ppdListView.PrintPreviewControl.Zoom = 1.0;

            // Display.
            if (ppdListView.ShowDialog() == DialogResult.OK)
            {
                List<int> xx = new List<int>();
                xx.Add(1);
                xx.Add(2);
                xx.Add(3);
                xx.Add(4);
                PrintExtendedListView printe = new PrintExtendedListView(xx);
                printe.Print(listViewUsers, false);
            }

        }

        private void printUsers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //List<int> xx = new List<int>();
            //xx.Add(1);
            //xx.Add(2);
            //xx.Add(3);
            //xx.Add(4);
            //PrintExtendedListView printe = new PrintExtendedListView(xx);
            //printe.Print(listViewUsers, false);

            listViewUsers.PrintMultiLineData(e.MarginBounds.Location,
        e.Graphics, Brushes.Black,
        Brushes.Black, Pens.Black);
            List<int> xx = new List<int>();
            xx.Add(1);
            xx.Add(2);
            xx.Add(3);
            xx.Add(4);
            xx.Add(5);
            PrintExtendedListView printe = new PrintExtendedListView(xx);
            printe.Print(listViewUsers, false);

        }

        private void toolStripButton34_Click(object sender, System.EventArgs e)
        {
            //PrintPreviewDialog dlg = new PrintPreviewDialog();
            //dlg.WindowState = FormWindowState.Maximized;
            //dlg.Document = printUsers;
            //dlg.ShowDialog();
        }

        private void printUsers_BeginPrint(object sender, PrintEventArgs e)
        {
            // Перед началом печати переменные-счетчики
            // установить в начальные значения
          int   counter = 0;
            int curPage = 1;
        }

        // позволяет передавать данные по нескольким строкам.
        
     

    }
}
