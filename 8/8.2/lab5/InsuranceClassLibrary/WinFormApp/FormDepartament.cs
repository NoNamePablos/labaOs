﻿using System;
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
    public partial class FormDepartament : Form
    {
        private Departament _dep;
        public Departament Dep {
            get { return _dep; }
            set
            {
                _dep = value;
                textBoxDepartament.Text = Dep.DepName;
                textBoxAddres.Text = Dep.Address;
                textBoTelephone.Text = Dep.Telephone;
            }
        }
        public FormDepartament()
        {
            InitializeComponent();
            
           
        }

        private void FormDepartament_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            _dep.DepName = textBoxDepartament.Text;
            _dep.Address = textBoxAddres.Text;
            _dep.Telephone = textBoTelephone.Text;

        }
    }
}
