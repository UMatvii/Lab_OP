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
    /// Interaction logic for Documents.xaml
    /// </summary>
    public partial class Documents : Window
    {

        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Document> data_Document_lst { get; set; }
        public Documents(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            id_Stud = idStud;
            db = db_par;
            user = user_par;

            SqlCommand com = new SqlCommand("SELECT TypeDocument, ContentDocument, StatusDocument\r\nFROM Documents WHERE IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Document_lst = new List<Data_Document>();

            using(SqlDataReader reader = com.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Data_Document data_Document_row = new Data_Document();
                        int colIndex = reader.GetOrdinal("TypeDocument");
                        data_Document_row.TypeDocument = reader.GetString(colIndex);
                        colIndex = reader.GetOrdinal("ContentDocument");
                        data_Document_row.ContentDocument = reader.GetString(colIndex);
                        colIndex = reader.GetOrdinal("StatusDocument");
                        data_Document_row.StatusDocument = reader.GetString(colIndex);
                        data_Document_lst.Add(data_Document_row);
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

        public class Data_Document
        {
            public string TypeDocument { get; set; }
            public string ContentDocument { get; set; }
            public string StatusDocument { get; set; }
        }
    }
}
