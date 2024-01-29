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
    /// Interaction logic for GroupsIMod.xaml
    /// </summary>
    public partial class GroupsIMod : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Groups> data_Groups_lst {  get; set; }
        public GroupsIMod(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;


            SqlCommand com = new SqlCommand("SELECT G.GrpName AS GrpName, TG.TypeGrade AS TypeGrade, CONCAT(T.FirstName, + ' ' + T.LastName) AS Teacher\r\nFROM Groups AS G\r\nINNER JOIN SchlGroups AS SG ON G.IDGrp = SG.IDGrp\r\nINNER JOIN Teachers AS T ON SG.IDTeacher = T.IDTeacher\r\nINNER JOIN Subjects AS S ON SG.IDSubject = S.IDSubject\r\nINNER JOIN Grades AS GR ON S.IDSubject = GR.IDSubject\r\nINNER JOIN TypeGrades AS TG ON GR.IDGrade = TG.IDGrade  WHERE IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Groups_lst = new List<Data_Groups>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Groups data_Groups_row = new Data_Groups();
                        int colIndex = dr.GetOrdinal("GrpName");
                        data_Groups_row.GrpName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("TypeGrade");
                        data_Groups_row.TypeGrade = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("Teacher");
                        data_Groups_row.Teacher = dr.GetString(colIndex);
                        data_Groups_lst.Add(data_Groups_row);
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

    public class Data_Groups
    {
        public string GrpName { get; set; }
        public string TypeGrade {  get; set; }
        public string Teacher { get; set; }
    }
}
