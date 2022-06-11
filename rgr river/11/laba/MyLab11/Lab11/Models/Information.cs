using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Lab11.Models
{
    public class Information
    {
        private static readonly string _selectUsersCommand = @"SELECT [id_river], [river_name],[river_palace], [river_outflow],[river_length] FROM [dbo].[River]";
        private static readonly string _insertUserCommand = @"INSERT INTO [dbo].[River] ([river_name],[river_palace], [river_outflow], [river_length]) VALUES (@river_name,@river_palace, @river_outflow,@river_length)";
        private static readonly string _updateUserCommand = @"UPDATE [dbo].[River] SET [river_name] = @river_name,[river_palace]=@river_palace, [river_outflow] = @river_outflow, [river_length] = @river_length WHERE [id_river] = @id_river";
        private static readonly string _deleteUserCommand = @"DELETE FROM [dbo].[River] WHERE [id_river] = @id_river";
        private static readonly string _checkDuplicates = @"SELECT [id_river], [river_name],[river_palace], [river_outflow],[river_length] FROM [dbo].[River] WHERE [river_name]=@river_name ";
        public int RiverId { get; set; }
        public string RiverName { get; set; }
        public string RiverOutflow { get; set; }
        public string RiverPalace { get; set; }
        public double RiverLength { get; set; }
        public static List<Information> List(SqlConnection connection)
        {
            List<Information> rivers = new List<Information>();
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
                        Information river = new Information
                        {
                            RiverId = (int)reader["id_river"],
                            RiverName = (string)reader["river_name"],
                            RiverPalace = (string)reader["river_palace"],
                            RiverOutflow = (string)reader["river_outflow"],
                            RiverLength= (double)reader["river_length"]
                           
                            
                        };
                        rivers.Add(river);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return rivers;
        }

        public static void Insert(SqlConnection connection, Information river)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertUserCommand;
                    command.CommandType = CommandType.Text; 
                    command.Parameters.Add("@river_name", SqlDbType.NVarChar, 50).Value = river.RiverName;
                    command.Parameters.Add("@river_palace", SqlDbType.NVarChar, 50).Value = river.RiverPalace;
                    command.Parameters.Add("@river_outflow", SqlDbType.NVarChar, 50).Value = river.RiverOutflow;
                    command.Parameters.Add("@river_length", SqlDbType.Float).Value = river.RiverLength;
                    command.Parameters.Add("@id_river", SqlDbType.Int, 32).Value = river.RiverId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Information river)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    /*
                         command.Parameters.Add("@river_name", SqlDbType.NVarChar, 50).Value = river.RiverName;
                    command.Parameters.Add("@river_palace", SqlDbType.NVarChar, 50).Value = river.RiverPalace;
                    command.Parameters.Add("@river_outflow", SqlDbType.NVarChar, 50).Value = river.RiverOutflow;
                    command.Parameters.Add("@river_length", SqlDbType.Float).Value = river.RiverLength;
                    command.Parameters.Add("@id_river", SqlDbType.Int, 32).Value = river.RiverId;
                     */
                    command.Connection = connection;
                    command.CommandText = _updateUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@river_name", SqlDbType.NVarChar, 50).Value = river.RiverName;
                    command.Parameters.Add("@river_palace", SqlDbType.NVarChar, 50).Value = river.RiverPalace;
                    command.Parameters.Add("@river_outflow", SqlDbType.NVarChar, 50).Value = river.RiverOutflow;
                    command.Parameters.Add("@river_length", SqlDbType.Float).Value = river.RiverLength;
                    command.Parameters.Add("@id_river", SqlDbType.Int, 32).Value = river.RiverId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static string CheckDuplicates(SqlConnection connection, string name) {
            String Title = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _checkDuplicates;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@river_name", SqlDbType.NVarChar, 32).Value = name;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Title = (string)reader["river_name"];
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return Title;


        }
        public static void Delete(SqlConnection connection, int riverID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteUserCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id_river", SqlDbType.Int).Value = riverID;
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
