using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public class UserDB
    {
       // private string connectionString = "Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;";
        public MySqlConnection sc = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");

        public List<Employee> FetchData()
        {
            //counter = _counter;
            //post = _post;
            try
            {
                List<Employee> listOfEmployees = new List<Employee>();
                sc.Open();
                MySqlCommand command = new MySqlCommand("select user_id, user_name, first_name, last_name, shift From users", sc);
                MySqlDataReader srd = command.ExecuteReader();
               
                while (srd.Read())
                {

                    Employee employee = new Employee();
                    employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                    employee.UserName = srd.GetValue(1).ToString();
                    employee.getFName = srd.GetValue(2).ToString();
                    employee.getLName = srd.GetValue(3).ToString();
                    Shifts shift = (Shifts)Enum.Parse(typeof(Shifts), srd["shift"].ToString());
                    employee.GetShifts = shift;
                    listOfEmployees.Add(employee);
                }
                return listOfEmployees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                sc.Close();
            }
        }
        public void SearchEmployee(string fName, string lName, List<Employee> listOfEmployees, Employee employee)
        {

            try
            {

                sc.Open();
                MySqlCommand command = new MySqlCommand("select user_id, user_name, first_name, last_name  From users WHERE first_name = '" + fName + "'OR last_name = '" + lName + "'", sc);
                MySqlDataReader srd = command.ExecuteReader();
                listOfEmployees.Clear();
                while (srd.Read())
                {
                    employee = new Employee();

                    employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                    employee.UserName = srd.GetValue(1).ToString();
                    employee.getFName = srd.GetValue(2).ToString();
                    employee.getLName = srd.GetValue(3).ToString();


                    listOfEmployees.Add(employee);
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                string error = $"There is an error with the database";
            }
        }
        public void UpdateShift(Employee employee, Shifts shift)
        {
            try
            {
                sc.Open();
            
                var cmd = sc.CreateCommand();
                cmd.CommandText = "Update users set shift = @shift where user_id = @id";
                cmd.Parameters.AddWithValue("@id", employee.getEmployeeID);
                cmd.Parameters.AddWithValue("@shift", shift.ToString());
                cmd.ExecuteNonQuery();
              
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                sc.Close();
            }
        }
        public void SearchEmployeeByID(int Id, List<Employee> listOfEmployees, Employee employee)
        {

            try
            {

                sc.Open();
                MySqlCommand command = new MySqlCommand("select user_id, user_name, first_name, last_name, shift From users WHERE user_id = '" + Id + "'", sc);
                MySqlDataReader srd = command.ExecuteReader();
                listOfEmployees.Clear();
                while (srd.Read())
                {
                    //employee = new Employees();

                    //employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                    //employee.getFName = srd.GetValue(1).ToString();
                    //employee.getLName = srd.GetValue(2).ToString();

                     employee = new Employee();
                    employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                    employee.UserName = srd.GetValue(1).ToString();
                    employee.getFName = srd.GetValue(2).ToString();
                    employee.getLName = srd.GetValue(3).ToString();
                    Shifts shift = (Shifts)Enum.Parse(typeof(Shifts), srd["shift"].ToString());
                    employee.GetShifts = shift;
                    listOfEmployees.Add(employee);

                  //  listOfEmployees.Add(employee);
                }
            }
            catch (Exception ex)
            {
                string error = $"There is an error with the database";
            }
            finally
            {
                sc.Close();
            }
        }


        public bool logInUser(string username, string password, Employee employee)
        {
            string InsertQuery = "SELECT user_name, password FROM users where user_name = @username and password = @password";

            sc.Open();
            MySqlCommand cmd = new MySqlCommand(InsertQuery, sc);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                employee = new Employee();
                employee.UserName = username;
                return true;
                
            }
            else
            {
                return false;

            }
            sc.Close();
        }
    }
}
