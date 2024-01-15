using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University
{
    class DBContext  
    {
        public SqlConnection db;

        public Boolean DBConnect()
        {
            try
            {
                db = new SqlConnection("Server=MATVII\\MSSQLSERVER01; Database=Projekt_BD; Trusted_Connection=True; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True");
                if (db.State != ConnectionState.Open)
                {
                    db.Open();
                }
                return true;
            }

            finally
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Dispose();
                }
            }
        }
        public void DBClose()
        {
            db.Close();
        }
    }

}
