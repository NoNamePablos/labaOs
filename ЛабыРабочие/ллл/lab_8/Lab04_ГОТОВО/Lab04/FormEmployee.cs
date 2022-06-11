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

namespace lab4
{
    public partial class FormEmployee : Form
    {

        private Employee _employee;

        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                textBox1.Text = Employee.FirstName;
                textBox2.Text = Employee.MiddleName;
                textBox3.Text = Employee.LastName;
                numericUpDown1.Value = Employee.Salary;
            }
        }

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _employee.FirstName = textBox1.Text;
            _employee.MiddleName = textBox2.Text;
            _employee.LastName = textBox3.Text;
            _employee.Salary = numericUpDown1.Value;

           
        }









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
