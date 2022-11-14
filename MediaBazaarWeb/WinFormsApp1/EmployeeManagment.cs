using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;

using Entities;
using BuissnessLogicLayer;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class EmployeeManagment : Form
    {
        UserManager userManager = new UserManager();
        UserDB dbUser = new UserDB();
        List<Employee> employees = new List<Employee>();
        Employee employee;
        public MySqlConnection sc = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");
        public EmployeeManagment()
        {
            InitializeComponent();
            UpdateDataSet();
            foreach (Employee e in userManager.getAllEmployees())
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

         

            

         


            foreach (Employee emp in userManager.getAllEmployees())
            {
                lbEmployees.Items.Add(emp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                Employee employee = (Employee)lbEmployees.SelectedItem;
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

                userManager.SearchEmployeeByID(Convert.ToInt32(tbSearch.Text),  employee);
                foreach (Employee em in employees)
                {
                    lbEmployees.Items.Add(em);
                }
            }
            else
            {

                userManager.SearchEmployee(tbSearch.Text, tbSearch.Text,  employee);
                foreach (Employee em in employees)
                {
                    lbEmployees.Items.Add(em);
                }
            }
        }
        public void UpdateDataSet()
        {
            //dataGridView1.Rows.Clear();
            //foreach (Employee admin in userManager.getAllEmployees())
            //{
            //    dataGridView1.Rows.Add(admin.getEmployeeID, admin.UserName, admin., admin., game.gameTime + " hours", game.releaseDate.ToString("dd/MM/yyyy"), game.avgScore, game.description);
            //}
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void EmployeeManagment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
