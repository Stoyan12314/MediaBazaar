using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        UserDB dbUser = new UserDB();
        List<Employees> employees = new List<Employees>();
        Employees employee;
        public MySqlConnection sc = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");
        public Form2()
        {
            InitializeComponent();
         


            foreach (Employees e in dbUser.FetchData())
            {
                lbEmployees.Items.Add(e);
            }
        }
       


        //isNumber = int.TryParse(tbSearch.Text, out value);
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
           


        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();
         


            foreach (Employees emp in dbUser.FetchData())
            {
                lbEmployees.Items.Add(emp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                Employees employee = (Employees)lbEmployees.SelectedItem;
                ManageShifts fprm = new ManageShifts(dbUser, employee);
                fprm.ShowDialog();

            }
         
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int value;
            lbEmployees.Items.Clear();
            if (int.TryParse(tbSearch.Text, out value))
            {
                dbUser.SearchEmployeeByID(Convert.ToInt32(tbSearch.Text), employees, employee);
                foreach (Employees em in employees)
                {
                    lbEmployees.Items.Add(em);
                }
            }
            else
            {
                dbUser.SearchEmployee(tbSearch.Text, tbSearch.Text, employees, employee);
                foreach (Employees em in employees)
                {
                    lbEmployees.Items.Add(em);
                }
            }
        }
    }
}
