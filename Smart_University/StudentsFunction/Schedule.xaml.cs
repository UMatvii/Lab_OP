using Smart_University.StudentsFunction;
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


namespace Smart_University
{
    /// <summary>
    /// Interaction logic for Schedule.xaml
    /// </summary>
    public partial class Schedule : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Schedule> data_Schedule_lst { get; set; }
        public Schedule(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;

            SqlCommand com = new SqlCommand("SELECT sg.DateLn AS DateLn, sg.TimeStart AS TimeStart, sg.TimeFinish AS TimeFinish, r.RoomName AS RoomName, sj.SubjName AS SubjName, tg.TypeGrade AS TypeGrade, CONCAT(t.FirstName, + ' ' + t.LastName) AS Teacher FROM SchlGroups AS sg  INNER JOIN Rooms AS r ON sg.IDRoom = r.IDRoom INNER JOIN Subjects AS sj ON sg.IDSubject =sj.IDSubject INNER JOIN Grades AS g ON sj.IDSubject = g.IDSubject INNER JOIN TypeGrades AS tg ON g.IDGrade = tg.IDGrade INNER JOIN Teachers AS t ON sg.IDTeacher = t.IDTeacher INNER JOIN Students AS s ON g.IDStudent = s.IDStudent WHERE s.IDStudent = @idStudent", db.DBConnect());
            com.Parameters.AddWithValue("@idStudent", id_Stud.ToString());


            data_Schedule_lst = new List<Data_Schedule>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Schedule data_Schedule_row = new Data_Schedule();
                        int colIndex = dr.GetOrdinal("DateLn");
                        data_Schedule_row.DateLn = Convert.ToString(dr.GetDateTime(colIndex).ToString("yyyy-MM-dd"));
                        colIndex = dr.GetOrdinal("TimeStart");
                        if (!dr.IsDBNull(colIndex))
                        {
                            data_Schedule_row.StartTime = dr.GetTimeSpan(colIndex).ToString(@"hh\:mm");
                        }
                        colIndex = dr.GetOrdinal("TimeFinish");
                        if (!dr.IsDBNull(colIndex))
                        {
                            data_Schedule_row.FinishTime = dr.GetTimeSpan(colIndex).ToString(@"hh\:mm");

                        }
                        colIndex = dr.GetOrdinal("RoomName");
                        data_Schedule_row.RoomName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("SubjName");
                        data_Schedule_row.SubjName = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("TypeGrade");
                        data_Schedule_row.TypeGrade = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("TypeGrade");
                        data_Schedule_row.TypeGrade = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("Teacher");
                        data_Schedule_row.Teacher = dr.GetString(colIndex);
                        data_Schedule_lst.Add(data_Schedule_row);

                       
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

    public class Data_Schedule
    {
        public string DateLn { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string RoomName { get; set; }
        public string SubjName { get; set; }
        public string TypeGrade { get; set; }
        public string Teacher { get; set; }
    }
}
