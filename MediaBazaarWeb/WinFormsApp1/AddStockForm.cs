using BuissnessLogicLayer;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddStockForm : Form
    {
        Stock stock;
        StockManager stockMg = new StockManager();

        public string id, stockName, quantity;


        

        private readonly StockForm _parent;

        public AddStockForm(StockForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            label1.Text = "Update Stock";
            btnAddstock.Text = "Update";
            tbName.Text = stockName;
            tbQuantity.Text = quantity;
        }

        public void Clear()
        {
            tbName.Text = tbQuantity.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAddstock_Click(object sender, EventArgs e)
        {
            if(btnAddstock.Text == "Update")
            {
                Stock stock = new Stock(tbName.Text.Trim(), Convert.ToInt32(tbQuantity.Text.Trim()));
                stockMg.UpdateStock(stock, id);
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                stock = new Stock(tbName.Text, Convert.ToInt32(tbQuantity.Text));
                try
                {
                    stockMg.AddStock(stock);
                    MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Stock not added! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _parent.Display();   

        }
    }
}
