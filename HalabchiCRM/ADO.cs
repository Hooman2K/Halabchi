using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalabchiCRM
{
    class ADO
    {
        SqlConnection sqlc = new SqlConnection(@"data source=.;initial catalog=HalabchiDB;integrated security=True");
        SqlCommand sqlcmd = new SqlCommand();
        public DataTable Select(string str)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sqlc.Open();
            sqlcmd.Connection = sqlc;
            sqlcmd.CommandText = str;
            sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dt);
            sqlc.Close();
            return dt;
        }
    }
}
