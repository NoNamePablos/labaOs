using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceClassLibrary;


namespace WindowsFormsControlLibraryInsurance1
{
    public partial class UserControlInsurance : UserControl
    {


        private readonly Insurance _insurance = Insurance.Instance;
        public Contract Settlement { get; }
        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControlInsurance)) continue;
                            var userControlSettlement = control as UserControlInsurance;
                            if (userControlSettlement != this)
                            {
                                userControlSettlement.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }
        public UserControlInsurance(Contract contracrt)
        {
            InitializeComponent();
            Settlement = contracrt;
        }


        private void label1_Click(object sender, EventArgs e)
        {


        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                _insurance.RemoveSettlement(Settlement);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о поселении");
            }



        }



        private void UserControl1_Load(object sender, EventArgs e)
        {


        }


        private void userControl1_Click(object sender, EventArgs e)
        {
            Selected = true;
        }


        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {

            textBoxNumber.Text = Settlement.NumberContract.ToString();
            textBoxDate.Text = Settlement.Date.ToShortDateString();
            textBoxTariffRate.Text = Settlement.TariffRate.ToString();
            textBoxInsuranceAmount.Text = $@"{Settlement.InsuranceAmount}.";


            textBoxInsuranceType.Text = Settlement.LocalInsuranceTypes.InsuranceType.ToString();
            textBoDepartament.Text = $@"{Settlement.LocalDepartament.DepName}.";
            textBoDepartament.BackColor = Color.Aqua;


            if (Settlement.InsuranceAmount > 100000)
            {
                textBoxInsuranceAmount.BackColor = Color.Green;
            }
            else
            {
                textBoxInsuranceAmount.BackColor = (Settlement.InsuranceAmount < 30000 ? Color.Yellow : Color.Red);
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlInsurance_load(object sender, EventArgs e)
        {

        }
    }
}