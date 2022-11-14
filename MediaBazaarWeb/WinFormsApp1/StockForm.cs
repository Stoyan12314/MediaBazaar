using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuissnessLogicLayer;
using DataAccessLayer;

namespace WinFormsApp1
{
    public partial class StockForm : Form
    {
        StockManager stockMng = new StockManager();
        AddStockForm addStock;
        public StockForm()
        {
            InitializeComponent();
            Display();
            addStock = new AddStockForm(this);
           
        }

        public void Display() {
            dgvStocks.DataSource = stockMng.DisplayStocks();
        }
        public void Search()
        {
            dgvStocks.DataSource = stockMng.SearchStocks(tbSearch.Text);
        }
        private void btnAddstock_Click(object sender, EventArgs e)
        {
            addStock.Clear();
            addStock.ShowDialog();
            
        }

        private void StockForm_Shown(object sender, EventArgs e)
        {

            Display();


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                addStock.Clear();
                addStock.id= dgvStocks.Rows[e.RowIndex].Cells[2].Value.ToString();
                addStock.stockName = dgvStocks.Rows[e.RowIndex].Cells[3].Value.ToString();
                addStock.quantity = dgvStocks.Rows[e.RowIndex].Cells[4].Value.ToString();

                addStock.UpdateInfo();
                addStock.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1) 
            {
                try
                {
                    MessageBox.Show("Are you sure you want to delete this stock?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    stockMng.DeleteStock(dgvStocks.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Stock not deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            return;
        }
    }
}
