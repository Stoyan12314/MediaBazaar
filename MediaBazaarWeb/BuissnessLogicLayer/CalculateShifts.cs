using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLogicLayer
{
    public  class CalculateShifts
    {
        public static Dictionary<Employee, Shift> AssignShifts(List<Employee> employees, List<Shift> shifts)
        {
            Dictionary<Employee, Shift> sortedShifts = new Dictionary<Employee, Shift>();

                var mc = new CalculateShifts();
                foreach (Shift shift in shifts)
                {
              
                    Employee emp = mc.GetEmployee(shift.employeeId, employees);
                    if (emp != null)
                    {
                        if (sortedShifts.ContainsKey(emp))
                        {

                        }
                        else
                        {
                            sortedShifts.Add(emp, shift);
                        }
                    }
                    
                }
            return sortedShifts;
        }
        

        private  Employee GetEmployee(int employee_id, List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee.getEmployeeID == employee_id)
                {
                    return employee;
                }
            }
            return null;
        }


    }

  
}
