using SqlInjectionExample;
using System;
using System.Data.SqlClient;

namespace SQLInjectionExample
{
    public class CallHelper
    {
        public static void Main(string queryTextBox)
        {
            Console.WriteLine("Enter a user ID to search:");
            //string userInput = Console.ReadLine();

            string connectionString = "Connection_String";
            DatabaseConnection db = new DatabaseConnection(connectionString);
            string query = $"SELECT * FROM Users WHERE Id = {queryTextBox}"; //OR '1' = '1'
            db.CreateCommand(query, db.Connection);


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();



            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    Console.WriteLine($"User: {reader["Username"]}, Email: {reader["Email"]}");
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred: {ex.Message}");
            //    }
            //}
        }
    }
}