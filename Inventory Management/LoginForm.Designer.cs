
namespace Inventory_Management
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UserPasswordLbl = new System.Windows.Forms.Label();
            this.UserEmailLbl = new System.Windows.Forms.Label();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(309, 328);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(118, 39);
            this.ClearBtn.TabIndex = 34;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // UserPasswordLbl
            // 
            this.UserPasswordLbl.AutoSize = true;
            this.UserPasswordLbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordLbl.Location = new System.Drawing.Point(29, 267);
            this.UserPasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserPasswordLbl.Name = "UserPasswordLbl";
            this.UserPasswordLbl.Size = new System.Drawing.Size(87, 19);
            this.UserPasswordLbl.TabIndex = 30;
            this.UserPasswordLbl.Text = "Password :";
            // 
            // UserEmailLbl
            // 
            this.UserEmailLbl.AutoSize = true;
            this.UserEmailLbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmailLbl.Location = new System.Drawing.Point(29, 191);
            this.UserEmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserEmailLbl.Name = "UserEmailLbl";
            this.UserEmailLbl.Size = new System.Drawing.Size(59, 19);
            this.UserEmailLbl.TabIndex = 31;
            this.UserEmailLbl.Text = "Email :";
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordTxt.Location = new System.Drawing.Point(33, 290);
            this.UserPasswordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.Size = new System.Drawing.Size(394, 30);
            this.UserPasswordTxt.TabIndex = 32;
            this.UserPasswordTxt.UseSystemPasswordChar = true;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.Location = new System.Drawing.Point(33, 214);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(394, 30);
            this.UserNameTxt.TabIndex = 29;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(33, 328);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(118, 39);
            this.LoginBtn.TabIndex = 33;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Management.Properties.Resources.login_logo;
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // DateTimeLbl
            // 
            this.DateTimeLbl.AutoSize = true;
            this.DateTimeLbl.Location = new System.Drawing.Point(5, 426);
            this.DateTimeLbl.Name = "DateTimeLbl";
            this.DateTimeLbl.Size = new System.Drawing.Size(83, 19);
            this.DateTimeLbl.TabIndex = 36;
            this.DateTimeLbl.Text = "Date-Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.DateTimeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.UserPasswordLbl);
            this.Controls.Add(this.UserEmailLbl);
            this.Controls.Add(this.UserPasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button ClearBtn;
        internal System.Windows.Forms.Label UserPasswordLbl;
        internal System.Windows.Forms.Label UserEmailLbl;
        internal System.Windows.Forms.TextBox UserPasswordTxt;
        internal System.Windows.Forms.TextBox UserNameTxt;
        internal System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DateTimeLbl;
        private System.Windows.Forms.Timer timer1;
    }
}