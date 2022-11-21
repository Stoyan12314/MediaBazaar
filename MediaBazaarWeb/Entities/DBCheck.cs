using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBCheck
    {
        public MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");

        public bool checkForRepShift(int user_id, string date)
        {
			try
			{
               
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM shift where user_id = @id and day_shift = @shift";
                cmd.Parameters.AddWithValue("@id", user_id);
                cmd.Parameters.AddWithValue("@shift", date);
                if (cmd.ExecuteScalar() != null)
                {
                    return false;
                }
                return true;
            }
			catch (Exception)
			{

				throw;
			}
            finally { conn.Close(); }
        }
    }
}
