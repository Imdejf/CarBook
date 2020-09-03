using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook
{
    class CONNECT
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3C1LRCQ\SQLEXPRESS;Initial Catalog=CarBook;Integrated Security=True");

        public SqlConnection GetConnection()
        {
            return connection;
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
