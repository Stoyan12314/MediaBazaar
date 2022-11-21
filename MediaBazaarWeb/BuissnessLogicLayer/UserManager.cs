using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Entities;
namespace BuissnessLogicLayer
{
    public class UserManager
    {
        UserDB userDB;
        public UserManager()
        {
                userDB = new UserDB();  
        }
        public List<Employee> getAllEmployees()
        {
            return userDB.FetchData();
        }
        public bool checkLogin(string username, string password, Employee employee)
        {
            return userDB.logInUser( username,  password,  employee);
        }
        public User checkLoginAdministrator(string username, string password)
        {
            return userDB.logInAdministrator(username, password);
        }
        public List<Employee> SearchEmployee(string fName, string lName, Employee employee)
        {
            return userDB.SearchEmployee( fName,  lName,  employee);
        }
        public void UpdateShift(Employee employee, ShiftType shift, DateTime date)
        {
           userDB.UpdateShift(employee, shift, date);
        }
        public List<Employee> SearchEmployeeByID(int Id,  Employee employee)
        {

          return userDB.SearchEmployeeByID(Id,  employee); 
        }
        public void UpdateCredentials(Employee emp)
        {
            userDB.UpdateCredentials(emp);
        }
    }
}
