using Inventory_Management.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repositories
{
    class StockRepository : BaseRepository<Stock>
    {
        public override Stock GetOne(int id)
        {
            /* ! TODO: ! */
            string query = $"SELECT * FROM {Stock.tableName} WHERE id='{id}'";

            //Create a stock object to store the result
            Stock stock = new Stock();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the stock object
                if (dataReader.Read())
                {
                    stock.Id = (int)dataReader["id"];
                    stock.Quantity = (int)dataReader["quantity"];
                    stock.Product = new Product()
                    {
                        Id = (int)dataReader["product_id"],
                        Name = dataReader["name"].ToString(),
                        Barcode = dataReader["barcode"].ToString()
                    };
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                _dbConnection.CloseConnection();

                //return list to be displayed
                return stock;
            }
            else
            {
                return stock;
            }
        }

        public override List<Stock> GetAll()
        {
            /* ! TODO: ! */
            string query = $"SELECT * FROM {Stock.tableName}";

            //Create a list to store the result
            List<Stock> stocks = new List<Stock>();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    stocks.Add(new Stock()
                    {
                        Id = (int)dataReader["id"],
                        Quantity = (int)dataReader["quantity"],
                        Product = new Product()
                        {
                            Id = (int)dataReader["product_id"],
                            Name = dataReader["name"].ToString(),
                            Barcode = dataReader["barcode"].ToString()
                        }
                    });
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                _dbConnection.CloseConnection();

                //return list to be displayed
                return stocks;
            }
            else
            {
                return stocks;
            }
        }

        public override void Insert(Stock stock)
        {
            string query = $"INSERT INTO {Stock.tableName} (quantity, product_id) VALUES('@quantity', '@product_id')";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand
                {
                    //Assign the query using CommandText
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                cmd.Parameters.AddWithValue("@product_id", stock.Product.Id);
                //Assign the connection using Connection
                cmd.Connection = _dbConnection.Connection;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                _dbConnection.CloseConnection();
            }
        }

        public override void Update(int id, Stock stock)
        {
            string query = $"UPDATE {Stock.tableName} SET quantity='@quantity', product_id='@product_id' WHERE id='{id}'";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand
                {
                    //Assign the query using CommandText
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                cmd.Parameters.AddWithValue("@product_id", stock.Product.Id);
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
            string query = $"DELETE FROM {Stock.tableName} WHERE id='{id}'";

            if (_dbConnection.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.ExecuteNonQuery();
                _dbConnection.CloseConnection();
            }
        }
    }
}
