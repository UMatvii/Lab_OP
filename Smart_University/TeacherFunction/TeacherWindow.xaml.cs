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

namespace Smart_University.Users
{
    /// <summary>
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {

        SqlConnection query_Connect;
        int id_Teacher;
        public TeacherWindow(int idTeacher, SqlConnection queryConnection)
        {
            InitializeComponent();
            id_Teacher = idTeacher;
            query_Connect = queryConnection;
        }
    }
}
