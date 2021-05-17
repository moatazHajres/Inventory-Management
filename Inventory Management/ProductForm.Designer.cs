
namespace Inventory_Management
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsDgv = new System.Windows.Forms.DataGridView();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductBarcodeTxt = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductBarcodeLbl = new System.Windows.Forms.Label();
            this.SearchProductsTxt = new System.Windows.Forms.TextBox();
            this.ReloadProductsBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ResetFieldsBtn = new System.Windows.Forms.Button();
            this.ProductPriceInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDgv
            // 
            this.ProductsDgv.AllowUserToAddRows = false;
            this.ProductsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDgv.Location = new System.Drawing.Point(387, 88);
            this.ProductsDgv.Name = "ProductsDgv";
            this.ProductsDgv.RowHeadersWidth = 62;
            this.ProductsDgv.RowTemplate.Height = 29;
            this.ProductsDgv.Size = new System.Drawing.Size(726, 346);
            this.ProductsDgv.TabIndex = 0;
            this.ProductsDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDgv_CellDoubleClick);
            this.ProductsDgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsDgv_RowHeaderMouseClick);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(12, 39);
            this.ProductNameTxt.Multiline = true;
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(367, 42);
            this.ProductNameTxt.TabIndex = 1;
            // 
            // ProductBarcodeTxt
            // 
            this.ProductBarcodeTxt.Location = new System.Drawing.Point(12, 110);
            this.ProductBarcodeTxt.Multiline = true;
            this.ProductBarcodeTxt.Name = "ProductBarcodeTxt";
            this.ProductBarcodeTxt.Size = new System.Drawing.Size(367, 42);
            this.ProductBarcodeTxt.TabIndex = 2;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(12, 226);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(369, 42);
            this.AddProductBtn.TabIndex = 3;
            this.AddProductBtn.Text = "Save Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(8, 18);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(50, 19);
            this.ProductNameLbl.TabIndex = 4;
            this.ProductNameLbl.Text = "Name";
            // 
            // ProductBarcodeLbl
            // 
            this.ProductBarcodeLbl.AutoSize = true;
            this.ProductBarcodeLbl.Location = new System.Drawing.Point(8, 88);
            this.ProductBarcodeLbl.Name = "ProductBarcodeLbl";
            this.ProductBarcodeLbl.Size = new System.Drawing.Size(65, 19);
            this.ProductBarcodeLbl.TabIndex = 5;
            this.ProductBarcodeLbl.Text = "Barcode";
            // 
            // SearchProductsTxt
            // 
            this.SearchProductsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProductsTxt.Location = new System.Drawing.Point(387, 39);
            this.SearchProductsTxt.Multiline = true;
            this.SearchProductsTxt.Name = "SearchProductsTxt";
            this.SearchProductsTxt.Size = new System.Drawing.Size(412, 42);
            this.SearchProductsTxt.TabIndex = 6;
            this.SearchProductsTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductsTxt_KeyDown);
            // 
            // ReloadProductsBtn
            // 
            this.ReloadProductsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadProductsBtn.Location = new System.Drawing.Point(963, 39);
            this.ReloadProductsBtn.Name = "ReloadProductsBtn";
            this.ReloadProductsBtn.Size = new System.Drawing.Size(150, 44);
            this.ReloadProductsBtn.TabIndex = 7;
            this.ReloadProductsBtn.Text = "Reload Products";
            this.ReloadProductsBtn.UseVisualStyleBackColor = true;
            this.ReloadProductsBtn.Click += new System.EventHandler(this.ReloadProductsBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(807, 39);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(150, 44);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search";
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(12, 275);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(369, 42);
            this.EditProductBtn.TabIndex = 10;
            this.EditProductBtn.Text = "Update Product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(12, 323);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(369, 42);
            this.DeleteProductBtn.TabIndex = 11;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Location = new System.Drawing.Point(8, 156);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(43, 19);
            this.ProductPriceLbl.TabIndex = 13;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ResetFieldsBtn
            // 
            this.ResetFieldsBtn.Location = new System.Drawing.Point(12, 371);
            this.ResetFieldsBtn.Name = "ResetFieldsBtn";
            this.ResetFieldsBtn.Size = new System.Drawing.Size(369, 42);
            this.ResetFieldsBtn.TabIndex = 14;
            this.ResetFieldsBtn.Text = "Reset Fields";
            this.ResetFieldsBtn.UseVisualStyleBackColor = true;
            this.ResetFieldsBtn.Click += new System.EventHandler(this.ResetFieldsBtn_Click);
            // 
            // ProductPriceInput
            // 
            this.ProductPriceInput.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ProductPriceInput.Location = new System.Drawing.Point(12, 179);
            this.ProductPriceInput.Name = "ProductPriceInput";
            this.ProductPriceInput.Size = new System.Drawing.Size(367, 27);
            this.ProductPriceInput.TabIndex = 15;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.ProductPriceInput);
            this.Controls.Add(this.ResetFieldsBtn);
            this.Controls.Add(this.ProductPriceLbl);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ReloadProductsBtn);
            this.Controls.Add(this.SearchProductsTxt);
            this.Controls.Add(this.ProductBarcodeLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.ProductBarcodeTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.ProductsDgv);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDgv;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox ProductBarcodeTxt;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductBarcodeLbl;
        private System.Windows.Forms.TextBox SearchProductsTxt;
        private System.Windows.Forms.Button ReloadProductsBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Button ResetFieldsBtn;
        private System.Windows.Forms.NumericUpDown ProductPriceInput;
    }
}