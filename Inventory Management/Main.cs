using Inventory_Management.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management.Entities;

namespace Inventory_Management
{
    public partial class Main : Form
    {
        StockRepository stockRepository = new StockRepository();
        Boolean loggedIn;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ChangeToLogoutStatus();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchTxt.Text))
            {
                MessageBox.Show("✖ Please check your input");

                return;
            }

            List<Stock> stocks = stockRepository.All();
            var stocksList = (from stock in stocks
                              where (stock.Product.Name.Contains(SearchTxt.Text) || stock.Product.Barcode.Contains(SearchTxt.Text))
                              select new
                              {
                                  Product = stock.Product.Name,
                                  Barcode = stock.Product.Barcode,
                                  Price = stock.Product.Price,
                                  Quantity = stock.Quantity

                              }).ToList();

            if (stocksList.Count > 0)
            {
                StockDgv.DataSource = null;
                StockDgv.DataSource = stocksList;
            }
            else
            {
                MessageBox.Show("✖ No results was found");

                return;
            }
        }

        private void ProductsManageBtn_Click(object sender, EventArgs e)
        {
            new ProductForm(this).ShowDialog();
        }

        private void UsersManageBtn_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                ChangeToLogoutStatus();
            }
            else
            {
                new LoginForm(this).ShowDialog();
            }
        }
        private void StockInBtn_Click(object sender, EventArgs e)
        {
            new StockInForm(this).ShowDialog();
        }
        private void StockOutBtn_Click(object sender, EventArgs e)
        {
            new StockOutForm(this).ShowDialog();
        }

        public void ChangeToLoginStatus()
        {
            ProductsManageBtn.Enabled = true;
            UsersManageBtn.Enabled = true;
            StockInBtn.Enabled = true;
            StockOutBtn.Enabled = true;
            SearchBtn.Enabled = true;
            ReloadStocksBtn.Enabled = true;
            SearchTxt.Enabled = true;
            loggedIn = true;
            LoadStocks();
            AuthBtn.Text = "Logout";
            AuthBtn.Image = Inventory_Management.Properties.Resources.logout;
        }

        private void ChangeToLogoutStatus()
        {
            ProductsManageBtn.Enabled = false;
            UsersManageBtn.Enabled = false;
            StockInBtn.Enabled = false;
            StockOutBtn.Enabled = false;
            SearchBtn.Enabled = false;
            ReloadStocksBtn.Enabled = false;
            SearchTxt.Enabled = false;
            StockDgv.DataSource = null;
            loggedIn = false;
            AuthBtn.Text = "Login";
            AuthBtn.Image = Inventory_Management.Properties.Resources.login;
        }

        private void ReloadStocksBtn_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }
        public void LoadStocks()
        {
            StockDgv.DataSource = null;
            List<Stock> stocks = stockRepository.All();
            var stocksList = (from stock in stocks
                              select new
                              {
                                  Product = stock.Product.Name,
                                  Barcode = stock.Product.Barcode,
                                  Price = stock.Product.Price,
                                  Quantity = stock.Quantity

                              }).ToList();

            StockDgv.DataSource = stocksList;
        }
    }
}
