using System;
using System.Windows.Forms;
using lab4;
using lab4_samopal;
using WindowsFormsControlLibraryHotel;
using ClassLibraryHotel.Serialization;


namespace Lab04
{
    public partial class FormMain : Form
    {

        private readonly Job _job = Job.Instance;
        readonly FormTypeOfWorks _formTypeOfWorks = new FormTypeOfWorks();
        readonly FormEmployee _formEmployee = new FormEmployee();
        readonly FormWorks _formWorks = new FormWorks();

        public FormMain()
        {
            InitializeComponent();
            _job.EmployeeAdded += _job_EmployeeAdded;
            _job.TypeOfWorksAdded += _job_TOWAdded;
            _job.WorksAdded += _job_WorksAdded;
            _job.EmployeeRemoved += _job_EmployeeRemoved;
            _job.TypeOfWorksRemoved += _job_TOWRemoved;
            _job.WorksRemoved += _job_WorksRemoved;
        }

        private void _job_WorksRemoved(object sender, EventArgs e)
        {
            var works = sender as Works;
            for (int i = 0; i < Работы.Controls.Count; i++)
            {
                if ((Работы.Controls[i] as UserControlSettlement)?.Works == works)
                {
                    Работы.Controls.RemoveAt(i);
                    break;
                }
            }
        }

        private void _job_TOWRemoved(object sender, EventArgs e)
        {
            var typeWork = (TypeOfWorksEnum)sender;
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (((TypeOfWorks)listView2.Items[i].Tag).TypeWork == typeWork)
                {
                    listView2.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _job_EmployeeRemoved(object sender, EventArgs e)
        {
            var employeeId = (int)sender;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (((Employee)listView1.Items[i].Tag).EmployeeId == employeeId)
                {
                    listView1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _job_WorksAdded(object sender, EventArgs e)
        {
            var works = sender as Works;
            if (works != null)
            {
                UserControlSettlement userControl = new UserControlSettlement(works)
                {
                    Dock = DockStyle.Top
                };
                Работы.Controls.Add(userControl);
            }
        }

        private void _job_TOWAdded(object sender, EventArgs e)
        {
            var typeOfWorks = sender as TypeOfWorks;
            if (typeOfWorks != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = typeOfWorks,
                    Text = typeOfWorks.ToString()
                };
                listView2.Items.Add(listViewItem);
            }
        }

        private void _job_EmployeeAdded(object sender, EventArgs e)
        {
            var employee = sender as Employee;
            if (employee != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = employee,
                    Text = employee.ToString()
                };
                listView1.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            _formEmployee.Employee = employee;
            if (_formEmployee.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _job.AddEnployee(employee);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = listView1.SelectedItems[0].Tag as Employee;
                _formEmployee.Employee = employee;
                if (_formEmployee.ShowDialog() == DialogResult.OK)
                {
                    listView1.SelectedItems[0].Text = _formEmployee.Employee.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с клиентом");
            }
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var typeOfWorks = new TypeOfWorks();
            _formTypeOfWorks.TypeOfWorks = typeOfWorks;
            if (_formTypeOfWorks.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _job.AddTOW(typeOfWorks);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var typeOfWorks = listView2.SelectedItems[0].Tag as TypeOfWorks;
                _formTypeOfWorks.TypeOfWorks = typeOfWorks;
                if (_formTypeOfWorks.ShowDialog() == DialogResult.OK)
                {
                    listView2.SelectedItems[0].Text = _formTypeOfWorks.TypeOfWorks.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с номером");
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var works = new Works();
            _formWorks.Works = works;
            if (_formWorks.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _job.AddWorks(works);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Работы.Controls.Count; i++)
                {
                    var userControl = Работы.Controls[i] as UserControlSettlement;
                    if (userControl != null)
                    {
                        if (userControl.Selected)
                        {
                            var works = userControl.Works;
                            _formWorks.Works = works;
                            if (_formWorks.ShowDialog() == DialogResult.OK)
                            {
                                userControl.Refresh();
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о поселении");
            }
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        private void listViewClients_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var employee = listView1.SelectedItems[0].Tag as Employee;
                    if (employee != null)
                    {
                        _job.RemoveEmployee(employee.EmployeeId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с Сотрудником");
                }
            }
        }

        private void listViewRooms_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var typeOfWorks = listView2.SelectedItems[0].Tag as TypeOfWorks;
                    if (typeOfWorks != null)
                    {
                        _job.RemoveTOW(typeOfWorks.TypeWork);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с Видом Работы");
                }
            }

        }





        //private void listViewSettlement_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        try
        //        {
        //            var works = listView3.SelectedItems[0].Tag as Works;
        //            if (works != null)
        //            {
        //                _job.RemoveWorks(works);
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Не выбрана строка с работой");
        //        }
        //    }
        //}





















        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML-файлы|*.xml|Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JobSerializable.Save(saveFileDialog1.FileName, SerializeType.XML);
            }

        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON-файлы|*.json|Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JobSerializable.Save(saveFileDialog1.FileName, SerializeType.JSON);
            }
        }

        private void двоичныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Двоичные файлы|*.bin|Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JobSerializable.Save(saveFileDialog1.FileName, SerializeType.Binary);
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-файлы|*.xml|Все файлы|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                
                JobSerializable.Load(openFileDialog1.FileName, SerializeType.XML);

            }
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON-файлы|*.json|Все файлы|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JobSerializable.Load(openFileDialog1.FileName, SerializeType.JSON);
            }
        }

        private void двоичныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Двоичные файлы|*.bin|Все файлы|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JobSerializable.Load(openFileDialog1.FileName, SerializeType.Binary);
            }
        }
    }
}
