using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CarBook
{
    class CAR
    {
        CONNECT conn = new CONNECT();

        SqlCommand command = new SqlCommand();

        //create a function to insert a new car
        public bool insertCar(string carBrand, string carBody, string carMilage, string carEngine, string carNumberEnigne, string carRegistration, string carModel, DateTime carProduction, DateTime carBuy, byte [] carImage,string carPathImage)
        {
            SqlCommand command = new SqlCommand();
            string insertQuery = "INSERT INTO CarBase(carBrand, carEngine, carProduction,carModel,carBody,carBuy,carRegistration,carNumberEngine,carMilage,carPathImage,carImage)VALUES (@cBr,@cE,@cP,@cMo,@cBo,@cBu,@cRe,@cNE,@cM,@cPI,@cI)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            //@cBr,@cE,@cP,@cM,@cBo,@cBu,@cRe,@cNE,@cMo,@cPI,@cI
            command.Parameters.Add("@cBr", SqlDbType.VarChar).Value = carBrand;
            command.Parameters.Add("@cBo", SqlDbType.VarChar).Value = carBody;
            command.Parameters.Add("@cM", SqlDbType.VarChar).Value = carMilage;
            command.Parameters.Add("@cE", SqlDbType.VarChar).Value = carEngine;
            command.Parameters.Add("@cNE", SqlDbType.VarChar).Value = carNumberEnigne;
            command.Parameters.Add("@cRe", SqlDbType.VarChar).Value = carRegistration;
            command.Parameters.Add("@cMo", SqlDbType.VarChar).Value = carModel;
            command.Parameters.Add("@cP", SqlDbType.Date).Value = carProduction;
            command.Parameters.Add("@cBu", SqlDbType.Date).Value = carBuy;
            command.Parameters.Add("@cPI", SqlDbType.VarChar).Value = carPathImage;
            command.Parameters.Add("@cI", SqlDbType.Image).Value = carImage;

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
        //create a function to get the cars list
        public DataTable getCars()
        {

            SqlCommand command = new SqlCommand("SELECT CarBase.carBrand,CarBase.carModel,CarBase.carRegistration,CarBase.carBuy,CarBase.carProduction,CarBase.carBody,CarBase.carMilage,CarBase.carNumberEngine,CarBase.carEngine,CarBase.carImage,CarBase.carPathImage,CarBase.ID FROM CarBase", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public bool removeCar(int id)
        {
            SqlCommand command = new SqlCommand();
            string removeQuery = ("DELETE FROM CarBase WHERE ID=@cID");
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            //@cID
            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public bool editCar(string carBrand, string carBody, string carMilage, string carEngine, string carNumberEnigne, string carRegistration, string carModel, DateTime carProduction, DateTime carBuy, string carPathImage ,byte[] carImage,int ID)
        {
            SqlCommand command = new SqlCommand();
            string editQuery = "UPDATE CarBase SET carBrand=@cB,carEngine =@cE,carModel = @cMo, carNumberEngine = @cNE,carBody = @cBo,carMilage = @cM,carRegistration = @cRe,carBuy = @cBu,carProduction = @cP,carPathImage = @cPI,carImage = @cI WHERE ID=@cID";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();


            //@cB,@cE,@cP,@cM,@cBo, ,@cRe,@cNE,@cMo,@cPI,@cI.@cID
            command.Parameters.Add("@cB", SqlDbType.VarChar).Value = carBrand;
            command.Parameters.Add("@cE", SqlDbType.VarChar).Value = carEngine;
            command.Parameters.Add("@cNE", SqlDbType.VarChar).Value = carNumberEnigne;
            command.Parameters.Add("@cBo", SqlDbType.VarChar).Value = carBody;
            command.Parameters.Add("@cMo", SqlDbType.VarChar).Value = carModel;
            command.Parameters.Add("@cM", SqlDbType.VarChar).Value = carMilage;
            command.Parameters.Add("@cRe", SqlDbType.VarChar).Value = carRegistration;
            command.Parameters.Add("@cBu", SqlDbType.Date).Value = carBuy;
            command.Parameters.Add("@cP", SqlDbType.Date).Value = carProduction;
            command.Parameters.Add("@cPI", SqlDbType.VarChar).Value = carPathImage;
            command.Parameters.Add("@cI", SqlDbType.Image).Value = carImage;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

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
