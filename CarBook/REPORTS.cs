using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook
{
    class REPORTS
    {
        CONNECT conn = new CONNECT();

        //create a function to get the cars list
        public DataTable getCars()
        {

            SqlCommand command = new SqlCommand("SELECT CarBase.carBrand,CarBase.carRegistration FROM CarBase", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
    }
}
