using System;
using System.Drawing;
using System.Windows.Forms;
using lab4;

namespace WindowsFormsControlLibraryHotel
{
    public partial class UserControlSettlement : UserControl
    {
        private readonly Job _job = Job.Instance;
        public Works Works{ get; }

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

        public UserControlSettlement(Works works)
        {
            InitializeComponent();
            Works = works;
        }

        private void UserControlSettlement_Paint(object sender, PaintEventArgs e)
        {
            textBoxClient.Text = $@"{Works.Employee.LastName} {Works.Employee.FirstName[0]}.{Works.Employee.MiddleName[0]}.";
            textBoxRoom.Text = Works.TypeOfWorks.TypeWork.ToString();
            textBoxPeriod.Text = $@"С {Works.StartDate:dd MMMM yyyy} по {Works.EndDate:dd MMMM yyyy}";
            if (Works.EndDate < DateTime.Today)
            {
                textBoxPeriod.BackColor = Color.Green;
            }
            else
            {
                textBoxPeriod.BackColor = Works.StartDate < DateTime.Today ? Color.Yellow : Color.Red;
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
                _job.RemoveWorks(Works);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о поселении");
            }
        }
    }
}
