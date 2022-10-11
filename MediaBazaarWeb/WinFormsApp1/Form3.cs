using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        Employee employee;
        public Form3(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            MessageBox.Show("You successfully logged as: " + emp.UserName);
        }
    }
}
