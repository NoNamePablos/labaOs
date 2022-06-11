using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class Comment
    {
        private static readonly string _selectUsersCommand = @"SELECT [CountryId],  [Country_population], [Country_name] FROM [dbo].[Country]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Country] ([Country_population], [Country_name]) VALUES (@Country_population, @Country_name)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Country] SET [Country_population] = @Country_population, [Country_name] = @Country_name  WHERE [CountryId] = @CountryId";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Country] WHERE [CountryId] = @CountryId";

        public long CountryPopulation { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public static List<Comment> List(SqlConnection connection)
        {
            List<Comment> users = new List<Comment>();
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
                        Comment user = new Comment
                        {
                            CountryPopulation = (long)reader["Country_population"],
                            CountryId = (int)reader["CountryId"],
                            CountryName = (string)reader["Country_name"]
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

        public static void Insert(SqlConnection connection, Comment user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Country_name", SqlDbType.NVarChar, 32).Value = user.CountryName;
                    command.Parameters.Add("@Country_population", SqlDbType.BigInt, 64).Value = user.CountryPopulation;
                    command.Parameters.Add("@CountryId", SqlDbType.Int, 32).Value = user.CountryId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Comment user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Country_name", SqlDbType.NVarChar, 32).Value = user.CountryName;
                    command.Parameters.Add("@Country_population", SqlDbType.BigInt, 64).Value = user.CountryPopulation;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = user.CountryId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int userId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@CountryId", SqlDbType.Int).Value = userId;
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
