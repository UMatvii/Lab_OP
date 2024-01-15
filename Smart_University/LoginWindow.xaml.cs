using System;
using System.Collections.Generic;
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

namespace Smart_University
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        DBContext dbcntx = new DBContext();
        

        public LoginWindow()
        {
            InitializeComponent();
           
        }

        public bool IsDarkTheme {  get; set; }
        private readonly PaletteHelper palette = new PaletteHelper();

        private void Btn_SignIn_Clk(object sender, RoutedEventArgs e)
        {
            User user = new User(Login.Text, Password.Password);
            

            if (user.CheckUser(dbcntx) == false)
            {
                MessageBox.Show("Wrong password or login");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();

                
                if (user.user_type == "s")
                {
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Teacher Window");
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
