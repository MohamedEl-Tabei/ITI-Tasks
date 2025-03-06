using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
namespace ITI.DataAccessLayer
{
    public class DBManager
    {
        public DataTable DTable { get; set; }
        
        public static DataTable ExecuteQuery(string query)
        {
            var dt=new DataTable();
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBITI"].ConnectionString);
            var cmd=new SqlCommand(query,conn);
            var adapter=new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters ) {
            int affected = 0;
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBITI"].ConnectionString);
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            try
            {
                conn.Open();
                affected = cmd.ExecuteNonQuery();

            }
            finally { conn.Close(); }
            return affected;
        }
    }
}
