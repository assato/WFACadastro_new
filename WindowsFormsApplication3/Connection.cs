using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace WindowsFormsApplication3
{
    class ProjectConnection
    {
        private static void OpenSqlConnection()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = @"Server=TESTEPC02\SQLEXPRESS;" + "DataBase=TESTE02;" + @"User Id = ERPPC02\isabela";
            conn.Open();
        }
    }
}