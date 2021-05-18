
namespace Inventory_Management
{
    partial class UserForm
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
            this.ResetFieldsBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.UserSearchLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ReloadUserssBtn = new System.Windows.Forms.Button();
            this.SearchUsersTxt = new System.Windows.Forms.TextBox();
            this.UserEmailLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UserEmailTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.UsersDgv = new System.Windows.Forms.DataGridView();
            this.UserPasswordLbl = new System.Windows.Forms.Label();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetFieldsBtn
            // 
            this.ResetFieldsBtn.Location = new System.Drawing.Point(6, 255);
            this.ResetFieldsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetFieldsBtn.Name = "ResetFieldsBtn";
            this.ResetFieldsBtn.Size = new System.Drawing.Size(246, 29);
            this.ResetFieldsBtn.TabIndex = 23;
            this.ResetFieldsBtn.Text = "Reset Fields";
            this.ResetFieldsBtn.UseVisualStyleBackColor = true;
            this.ResetFieldsBtn.Click += new System.EventHandler(this.ResetFieldsBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(6, 222);
            this.DeleteUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(246, 29);
            this.DeleteUserBtn.TabIndex = 22;
            this.DeleteUserBtn.Text = "Delete User";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Location = new System.Drawing.Point(6, 189);
            this.EditUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(246, 29);
            this.EditUserBtn.TabIndex = 21;
            this.EditUserBtn.Text = "Update User";
            this.EditUserBtn.UseVisualStyleBackColor = true;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // UserSearchLbl
            // 
            this.UserSearchLbl.AutoSize = true;
            this.UserSearchLbl.Location = new System.Drawing.Point(253, 12);
            this.UserSearchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserSearchLbl.Name = "UserSearchLbl";
            this.UserSearchLbl.Size = new System.Drawing.Size(41, 13);
            this.UserSearchLbl.TabIndex = 25;
            this.UserSearchLbl.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(547, 26);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 30);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ReloadUserssBtn
            // 
            this.ReloadUserssBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadUserssBtn.Location = new System.Drawing.Point(651, 26);
            this.ReloadUserssBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReloadUserssBtn.Name = "ReloadUserssBtn";
            this.ReloadUserssBtn.Size = new System.Drawing.Size(97, 30);
            this.ReloadUserssBtn.TabIndex = 26;
            this.ReloadUserssBtn.Text = "Reload Users";
            this.ReloadUserssBtn.UseVisualStyleBackColor = true;
            this.ReloadUserssBtn.Click += new System.EventHandler(this.ReloadUserssBtn_Click);
            // 
            // SearchUsersTxt
            // 
            this.SearchUsersTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchUsersTxt.Location = new System.Drawing.Point(256, 26);
            this.SearchUsersTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchUsersTxt.Multiline = true;
            this.SearchUsersTxt.Name = "SearchUsersTxt";
            this.SearchUsersTxt.Size = new System.Drawing.Size(289, 30);
            this.SearchUsersTxt.TabIndex = 24;
            this.SearchUsersTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchUsersTxt_KeyDown);
            // 
            // UserEmailLbl
            // 
            this.UserEmailLbl.AutoSize = true;
            this.UserEmailLbl.Location = new System.Drawing.Point(3, 60);
            this.UserEmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserEmailLbl.Name = "UserEmailLbl";
            this.UserEmailLbl.Size = new System.Drawing.Size(36, 13);
            this.UserEmailLbl.TabIndex = 21;
            this.UserEmailLbl.Text = "*Email";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(3, 12);
            this.UserNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(39, 13);
            this.UserNameLbl.TabIndex = 20;
            this.UserNameLbl.Text = "*Name";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(6, 155);
            this.AddUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(246, 29);
            this.AddUserBtn.TabIndex = 20;
            this.AddUserBtn.Text = "Save User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UserEmailTxt
            // 
            this.UserEmailTxt.Location = new System.Drawing.Point(6, 75);
            this.UserEmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.UserEmailTxt.Multiline = true;
            this.UserEmailTxt.Name = "UserEmailTxt";
            this.UserEmailTxt.Size = new System.Drawing.Size(246, 30);
            this.UserEmailTxt.TabIndex = 18;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(6, 26);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(246, 30);
            this.UserNameTxt.TabIndex = 17;
            // 
            // UsersDgv
            // 
            this.UsersDgv.AllowUserToAddRows = false;
            this.UsersDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDgv.Location = new System.Drawing.Point(255, 60);
            this.UsersDgv.Margin = new System.Windows.Forms.Padding(2);
            this.UsersDgv.Name = "UsersDgv";
            this.UsersDgv.RowHeadersWidth = 62;
            this.UsersDgv.RowTemplate.Height = 29;
            this.UsersDgv.Size = new System.Drawing.Size(493, 240);
            this.UsersDgv.TabIndex = 27;
            this.UsersDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDgv_CellDoubleClick);
            this.UsersDgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDgv_RowHeaderMouseClick);
            // 
            // UserPasswordLbl
            // 
            this.UserPasswordLbl.AutoSize = true;
            this.UserPasswordLbl.Location = new System.Drawing.Point(3, 107);
            this.UserPasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserPasswordLbl.Name = "UserPasswordLbl";
            this.UserPasswordLbl.Size = new System.Drawing.Size(57, 13);
            this.UserPasswordLbl.TabIndex = 31;
            this.UserPasswordLbl.Text = "*Password";
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.Location = new System.Drawing.Point(6, 122);
            this.UserPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.UserPasswordTxt.Multiline = true;
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '*';
            this.UserPasswordTxt.Size = new System.Drawing.Size(246, 30);
            this.UserPasswordTxt.TabIndex = 19;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 308);
            this.Controls.Add(this.UserPasswordLbl);
            this.Controls.Add(this.UserPasswordTxt);
            this.Controls.Add(this.ResetFieldsBtn);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.UserSearchLbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ReloadUserssBtn);
            this.Controls.Add(this.SearchUsersTxt);
            this.Controls.Add(this.UserEmailLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UserEmailTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.UsersDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetFieldsBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.Label UserSearchLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ReloadUserssBtn;
        private System.Windows.Forms.TextBox SearchUsersTxt;
        private System.Windows.Forms.Label UserEmailLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.TextBox UserEmailTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.DataGridView UsersDgv;
        private System.Windows.Forms.Label UserPasswordLbl;
        private System.Windows.Forms.TextBox UserPasswordTxt;
    }
}