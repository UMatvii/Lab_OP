using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Smart_University.StudentsFunction
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        User user;
        DataBase db;
        int id_Stud;
        public Setting(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            id_Stud = idStud;
            db = db_par;
            user = user_par;
        }

        private void Button_ChangePass_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand com = new SqlCommand("UPDATE Logins SET password = @password WHERE IDStudent = @idStudent", db.DBConnect());
            com.Parameters.AddWithValue("@idStudent", id_Stud.ToString());
            if(New_Password.Password != Old_Password.Password && Old_Password.Password == Old_Password.Password)
            {
                com.Parameters.AddWithValue("@password", New_Password.Password);
            }

            com.ExecuteNonQuery();

            MainWindow mainWindow = new MainWindow(user.IDStudent, user, db);
            mainWindow.Show();
            Hide();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(user.IDStudent, user, db);
            mainWindow.Show();
            Hide();
        }
    }
}
