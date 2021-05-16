
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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.CategoriesManageBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchByCmb = new System.Windows.Forms.ComboBox();
            this.AuthBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDgv
            // 
            this.StockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDgv.Location = new System.Drawing.Point(12, 116);
            this.StockDgv.Name = "StockDgv";
            this.StockDgv.RowHeadersWidth = 62;
            this.StockDgv.RowTemplate.Height = 29;
            this.StockDgv.Size = new System.Drawing.Size(1176, 530);
            this.StockDgv.TabIndex = 0;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(12, 12);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(126, 45);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            // 
            // CategoriesManageBtn
            // 
            this.CategoriesManageBtn.Location = new System.Drawing.Point(144, 12);
            this.CategoriesManageBtn.Name = "CategoriesManageBtn";
            this.CategoriesManageBtn.Size = new System.Drawing.Size(126, 45);
            this.CategoriesManageBtn.TabIndex = 2;
            this.CategoriesManageBtn.Text = "Categories";
            this.CategoriesManageBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(12, 83);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(882, 27);
            this.SearchTxt.TabIndex = 3;
            // 
            // SearchByCmb
            // 
            this.SearchByCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByCmb.FormattingEnabled = true;
            this.SearchByCmb.Location = new System.Drawing.Point(900, 83);
            this.SearchByCmb.Name = "SearchByCmb";
            this.SearchByCmb.Size = new System.Drawing.Size(121, 27);
            this.SearchByCmb.TabIndex = 4;
            // 
            // AuthBtn
            // 
            this.AuthBtn.Location = new System.Drawing.Point(1062, 12);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(126, 45);
            this.AuthBtn.TabIndex = 5;
            this.AuthBtn.Text = "Login";
            this.AuthBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1027, 83);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(161, 27);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AuthBtn);
            this.Controls.Add(this.SearchByCmb);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.CategoriesManageBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.StockDgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockDgv;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button CategoriesManageBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SearchByCmb;
        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}

