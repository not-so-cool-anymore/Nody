using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Node_Server
{
    class DatabaseFunctions
    {
        static MySqlConnection sqlConnection;
        static MySqlCommand sqlCommand;

        public static void Connect()
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=nody;UID=root;PWD=@?46ns)N=?Dc*9kq;SSLMODE=none";
            sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();
        }
        public static void Close()
        {
            sqlConnection.Close();
        }
        public static bool CheckUserDuplicating(string username)
        {
            int duplications = 0;
            try
            {
                Connect();
                string duplicationCountung = "SELECT COUNT(*) FROM nody_users WHERE username = @USERNAME;";
                sqlCommand = new MySqlCommand(duplicationCountung, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@USERNAME", username);
                duplications = int.Parse(sqlCommand.ExecuteScalar().ToString());
                if (duplications >=1)
                {
                    Close();
                    return true;
                }
                else
                {
                    Close();
                    return false;
                }              
            }
            catch (Exception ex)
            {

                Close();
                Console.WriteLine(">> DB exeption " + ex.Message);
            }

            return false;
        }
        public static bool ValidateUser(string username, string password)
        {
            if (!CheckUserDuplicating(username))
            {
                return false;
            }
               
            int matchingRecords = 0;

            string salt = GetSalt(username);
            Connect();
            Console.WriteLine(salt);
            string hashedPassword = CryptoSecurityClass.HashPassword(password, salt);
           
            string userValidationString = "SELECT COUNT(*) FROM nody_users WHERE username = @USERNAME AND hashed_password = @PASS; ";
            sqlCommand = new MySqlCommand(userValidationString, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@USERNAME", username);
            sqlCommand.Parameters.AddWithValue("@PASS", hashedPassword);
            
            matchingRecords = int.Parse(sqlCommand.ExecuteScalar().ToString());
            if (matchingRecords >= 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
            
        }
        public static void InsertUser(string username, string hashedPassword, string salt)
        {
            try
            {
                Connect();

                string insertionCmdString = "INSERT INTO nody_users(id, username, hashed_password, password_salt) VALUES(NULL, @USERNAME, @PASS, @SALT);";
                sqlCommand = new MySqlCommand(insertionCmdString, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@USERNAME", username);
                sqlCommand.Parameters.AddWithValue("@PASS", hashedPassword);
                sqlCommand.Parameters.AddWithValue("@SALT", salt);

                int affectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(">> DB insert exception " + ex.Message);
                Close();
            }
        }
        private static string GetSalt(string username)
        {
            string salt = "";
            try
            {
                Connect();
                string insertionCmdString = "SELECT password_salt FROM nody_users WHERE username = @USERNAME;";
                sqlCommand = new MySqlCommand(insertionCmdString, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@USERNAME", username);

                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        salt = reader[0].ToString();
                    }
                    reader.Close();
                    
                }

                Close();
                return salt;
                
            }
            catch (Exception ex)
            {
                Close();
                Console.WriteLine(">> DB salt get exception " + ex.Message);
                return "";
            }
            
        }
    }
}
