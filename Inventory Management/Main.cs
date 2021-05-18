using Inventory_Management.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            /* 
            ProductsManageBtn.Enabled = false;
            UsersManageBtn.Enabled = false;
            SearchBtn.Enabled = false;
            SearchTxt.Enabled = false;
            */
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductsManageBtn_Click(object sender, EventArgs e)
        {
            new ProductForm().ShowDialog();
        }

        private void UsersManageBtn_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }
    }
}
