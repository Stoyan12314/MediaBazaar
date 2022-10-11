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
    public partial class LoginForm : Form
    {
        Employee employee;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDB login = new UserDB();
            bool isItLoggedIn = false;
            try
            {
                if(login.logInUser(tbUsername.Text, tbPassword.Text, employee) == true)
                {
                    employee = new Employee();
                    employee.UserName = tbUsername.Text;
                    this.Hide();
                    new Form3(employee).Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                    tbUsername.Clear();
                    tbPassword.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
