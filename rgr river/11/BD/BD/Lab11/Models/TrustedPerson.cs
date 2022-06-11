using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
   public class TrustedPerson
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_client],  [id_trusted], [trustedNumber] FROM [dbo].[Trusted Person Table]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Trusted Person Table] ([id_client], [id_trusted]) VALUES (@id_client, @id_trusted)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Trusted Person Table] SET [id_client] = @id_client, [id_trusted] = @id_trusted WHERE [trustedNumber] = @trustedNumber";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Trusted Person Table] WHERE [trustedNumber] = @trustedNumber";

        public long IdTrusted { get; set; }
        public long IdClient { get; set; }
        public long TrustedNumber { get; set; }

        public static List<TrustedPerson> List(SqlConnection connection)
        {
            List<TrustedPerson> users = new List<TrustedPerson>();

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

                        TrustedPerson user = new TrustedPerson
                        {
                            IdTrusted = (long)reader["id_trusted"],
                            IdClient = (long)reader["id_client"],
                            TrustedNumber = (long)reader["trustedNumber"],
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


        public static void Insert(SqlConnection connection, TrustedPerson user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    /*
                     
                            IdTrusted = (long)reader["id_trusted"],
                            IdClient = (long)reader["id_client"],
                            TrustedNumber = (long)reader["trustedNumber"],
                     
                     */
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = user.IdTrusted;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@trustedNumber", SqlDbType.BigInt).Value = user.TrustedNumber;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, TrustedPerson user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*

                          IdTrusted = (long)reader["id_trusted"],
                          IdClient = (long)reader["id_client"],
                          TrustedNumber = (long)reader["trustedNumber"],

                   */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_client", SqlDbType.BigInt).Value = user.IdClient;
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = user.IdTrusted;
                    command.Parameters.Add("@TrustedNumber", SqlDbType.BigInt).Value = user.TrustedNumber;
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
                    command.Parameters.Add("@trustedNumber", SqlDbType.BigInt).Value = id_client;
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
