using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
namespace WinFormsApp1
{
    public partial class Users : Form
    {
        List<Employee> employees;
        public Users(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            UpdateDataSet();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
        public void UpdateDataSet()
        {
            dataGridView1.Rows.Clear();
            foreach (Employee employee in employees)
            {
                dataGridView1.Rows.Add(employee.getEmployeeID, employee.UserName) ;
            }
        }
        public Employee FindEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.getEmployeeID == id)
                {
                    return emp;
                }
            }
            return null;    
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;
            Employee employee = FindEmployee(id);
            if (employee == null)
            {

            }
            else
            {
                EditUsers newForm = new EditUsers(employee);
                newForm.ShowDialog();
            }

           
        }
    }
}
