using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using BuissnessLogicLayer;
namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        UserManager userManager = new UserManager();
        User admin;
        public Form3(User admin)
        {
            InitializeComponent();
            this.admin = admin;
            MessageBox.Show("You successfully logged as: " + admin.UserName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = userManager.getAllEmployees();
            Users form = new Users(employees);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeManagment frm = new EmployeeManagment();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
