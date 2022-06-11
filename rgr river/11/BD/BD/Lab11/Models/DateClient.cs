using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class DateClient
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_client],  [FirstDate], [LastDate],[id_clientVisited] FROM [dbo].[Date of Visit Client]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Date of Visit Client] ([id_client], [FirstDate],[LastDate]) VALUES (@id_client, @FirstDate, @LastDate)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Date of Visit Client] SET [id_client] = @id_client, [FirstDate] = @FirstDate, [LastDate] = @LastDate WHERE [id_clientVisited] = @id_clientVisited";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Date of Visit Client] WHERE [id_clientVisited] = @id_clientVisited";

        public long IdVisitedClient { get; set; }
        public long IdClient { get; set; }
        public DateTime FirstDate { get; set; } = DateTime.Now;
        public DateTime LastDate { get; set; } = DateTime.Now;
        public static List<DateClient> List(SqlConnection connection)
        {
            List<DateClient> users = new List<DateClient>();

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

                        DateClient user = new DateClient
                        {
                            
                            IdVisitedClient = (long)reader["id_clientVisited"],
                            FirstDate=(DateTime)reader["FirstDate"],
                            LastDate = (DateTime)reader["LastDate"],

                            IdClient = (long)reader["id_client"]
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
        
        public static void Insert(SqlConnection connection, DateClient user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    /*
                       IdVisitedClient = (long)reader["id_clientVisited"],
                            FirstDate=(DateTime)reader["FirstDate"],
                            LastDate = (DateTime)reader["LastDate"],

                            IdClient = (long)reader["id_client"]
                     */
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@FirstDate", SqlDbType.SmallDateTime).Value = user.FirstDate;
                    command.Parameters.Add("@LastDate", SqlDbType.SmallDateTime).Value = user.LastDate;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, DateClient user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                    IdVisitedClient = (long)reader["id_clientVisited"],
                            FirstDate=(DateTime)reader["FirstDate"],
                            LastDate = (DateTime)reader["LastDate"],

                            IdClient = (long)reader["id_client"]

                   */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@FirstDate", SqlDbType.SmallDateTime).Value = user.FirstDate;
                    command.Parameters.Add("@LastDate", SqlDbType.SmallDateTime).Value = user.LastDate;
                    command.Parameters.Add("@id_clientVisited", SqlDbType.BigInt).Value = user.IdVisitedClient;
                  
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
                    command.Parameters.Add("@id_clientVisited", SqlDbType.BigInt).Value = id_client;
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
