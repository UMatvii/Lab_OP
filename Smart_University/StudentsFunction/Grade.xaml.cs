using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Xml.Linq;

namespace Smart_University.StudentsFunction
{
    /// <summary>
    /// Interaction logic for Grade.xaml
    /// </summary>
    public partial class Grade : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public ObservableCollection<Data_Grade> data_Grades_lst { get; set; }
        public Grade(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();

            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;
            

            SqlCommand com = new SqlCommand("SELECT SJ.SubjName AS SubjName, TG.TypeGrade AS TypeSubject, G.GradeI AS GradeI, G.GradeII AS GradeII, g.GradeIII AS GradeIII FROM Students S INNER JOIN Grades G ON S.IDStudent = G.IDStudent INNER JOIN TypeGrades TG ON G.IDGrade = TG.IDGrade INNER JOIN Subjects SJ ON G.IDSubject = SJ.IDSubject WHERE S.IDStudent = @idStud", db_par.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Grades_lst = new ObservableCollection<Data_Grade>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Grade data_Grade_row = new Data_Grade();
                        int colIndex = dr.GetOrdinal("SubjName");
                        data_Grade_row.SubjName = dr.GetString(colIndex);                        
                        colIndex = dr.GetOrdinal("TypeSubject");
                        data_Grade_row.TypeSubject = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("GradeI");
                        if (!dr.IsDBNull(colIndex))
                        {
                            data_Grade_row.GradeI = Convert.ToInt32(dr["GradeI"]);
                        }
                        
                        colIndex = dr.GetOrdinal("GradeII");
                        if (!dr.IsDBNull(colIndex))
                        {
                            data_Grade_row.GradeII = Convert.ToInt32(dr["GradeII"]);
                        }

                        colIndex = dr.GetOrdinal("GradeIII");
                        if (!dr.IsDBNull(colIndex))
                        {
                            data_Grade_row.GradeIII = Convert.ToInt32(dr["GradeIII"]);
                        }
                        data_Grades_lst.Add(data_Grade_row);
                    }
                }
            }
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(user.IDStudent,user,db);
            mainWindow.Show();
            Hide();
        }


    }
    public class Data_Grade
    {
        public string SubjName { get; set; }
        public string TypeSubject { get; set; }
        public int GradeI { get; set; }
        public int GradeII { get; set; }
        public int GradeIII { get; set; }
    }
}
