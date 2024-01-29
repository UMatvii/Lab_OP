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
    /// Interaction logic for Teachers_Stud.xaml
    /// </summary>
    public partial class Teachers_Stud : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Teacher_Stud> data_TeacherStud_lst { get; set; }
        public Teachers_Stud(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;


            SqlCommand com = new SqlCommand("SELECT CONCAT(T.AcadDegree, + ' ' + T.LastName, + ' ' + T.FirstName) AS Teacher, T.Email AS Email, T.PhoneNum AS PhonNum, S.SubjName AS SubjName, TG.TypeGrade AS TypeGrade \r\nFROM Teachers AS T\r\nINNER JOIN SchlGroups AS SG ON T.IDTeacher = SG.IDTeacher\r\nINNER JOIN Subjects AS S ON SG.IDSubject = S.IDSubject\r\nINNER JOIN Grades AS G ON S.IDSubject = G.IDSubject\r\nINNER JOIN TypeGrades AS TG ON G.IDGrade = TG.IDGrade \r\n WHERE IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_TeacherStud_lst = new List<Data_Teacher_Stud>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Teacher_Stud data_TeacherStud_row = new Data_Teacher_Stud();
                        int colIndex = dr.GetOrdinal("Teacher");
                        data_TeacherStud_row.Teacher = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("Email");
                        data_TeacherStud_row.Email = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("PhonNum");
                        data_TeacherStud_row.PhonNum = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("SubjName");
                        data_TeacherStud_row.SubjName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("TypeGrade");
                        data_TeacherStud_row.TypeGrade = dr.GetString(colIndex);
                        data_TeacherStud_lst.Add(data_TeacherStud_row);
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

    public class Data_Teacher_Stud
    {
        public string Teacher { get; set; }
        public string Email { get; set; }
        public string PhonNum { get; set; }
        public string SubjName { get; set; }
        public string TypeGrade { get; set; }
    }
}
