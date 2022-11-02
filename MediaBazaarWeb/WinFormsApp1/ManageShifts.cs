using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using Entities;
namespace WinFormsApp1
{
    public partial class ManageShifts : Form
    {
        Employee employees;
        UserDB dbUser;
        public ManageShifts(UserDB dbUser, Employee emp)
        {
            InitializeComponent();
            this.dbUser = dbUser;
            this.employees = emp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            ShiftType shift = (ShiftType)Enum.Parse(typeof(ShiftType), cbShifts.Text);
            DateTime time = dateTimePicker1.Value;
            dbUser.UpdateShift(employees, shift, time);
            this.Close();
        }
    }
}
