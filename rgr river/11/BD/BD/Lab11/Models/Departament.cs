using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lab11.Models
{
  public  class Departament
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_departament],  [departament__name], [departament__address],[id_banks] FROM [dbo].[Depatament]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Depatament] ([departament__name], [departament__address],[id_banks]) VALUES (@departament__name, @departament__address, @id_banks)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Depatament] SET [departament__name] = @departament__name, [departament__address] = @departament__address, [id_banks] = @id_banks WHERE [id_departament] = @id_departament";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Depatament] WHERE [id_client] = @id_client";

        public long IdDepartament { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long IdBank { get; set; }

        public static List<long> IdDepartamnets = new List<long>();
        public static List<Departament> List(SqlConnection connection)
        {
            List<Departament> users = new List<Departament>();

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
                        Departament user = new Departament
                        {
                            Name = (string)reader["departament__name"],
                            IdBank = (long)reader["id_banks"],
                            Address = (string)reader["departament__address"],
                            IdDepartament = (long)reader["id_departament"]
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

        public static void Insert(SqlConnection connection, Departament user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    /*
                        Name = (string)reader["name"],
                            IdBank = (long)reader["id_banks"],
                            Address = (string)reader["departament__address"],
                            IdDepartament = (long)reader["id_departament"]
                     
                     */
                    command.Parameters.Add("@departament__name", SqlDbType.NVarChar, 50).Value = user.Name;
                    command.Parameters.Add("@departament__address", SqlDbType.NVarChar, 50).Value = user.Address;
                    command.Parameters.Add("@id_banks", SqlDbType.BigInt).Value = user.IdBank;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Departament user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                               Name = (string)reader["name"],
                               IdBank = (long)reader["id_banks"],
                               Address = (string)reader["departament__address"],
                               IdDepartament = (long)reader["id_departament"]

                        */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@departament__name", SqlDbType.NVarChar, 50).Value = user.Name;
                    command.Parameters.Add("@id_departament", SqlDbType.BigInt).Value = user.IdDepartament;
                    command.Parameters.Add("@departament__address", SqlDbType.NVarChar, 50).Value = user.Address;
                    command.Parameters.Add("@id_banks", SqlDbType.BigInt).Value = user.IdBank;
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
                    command.Parameters.Add("@id_departament", SqlDbType.BigInt).Value = id_dep;
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
