using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook
{
    class FILTER
    {
        CONNECT conn = new CONNECT();
        //create a function to get cars list 
        public DataTable getCar()
        {
            SqlCommand command = new SqlCommand("SELECT CarBase.carBrand,CarBase.carModel,CarBase.carRegistration,CarBase.ID FROM CarBase",conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tabel = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(tabel);
            return tabel;

        }
        public DataTable getFilters(int id)
        {
            SqlCommand command = new SqlCommand($"SELECT FilterBase.filterFuel, FilterBase.filterOil, FilterBase.filterLPG, FilterBase.filterAir, FilterBase.filterCabin, FilterBase.filterRandomName, FilterBase.filterRandom FROM FilterBase,CarBase WHERE FilterBase.filterIdentityID = {id} AND FilterBase.filterIdentityID = CarBase.ID", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tabel = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(tabel);
            return tabel;
        }
        //Create a function to instert information about filter
        public bool insertFilter(string filterFuel, string filterOil, string filterLPG, string filterAir, string filterCabin, string filterRandom, int filterIdentityID, string filterRandomName, DateTime dateFuel, DateTime dateOil, DateTime dateLPG, DateTime dateAir, DateTime dateCabin, DateTime dateRandom)
        {
            SqlCommand command = new SqlCommand();
            string insertQuery = "INSERT INTO FilterBase (filterFuel,filterOil,filterLPG,filterAir,filterCabin,filterRandom,dateFuel, dateOil,dateLPG,dateAir,dateCabin,dateRandom,filterIdentityID, filterRandomName)VALUES (@fF,@fO,@fL,@fA,@fC,@fR,@dF,@dO,@dL,@dA,@dC,@dR,@fID, @fRN)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            //@fF,@fO,@fL,@fA,@fC,@fR,@dF,@dO,@dL,@dA,@dC,@dR
            command.Parameters.Add("@fF", SqlDbType.VarChar).Value = filterFuel;
            command.Parameters.Add("@fO", SqlDbType.VarChar).Value = filterOil;
            command.Parameters.Add("@fL", SqlDbType.VarChar).Value = filterLPG;
            command.Parameters.Add("@fA", SqlDbType.VarChar).Value = filterAir;
            command.Parameters.Add("@fC", SqlDbType.VarChar).Value = filterCabin;
            command.Parameters.Add("@fR", SqlDbType.VarChar).Value = filterRandom;
            command.Parameters.Add("@dF", SqlDbType.Date).Value = dateFuel;
            command.Parameters.Add("@dO", SqlDbType.Date).Value = dateOil;
            command.Parameters.Add("@dL", SqlDbType.Date).Value = dateLPG;
            command.Parameters.Add("@dA", SqlDbType.Date).Value = dateAir;
            command.Parameters.Add("@dC", SqlDbType.Date).Value = dateCabin;
            command.Parameters.Add("@dR", SqlDbType.Date).Value = dateRandom;
            command.Parameters.Add("@fID", SqlDbType.Int).Value = filterIdentityID;
            command.Parameters.Add("@fRN", SqlDbType.VarChar).Value = filterRandomName;
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
        //create a function to display filters
        public DataTable displayFilters(int id)
        {
            SqlCommand command = new SqlCommand($"SELECT FilterBase.filterFuel,FilterBase.filterOil,FilterBase.filterLPG,FilterBase.filterAir,FilterBase.filterCabin,FilterBase.filterRandomName,FilterBase.filterRandom,FilterBase.dateFuel,FilterBase.dateOil,FilterBase.dateLPG,FilterBase.dateAir,FilterBase.dateCabin,FilterBase.dateRandom,FilterBase.ID FROM FilterBase,CarBase WHERE FilterBase.filterIdentityID = {id} AND FilterBase.filterIdentityID = CarBase.ID",conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public bool removeFilter(int ID)
        {
            SqlCommand command = new SqlCommand();
            string removeQuery = "DELETE FROM FilterBase WHERE ID=@ID";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();
            //@ID
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
