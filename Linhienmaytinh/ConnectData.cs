using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linhienmaytinh
{
    class ConnectData
    {
        string sqlConnectionString = "Data Source=ADMIN;Initial Catalog=QL_BANMAYVITINH;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection conn;
        DataTable dt;
        public SqlConnection _CreateConnect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = sqlConnectionString;
            return conn;
        } 


        public DataTable Getdatatable(string sqlquery)
        {
            ConnectData con = new ConnectData();
            SqlConnection conn = new SqlConnection();
            conn = con._CreateConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;

        }

        public int GetScalar(string sqlquery)
        {
            ConnectData con = new ConnectData();
            SqlConnection conn = new SqlConnection();
            conn = con._CreateConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            int scalar = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return scalar;

        }
    }
}
