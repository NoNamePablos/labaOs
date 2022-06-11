using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace Lab11.Models
{
    public class TrustedFio
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_trusted],  [family], [name],[lastName] FROM [dbo].[FIO]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[FIO] ([family], [name],[lastName]) VALUES (@family, @name, @lastName)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[FIO] SET [family] = @family, [name] = @name, [lastName] = @lastName WHERE [id_trusted] = @id_trusted";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[FIO] WHERE [id_trusted] = @id_trusted";

        public long IdTrusted { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public static List<TrustedFio> List(SqlConnection connection)
        {
            List<TrustedFio> users = new List<TrustedFio>();

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
                      
                        TrustedFio user = new TrustedFio
                        {
                            Family = (string)reader["family"],
                            Name = (string)reader["name"],
                            LastName = (string)reader["lastName"],
                            IdTrusted = (long)reader["id_trusted"],
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


        public static void Insert(SqlConnection connection, TrustedFio user)
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
                            LastName = (string)reader["lastName"],
                            IdClient = (long)reader["id_client"],
                            AddressClient = (string)reader["address_client"],
                            IdDepartamnet = (long)reader["id_departament"]
                     
                     */
                    command.Parameters.Add("@family", SqlDbType.NVarChar, 20).Value = user.Family;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = user.Name;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar, 20).Value = user.LastName;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, TrustedFio user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                     Family = (string)reader["family"],
                          Name = (string)reader["name"],
                          LastName = (string)reader["lastName"],
                          IdClient = (long)reader["id_client"],
                          AddressClient = (string)reader["address_client"],
                          IdDepartamnet = (long)reader["id_departament"]

                   */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@family", SqlDbType.NVarChar, 32).Value = user.Family;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 32).Value = user.Name;
                    command.Parameters.Add("@lastName", SqlDbType.NVarChar, 32).Value = user.LastName;
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = user.IdTrusted;
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
                    command.Parameters.Add("@id_trusted", SqlDbType.BigInt).Value = id_client;
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
