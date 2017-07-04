using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNote.DB
{
    class DBContext
    {
        static string connectionString = "Data Source=.;Initial Catalog=TheNote;Persist Security Info=True;User ID=sa;Password=123456";
        private static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;

        }

        public bool checkAccount(string username, string password)
        {
            string sql = "SELECT  [username],[password] FROM [TheNote].[dbo].[account]";
            SqlConnection sqlConnection = getConnection();
            sqlConnection.Open();
            SqlCommand cmd  = new SqlCommand(sql,sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string user = reader.GetString(0);
                string pass = reader.GetString(1);
                if (user == username && pass == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
