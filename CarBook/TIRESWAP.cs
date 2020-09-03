 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook
{
    class TIRESWAP
    {
        CONNECT conn = new CONNECT();

        //create a function to get the cars list
        public DataTable getCar()
        {
            SqlCommand command = new SqlCommand("SELECT CarBase.CarBrand,CarBase.carModel,CarBase.carRegistration,CarBase.ID FROM CarBase", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        //create a function to insert a new tire information

        public bool insertTire(string tireName, string tireSize, DateTime tireSwap, int tireIdentityID)
        {
            SqlCommand command = new SqlCommand();
            string insertQuery = "INSERT INTO TireBase(tireName,tireSize,tireSwap,tireIdentityID)VALUES(@tN,@tSi,@tSw,@tII)";      
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            //@tN,@tSi,@ID,@tSw
            command.Parameters.Add("@tN", SqlDbType.VarChar).Value = tireName;
            command.Parameters.Add("@tSi", SqlDbType.VarChar).Value = tireSize;
            command.Parameters.Add("@tSw", SqlDbType.DateTime).Value = tireSwap;
            command.Parameters.Add("@tII", SqlDbType.VarChar).Value = tireIdentityID;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        //create a function to get the tires list
        public DataTable getTire()
        {
            SqlCommand command = new SqlCommand($" SELECT TireBase.tireName, TireBase.tireSize,TireBase.tireSwap,TireBase.ID FROM TireBase,CarBase WHERE TireBase.tireIdentityID=CarBase.ID ", conn.GetConnection()) ;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        //create a function to display tire for choosed car
        public DataTable DisplayTire(int id)
        {
            SqlCommand command = new SqlCommand($" SELECT TireBase.tireName, TireBase.tireSize,TireBase.tireSwap,TireBase.ID FROM TireBase,CarBase WHERE TireBase.tireIdentityID = {id} AND TireBase.tireIdentityID = CarBase.ID  ", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public bool removeTire(int ID)
        {
            SqlCommand command = new SqlCommand();
            string removeQuery = "DELETE FROM TireBase WHERE ID = @tID";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();
            //@tID
            command.Parameters.Add("@tID", SqlDbType.Int).Value = ID;
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public bool editTire(string tireName, string tireSize, DateTime tireSwap,int ID)
        {
            SqlCommand command = new SqlCommand();
            string editQuery = "UPDATE TireBase SET tireName = @tNa,tireSize = @tSi,tireSwap = @tSw WHERE ID = @tID";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();
            //@tNa,@tSi,@tSw,@tID
            command.Parameters.Add("@tNa", SqlDbType.VarChar).Value = tireName;
            command.Parameters.Add("@tSi", SqlDbType.VarChar).Value = tireSize;
            command.Parameters.Add("@tSw", SqlDbType.DateTime).Value = tireSwap;
            command.Parameters.Add("@tID", SqlDbType.Int).Value = ID;
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }
    }
}
