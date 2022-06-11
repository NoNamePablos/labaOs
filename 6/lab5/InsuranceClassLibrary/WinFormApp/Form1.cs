using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceClassLibrary;


namespace WinFormApp
{
    public partial class Form1 : Form
    {
        private readonly Insurance _insurance = Insurance.Instance;
        readonly FormTypes _formRoom = new FormTypes();
        readonly FormDepartament  _formClient = new FormDepartament();
        readonly FormContract _formSettlement = new FormContract();
        public Form1()
        {
            InitializeComponent();
            _insurance.ClientAdded += _hotel_ClientAdded;
            _insurance.RoomAdded += _hotel_RoomAdded;
            _insurance.SettlementAdded += _hotel_SettlementAdded;
            _insurance.ClientRemoved += _hotel_ClientRemoved;
            _insurance.RoomRemoved += _hotel_RoomRemoved;
            _insurance.SettlementRemoved += _hotel_SettlementRemoved;
        }
        private void _hotel_SettlementRemoved(object sender, EventArgs e)
        {
            var settlement = sender as Contract;
            for (int i = 0; i < listViewContracts.Items.Count; i++)
            {
                if ((Contract)listViewContracts.Items[i].Tag == settlement)
                {
                    listViewContracts.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_RoomRemoved(object sender, EventArgs e)
        {
            var roomNumber = (int)sender;
            for (int i = 0; i < listViewTypes.Items.Count; i++)
            {
                if (((InsuranceTypes)listViewTypes.Items[i].Tag).typeId == roomNumber)
                {
                    listViewTypes.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_ClientRemoved(object sender, EventArgs e)
        {
            var clientId = (int)sender;
            for (int i = 0; i < ListViewDepartamnet.Items.Count; i++)
            {
                if (((Departament)ListViewDepartamnet.Items[i].Tag).DepId == clientId)
                {
                    ListViewDepartamnet.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_SettlementAdded(object sender, EventArgs e)
        {
            var settlement = sender as Contract;
            if (settlement != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = settlement,
                    Text = settlement.numberContract.ToString()
                };
                listViewItem.SubItems.Add(settlement.date.ToShortDateString());

                listViewItem.SubItems.Add(settlement.insuranceAmount.ToString());
                listViewItem.SubItems.Add(settlement.tariffRate.ToString());
                listViewItem.SubItems.Add(settlement.localDepartament.ToString());
                listViewItem.SubItems.Add(settlement.LocalInsuranceTypes.ToString());
                listViewContracts.Items.Add(listViewItem);
            }
        }

        private void _hotel_RoomAdded(object sender, EventArgs e)
        {
            var room = sender as InsuranceTypes;
            if (room != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = room,
                    Text = room.insuranceType.ToString()
                };
                listViewTypes.Items.Add(listViewItem);

            }
        }

        private void _hotel_ClientAdded(object sender, EventArgs e)
        {
            var client = sender as Departament;
            if (client != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.depName.ToString()
                };
                listViewItem.SubItems.Add(client.address.ToString());
                listViewItem.SubItems.Add(client.telephone.ToString());
                ListViewDepartamnet.Items.Add(listViewItem);
            }



        }



        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var dep = new Departament();
            _formClient.Dep = dep;
            if (_formClient.ShowDialog() == DialogResult.OK)
            {
                try {
                    _insurance.AddClient(dep);
                }
                catch(Exception exception) {
                    MessageBox.Show(exception.Message);
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

           try
            {
                var client = ListViewDepartamnet.SelectedItems[0].Tag as Departament;
                _formClient.Dep = client;
                if (_formClient.ShowDialog() == DialogResult.OK)
                {
                    client = _formClient.Dep;
                    var listViewItem = ListViewDepartamnet.SelectedItems[0];

                    listViewItem.SubItems[0].Text = client.depName.ToString();
                    listViewItem.SubItems[1].Text = client.address.ToString();
                    listViewItem.SubItems[2].Text = client.telephone.ToString();
                }
              

                }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с клиентом");
            }

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var settlement = new Contract();
            _formSettlement.Contract = settlement;
            if (_formSettlement.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _insurance.AddSettlement(settlement);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                var settlement = listViewContracts.SelectedItems[0].Tag as Contract;
                _formSettlement.Contract = settlement;
                if (_formSettlement.ShowDialog() == DialogResult.OK)
                {
                    settlement = _formSettlement.Contract;
                    var listViewItem = listViewContracts.SelectedItems[0];
                    listViewItem.Text = settlement.numberContract.ToString();
                    listViewItem.SubItems[1].Text=settlement.date.ToShortDateString();

                    listViewItem.SubItems[2].Text = settlement.insuranceAmount.ToString();
                    listViewItem.SubItems[3].Text = settlement.tariffRate.ToString();
                    listViewItem.SubItems[4].Text = settlement.localDepartament.depName.ToString();
                    listViewItem.SubItems[4].Text = settlement.LocalInsuranceTypes.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с поселением");
            }

        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var insType = new InsuranceTypes();
            _formRoom.Type = insType;
            if (_formRoom.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _insurance.AddRoom(insType);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        //private void UpdateSettlementList()
        //{
        //    listViewContracts.Items.Clear();
        //    foreach (var settlement in Insurance.Settlements)
        //    {
        //        var listViewItem = new ListViewItem
        //        {
        //            Tag = settlement,
        //            Text = settlement.numberContract.ToString()
        //        };
        //        listViewItem.SubItems.Add(settlement.date.ToShortDateString());

        //        listViewItem.SubItems.Add(settlement.insuranceAmount.ToString());
        //        listViewItem.SubItems.Add(settlement.tariffRate.ToString());
        //        listViewItem.SubItems.Add(settlement.localDepartament.ToString());
        //        listViewItem.SubItems.Add(settlement.LocalInsuranceTypes.ToString());
        //        listViewContracts.Items.Add(listViewItem);
        //    }
        //}
        //private void UpdateTypes() {
        //    listViewTypes.Items.Clear();
        //    foreach (var types in Insurance.Rooms)
        //    {
        //        var listViewItem = new ListViewItem
        //        {
        //            Tag = types,
        //            Text = types.Value.insuranceType.ToString()
        //        };
        //        listViewTypes.Items.Add(listViewItem);
        //    }
        //}

        //private void UpdateClientsList()
        //{

        //    ///<summary>
        //    ///Апдейт листа филиалов
        //    ///</summary>
        //    ListViewDepartamnet.Items.Clear();
        //    foreach (var item in Insurance.Clients)
        //    {
        //        var client = item.Value;
        //        var listViewItem = new ListViewItem
        //        {
        //            Tag = client,
        //            Text = client.depName.ToString()
        //        };
               
        //        listViewItem.SubItems.Add(client.address.ToString());
        //        listViewItem.SubItems.Add(client.telephone.ToString());
        //        ListViewDepartamnet.Items.Add(listViewItem);
        //    }
        //}

        private void listViewContracts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var insTypes = listViewTypes.SelectedItems[0].Tag as InsuranceTypes;
                _formRoom.Type = insTypes;
                if (_formRoom.ShowDialog() == DialogResult.OK)
                {
                    listViewTypes.SelectedItems[0].Text = _formRoom.Type.ToString();
                }
            }
            catch (Exception) {
                MessageBox.Show("Не выбрана строка с типом");
            }
        }

        private void ListViewDepartamnet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var client = ListViewDepartamnet.SelectedItems[0].Tag as Departament;
                    if (client != null)
                    {
                        _insurance.RemoveClient(client.DepId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с филиалом");
                }
            }
        }

        private void listViewTypes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var room = listViewTypes.SelectedItems[0].Tag as InsuranceTypes;
                    if (room != null)
                    {
                        _insurance.RemoveRoom(room.typeId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с типом");
                }
            }
        }

        private void listViewContracts_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var settlement = listViewContracts.SelectedItems[0].Tag as Contract;
                    if (settlement != null)
                    {
                        _insurance.RemoveSettlement(settlement);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с договором");
                }
            }
        }
    }
}