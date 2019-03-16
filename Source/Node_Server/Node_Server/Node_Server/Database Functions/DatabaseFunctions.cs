using System;
using MySql.Data.MySqlClient;
namespace Node_Server.DatabaseFunctions
{
    public class DatabaseFunctions
    {
        private static MySqlConnection dbConnection;
        private static MySqlCommand queryCmd;

        public static bool Connect()
        {
            string connectionString = "";
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
