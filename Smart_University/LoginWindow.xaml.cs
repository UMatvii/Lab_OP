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
            if(dbcntx.DBConnect() == false)
            {
                test.Text = "NonConncted";
                return;
            }
        }

        private void Btn_SignIn_Clk(object sender, RoutedEventArgs e)
        {
            User user = new User(Login.Text, Password.Password);

            if (user.CheckUser(dbcntx) == false)
            {
                MessageBox.Show("Wrong password or login");
            }
            else
            {
                MessageBox.Show("Correct");
            }
        }
    }
}
