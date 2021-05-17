using Inventory_Management.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repositories
{
    // Repository pattern
    class ProductRepository : BaseRepository<Product>
    {
        public override Product GetOne(int id)
        {
            string query = $"SELECT * FROM {Product.tableName} WHERE id={id}";

            //Create a product object to store the result
            Product product = new Product();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                
                try
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the product object
                    if (dataReader.Read())
                    {
                        product.Id = (int)dataReader["id"];
                        product.Name = dataReader["name"].ToString();
                        product.Barcode = dataReader["barcode"].ToString();
                    }

                    //close Data Reader
                    dataReader.Close();                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //close Connection
                    _dbConnection.CloseConnection();
                }

                //return list to be displayed
                return product;
            }
            else
            {
                return product;
            }
        }

        public override List<Product> GetAll()
        {
            string query = $"SELECT * FROM {Product.tableName}";

            //Create a list to store the result
            List<Product> products = new List<Product>();
            
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
                        products.Add(new Product() {
                            Id = (int) dataReader["id"],
                            Name = dataReader["name"].ToString(),
                            Barcode = dataReader["barcode"].ToString()
                        });
                    }
                    //close Data Reader
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //close Connection
                    _dbConnection.CloseConnection();
                }
                //return list to be displayed
                return products;
            }
            else
            {
                return products;
            }
        }

        public override void Insert(Product product)
        {
            string query = $"INSERT INTO {Product.tableName} (name, barcode) VALUES(@name, @barcode)";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@barcode", product.Barcode);
                
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

        public override void Update(int id, Product product)
        {
            string query = $"UPDATE {Product.tableName} SET name=@name, barcode=@barcode WHERE id={id}";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@barcode", product.Barcode);
                
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
            string query = $"DELETE FROM {Product.tableName} WHERE id={id}";

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

        public List<Product> Search(string keyword)
        {
            string query = $"SELECT * FROM {Product.tableName} WHERE name LIKE %{keyword}% OR barcode LIKE %{keyword}%";

            //Create a list to store the result
            List<Product> products = new List<Product>();

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
                        products.Add(new Product()
                        {
                            Id = (int)dataReader["id"],
                            Name = dataReader["name"].ToString(),
                            Barcode = dataReader["barcode"].ToString()
                        });
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //close Connection
                    _dbConnection.CloseConnection();
                }

                //return list to be displayed
                return products;
            }
            else
            {
                return products;
            }
        }
    }
}
