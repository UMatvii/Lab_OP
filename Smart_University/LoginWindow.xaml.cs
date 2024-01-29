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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using Smart_University.Users;

namespace Smart_University
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        DataBase db = new DataBase();

        public LoginWindow()
        {
            InitializeComponent();
        }
        private void Btn_SignIn_Clk(object sender, RoutedEventArgs e)
        {

            User user = new User(Login.Text, Password.Password);

            if (user.CheckUser(db.DBConnect()) == false)
            {
                MessageBox.Show("Wrong password or login");
            }
            else
            {
                if (user.user_type == "s")
                {
                    MainWindow mainWindow = new MainWindow(user.IDStudent, user, db);
                    mainWindow.Show();
                }
                else if (user.user_type == "t")
                {
                    //TeacherWindow teacherWindow = new TeacherWindow(user.IDTeacher);
                    //teacherWindow.Show();
                }
                Hide();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
