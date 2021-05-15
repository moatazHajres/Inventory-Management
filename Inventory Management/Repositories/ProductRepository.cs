using Inventory_Managment.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment.Repositories
{
    // Repository pattern
    class ProductRepository : BaseRepository<Product>
    {
        public override Product GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Insert(Product entity)
        {
            string query = $"INSERT INTO {Product.tableName} (name, barcode) VALUES('@name', '@barcode')";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.Parameters.AddWithValue("@name", "Myname");
                cmd.Parameters.AddWithValue("@barcode", "Myaddress");
                //Assign the connection using Connection
                cmd.Connection = _dbConnection.Connection;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                _dbConnection.CloseConnection();
            }
        }

        public override void Update(int id, Product product)
        {
            string query = $"UPDATE {Product.tableName} SET name='@name', barcode='@barcode' WHERE id='{id}'";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@name", "Myname");
                cmd.Parameters.AddWithValue("@barcode", "Myaddress");
                //Assign the connection using Connection
                cmd.Connection = _dbConnection.Connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                _dbConnection.CloseConnection();
            }
        }

        public override void Delete(int id)
        {
            string query = $"DELETE FROM {Product.tableName} WHERE id='{id}'";

            if (_dbConnection.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.ExecuteNonQuery();
                _dbConnection.CloseConnection();
            }
        }
    }
}
