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
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class Course : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Course> data_Course_lst {  get; set; }
        public Course(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            id_Stud = idStud;
            db = db_par;
            user = user_par;

            SqlCommand com = new SqlCommand("SELECT DISTINCT s.IDStudent AS IDStudent, f.FacultyName AS FacultyName, ad.AcadDegrName AS AcadDegrName, s.Semester AS Semester\r\nFROM AcadDegrees ad\r\nINNER JOIN Students s ON ad.IDAcadDegree = s.IDAcadDegree\r\nINNER JOIN StudByGrp sbg ON s.IDStudent = sbg.IDStudent\r\nINNER JOIN Groups g ON sbg.IDGrp = g.IDGrp\r\nINNER JOIN Faculty f ON g.IDFaculty = f.IDFaculty WHERE s.IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Course_lst = new List<Data_Course>();

            using(SqlDataReader reader = com.ExecuteReader())
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Data_Course data_Course_row = new Data_Course();
                        int colIndex = reader.GetOrdinal("IDStudent");
                        data_Course_row.IDStudent = reader.GetInt32(colIndex);
                        colIndex = reader.GetOrdinal("FacultyName");
                        data_Course_row.FacultyName = reader.GetString(colIndex);
                        colIndex = reader.GetOrdinal("AcadDegrName");
                        data_Course_row.AcadDegrName = reader.GetString(colIndex);
                        colIndex = reader.GetOrdinal("Semester");
                        data_Course_row.Semester = reader.GetInt16(colIndex);
                        data_Course_lst.Add(data_Course_row);
                    }
                }
            }
            DataContext = this;
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(user.IDStudent, user, db);
            mainWindow.Show();
            Hide();
        }
    }
    public class Data_Course
    {
        public int IDStudent { get; set; }
        public string FacultyName { get; set; }
        public string AcadDegrName { get; set; }
        public int Semester {  get; set; }
    }
}
