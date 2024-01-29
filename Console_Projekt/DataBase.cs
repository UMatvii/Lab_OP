using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Console_Projekt
{
    public class DataBase
    {
        SqlConnection db;
        public void DBConnect()
        {
            try
            {
                db = new SqlConnection("Server=MATVII\\MSSQLSERVER01; Database=Projekt_BD; Trusted_Connection=True; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True");
                if (db.State != ConnectionState.Open)
                {
                    db.Open();
                }
            }

            finally
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Dispose();
                }
            }
        }
    }
}
