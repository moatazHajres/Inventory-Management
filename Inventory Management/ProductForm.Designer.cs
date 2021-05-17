
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
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).BeginInit();
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
            this.ProductsDgv.Location = new System.Drawing.Point(258, 60);
            this.ProductsDgv.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsDgv.Name = "ProductsDgv";
            this.ProductsDgv.RowHeadersWidth = 62;
            this.ProductsDgv.RowTemplate.Height = 29;
            this.ProductsDgv.Size = new System.Drawing.Size(484, 237);
            this.ProductsDgv.TabIndex = 0;
            this.ProductsDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDgv_CellDoubleClick);
            this.ProductsDgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsDgv_RowHeaderMouseClick);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(8, 27);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNameTxt.Multiline = true;
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(246, 30);
            this.ProductNameTxt.TabIndex = 1;
            // 
            // ProductBarcodeTxt
            // 
            this.ProductBarcodeTxt.Location = new System.Drawing.Point(8, 75);
            this.ProductBarcodeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ProductBarcodeTxt.Multiline = true;
            this.ProductBarcodeTxt.Name = "ProductBarcodeTxt";
            this.ProductBarcodeTxt.Size = new System.Drawing.Size(246, 30);
            this.ProductBarcodeTxt.TabIndex = 2;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(8, 109);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(246, 29);
            this.AddProductBtn.TabIndex = 3;
            this.AddProductBtn.Text = "Save Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(5, 12);
            this.ProductNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(35, 13);
            this.ProductNameLbl.TabIndex = 4;
            this.ProductNameLbl.Text = "Name";
            // 
            // ProductBarcodeLbl
            // 
            this.ProductBarcodeLbl.AutoSize = true;
            this.ProductBarcodeLbl.Location = new System.Drawing.Point(5, 60);
            this.ProductBarcodeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductBarcodeLbl.Name = "ProductBarcodeLbl";
            this.ProductBarcodeLbl.Size = new System.Drawing.Size(47, 13);
            this.ProductBarcodeLbl.TabIndex = 5;
            this.ProductBarcodeLbl.Text = "Barcode";
            // 
            // SearchProductsTxt
            // 
            this.SearchProductsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProductsTxt.Location = new System.Drawing.Point(258, 27);
            this.SearchProductsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchProductsTxt.Multiline = true;
            this.SearchProductsTxt.Name = "SearchProductsTxt";
            this.SearchProductsTxt.Size = new System.Drawing.Size(276, 30);
            this.SearchProductsTxt.TabIndex = 6;
            // 
            // ReloadProductsBtn
            // 
            this.ReloadProductsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadProductsBtn.Location = new System.Drawing.Point(642, 27);
            this.ReloadProductsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReloadProductsBtn.Name = "ReloadProductsBtn";
            this.ReloadProductsBtn.Size = new System.Drawing.Size(100, 30);
            this.ReloadProductsBtn.TabIndex = 7;
            this.ReloadProductsBtn.Text = "Reload Products";
            this.ReloadProductsBtn.UseVisualStyleBackColor = true;
            this.ReloadProductsBtn.Click += new System.EventHandler(this.ReloadProductsBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(538, 27);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 30);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search";
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(8, 142);
            this.EditProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(246, 29);
            this.EditProductBtn.TabIndex = 10;
            this.EditProductBtn.Text = "Update Product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(8, 175);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(246, 29);
            this.DeleteProductBtn.TabIndex = 11;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 308);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).EndInit();
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
    }
}