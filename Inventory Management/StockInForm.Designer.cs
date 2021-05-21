
namespace Inventory_Management
{
    partial class StockInForm
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
            this.ImportsDgv = new System.Windows.Forms.DataGridView();
            this.ProductsCmb = new System.Windows.Forms.ComboBox();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ProductCmbLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImportsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportsDgv
            // 
            this.ImportsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImportsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportsDgv.Location = new System.Drawing.Point(8, 75);
            this.ImportsDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImportsDgv.Name = "ImportsDgv";
            this.ImportsDgv.RowHeadersWidth = 62;
            this.ImportsDgv.RowTemplate.Height = 29;
            this.ImportsDgv.Size = new System.Drawing.Size(517, 225);
            this.ImportsDgv.TabIndex = 0;
            // 
            // ProductsCmb
            // 
            this.ProductsCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsCmb.FormattingEnabled = true;
            this.ProductsCmb.Location = new System.Drawing.Point(58, 9);
            this.ProductsCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductsCmb.Name = "ProductsCmb";
            this.ProductsCmb.Size = new System.Drawing.Size(469, 21);
            this.ProductsCmb.TabIndex = 1;
            // 
            // QuantityInput
            // 
            this.QuantityInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityInput.Location = new System.Drawing.Point(58, 31);
            this.QuantityInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(213, 20);
            this.QuantityInput.TabIndex = 2;
            // 
            // ImportBtn
            // 
            this.ImportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportBtn.Location = new System.Drawing.Point(275, 31);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(250, 25);
            this.ImportBtn.TabIndex = 3;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(8, 34);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(46, 13);
            this.QuantityLbl.TabIndex = 4;
            this.QuantityLbl.Text = "Quantity";
            // 
            // ProductCmbLbl
            // 
            this.ProductCmbLbl.AutoSize = true;
            this.ProductCmbLbl.Location = new System.Drawing.Point(8, 12);
            this.ProductCmbLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCmbLbl.Name = "ProductCmbLbl";
            this.ProductCmbLbl.Size = new System.Drawing.Size(44, 13);
            this.ProductCmbLbl.TabIndex = 5;
            this.ProductCmbLbl.Text = "Product";
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 308);
            this.Controls.Add(this.ProductCmbLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.ProductsCmb);
            this.Controls.Add(this.ImportsDgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockInForm";
            this.Text = "Stock In Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockInForm_FormClosed);
            this.Load += new System.EventHandler(this.StockInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImportsDgv;
        private System.Windows.Forms.ComboBox ProductsCmb;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label ProductCmbLbl;
    }
}