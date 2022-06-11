using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class DateTrustedPerson
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_trusted],  [FirstDate], [LastDate],[id_visitedTrusted] FROM [dbo].[Date Of Visit Trasted Person]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Date Of Visit Trasted Person] ([id_trusted], [FirstDate],[LastDate]) VALUES (@id_trusted, @FirstDate, @LastDate)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Date Of Visit Trasted Person] SET [id_trusted] = @id_trusted, [FirstDate] = @FirstDate, [LastDate] = @LastDate WHERE [id_visitedTrusted] = @id_visitedTrusted";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Date Of Visit Trasted Person] WHERE [id_visitedTrusted] = @id_visitedTrusted";

        public long IdVisitedClient { get; set; }
        public long IdClient { get; set; }
        public DateTime FirstDate { get; set; } = DateTime.Now;
        public DateTime LastDate { get; set; } = DateTime.Now;
        public static List<DateTrustedPerson> List(SqlConnection connection)
        {
            List<DateTrustedPerson> users = new List<DateTrustedPerson>();

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

                        DateTrustedPerson user = new DateTrustedPerson
                        {

                            IdVisitedClient = (long)reader["id_visitedTrusted"],
                            FirstDate = (DateTime)reader["FirstDate"],
                            LastDate = (DateTime)reader["LastDate"],

                            IdClient = (long)reader["id_trusted"]
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

        public static void Insert(SqlConnection connection, DateTrustedPerson user)
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
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = user.IdClient;
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

        public static void Update(SqlConnection connection, DateTrustedPerson user)
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
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@FirstDate", SqlDbType.SmallDateTime).Value = user.FirstDate;
                    command.Parameters.Add("@LastDate", SqlDbType.SmallDateTime).Value = user.LastDate;
                    command.Parameters.Add("@id_visitedTrusted", SqlDbType.BigInt).Value = user.IdVisitedClient;

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
                    command.Parameters.Add("@id_visitedTrusted", SqlDbType.BigInt).Value = id_client;
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
