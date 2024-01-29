using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University
{
    public class DataBase
    {

        SqlConnection db;

        public SqlConnection DBConnect()
        {
            try
            {
                db = new SqlConnection("Server=MATVII\\MSSQLSERVER01; Database=Projekt_BD; Trusted_Connection=True; Encrypt=True;" +
                    " TrustServerCertificate=True; MultipleActiveResultSets=True");
                if (db.State != ConnectionState.Open)
                {
                    db.Open();
                }
                return db;
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
