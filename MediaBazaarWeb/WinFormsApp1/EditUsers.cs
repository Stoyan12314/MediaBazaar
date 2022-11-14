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
    public partial class EditUsers : Form
    {
        Employee emp;
        UserManager empManagment;
        public EditUsers(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            UpdateInfo();
            empManagment = new UserManager();
        }
        public void UpdateInfo()
        {
           
            tbUsername.Text = emp.UserName;
            tbFirstName.Text = emp.getFName;
            tbLastName.Text = emp.getLName;
            tbAddress.Text = emp.Address;
            tbPassword.Text = emp.Password;
            tbEmail.Text = emp.Email;
            tbDateOfBirth.Text = emp.DateOfBirh.ToString();
            cbPossitions.Text = emp.AccType.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            empManagment.UpdateCredentials(emp);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
