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
using Lab04;

namespace Lab04
{
    public partial class FormWorks : Form
    {
        private Works _works;
        public Works Works
        {
            get { return _works; }
            set
            {
                _works = value;
                comboBox1.SelectedItem = _works.Employee;
                comboBox2.SelectedItem = _works.TypeOfWorks;
                dateTimePicker1.Value = _works.StartDate;
                dateTimePicker2.Value = _works.EndDate;
            }
        }
        private readonly Job _job = Job.Instance;
        public FormWorks()
        {
            InitializeComponent();
            _job.EmployeeAdded += _job_EmployeeAdded;
            _job.EmployeeRemoved += _job_EmployeeRemoved;
            _job.TypeOfWorksAdded += _job_TOWAdded;
            _job.TypeOfWorksRemoved += _job_TOWRemoved;
            foreach (var client in _job.Employees)
            {
                comboBox1.Items.Add(client);
            }
            foreach (var room in _job.TypeOfWorks)
            {
                comboBox2.Items.Add(room);
            }
        }

        private void _job_TOWRemoved(object sender, EventArgs e)
        {
            TypeOfWorksEnum key = (TypeOfWorksEnum)sender;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                var room = comboBox2.Items[i] as TypeOfWorks;
                if (room?.TypeWork == key)
                {
                    comboBox2.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _job_TOWAdded(object sender, EventArgs e)
        {
            comboBox2.Items.Add(sender);
        }

        private void _job_EmployeeRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                var client = comboBox1.Items[i] as Employee;
                if (client?.EmployeeId == key)
                {
                    comboBox1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _job_EmployeeAdded(object sender, EventArgs e)
        {
            comboBox1.Items.Add(sender);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            _works.Employee = comboBox1.SelectedItem as Employee;
            _works.TypeOfWorks = comboBox2.SelectedItem as TypeOfWorks;
            _works.StartDate = dateTimePicker1.Value;
            _works.EndDate = dateTimePicker2.Value;
        }

     


        private void FormWorks_Load(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }





















}

