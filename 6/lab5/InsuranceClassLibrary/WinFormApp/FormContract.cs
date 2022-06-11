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
                textBox1.Text = _contract.numberContract;
                numericUpDown1.Value = (int)_contract.insuranceAmount;
                numericUpDown2.Value = (int)_contract.tariffRate;
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
                comboBox1.Items.Add(item);

            }
            foreach (var item in _insurance.Rooms)
            {
                comboBox2.Items.Add(item);

            }
           
        }

        private void _hotel_RoomRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                var room = comboBox2.Items[i] as InsuranceTypes;
                if (room?.typeId == key)
                {
                    comboBox2.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_RoomAdded(object sender, EventArgs e)
        {
            comboBox2.Items.Add(sender);
        }

        private void _hotel_ClientRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                var client = comboBox1.Items[i] as Departament;
                if (client?.DepId == key)
                {
                    comboBox1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_ClientAdded(object sender, EventArgs e)
        {
            comboBox1.Items.Add(sender);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Contract.LocalInsuranceTypes= (InsuranceTypes)comboBox2.SelectedItem;
            Contract.localDepartament = (Departament)comboBox1.SelectedItem;
            Contract.numberContract = textBox1.Text;
            Contract.insuranceAmount=(int)numericUpDown1.Value;
            Contract.tariffRate= (int)numericUpDown2.Value;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
