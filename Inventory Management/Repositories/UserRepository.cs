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
    class UserRepository : BaseRepository<User>
    {
        public override User Find(int id)
        {
            string query = $"SELECT * FROM {User.tableName} WHERE id={id}";

            //Create a user object to store the result
            User user = new User();

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                
                try
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the user object
                    if (dataReader.Read())
                    {
                        user.Id = Convert.ToInt32(dataReader["id"]);
                        user.Name = dataReader["name"].ToString();
                        user.Email = dataReader["email"].ToString();
                        user.Password = dataReader["password"].ToString();
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
                return user;
            }
            else
            {
                return user;
            }
        }

        public override List<User> All()
        {
            string query = $"SELECT * FROM {User.tableName}";

            //Create a list to store the result
            List<User> users = new List<User>();
            
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
                        users.Add(new User() {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Name = dataReader["name"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Password = dataReader["password"].ToString()
                    });
                    }
                    //close Data Reader
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                }
                finally
                {
                    //close Connection
                    _dbConnection.CloseConnection();
                }
                //return list to be displayed
                return users;
            }
            else
            {
                return users;
            }
        }

        public override void Insert(User user)
        {
            string query = $"INSERT INTO {User.tableName} (name, email, password) VALUES(@name, @email, @password)";

            //open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);
                
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

        public override void Update(int id, User user)
        {
            string query = $"UPDATE {User.tableName} SET name=@name, email=@email, password=@password WHERE id={id}";

            //Open connection
            if (_dbConnection.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, _dbConnection.Connection);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);

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
            string query = $"DELETE FROM {User.tableName} WHERE id={id}";

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

        public List<User> SearchAll(string keyword)
        {
            string query = $"SELECT * FROM {User.tableName} WHERE name LIKE '%{keyword}%' OR email LIKE '%{keyword}%'";

            //Create a list to store the result
            List<User> users = new List<User>();

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
                        users.Add(new User()
                        {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Name = dataReader["name"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Password = dataReader["password"].ToString()
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
                return users;
            }
            else
            {
                return users;
            }
        }

        public List<User> SearchBy(string value, string key = "id", string op = "=")
        {
            string query = $"SELECT * FROM {User.tableName} WHERE {key}{op}'{value}'";

            //Create a list to store the result
            List<User> users = new List<User>();

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
                        users.Add(new User()
                        {
                            Id = Convert.ToInt32(dataReader["id"]),
                            Name = dataReader["name"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Password = dataReader["password"].ToString()
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
                return users;
            }
            else
            {
                return users;
            }
        }
    }
}
