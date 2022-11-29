using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using Entities;
namespace DataAccessLayer
{
    public class UserDB
    {
        public MySqlConnection sc = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");

        public List<Employee> FetchData()
        {
            //counter = _counter;
            //post = _post;
            try
            {

                List<Employee> listOfEmployees = new List<Employee>();
                sc.Open();

                MySqlCommand command = new MySqlCommand(" select * from users", sc);
                MySqlDataReader srd = command.ExecuteReader();
               
                while (srd.Read())
                {
                    AccountType accType = Enum.Parse<AccountType>(srd.GetString("accountType"));

                    if (accType == AccountType.Employee)
                    {
                        Employee employee = new Employee();
                        employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                        employee.UserName = srd.GetValue(1).ToString();
                        employee.getFName = srd.GetValue(2).ToString();
                        employee.getLName = srd.GetValue(3).ToString();
                        employee.Address = srd.GetValue(4).ToString();  
                        employee.Password = srd.GetValue(5).ToString();
                        employee.Email = srd.GetValue(6).ToString();
                        employee.DateOfBirh = Convert.ToDateTime(srd.GetValue(7));

                      
                        listOfEmployees.Add(employee);
                        
                    }
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
 
        public List<Employee> SearchEmployee(string fName, string lName, Employee employee)
        {
            try
            {
                List<Employee> listOfEmployees = new List<Employee>();
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
                return listOfEmployees;


            }
            catch (Exception)
            {

                throw;
            }
            finally { sc.Close(); } 
           
            
               
            
           

        }
        public void UpdateShift(Employee employee, ShiftType shift, DateTime date)
        {
            try
            {
                sc.Open();
            
                var cmd = sc.CreateCommand();
                cmd.CommandText = "Update shift set user_id = @user_id and shift = @shift and day_shift= @day_shift";
               // cmd.CommandText = "Update users set shift = @shift and day_shift=@date where user_id = @id";
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@user_id", employee.getEmployeeID);
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

        

        public List<Employee> SearchEmployeeByID(int Id,  Employee employee)
        {
            try
            {
                List<Employee> listOfEmployees = new List<Employee>();
                sc.Open();
                MySqlCommand command = new MySqlCommand("select user_id, user_name, first_name, last_name From users WHERE user_id = '" + Id + "'", sc); //divide the shifts
                MySqlDataReader srd = command.ExecuteReader();
                listOfEmployees.Clear();
                while (srd.Read())
                {
                   
                     employee = new Employee();
                    employee = new Employee();
                    employee.getEmployeeID = Convert.ToInt32(srd.GetValue(0).ToString());
                    employee.UserName = srd.GetValue(1).ToString();
                    employee.getFName = srd.GetValue(2).ToString();
                    employee.getLName = srd.GetValue(3).ToString();
                //    ShiftType shift = (ShiftType)Enum.Parse(typeof(ShiftType), srd["shift"].ToString());
                  //  DateTime shiftDate = Convert.ToDateTime(srd.GetValue(10).ToString());
                  //  employee.CreateShift(shift, shiftDate);
                    listOfEmployees.Add(employee);
                }
                sc.Close();
                return listOfEmployees;
               
            }
            catch (Exception)
            {
                sc.Close();
                throw;
            }

          

        }


        public bool logInUser(string username, string password, Employee employee)
        {
            try
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
        public User logInAdministrator(string username, string password)
        {
            try
            {
                Admin admin = null;
                string InsertQuery = "SELECT user_name, password FROM users where user_name = @username and password = @password and accountType = @accType";
              //  SELECT user_name, password FROM users where user_name = 'Milan42161' and password = '123' or accountType = 'Admin'
                sc.Open();
                MySqlCommand cmd = new MySqlCommand(InsertQuery, sc);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@accType", "Admin");
                MySqlDataReader rd = cmd.ExecuteReader();
                //   MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //   DataTable dt = new DataTable();

                //   da.Fill(dt);

                if (rd.Read())
                {
                    admin = new Admin();
                    admin.UserName = username;
                    admin.Password = password;  
                }
                return admin;
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
        public void UpdateCredentials(Employee emp)
        {
            try
            {
                sc.Open();
                var cmd = new MySqlCommand("UPDATE users SET user_name = @user_name, first_name = @first_name, last_name = @last_name, address = @address, password = @password, email = @email, dateofbirth = @dateofbirth, accountType = @accType WHERE user_id = @id", sc);
                cmd.Parameters.AddWithValue("@id", emp.getEmployeeID);
                cmd.Parameters.AddWithValue("@user_name", emp.UserName);
                cmd.Parameters.AddWithValue("@first_name", emp.getFName);
                cmd.Parameters.AddWithValue("@last_name", emp.getLName);
                cmd.Parameters.AddWithValue("@address", emp.Address);
                cmd.Parameters.AddWithValue("@password", emp.Password);
                cmd.Parameters.AddWithValue("@email", emp.Email);
                cmd.Parameters.AddWithValue("@dateofbirth", emp.DateOfBirh);
                cmd.Parameters.AddWithValue("@accType", emp.AccType.ToString());

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public bool logInUser(string username, string password, Employee employee)
        //{
        //    string InsertQuery = "SELECT user_name, password FROM users where user_name = @username and password = @password";

        //    sc.Open();
        //    MySqlCommand cmd = new MySqlCommand(InsertQuery, sc);

        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.Parameters.AddWithValue("@password", password);

        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();

        //    da.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        employee = new Employee();
        //        employee.UserName = username;
        //        return true;

        //    }
        //    else
        //    {
        //        return false;

        //    }

        //    sc.Close();
        //}
    }
}
