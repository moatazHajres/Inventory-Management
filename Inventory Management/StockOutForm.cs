using System;
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
    public partial class StockOutForm : Form
    {
        StockRepository stockRepository;
        ProductRepository productRepository;
        public StockOutForm()
        {
            InitializeComponent();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            stockRepository = new StockRepository();
            productRepository = new ProductRepository();
            LoadProducts();
            ReloadExports();
            ProductsCmb.SelectedIndex = -1;
        }
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (ProductsCmb.SelectedIndex == -1 || QuantityInput.Value <= 0)
            {
                MessageBox.Show("✖ Please check you inputs");

                return;
            }

            stockRepository.Insert(new Stock()
            {
                Product = productRepository.Find(((Product)ProductsCmb.SelectedItem).Id),
                Quantity = (int)QuantityInput.Value*(-1)
            });

            ReloadExports();

            MessageBox.Show("✔ Export Added Successfully");
        }

        private void ProductsCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = ((Product)((ComboBox)sender).SelectedItem).Id;

            List<Stock> stocks = stockRepository.All();
            Stock stock = stocks.First(s => s.Product.Id == id);

            QuantityInput.Maximum = stock.Quantity;
        }

        private void LoadProducts()
        {
            ProductsCmb.DataSource = null;
            ProductsCmb.DisplayMember = "Name";
            ProductsCmb.ValueMember = "Id";
            ProductsCmb.DataSource = productRepository.All();
        }

        private void ReloadExports()
        {
            ExportsDgv.DataSource = null;
            ExportsDgv.DataSource = stockRepository.SearchBy("0", "quantity", "<");
            ExportsDgv.Columns["Id"].Visible = false;
        }
    }
}
