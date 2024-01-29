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
    /// Interaction logic for Transactions.xaml
    /// </summary>
    public partial class Transactions : Window
    {
        User user;
        DataBase db;
        int id_Stud;

        public List<Data_Transaction> data_Transaction_lst { get; set; }
        public Transactions(int idStud, User user_par, DataBase db_par)
        {
            InitializeComponent();
            DataContext = this;
            id_Stud = idStud;
            db = db_par;
            user = user_par;


            SqlCommand com = new SqlCommand("SELECT TypeTransaction, Amount, DateTransaction, Description\r\nFROM Transactions WHERE IDStudent = @idStud", db.DBConnect());
            com.Parameters.AddWithValue("@idStud", id_Stud);

            data_Transaction_lst = new List<Data_Transaction>();
            using (SqlDataReader dr = com.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data_Transaction data_Transaction_row = new Data_Transaction();
                        int colIndex = dr.GetOrdinal("TypeTransaction");
                        data_Transaction_row.TypeTrans = dr.GetString(colIndex);
                        colIndex = dr.GetOrdinal("Amount");
                        data_Transaction_row.Amount = Convert.ToInt32(dr.GetDecimal(colIndex));
                        colIndex = dr.GetOrdinal("DateTransaction");
                        data_Transaction_row.DateTrans = Convert.ToString(dr.GetDateTime(colIndex).ToString("yyyy-MM-dd"));
                        colIndex = dr.GetOrdinal("Description");
                        data_Transaction_row.Descript = dr.GetString(colIndex);
                        data_Transaction_lst.Add(data_Transaction_row);
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

    public class Data_Transaction
    {
        public string TypeTrans { get; set; }
        public int Amount { get; set; }
        public string DateTrans { get; set; }
        public string Descript { get; set; }
    }
}
