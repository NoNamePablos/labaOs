using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lab11.Models
{
    public class ClientSafes
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_safe],  [num_key], [positionKey],[id_client] FROM [dbo].[Client Safes]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Client Safes] ([num_key], [positionKey],[id_client]) VALUES (@num_key, @positionKey, @id_client)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Client Safes] SET [positionKey] = @positionKey, [id_client] = @id_client WHERE [id_safe] = @id_safe";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Client Safes] WHERE [id_safe] = @id_safe";

        public long IdSafe { get; set; }
        public long NumKey { get; set; }
        public string PositionKey { get; set; }
        public long IdClient { get; set; }

        public static List<long> IdDepartamnets = new List<long>();
        //Этот метод должен возвращать случайное значение
       public static long GetRandom()
        {
            //Создание объекта для генерации чисел (с указанием начального значения)
            Random rnd = new Random(245);

            //Получить случайное число 
            long value = rnd.Next();

            //Вернуть полученное значение
            return value;
        }
        public static List<ClientSafes> List(SqlConnection connection)
        {
            List<ClientSafes> users = new List<ClientSafes>();

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
                        IdDepartamnets.Add((long)reader["id_safe"]);
                        ClientSafes user = new ClientSafes
                        {
                            NumKey = (long)reader["num_key"],
                            PositionKey = (string)reader["positionKey"],
                            IdClient = (long)reader["id_client"],
                            IdSafe = (long)reader["id_safe"]
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
        public static List<long> idDeps()
        {
            return IdDepartamnets;
        }

        public static void Insert(SqlConnection connection, ClientSafes user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    /*
                       NumKey = (long)reader["num_key"],
                            PositionKey = (string)reader["positionKey"],
                            IdClient = (long)reader["id_client"],
                            IdSafe = (long)reader["id_safe"]
                     
                     */
                    command.Parameters.Add("@num_key", SqlDbType.BigInt).Value = user.NumKey;
                    command.Parameters.Add("@positionKey", SqlDbType.NVarChar, 50).Value = user.PositionKey;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, ClientSafes user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                                   NumKey = (long)reader["num_key"],
                            PositionKey = (string)reader["positionKey"],
                            IdClient = (long)reader["id_client"],
                            IdSafe = (long)reader["id_safe"]

                        */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@num_key", SqlDbType.BigInt).Value = user.NumKey;
                    command.Parameters.Add("@id_safe", SqlDbType.BigInt).Value = user.IdSafe;
                    command.Parameters.Add("@positionKey", SqlDbType.NVarChar, 50).Value = user.PositionKey;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, long id_dep)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_safe", SqlDbType.BigInt).Value = id_dep;
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
