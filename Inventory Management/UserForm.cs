using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management.Repositories;
using Inventory_Management.Entities;

namespace Inventory_Management
{
    public partial class UserForm : Form
    {
        UserRepository userRepository;
        private int selectedUserId = -1;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            EditUserBtn.Enabled = false;
            DeleteUserBtn.Enabled = false;
            userRepository = new UserRepository();
            UsersDgv.DataSource = userRepository.All();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserNameTxt.Text) || String.IsNullOrWhiteSpace(UserEmailTxt.Text) || String.IsNullOrWhiteSpace(UserPasswordTxt.Text))
            {
                MessageBox.Show("✖ Please make sure to fill all fields");

                return;
            }

            List<User> results = userRepository.SearchBy(UserNameTxt.Text, "name");

            if (results.Count > 0)
            {
                MessageBox.Show("✖ User name already exists, please try diffrent name");

                return;
            }

            userRepository.Insert(new User()
            {
                Name = UserNameTxt.Text.ToLower().Trim(),
                Email = UserEmailTxt.Text,
                Password = UserPasswordTxt.Text
            });

            ResetForm();
            ReloadUsers();

            MessageBox.Show("✔ User Added Successfully");
        }

        private void ReloadUserssBtn_Click(object sender, EventArgs e)
        {
            ReloadUsers();
        }

        public void ReloadUsers()
        {
            UsersDgv.DataSource = null;
            UsersDgv.DataSource = userRepository.All();
        }

        public void ResetForm()
        {
            selectedUserId = -1;
            EditUserBtn.Enabled = false;
            DeleteUserBtn.Enabled = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
            }
        }

        private void UsersDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                EditUserBtn.Enabled = true;
                DeleteUserBtn.Enabled = true;
                UserNameTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                UserEmailTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                UserPasswordTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                selectedUserId = (int)UsersDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId > 0)
            {
                List<User> results = userRepository.SearchBy(UserNameTxt.Text, "name");

                if (results.Count > 0)
                {
                    MessageBox.Show("✖ User name already exists, please try diffrent name");

                    return;
                }

                userRepository.Update(selectedUserId, new User()
                {
                    Name = UserNameTxt.Text.ToLower().Trim(),
                    Email = UserEmailTxt.Text,
                    Password = UserPasswordTxt.Text
                });

                ResetForm();
                ReloadUsers();

                MessageBox.Show("✔ User Updated Successfully");
            }
        }

        private void UsersDgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                EditUserBtn.Enabled = true;
                DeleteUserBtn.Enabled = true;
                UserNameTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                UserEmailTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                UserPasswordTxt.Text = UsersDgv.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                selectedUserId = (int)UsersDgv.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId > 0)
            {
                userRepository.Delete(selectedUserId);

                ResetForm();
                ReloadUsers();

                MessageBox.Show("✔ User Deleted Successfully");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchUsersTxt.Text))
            {
                MessageBox.Show("✖ Please check your input");

                return;
            }

            List<User> results = userRepository.SearchAll(SearchUsersTxt.Text);

            if (results.Count > 0)
            {
                UsersDgv.DataSource = null;
                UsersDgv.DataSource = results;
            }
            else
            {
                MessageBox.Show("✖ No results was found");

                return;
            }
        }

        private void SearchUsersTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn_Click(this, new EventArgs());
            }
        }

        private void ResetFieldsBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
