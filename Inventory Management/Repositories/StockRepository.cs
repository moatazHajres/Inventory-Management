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
            string query = $"SELECT * FROM {Stock.tableName} WHERE id={id}";

            //Create a stock object to store the result
            Stock stock = new Stock();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                try
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the stock object
                    if (dataReader.Read())
                    {
                        stock.Id = Convert.ToInt32(dataReader["id"]);
                        stock.Quantity = Convert.ToInt32(dataReader["quantity"]);
                        stock.Product = new Product()
                        {
                            Id = Convert.ToInt32(dataReader["product_id"]),
                            Name = dataReader["name"].ToString(),
                            Barcode = dataReader["barcode"].ToString(),
                            Price = Convert.ToDouble(dataReader["price"])
                        };
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    //close connection
                    _dbConnection.CloseConnection();
                }

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
            string query = $"SELECT `stock`.`id`, SUM(`quantity`) AS `quantity`, `stock`.`product_id`, `products`.`name`, `products`.`barcode`, `products`.`price` " +
                $"FROM {Stock.tableName} " +
                $"INNER JOIN `products`" +
                $" ON `stock`.`product_id` = `products`.`id` " +
                $"GROUP BY `product_id`";

            //Create a list to store the result
            List<Stock> stocks = new List<Stock>();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                try
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        stocks.Add(new Stock()
                        {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Quantity = Convert.ToInt32(dataReader["quantity"]),
                            Product = new Product()
                            {
                                Id = Convert.ToInt32(dataReader["product_id"]),
                                Name = dataReader["name"].ToString(),
                                Barcode = dataReader["barcode"].ToString(),
                                Price = Convert.ToDouble(dataReader["price"])
                            }
                        });
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    //close connection
                    _dbConnection.CloseConnection();
                }

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
            string query = $"INSERT INTO {Stock.tableName} (quantity, product_id) VALUES(@quantity, @product_id)";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                cmd.Parameters.AddWithValue("@product_id", stock.Product.Id);
                
                try
                {
                    //Execute query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    //close connection
                    _dbConnection.CloseConnection();
                }
            }
        }

        public override void Update(int id, Stock stock)
        {
            string query = $"UPDATE {Stock.tableName} SET quantity=@quantity, product_id=@product_id WHERE id={id}";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                cmd.Parameters.AddWithValue("@product_id", stock.Product.Id);

                try
                {
                    //Execute query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    //close connection
                    _dbConnection.CloseConnection();
                }
            }
        }

        public override void Delete(int id)
        {
            string query = $"DELETE FROM {Stock.tableName} WHERE id={id}";

            if (_dbConnection.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                try
                {
                    //Execute query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    //close connection
                    _dbConnection.CloseConnection();
                }
            }
        }
    }
}
