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
        ShiftManager shiftManager = new ShiftManager();
        Dictionary<Employee, Shift> shifts;
      
        Employee employee;
        Employee employeeWithShift;
        string dateTime;
        public MySqlConnection sc = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");
        public EmployeeManagment()
        {
            InitializeComponent();
            UpdateDataSet();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        public void UpdateDataSet()
        {
            Dictionary<Employee, Shift> shifts = CalculateShifts.AssignShifts(userManager.getAllEmployees(), shiftManager.getAllShifts());
            dataGridViewEmployees.Rows.Clear();

            foreach (var entry in shifts)
            {
                Employee emp = entry.Key;
                Shift shift = entry.Value;
                dataGridViewEmployees.Rows.Add(emp.getEmployeeID, emp.UserName, emp.getFName, emp.getLName, shift.shiftType);
            }
        }



        private void btnAll_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.Rows.Clear();
            foreach (Employee emp in userManager.getAllEmployees())
            {
                dataGridViewEmployees.Rows.Add(emp.getEmployeeID,emp.UserName, emp.getFName, emp.getLName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow.Index == dataGridViewEmployees.Rows.Count - 1)
            {
                Employee employee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;
                UserDB dbUser = new UserDB();
                ManageShifts fprm = new ManageShifts(dbUser, employee);
                fprm.ShowDialog();
            }
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewEmployees.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;
            employee = userManager.SearchEmployeeByID(id, employee)[0];
        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            int value;
            dataGridViewEmployees.Rows.Clear();
            if (int.TryParse(tbSearch.Text, out value))
            {
                foreach (Employee em in userManager.SearchEmployeeByID(Convert.ToInt32(tbSearch.Text), employee))
                {
                    dataGridViewEmployees.Rows.Add(em.getEmployeeID, em.UserName, em.getFName, em.getLName);
                }
            }
            else
            {
                foreach (Employee em in userManager.SearchEmployee(tbSearch.Text, tbSearch.Text, employee))
                {
                    dataGridViewEmployees.Rows.Add(em.getEmployeeID, em.UserName, em.getFName, em.getLName);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (employee == null)
            {
                MessageBox.Show("Select employee first");
            }
            else
            {
                ShiftType accType = Enum.Parse<ShiftType>(cbShiftType.Text);
                shiftManager.SetShift(employee.getEmployeeID, accType, tbDate.Text);
                MessageBox.Show("Shift Added!");
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTime = monthCalendar2.SelectionRange.Start.ToString("yyyy/MM/dd");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewEmployeesShifts.Rows.Clear();
            foreach (Shift shift in shiftManager.getAllShifts())
            {
                if(shift.dayShift.ToString("yyyy/MM/dd") == dateTime)
                {
                    Employee emp =  userManager.SearchEmployeeByID(shift.employeeId, employee)[0];
                    dataGridViewEmployeesShifts.Rows.Add(emp.getEmployeeID, emp.UserName, emp.getFName, emp.getLName, shift.shiftType);

                }
            }
        }
        
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            
          //  dateTime = monthCalendar1.SelectionRange.Start.ToShortDateString();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbDate.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            if (employeeWithShift == null)
            {
                MessageBox.Show("Select employee first !");
            }
            else
            {
                if (shiftManager.RemoveShift(employeeWithShift.getEmployeeID, dateTime) == true)
                {
                    MessageBox.Show("Shift deleted successfully!");
                }
                else
                {
                    MessageBox.Show("An error has occured!");
                }
                dataGridViewEmployeesShifts.Rows.Clear();
            }
        }

        private void dataGridViewEmployeesShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewEmployees.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;
            employeeWithShift = userManager.SearchEmployeeByID(id, employee)[0];
        }
    }
}
