using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    public class User
    {
        private static readonly string _selectUsersCommand = @"SELECT [CityId], [City_name], [City_population], [Create_date],[CountryId] FROM [dbo].[City]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[City] ([City_name], [City_population], [Create_date],[CountryId]) VALUES (@City_name, @City_population, @Create_date,@CountryId)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[City] SET [City_name] = @City_name, [City_population] = @City_population, [Create_date] = @Create_date WHERE [CityId] = @CityId";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[City] WHERE [CityId] = @CityId";

        public int CityId { get; set; }
        public string CityName { get; set; }
        public long CityPopulation { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CountryId { get; set; }
        public byte[] Photo { get; set; }

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
                        User user = new User
                        {
                            CityName = (string)reader["City_name"],
                            CityPopulation = (long)reader["City_population"],
                            CreateDate = (DateTime)reader["Create_date"],
                            CityId = (int)reader["CityId"],
                            CountryId=(int)reader["CountryId"]
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

        public static void Insert(SqlConnection connection, User user)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@City_name", SqlDbType.NVarChar, 32).Value = user.CityName;
                    command.Parameters.Add("@City_population", SqlDbType.BigInt, 64).Value = user.CityPopulation;
                    command.Parameters.Add("@Create_date", SqlDbType.DateTime, 32).Value = user.CreateDate;
                    command.Parameters.Add("@CountryId",SqlDbType.Int,32).Value=user.CountryId;
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
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@City_name", SqlDbType.NVarChar, 32).Value = user.CityName;
                    command.Parameters.Add("@City_population", SqlDbType.NVarChar, 32).Value = user.CityPopulation;
                    command.Parameters.Add("@Create_date", SqlDbType.NVarChar, 32).Value = user.CreateDate;
                    command.Parameters.Add("@CityId", SqlDbType.Int).Value = user.CityId;
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
                    command.Parameters.Add("@CityId", SqlDbType.Int).Value = userId;
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
