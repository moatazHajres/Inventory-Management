using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_Managment.Database
{
    class DBConnection
    {
        private string Server = "localhost";
        private string DatabaseName = "invintory_managment";
        private string UserName = "root";
        private string Password = "";

        public MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;

        // Singleton pattern
        private DBConnection()
        {
        }
        
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        //open connection to database
        public bool OpenConnection()
        {
            string connectionString =
                "SERVER=" + Server + ";" +
                "DATABASE=" + DatabaseName + ";" +
                "UID=" + UserName + ";" +
                "PASSWORD=" + Password + ";";
            Connection = new MySqlConnection(connectionString);

            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }

}
