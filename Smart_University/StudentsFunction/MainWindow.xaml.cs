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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase db;
        int id_Stud;
        User user;
        public MainWindow(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            id_Stud = idStud;
            user = user_par;
            db = db_par;
        }

        

        private void Button_LogOut(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void Button_Pod_God_Click(object sender, RoutedEventArgs e)
        {
            Schedule schedule = new Schedule(user.IDStudent, user, db);
            schedule.Show();
            Hide();
        }

        private void Button_Grade_Click(object sender, RoutedEventArgs e)
        {
            Grade grade = new Grade(user.IDStudent, user, db);
            grade.Show();
            Hide();
        }

        private void Button_Document_Click(object sender, RoutedEventArgs e)
        {
            Documents documents = new Documents(user.IDStudent, user, db);
            documents.Show();
            Hide();
        }

        private void Button_Course_Click(object sender, RoutedEventArgs e)
        {
            Course course = new Course(user.IDStudent, user, db);
            course.Show();
            Hide();
        }

        private void Button_Groups_Click(object sender, RoutedEventArgs e)
        {
            GroupsIMod groupsIMod = new GroupsIMod(user.IDStudent, user, db);
            groupsIMod.Show();
            Hide();
        }

        private void Button_DataStud_Click(object sender, RoutedEventArgs e)
        {
            DataStud dataStud = new DataStud(user.IDStudent, user, db);
            dataStud.Show();
            Hide();
        }

        private void Button_TeacherStud_Click(object sender, RoutedEventArgs e)
        {
            Teachers_Stud teachers_Stud = new Teachers_Stud(user.IDStudent, user, db);
            teachers_Stud.Show();
            Hide();
        }

        private void Button_Transaction_Click(object sender, RoutedEventArgs e)
        {
            Transactions transactions = new Transactions(user.IDStudent, user, db);
            transactions.Show();
            Hide();
        }

        private void Button_Setting_Click(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting(user.IDStudent, user, db);
            setting.Show();
            Hide();
        }
    }
}
