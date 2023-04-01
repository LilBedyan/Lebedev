using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebedev
{
    public class DBConnect
    {
        SqlConnection con = new SqlConnection(@"Data Source = db.edu.cchgeu.ru; Initial Catalog = 201s_Lebedev; User = 201s_Lebedev; Password = Vlebedev2002");

        public void openConn()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConn()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConn()
        {
            return con;
        }
    }
}
