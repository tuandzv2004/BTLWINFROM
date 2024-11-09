using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhahang.Classes
{
    internal class a
    {
        string strconnect = "Server=DESKTOP-8M88ESB\\SQLEXPRESS;Database=quanlynhahang; Trusted_Connection=True;";
        SqlConnection sqlconnec=null;
        void openconnection()
        {
            sqlconnec = new SqlConnection(strconnect);
            if (sqlconnec.State != ConnectionState.Open)
            {
                sqlconnec.Open();
            }
        }

        void closeconnection() {
            if (sqlconnec.State != ConnectionState.Closed) {
                sqlconnec.Close();
                sqlconnec.Dispose();
            }
        }
        public DataTable readdata(string str) {
            DataTable dt = new DataTable();
            openconnection();
            SqlDataAdapter adapter = new SqlDataAdapter(str, sqlconnec);
            adapter.Fill(dt);
            closeconnection();
            adapter.Dispose();
            return dt;
        }

        public void changedata(string str) {
        
            openconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = str;
            cmd.Connection=sqlconnec;
            cmd.ExecuteNonQuery();
            closeconnection();
            cmd.Dispose();
        }

        public int login(string username, string password)
        {
            int a;
            string query = "SELECT COUNT(1) FROM Account WHERE UserName=@username AND PassWord=@password";
            openconnection();
            SqlCommand commad = new SqlCommand();
            commad.CommandText = query;
            commad.Connection = sqlconnec;
            commad.Parameters.AddWithValue("@username", username);
            commad.Parameters.AddWithValue("@password", password);
            a = Convert.ToInt32(commad.ExecuteScalar());
            return a;
        }


    }
}
