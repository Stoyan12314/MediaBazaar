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
        Employee upEmp;
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
            DateTimePickerBirth.Value = emp.DateOfBirh;
            cbPossitions.Text = emp.AccType.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountType accType = Enum.Parse<AccountType>(cbPossitions.Text);
            upEmp = new Employee(emp.getEmployeeID, tbUsername.Text, tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbPassword.Text, tbEmail.Text, DateTimePickerBirth.Value, accType);

            empManagment.UpdateCredentials(upEmp);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
