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

      //  private Contract _contarct;
       // private Departament _dep;
        //private InsuranceTypes _insType;
        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var _dep = new Departament();

            FormDepartament formRoom = new FormDepartament(_dep);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                Insurance.Clients.Add(_dep.DepId,formRoom.dep);
                UpdateClientsList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dep = ListViewDepartamnet.SelectedItems[0].Tag as Departament;
            FormDepartament formSettlement = new FormDepartament(dep);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsList();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var settlement = new Contract();
            FormContract formSettlement = new FormContract(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                Insurance.Settlements.Add(settlement);
                UpdateSettlementList();
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var contract = listViewContracts.SelectedItems[0].Tag as Contract;
            FormContract formSettlement = new FormContract(contract);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateSettlementList();
            }
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var _insType = new InsuranceTypes();

            FormTypes formRoom = new FormTypes(_insType);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                Insurance.Rooms.Add( _insType.typeId,formRoom.it);
                UpdateTypes();

            }
        }
        private void UpdateSettlementList()
        {
            listViewContracts.Items.Clear();
            foreach (var settlement in Insurance.Settlements)
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
        private void UpdateTypes() {
            listViewTypes.Items.Clear();
            foreach (var types in Insurance.Rooms)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = types,
                    Text = types.Value.insuranceType.ToString()
                };
                listViewTypes.Items.Add(listViewItem);
            }
        }

        private void UpdateClientsList()
        {

            ///<summary>
            ///Апдейт листа филиалов
            ///</summary>
            ListViewDepartamnet.Items.Clear();
            foreach (var item in Insurance.Clients)
            {
                var client = item.Value;
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

        private void listViewContracts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var insTypes = listViewTypes.SelectedItems[0].Tag as InsuranceTypes;
            FormTypes formSettlement = new FormTypes(insTypes);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateTypes();
            }
        }
    }
}