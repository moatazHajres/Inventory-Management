
namespace Inventory_Management
{
    partial class Main
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
            this.ProductsManageBtn = new System.Windows.Forms.Button();
            this.UsersManageBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.AuthBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StockInBtn = new System.Windows.Forms.Button();
            this.StockOutBtn = new System.Windows.Forms.Button();
            this.ReloadStocksBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDgv
            // 
            this.StockDgv.AllowUserToAddRows = false;
            this.StockDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDgv.Location = new System.Drawing.Point(12, 115);
            this.StockDgv.Name = "StockDgv";
            this.StockDgv.RowHeadersWidth = 62;
            this.StockDgv.RowTemplate.Height = 29;
            this.StockDgv.Size = new System.Drawing.Size(1176, 531);
            this.StockDgv.TabIndex = 0;
            // 
            // ProductsManageBtn
            // 
            this.ProductsManageBtn.Location = new System.Drawing.Point(368, 12);
            this.ProductsManageBtn.Name = "ProductsManageBtn";
            this.ProductsManageBtn.Size = new System.Drawing.Size(195, 45);
            this.ProductsManageBtn.TabIndex = 1;
            this.ProductsManageBtn.Text = "Products Management";
            this.ProductsManageBtn.UseVisualStyleBackColor = true;
            this.ProductsManageBtn.Click += new System.EventHandler(this.ProductsManageBtn_Click);
            // 
            // UsersManageBtn
            // 
            this.UsersManageBtn.Location = new System.Drawing.Point(569, 12);
            this.UsersManageBtn.Name = "UsersManageBtn";
            this.UsersManageBtn.Size = new System.Drawing.Size(172, 45);
            this.UsersManageBtn.TabIndex = 2;
            this.UsersManageBtn.Text = "Users Management";
            this.UsersManageBtn.UseVisualStyleBackColor = true;
            this.UsersManageBtn.Click += new System.EventHandler(this.UsersManageBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.Location = new System.Drawing.Point(12, 75);
            this.SearchTxt.Multiline = true;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(931, 35);
            this.SearchTxt.TabIndex = 3;
            // 
            // AuthBtn
            // 
            this.AuthBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthBtn.Location = new System.Drawing.Point(1062, 12);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(126, 45);
            this.AuthBtn.TabIndex = 5;
            this.AuthBtn.Text = "Login";
            this.AuthBtn.UseVisualStyleBackColor = true;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(949, 75);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(118, 35);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StockInBtn
            // 
            this.StockInBtn.Location = new System.Drawing.Point(12, 12);
            this.StockInBtn.Name = "StockInBtn";
            this.StockInBtn.Size = new System.Drawing.Size(172, 45);
            this.StockInBtn.TabIndex = 7;
            this.StockInBtn.Text = "Stock In";
            this.StockInBtn.UseVisualStyleBackColor = true;
            this.StockInBtn.Click += new System.EventHandler(this.StockInBtn_Click);
            // 
            // StockOutBtn
            // 
            this.StockOutBtn.Location = new System.Drawing.Point(190, 12);
            this.StockOutBtn.Name = "StockOutBtn";
            this.StockOutBtn.Size = new System.Drawing.Size(172, 45);
            this.StockOutBtn.TabIndex = 8;
            this.StockOutBtn.Text = "Stock out";
            this.StockOutBtn.UseVisualStyleBackColor = true;
            this.StockOutBtn.Click += new System.EventHandler(this.StockOutBtn_Click);
            // 
            // ReloadStocksBtn
            // 
            this.ReloadStocksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadStocksBtn.Location = new System.Drawing.Point(1070, 75);
            this.ReloadStocksBtn.Name = "ReloadStocksBtn";
            this.ReloadStocksBtn.Size = new System.Drawing.Size(118, 35);
            this.ReloadStocksBtn.TabIndex = 9;
            this.ReloadStocksBtn.Text = "Reload";
            this.ReloadStocksBtn.UseVisualStyleBackColor = true;
            this.ReloadStocksBtn.Click += new System.EventHandler(this.ReloadStocksBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.ReloadStocksBtn);
            this.Controls.Add(this.StockOutBtn);
            this.Controls.Add(this.StockInBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AuthBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.UsersManageBtn);
            this.Controls.Add(this.ProductsManageBtn);
            this.Controls.Add(this.StockDgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockDgv;
        private System.Windows.Forms.Button ProductsManageBtn;
        private System.Windows.Forms.Button UsersManageBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button StockInBtn;
        private System.Windows.Forms.Button StockOutBtn;
        private System.Windows.Forms.Button ReloadStocksBtn;
    }
}

