using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class User
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_client],  [family], [name],[last_name], [address_client] ,[id_departament] FROM [dbo].[Client]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Client] ([family], [name],[last_name], [address_client] ,[id_departament]) VALUES (@family, @name, @last_name,@address_client,@id_departament)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Client] SET [family] = @family, [name] = @name, [last_name] = @last_name,[address_client]= @address_client ,[id_departament]= @id_departament WHERE [id_client] = @id_client";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Client] WHERE [id_client] = @id_client";

        public long IdClient { get; set; }
        public long IdDepartamnet { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string AddressClient { get; set; }
        public static List<long> IdDepartamnets = new List<long>();
        public static List<User> List(SqlConnection connection)
        {
            List<User> users = new List<User>();
            
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectUsersCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        IdDepartamnets.Add((long)reader["id_departament"]);
                        User user = new User
                        {
                            Family = (string)reader["family"],
                            Name = (string)reader["name"],
                            LastName = (string)reader["last_name"],
                            IdClient = (long)reader["id_client"],
                            AddressClient = (string)reader["address_client"],
                            IdDepartamnet = (long)reader["id_departament"]
                        };
                        users.Add(user);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return users;
        }
        public static List<long> idDeps() {
            return IdDepartamnets;
        }

        public static void Insert(SqlConnection connection, User user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    /*
                       Family = (string)reader["family"],
                            Name = (string)reader["name"],
                            LastName = (string)reader["last_name"],
                            IdClient = (long)reader["id_client"],
                            AddressClient = (string)reader["address_client"],
                            IdDepartamnet = (long)reader["id_departament"]
                     
                     */
                    command.Parameters.Add("@family", SqlDbType.NVarChar, 20).Value = user.Family;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = user.Name;
                    command.Parameters.Add("@last_name", SqlDbType.NVarChar, 20).Value = user.LastName;
                    command.Parameters.Add("@address_client", SqlDbType.NVarChar, 20).Value = user.AddressClient;
                    command.Parameters.Add("@id_departament", SqlDbType.BigInt).Value = user.IdDepartamnet;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, User user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                     Family = (string)reader["family"],
                          Name = (string)reader["name"],
                          LastName = (string)reader["last_name"],
                          IdClient = (long)reader["id_client"],
                          AddressClient = (string)reader["address_client"],
                          IdDepartamnet = (long)reader["id_departament"]

                   */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@family", SqlDbType.NVarChar, 32).Value = user.Family;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 32).Value = user.Name;
                    command.Parameters.Add("@last_name", SqlDbType.NVarChar, 32).Value = user.LastName;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@address_client", SqlDbType.NVarChar, 32).Value = user.AddressClient;
                    command.Parameters.Add("@id_departament", SqlDbType.BigInt).Value = user.IdDepartamnet;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, long id_client)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = id_client;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        
    }
}
