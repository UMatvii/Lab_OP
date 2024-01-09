using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University
{
    class User
    {
        string login {get; set;}
        string password;

        public User () { }

        public User (string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Boolean CheckUser(DBContext dbconn)
        {
            try
            {
                if (dbconn.db.State != ConnectionState.Open)
                {
                    dbconn.db.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Logins WHERE login = @login and password = @password", dbconn.db);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows == true)
                    {
                        return true;
                    }
                        return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка бази даних: {ex.Message}");
                return false;
            }

            finally 
            { 
                dbconn.DBClose();
            }
        }
    }
}
