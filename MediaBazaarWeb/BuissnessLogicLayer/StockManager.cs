using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using BuissnessLogicLayer;
using DataAccessLayer;
using System.Data;

namespace BuissnessLogicLayer
{
    public class StockManager
    {
        StockDB stockDB;
        
        

        public StockManager()
        {
            stockDB = new StockDB();
        }
        public void AddStock(Stock stock)
        {
            stockDB.AddStock(stock);
        }
        public void UpdateStock(Stock stock, string id)
        {
            stockDB.UpdateStock(stock, id);
        }
        public void DeleteStock(string id)
        {
            stockDB.DeleteStock(id);
        }
        public DataTable DisplayStocks()
        {
            return stockDB.DisplayStocks();
        }

        public DataTable SearchStocks(string name)
        {
            return stockDB.SearchStocks(name);
        }
    }
}
