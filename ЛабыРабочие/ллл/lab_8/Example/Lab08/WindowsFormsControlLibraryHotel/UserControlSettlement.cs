using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace WindowsFormsControlLibraryHotel
{
    public partial class UserControlSettlement : UserControl
    {
        private readonly Hotel _hotel = Hotel.Instance;
        public Settlement Settlement { get; }

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
                            if (!(control is UserControlSettlement)) continue;
                            var userControlSettlement = control as UserControlSettlement;
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

        public UserControlSettlement(Settlement settlement)
        {
            InitializeComponent();
            Settlement = settlement;
        }

        private void UserControlSettlement_Paint(object sender, PaintEventArgs e)
        {
            textBoxClient.Text = $@"{Settlement.Client.LastName} {Settlement.Client.FirstName[0]}.{Settlement.Client.MiddleName[0]}.";
            textBoxRoom.Text = Settlement.Room.Number.ToString("0");
            textBoxPeriod.Text = $@"С {Settlement.StartDate:dd MMMM yyyy} по {Settlement.EndDate:dd MMMM yyyy}";
            if (Settlement.EndDate < DateTime.Today)
            {
                textBoxPeriod.BackColor = Color.Green;
            }
            else
            {
                textBoxPeriod.BackColor = Settlement.StartDate < DateTime.Today ? Color.Yellow : Color.Red;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }

        private void UserControlSettlement_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _hotel.RemoveSettlement(Settlement);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о поселении");
            }
        }
    }
}
