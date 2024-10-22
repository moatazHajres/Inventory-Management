﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management.Repositories;
using Inventory_Management.Entities;

namespace Inventory_Management
{
    public partial class StockInForm : Form
    {
        StockRepository stockRepository;
        ProductRepository productRepository;
        private Main mainForm;

        public StockInForm(Main parent)
        {
            InitializeComponent();
            mainForm = parent;
        }
        private void StockInForm_Load(object sender, EventArgs e)
        {
            stockRepository = new StockRepository();
            productRepository = new ProductRepository();
            LoadProducts();
            ReloadImports();
            ProductsCmb.SelectedIndex = -1;
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (ProductsCmb.SelectedIndex == -1 || QuantityInput.Value <= 0)
            {
                MessageBox.Show("✖ Please check you inputs");

                return;
            }

            stockRepository.Insert(new Stock()
            {
                Product = productRepository.Find(((Product)ProductsCmb.SelectedItem).Id),
                Quantity = (int)QuantityInput.Value
            });

            ReloadImports();

            MessageBox.Show("✔ Import Added Successfully");
        }

        private void LoadProducts()
        {
            ProductsCmb.DataSource = null;
            ProductsCmb.DisplayMember = "Name";
            ProductsCmb.ValueMember = "Id";
            ProductsCmb.DataSource = productRepository.All();
        }

        private void ReloadImports()
        {
            List<Stock> stocks = stockRepository.SearchBy("0", "quantity", ">");
            var stocksList = (from stock in stocks
                              select new
                              {
                                  Product = stock.Product.Name,
                                  Barcode = stock.Product.Barcode,
                                  Price = stock.Product.Price,
                                  Quantity = stock.Quantity

                              }).ToList();
            ImportsDgv.DataSource = null;
            ImportsDgv.DataSource = stocksList;
        }

        private void StockInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.LoadStocks();
        }
    }
}
