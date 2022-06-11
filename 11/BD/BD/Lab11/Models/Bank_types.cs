using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lab11.Models
{
    public class Bank_types
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_bank], [name] FROM [dbo].[Bank_types]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[Bank_types] (name) VALUES ( @name)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[Bank_types] SET  [name] = @name WHERE [id_bank] = @id_bank";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[Bank_types] WHERE [id_bank] = @id_bank";

        public long IdBank { get; set; }
        public string Name { get; set; }
        public static List<Bank_types> List(SqlConnection connection)
        {
            List<Bank_types> users = new List<Bank_types>();

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

                        Bank_types user = new Bank_types
                        {
                           
                            Name = (string)reader["name"],
                            IdBank = (long)reader["id_bank"],
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
     

        public static void Insert(SqlConnection connection, Bank_types user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                   
                  
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = user.Name;
                   
                  
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Bank_types user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                   
                    command.Parameters.Add("@name", SqlDbType.NVarChar,50).Value = user.Name;                
                    command.Parameters.Add("@id_bank", SqlDbType.BigInt).Value = user.IdBank;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, long id_bank)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_bank", SqlDbType.BigInt).Value = id_bank;
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
