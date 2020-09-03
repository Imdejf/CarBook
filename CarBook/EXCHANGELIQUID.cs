using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook
{
    class EXCHANGELIQUID
    {
        CONNECT conn = new CONNECT();
        public DataTable getCar()
        {
            SqlCommand command = new SqlCommand("SELECT CarBase.carBrand, CarBase.carModel, CarBase.carRegistration,CarBase.ID FROM CarBase", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //number of records satisfying the condition
        public bool countRecord(int id)
        {
            SqlCommand command = new SqlCommand();
            string removeQuery = $"SELECT COUNT(*) FROM LiquidBase, CarBase WHERE  {id} = LiquidBase.liquidIdentityID";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();
            conn.openConnection();
            Int32 count = (Int32)command.ExecuteScalar();
            if (count < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Create a function to instert information about liquids
        public bool insertLiquid(string liquidOne, string liquidTwo, string liquidThree, string liquidFour, string liquidFive, DateTime dateOne, DateTime dateTwo, DateTime dateThree, DateTime dateFour, DateTime dateFive, int liquidIdentityID)
        {
            SqlCommand command = new SqlCommand();
            string insertLiquid = "INSERT INTO LiquidBase (LiquidBase.liquidOne,LiquidBase.liquidTwo,LiquidBase.liquidThree,LiquidBase.liquidFour,LiquidBase.liquidFive,LiquidBase.dateOne,LiquidBase.dateTwo,LiquidBase.dateThree,LiquidBase.dateFour,LiquidBase.dateFive,LiquidBase.liquidIdentityID) VALUES (@lOn,@lTw,@lTh,@lFo,@lFi,@dOn,@dTw,@dTh,@dFo,@dFi,@lID)";
            command.CommandText = insertLiquid;
            command.Connection = conn.GetConnection();
            //@lOn,@lTw,@lTh,@lFo,@lFi,@dOn,@dTw,@dTh,@dFo,@dFi,@lID
            command.Parameters.Add("@lOn", SqlDbType.VarChar).Value = liquidOne;
            command.Parameters.Add("@lTw", SqlDbType.VarChar).Value = liquidTwo;
            command.Parameters.Add("@lTh", SqlDbType.VarChar).Value = liquidThree;
            command.Parameters.Add("@lFo", SqlDbType.VarChar).Value = liquidFour;
            command.Parameters.Add("@lFi", SqlDbType.VarChar).Value = liquidFive;
            command.Parameters.Add("@dOn", SqlDbType.Date).Value = dateOne;
            command.Parameters.Add("@dTw", SqlDbType.Date).Value = dateTwo;
            command.Parameters.Add("@dTh", SqlDbType.Date).Value = dateThree;
            command.Parameters.Add("@dFo", SqlDbType.Date).Value = dateFour;
            command.Parameters.Add("@dFi", SqlDbType.Date).Value = dateFive;
            command.Parameters.Add("@lID", SqlDbType.Int).Value = liquidIdentityID;
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
        //Update last record
        public bool editLiquid(string liquidOne, string liquidTwo, string liquidThree, string liquidFour, string liquidFive, DateTime dateOne, DateTime dateTwo, DateTime dateThree, DateTime dateFour, DateTime dateFive, int ID)
        {
            SqlCommand command = new SqlCommand();

            string editQuery = "UPDATE LiquidBase SET LiquidBase.liquidOne =@lOn ,LiquidBase.liquidTwo = @lTw ,LiquidBase.liquidThree = @lTh,LiquidBase.liquidFour = @lFo,LiquidBase.liquidFive = @lFi,LiquidBase.dateOne = @dOn,LiquidBase.dateTwo = @dTw,LiquidBase.dateThree = @dTh,LiquidBase.dateFour = @dFo,LiquidBase.dateFive = @dFi WHERE liquidIdentityID = @lID";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();
            //@lOn,@lTw,@lTh,@lFo,@lFi,@dOn,@dTw,@dTh,@dFo,@dFi,@lID
            command.Parameters.Add("@lOn", SqlDbType.VarChar).Value = liquidOne;
            command.Parameters.Add("@lTw", SqlDbType.VarChar).Value = liquidTwo;
            command.Parameters.Add("@lTh", SqlDbType.VarChar).Value = liquidThree;
            command.Parameters.Add("@lFo", SqlDbType.VarChar).Value = liquidFour;
            command.Parameters.Add("@lFi", SqlDbType.VarChar).Value = liquidFive;
            command.Parameters.Add("@dOn", SqlDbType.Date).Value = dateOne;
            command.Parameters.Add("@dTw", SqlDbType.Date).Value = dateTwo;
            command.Parameters.Add("@dTh", SqlDbType.Date).Value = dateThree;
            command.Parameters.Add("@dFo", SqlDbType.Date).Value = dateFour;
            command.Parameters.Add("@dFi", SqlDbType.Date).Value = dateFive;
            command.Parameters.Add("@lID", SqlDbType.Int).Value = ID;
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
        public DataTable displayData(int ID)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM LiquidBase WHERE {ID} = LiquidBase.liquidIdentityID", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
