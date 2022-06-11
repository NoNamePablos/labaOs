using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab11.Models;
using System.Collections.Generic;
using System.IO;
using System;
using System.Net;
using HtmlAgilityPack;
using System.Linq;
using System.Text;

namespace Lab11
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=riverDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
            refresh();
        }

        private void refresh() {

            var rivers = Information.List(_connection);
            listViewUsers.Items.Clear();
            for (int i = 0; i < rivers.Count; i++)
            {
                var river = rivers[i];
                var listListViewItem = listViewUsers.Items.Add(river.RiverId.ToString());
                listListViewItem.Tag = river;
                listListViewItem.SubItems.Add(river.RiverName);
                listListViewItem.SubItems.Add(river.RiverPalace);
                listListViewItem.SubItems.Add(river.RiverOutflow);
                listListViewItem.SubItems.Add(river.RiverLength.ToString());
            }
        }
        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            List<Information> DownList = new List<Information>();
            using (WebClient client = new WebClient())
            {
           
                var htmlWeb = new HtmlWeb();
                htmlWeb.OverrideEncoding = Encoding.UTF8;
                var doc = htmlWeb.Load("https://mostinfo.su/53-samye-bolshie-reki-mira.html");

                // Using LINQ to parse HTML table smartly 
                var HTMLTableTRList = from table in doc.DocumentNode.SelectNodes("//tbody").Cast<HtmlNode>()
                                      from row in table.SelectNodes("tr").Cast<HtmlNode>()
                                      from cell1 in row.SelectNodes("th|td").Cast<HtmlNode>()
                                      select new { Cell_Text = cell1.InnerText };


                // now showing output of parsed HTML table

                int x = 0;
                string[] ss1 = new string[4];
                int lineId = 1;
                int j = 0;
                int check = 0;
                
                foreach (var cell1 in HTMLTableTRList)
                {
                    if (check >4) {

                        var ls = cell1.Cell_Text;

                        var lines = cell1.Cell_Text;
                        if (lineId == 1)
                        {
                            ss1[0] = cell1.Cell_Text;
                        }
                        if (lineId == 2)
                        {
                            ss1[1] = cell1.Cell_Text;
                        }
                        if (lineId == 3)
                        {
                            ss1[2] = cell1.Cell_Text;
                        }
                        if (lineId == 5)
                        {
                            ss1[3] = cell1.Cell_Text;

                        }
                        lineId++;
                        j++;
                        if (lineId > 5)
                        {
                            lineId = 1;
                            Information river = new Information();
                            river.RiverName = ss1[0];
                            river.RiverPalace = ss1[1];
                            river.RiverOutflow = ss1[2];
                            river.RiverLength = double.Parse(ss1[3]);
                            DownList.Add(river);
                        }
                    }
                    check ++;
                }
               
            }


            for (int i = 0; i < DownList.Count; i++)
            {
                if (Information.CheckDuplicates(_connection, DownList[i].RiverName) == null)
                {
                    Information.Insert(_connection, DownList[i]);
                }


                
            }

            var rivers = Information.List(_connection);
            listViewUsers.Items.Clear();
            for (int i = 0; i < rivers.Count; i++)
            {
                var river = rivers[i];
                var listListViewItem = listViewUsers.Items.Add(river.RiverId.ToString());
                listListViewItem.Tag = river;
                listListViewItem.SubItems.Add(river.RiverName);
                listListViewItem.SubItems.Add(river.RiverPalace);
                listListViewItem.SubItems.Add(river.RiverOutflow);
                listListViewItem.SubItems.Add(river.RiverLength.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            FormUser formUser = new FormUser
            {
                River = new Information()
            };
            try
            {
                if (formUser.ShowDialog() == DialogResult.OK)
                {

                    if (String.IsNullOrEmpty(formUser.River.RiverName))
                    {
                        throw new Exception("Error");
                    }
                    Information.Insert(_connection, formUser.River);
                    refresh();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пустые поля не могут быть добавлены");
            }

        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            try
            {
                FormUser formUser = new FormUser
                {
                    River = (Information)listViewUsers.SelectedItems[0].Tag
                };

                if (listViewUsers.SelectedItems[0] == null)
                {
                    throw new Exception("Error");
                }

                if (formUser.ShowDialog() == DialogResult.OK)
                {
                

                    Information.Update(_connection, formUser.River);
                }
                refresh();
            }
            catch (Exception) {
                MessageBox.Show("Не выбрано поле");
            }
            
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (listViewUsers.SelectedItems[0]== null){
                    throw new Exception("Error");
                }
                Information.Delete(_connection, ((Information)listViewUsers.SelectedItems[0].Tag).RiverId);
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрано поле");
            }
        }
        private void listViewUsers_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

   

    }
}
