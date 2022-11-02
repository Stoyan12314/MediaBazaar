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
    public partial class LoginForm : Form
    {
      //  Employee admin;

        UserManager userManager;
        public LoginForm()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // UserDB login = new UserDB();
            bool isItLoggedIn = false;
            try
            {
                User admin = userManager.checkLoginAdministrator(tbUsername.Text, tbPassword.Text);
                if (admin==null)
                {

                    MessageBox.Show("Wrong username or password");
                    tbUsername.Clear();
                    tbPassword.Clear();

                   
                }
                else
                {
                 //   employee = new Employee();
                   // admin.UserName = tbUsername.Text;
                    this.Hide();
                    new Form3(admin).Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connect the VPN!");
            }

        }
    }
}
