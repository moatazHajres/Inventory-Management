
namespace Inventory_Management
{
    partial class StockOutForm
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
            this.ProductCmbLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.ProductsCmb = new System.Windows.Forms.ComboBox();
            this.ExportsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCmbLbl
            // 
            this.ProductCmbLbl.AutoSize = true;
            this.ProductCmbLbl.Location = new System.Drawing.Point(12, 18);
            this.ProductCmbLbl.Name = "ProductCmbLbl";
            this.ProductCmbLbl.Size = new System.Drawing.Size(63, 19);
            this.ProductCmbLbl.TabIndex = 11;
            this.ProductCmbLbl.Text = "Product";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(12, 50);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(69, 19);
            this.QuantityLbl.TabIndex = 10;
            this.QuantityLbl.Text = "Quantity";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Location = new System.Drawing.Point(412, 45);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(375, 37);
            this.ExportBtn.TabIndex = 9;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityInput.Location = new System.Drawing.Point(87, 45);
            this.QuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(320, 27);
            this.QuantityInput.TabIndex = 8;
            this.QuantityInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityInput_KeyUp);
            // 
            // ProductsCmb
            // 
            this.ProductsCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsCmb.FormattingEnabled = true;
            this.ProductsCmb.Location = new System.Drawing.Point(87, 13);
            this.ProductsCmb.Name = "ProductsCmb";
            this.ProductsCmb.Size = new System.Drawing.Size(702, 27);
            this.ProductsCmb.TabIndex = 7;
            this.ProductsCmb.SelectionChangeCommitted += new System.EventHandler(this.ProductsCmb_SelectionChangeCommitted);
            // 
            // ExportsDgv
            // 
            this.ExportsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExportsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportsDgv.Location = new System.Drawing.Point(12, 110);
            this.ExportsDgv.Name = "ExportsDgv";
            this.ExportsDgv.RowHeadersWidth = 62;
            this.ExportsDgv.RowTemplate.Height = 29;
            this.ExportsDgv.Size = new System.Drawing.Size(776, 329);
            this.ExportsDgv.TabIndex = 6;
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductCmbLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.ProductsCmb);
            this.Controls.Add(this.ExportsDgv);
            this.Name = "StockOutForm";
            this.Text = "Stock Out Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockOutForm_FormClosed);
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductCmbLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.ComboBox ProductsCmb;
        private System.Windows.Forms.DataGridView ExportsDgv;
    }
}