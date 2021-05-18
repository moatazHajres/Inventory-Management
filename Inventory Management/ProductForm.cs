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
    public partial class ProductForm : Form
    {
        ProductRepository productRepository;
        private int selectedProductId = -1;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            EditProductBtn.Enabled = false;
            DeleteProductBtn.Enabled = false;
            productRepository = new ProductRepository();
            ProductsDgv.DataSource = productRepository.GetAll();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ProductNameTxt.Text) || String.IsNullOrWhiteSpace(ProductBarcodeTxt.Text))
            {
                MessageBox.Show("✖ Please make sure to fill all fields");
                
                return;
            }

            productRepository.Insert(new Product() {
                Name = ProductNameTxt.Text,
                Barcode = ProductBarcodeTxt.Text,
                Price = (Double)ProductPriceInput.Value
            });

            ResetForm();
            ReloadProducts();

            MessageBox.Show("✔ Product Added Successfully");

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

        public void ResetForm()
        {
            selectedProductId = -1;
            EditProductBtn.Enabled = false;
            DeleteProductBtn.Enabled = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
                else if(ctrl.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }
            }
        }

        private void ProductsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                EditProductBtn.Enabled = true;
                DeleteProductBtn.Enabled = true;
                ProductNameTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                ProductBarcodeTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Barcode"].Value.ToString();
                ProductPriceInput.Value = Decimal.Parse(ProductsDgv.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                selectedProductId = (int)ProductsDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if (selectedProductId > 0)
            {
                productRepository.Update(selectedProductId, new Product()
                {
                    Name = ProductNameTxt.Text,
                    Barcode = ProductBarcodeTxt.Text,
                    Price = (Double)ProductPriceInput.Value
                });

                ResetForm();
                ReloadProducts();

                MessageBox.Show("✔ Product Updated Successfully");
            }
        }

        private void ProductsDgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                EditProductBtn.Enabled = true;
                DeleteProductBtn.Enabled = true;
                ProductNameTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                ProductBarcodeTxt.Text = ProductsDgv.Rows[e.RowIndex].Cells["Barcode"].Value.ToString();
                ProductPriceInput.Value = Decimal.Parse(ProductsDgv.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                selectedProductId = (int)ProductsDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (selectedProductId > 0)
            {
                productRepository.Delete(selectedProductId);

                ResetForm();
                ReloadProducts();

                MessageBox.Show("✔ Product Deleted Successfully");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchProductsTxt.Text))
            {
                MessageBox.Show("✖ Please check your input");

                return;
            }

            List<Product> results = productRepository.Search(SearchProductsTxt.Text);
            
            if (results.Count > 0)
            {
                ProductsDgv.DataSource = null;
                ProductsDgv.DataSource = results;
            } 
            else
            {
                MessageBox.Show("✖ No results was found");

                return;
            }
        }

        private void SearchProductsTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn_Click(this, new EventArgs());
            }
        }

        private void ResetFieldsBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
