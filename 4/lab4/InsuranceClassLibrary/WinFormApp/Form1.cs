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

        private Contract _contarct;
        private Departament _dep;

        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dep = new Departament();
            FormDepartament formRoom = new FormDepartament(_dep);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _dep = formRoom.dep;
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDepartament formRoom = new FormDepartament(_dep);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _dep = formRoom.dep;

            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _contarct = new Contract();
            FormContract formRoom = new FormContract(_contarct, _dep);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _contarct = formRoom.Contract;

            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormContract formRoom = new FormContract(_contarct, _dep);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                _contarct = formRoom.Contract;

            }
        }
    }
}
