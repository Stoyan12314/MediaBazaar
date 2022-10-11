using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;
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

            Shifts shift = (Shifts)Enum.Parse(typeof(Shifts), cbShifts.Text);
            dbUser.UpdateShift(employees, shift);
            this.Close();
        }
    }
}
