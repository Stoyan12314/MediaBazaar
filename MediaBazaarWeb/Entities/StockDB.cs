using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Entities;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace DataAccessLayer
{
    public class StockDB
    {
        public MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi476548_app;Database=dbi476548_app;Pwd=Welcome01;");
   
        public void AddStock(Stock stock)
        { 
            string sql = "INSERT INTO stock(stock_name, quantity)Values('" + stock.stockName + "','" + stock.stockQuantity +"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateStock(Stock stock, string id)
        {
            string sql = "UPDATE stock SET stock_name = '"+stock.stockName+"', quantity = '"+stock.stockQuantity+ "' WHERE stock_id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteStock(string id) 
        {
            string sql = "DELETE FROM stock WHERE stock_id = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public DataTable DisplayStocks()
        {
            string sql = "SELECT stock_id, stock_name, quantity FROM stock";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            return dt;

        }

        public DataTable SearchStocks(string name)
        {
            string sql = "SELECT stock_id, stock_name, quantity FROM stock WHERE stock_name LIKE '%"+name+"%'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            return dt;

        }
    }
}
