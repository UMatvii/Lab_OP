using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DataStud.xaml
    /// </summary>
    public partial class DataStud : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Students> data_Students_lst { get; set; }
        public DataStud(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;


            SqlCommand com = new SqlCommand("SELECT LastName, FirstName, IDStudent, BirthDay, Pesel, PhonNum, Email, StudEmail, Semester\r\nFROM Students  WHERE IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Students_lst = new List<Data_Students>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Students data_Students_row = new Data_Students();
                        int colIndex = dr.GetOrdinal("LastName");
                        data_Students_row.LastName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("FirstName");
                        data_Students_row.FirstName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("IDStudent");
                        data_Students_row.IDStudent = dr.GetInt32(colIndex);
                        colIndex = dr.GetOrdinal("BirthDay");
                        data_Students_row.BirthDay = Convert.ToString(dr.GetDateTime(colIndex).ToString("yyyy-MM-dd"));
                        colIndex = dr.GetOrdinal("Pesel");
                        data_Students_row.Pesel = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("PhonNum");
                        data_Students_row.PhonNum = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("Email");
                        data_Students_row.Email = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("StudEmail");
                        data_Students_row.StudEmail = dr.GetString(colIndex);
                        data_Students_lst.Add(data_Students_row);
                    }
                }
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(user.IDStudent, user, db);
            mainWindow.Show();
            Hide();
        }
    }

    public class Data_Students
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int IDStudent { get; set; }
        public string BirthDay { get; set; }
        public string Pesel { get; set; }
        public string PhonNum { get; set; }
        public string Email { get; set; }
        public string StudEmail { get; set; }
    }
}
