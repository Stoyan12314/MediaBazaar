using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Entities;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class ShiftDB
    {
        public MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");
        
        public List<Shift> GetAllShift()
        {
			try
			{
                List<Shift> listOfShifts = new List<Shift>();
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM shift ", conn);
                MySqlDataReader srd = command.ExecuteReader();
                listOfShifts.Clear();
                while (srd.Read())
                {
                    ShiftType shiftType = Enum.Parse<ShiftType>(srd.GetString("shift"));
                    Shift shift = new Shift(Convert.ToInt32(srd.GetValue(0)), shiftType, Convert.ToDateTime(srd.GetValue(2)));
                    listOfShifts.Add(shift);
                }
                return listOfShifts;
            }
			catch (Exception)
			{

                return null;
			}
            finally 
            { conn.Close(); }
        }
        public void SetShift(int employee_id, ShiftType shiftType, string dayShift)
        {
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO shift SET user_id = @user_id, shift = @shift, day_shift = @dayShift", conn);
                cmd.Parameters.AddWithValue("@user_id", employee_id);
                cmd.Parameters.AddWithValue("@shift", shiftType.ToString());
                cmd.Parameters.AddWithValue("@dayShift", dayShift);
               

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
             {
                conn.Close();
             }
        }
        public void DeleteShift(int employee_id, string dayShift)
        {
            try
            {
                conn.Open();
                
                var cmd = new MySqlCommand("DELETE FROM shift WHERE user_id = @user_id and day_shift = @dayShift;", conn);
                cmd.Parameters.AddWithValue("@user_id", employee_id);
                cmd.Parameters.AddWithValue("@dayShift", dayShift);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}
