using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiess;
namespace Entities
{
   public class Employee: User
    {
        public List<Shift> shifts { private set; get; }
        public Shift shift { private set;  get; }
        //Dictionary<Employee, Shift> shifts;
        //protected Shifts shifts; //dictionary//

        public Employee(): base()
        {
            shifts = new List<Shift>();
        }
        public Employee(int employeeID, string userName, string firstName, string lastName, string address, string password, string email, DateTime dateOfBirh, AccountType accType) : base(employeeID, userName, firstName, lastName, address, password, email, dateOfBirh, accType)
        {
            shifts = new List<Shift>();

        }
        public Employee(string userName, Shift shift) : base(userName)
        {
            shifts = new List<Shift>();

        }
        public void CreateShift(ShiftType shiftType, DateTime dayShift)
        {
            shift = new Shift(shiftType, dayShift);
            shifts.Add(shift);
        }
        public void UpdateShift()
        {
            
        }
        public override string ToString()
        {
            return this.employeeID + " " + this.userName + " " + " " + this.firstName + " " + this.lastName + " ";
        }
    }
}
