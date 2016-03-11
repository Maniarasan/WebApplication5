using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class DBFetcher : IDBFetcher
    {
        SqlConnection connection;
        public DBFetcher()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
            connection.Open();
        }

        public void Insert(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand,connection);
            command.ExecuteNonQuery();
        }

        public DataTable Select(string sqlCommand)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, connection);
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
