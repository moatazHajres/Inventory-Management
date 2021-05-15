using Inventory_Managment.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment.Repositories
{
    class ProductRepository : BaseRepository<Product>
    {
        protected string tableName = Product.tableName;

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
            string query = $"INSERT INTO {tableName} (name, barcode) VALUES('John Smith', '33')";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                _dbConnection.CloseConnection();
            }
        }

        public override void Update(int id, Product product)
        {
            string query = $"UPDATE {tableName} SET name='Joe', age='22' WHERE id='{id}'";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
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
            string query = $"DELETE FROM {tableName} WHERE id='{id}'";

            if (_dbConnection.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.ExecuteNonQuery();
                _dbConnection.CloseConnection();
            }
        }
    }
}
