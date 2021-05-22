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
    public partial class LoginForm : Form
    {
        UserRepository userRepository;
        private Main mainForm;

        public LoginForm(Main parent)
        {
            InitializeComponent();
            mainForm = parent;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeLbl.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Clear();

                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserNameTxt.Text) || String.IsNullOrWhiteSpace(UserPasswordTxt.Text))
            {
                MessageBox.Show("✖ Please make sure to fill both fields");

                return;
            }

            List<User> results = userRepository.SearchBy(UserNameTxt.Text.ToLower().Trim(), "name");

            if (results.Count < 1)
            {
                MessageBox.Show("✖ Invalid credentials");

                return;
            }

            if (!String.Equals((UserPasswordTxt.Text.GetHashCode()).ToString(), results[0].Password.ToString()))
            {
                MessageBox.Show("✖ Invalid credentials");

                return;
            }

            mainForm.ChangeToLoginStatus();
            this.Close();
        }

        private void UserPasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(this, new EventArgs());
            }
        }
    }
}
