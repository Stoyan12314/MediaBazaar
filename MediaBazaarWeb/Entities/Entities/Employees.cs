using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
namespace DataAccessLayer
{
   public class Employees: User
    {
      
        public Employees(): base()
        {
         
        }
        public Employees(int employeeID, string userName, string firstName, string lastName, string address, string password, string email, DateTime dateOfBirh, AccountType accType) : base(employeeID, userName, firstName, lastName, address, password, email, dateOfBirh, accType)
        {
          
                
        }
        public Employees(string userName,  Shifts shift): base(userName, shift)
        {


        }
        public override string ToString()
        {
            return this.employeeID + " " + this.userName + " " + this.shifts;
        }
    }
}
