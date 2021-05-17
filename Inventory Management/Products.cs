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
    public partial class Products : Form
    {
        ProductRepository productRepository;
        private int ProductIdToUpdate = -1;
        private int ProductIdToDelete = -1;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            ProductsDgv.DataSource = productRepository.GetAll();
            EditProductBtn.Enabled = false;
            DeleteProductBtn.Enabled = false;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(ProductNameTxt.Text) || String.IsNullOrWhiteSpace(ProductBarcodeTxt.Text))
            {
                MessageBox.Show("Please make sure to fill both fields");
                
                return;
            }

            productRepository.Insert(new Product() {
                Name = ProductNameTxt.Text,
                Barcode = ProductBarcodeTxt.Text
            });

            MessageBox.Show("Product Added !");

            ResetFields();
            ReloadProducts();

        }

        private void ReloadProductsBtn_Click(object sender, EventArgs e)
        {
            ReloadProducts();
        }

        public void ReloadProducts()
        {
            ProductsDgv.DataSource = null;
            ProductsDgv.DataSource = productRepository.GetAll();
        }

        public void ResetFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
            }
        }

        private void ProductsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                EditProductBtn.Enabled = true;
                ProductNameTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                ProductBarcodeTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Barcode"].Value.ToString();
                ProductIdToUpdate = (int)ProductsDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if(ProductIdToUpdate > 0)
            {
                productRepository.Update(ProductIdToUpdate, new Product()
                {
                    Name = ProductNameTxt.Text,
                    Barcode = ProductBarcodeTxt.Text
                });

                MessageBox.Show("Product Updated !");

                ResetFields();
                ReloadProducts();
                ProductIdToUpdate = -1;
                EditProductBtn.Enabled = false;
            }
        }

        private void ProductsDgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DeleteProductBtn.Enabled = true;
                ProductIdToDelete = (int)ProductsDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductIdToDelete > 0)
            {
                productRepository.Delete(ProductIdToUpdate);

                MessageBox.Show("Product Deleted !");

                ReloadProducts();
                ProductIdToDelete = -1;
                DeleteProductBtn.Enabled = false;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchProductsTxt.Text))
            {
                MessageBox.Show("Please check you input");

                return;
            }

            List<Product> results = productRepository.Search(SearchProductsTxt.Text);
            
            if(results.Count > 0)
            {
                ProductsDgv.DataSource = null;
                ProductsDgv.DataSource = results;
            } 
            else
            {
                MessageBox.Show("No redults was found !");

                return;
            }
        }
    }
}
