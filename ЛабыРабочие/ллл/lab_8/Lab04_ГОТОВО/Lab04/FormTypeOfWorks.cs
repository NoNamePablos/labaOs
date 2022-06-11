using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4;

namespace lab4_samopal
{
    public partial class FormTypeOfWorks : Form
    {


        private TypeOfWorks _typeOfWorks;
        public TypeOfWorks TypeOfWorks
        {
            get
            {
                return _typeOfWorks;
            }
            set
            {
                _typeOfWorks = value;
                comboBox1.SelectedItem = _typeOfWorks.TypeWork;
                numericUpDown1.Value = _typeOfWorks.Coast;
            }
        }
       
        public FormTypeOfWorks()
        {
            InitializeComponent();
            comboBox1.Items.Add(TypeOfWorksEnum.Type1);
            comboBox1.Items.Add(TypeOfWorksEnum.Type2);
            comboBox1.Items.Add(TypeOfWorksEnum.Type3);
            //comboBox1.SelectedItem = TypeOfWorks.TypeWork;
            //numericUpDown1.Value = TypeOfWorks.Coast;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _typeOfWorks.TypeWork = (TypeOfWorksEnum)comboBox1.SelectedItem;
            _typeOfWorks.Coast = numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
