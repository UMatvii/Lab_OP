using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University
{
    public class User
    {
        public string login {get; set;}
        string password;
        public string user_type;
        public int IDStudent;
        public int IDTeacher;


        public User () { }

        public User (string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Boolean CheckUser(SqlConnection dbconn)
        {
            
            try
            {

                if (dbconn != null)
               {
                    SqlCommand command = new SqlCommand("SELECT * FROM Logins WHERE login = @login and password = @password", dbconn);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader dt_user = command.ExecuteReader())
                    {
                        if (dt_user.HasRows)
                        {
                            while (dt_user.Read())
                            {
                                user_type = dt_user["typeUser"].ToString();
                                if (user_type == "s")
                                {
                                    IDStudent = Convert.ToInt32(dt_user["IDStudent"]);
                                }
                                else if (user_type == "t")
                                {
                                    IDTeacher = Convert.ToInt32(dt_user["IDTeacher"]);
                                }
                            }
                            dt_user.Close();
                            return true;
                        }
                        return false;
                    }
                }

                else
                {
                    Console.WriteLine("Baza danych nie połączona!");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wyjątek bazy danych: {ex.Message}");
                return false;
            }
        }

    }
}
