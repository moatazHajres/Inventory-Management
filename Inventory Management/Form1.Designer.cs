
namespace Inventory_Management
{
    partial class Form1
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
            this.StockDgv = new System.Windows.Forms.DataGridView();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.CategoriesManageBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.AuthBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDgv
            // 
            this.StockDgv.AllowUserToAddRows = false;
            this.StockDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDgv.Location = new System.Drawing.Point(8, 79);
            this.StockDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StockDgv.Name = "StockDgv";
            this.StockDgv.RowHeadersWidth = 62;
            this.StockDgv.RowTemplate.Height = 29;
            this.StockDgv.Size = new System.Drawing.Size(784, 363);
            this.StockDgv.TabIndex = 0;
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Location = new System.Drawing.Point(8, 8);
            this.ProductsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(84, 31);
            this.ProductsBtn.TabIndex = 1;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // CategoriesManageBtn
            // 
            this.CategoriesManageBtn.Location = new System.Drawing.Point(96, 8);
            this.CategoriesManageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriesManageBtn.Name = "CategoriesManageBtn";
            this.CategoriesManageBtn.Size = new System.Drawing.Size(84, 31);
            this.CategoriesManageBtn.TabIndex = 2;
            this.CategoriesManageBtn.Text = "Categories";
            this.CategoriesManageBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(8, 51);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchTxt.Multiline = true;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(674, 25);
            this.SearchTxt.TabIndex = 3;
            // 
            // AuthBtn
            // 
            this.AuthBtn.Location = new System.Drawing.Point(708, 8);
            this.AuthBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(84, 31);
            this.AuthBtn.TabIndex = 5;
            this.AuthBtn.Text = "Login";
            this.AuthBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(685, 51);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 24);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AuthBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.CategoriesManageBtn);
            this.Controls.Add(this.ProductsBtn);
            this.Controls.Add(this.StockDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockDgv;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Button CategoriesManageBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}

