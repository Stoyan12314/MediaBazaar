using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class User
    {
        protected int employeeID;
        protected string userName;
        protected string firstName;
        protected string lastName;
        protected string address;
        protected string password;
        protected string email;
        protected DateTime dateOfBirh;
        //protected DateTime dayShift;
        protected AccountType accType;
        
       
        public User()
        {

        }
        public User(int employeeID, string userName, string firstName, string lastName, string address, string password, string email, DateTime dateOfBirh, AccountType accType)
        {
            this.employeeID = employeeID;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.password = password;
            this.email = email;
            this.dateOfBirh = dateOfBirh;
            this.accType = accType;
           
        }
        public User(string username, string password)
        {

        }
        public User(string userName)
        {
            this.userName = userName;
          
        }
        public int getEmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string getFName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string getLName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DateOfBirh
        {
            get { return dateOfBirh; }
            set { dateOfBirh = value; }
        }

        public AccountType AccType
        {
            get { return accType; }
            set { accType = value; }
        }
        //public ShiftType GetShifts
        //{
        //    get { return shiftType; }
        //    set { shiftType = value; }
        //}
    }
}
