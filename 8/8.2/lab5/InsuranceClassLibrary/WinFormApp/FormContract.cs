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
    public partial class FormContract : Form
    {
        private Contract _contract;
        public Contract Contract {
            get { return _contract; }
            set
            {
                _contract = value;
                textBoxNumberContract.Text = _contract.NumberContract;
                numericUpDownInsuranceAmount.Value = (int)_contract.InsuranceAmount;
                numericUpDownTariffRate.Value = (int)_contract.TariffRate;
            }

        }

        private readonly Insurance _insurance = Insurance.Instance;
        //public InsuranceTypes it { get; }
        //public Departament dep { get; }
        public FormContract()
        {
            InitializeComponent();
            _insurance.ClientAdded += _hotel_ClientAdded;
            _insurance.ClientRemoved += _hotel_ClientRemoved;
            _insurance.RoomAdded += _hotel_RoomAdded;
            _insurance.RoomRemoved += _hotel_RoomRemoved;

            foreach (var item in _insurance.Clients) {
                comboBoxDepartament.Items.Add(item);

            }
            foreach (var item in _insurance.Rooms)
            {
                comboBoxTypeInsurance.Items.Add(item);

            }
           
        }

        private void _hotel_RoomRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxTypeInsurance.Items.Count; i++)
            {
                var room = comboBoxTypeInsurance.Items[i] as InsuranceTypes;
                if (room?.TypeId == key)
                {
                    comboBoxTypeInsurance.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_RoomAdded(object sender, EventArgs e)
        {
            comboBoxTypeInsurance.Items.Add(sender);
        }

        private void _hotel_ClientRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxDepartament.Items.Count; i++)
            {
                var client = comboBoxDepartament.Items[i] as Departament;
                if (client?.DepId == key)
                {
                    comboBoxDepartament.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_ClientAdded(object sender, EventArgs e)
        {
            comboBoxDepartament.Items.Add(sender);
        }


        private void FormContract_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {

            Contract.LocalInsuranceTypes = (InsuranceTypes)comboBoxTypeInsurance.SelectedItem;
            Contract.LocalDepartament = (Departament)comboBoxDepartament.SelectedItem;
            Contract.NumberContract = textBoxNumberContract.Text;
            Contract.InsuranceAmount = (int)numericUpDownInsuranceAmount.Value;
            Contract.TariffRate = (int)numericUpDownTariffRate.Value;
        }
    }
}
