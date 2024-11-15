using Microsoft.VisualBasic.ApplicationServices;
using SqlInjectionExample;
using System;
using System.Data.SqlClient;

namespace SQLForms
{
    public class CallHelper
    {
        public static List<User> CallQuery(string queryTextBox)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=SQLInjection;Trusted_Connection=True;";
            DatabaseConnection db = new DatabaseConnection(connectionString);
            string query = $"SELECT * FROM Users WHERE UserId = {queryTextBox}"; //OR '1' = '1', ' OR '1' = '1' --
            //string query = $"SELECT * FROM Users";// WHERE UserId = 2 OR '1' = '1'";
            SqlCommand command = db.CreateCommand(query, db.Connection);
            //command.Parameters.AddWithValue("@UserId", queryTextBox);
            User user = new User();
            List<User> usersList = new List<User>(); ;
            using (var reader = command.ExecuteReader())
            {
                while(true)
                {
                    if (reader.Read())
                    {
                        usersList.Add(new User
                        {
                            UserId = (int)reader["UserId"],
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                    else
                    {
                        break;
                    }  
                }
                return usersList;
            }
        }
    }
}