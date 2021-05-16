
namespace Inventory_Management
{
    partial class CategoriesManagement
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
            this.CategoriesDgv = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.AddTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesDgv
            // 
            this.CategoriesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDgv.Location = new System.Drawing.Point(13, 51);
            this.CategoriesDgv.Name = "CategoriesDgv";
            this.CategoriesDgv.RowHeadersWidth = 62;
            this.CategoriesDgv.RowTemplate.Height = 29;
            this.CategoriesDgv.Size = new System.Drawing.Size(331, 269);
            this.CategoriesDgv.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(239, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 27);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // AddTxt
            // 
            this.AddTxt.Location = new System.Drawing.Point(12, 12);
            this.AddTxt.Name = "AddTxt";
            this.AddTxt.Size = new System.Drawing.Size(221, 27);
            this.AddTxt.TabIndex = 2;
            // 
            // CategoriesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 332);
            this.Controls.Add(this.AddTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.CategoriesDgv);
            this.Name = "CategoriesManagement";
            this.Text = "CategoriesManagement";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDgv;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox AddTxt;
    }
}