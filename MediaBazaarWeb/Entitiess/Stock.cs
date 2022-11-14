using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Stock
    {
        public int stockID { get; }
        public string stockName { get; set; }
        public int stockQuantity { get; set; }


        public Stock(string stockName, int stockQuantity)
        {
            this.stockName = stockName;
            this.stockQuantity = stockQuantity;
        }
    }
}
