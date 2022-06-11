using System;
using System.Windows.Forms;
using Lab11.Models;

namespace Lab11
{
    public partial class FormUser : Form
    {
        private Information _user;
        public Information River
        {
            get { return _user; }
            set
            {
                _user = value;
                textBoxFirstName.Text = _user.RiverName;
                textPalace.Text = _user.RiverPalace;
                textOutflow.Text = _user.RiverOutflow;
                textBoxLength.Text = _user.RiverLength.ToString();
            }
        }
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
       
                    River.RiverName = textBoxFirstName.Text;
                    River.RiverPalace = textPalace.Text;
                    River.RiverOutflow = textOutflow.Text;
                    River.RiverLength = int.Parse(textBoxLength.Text);
    

        }
    }
}
