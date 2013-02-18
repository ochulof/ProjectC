using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;


namespace SoccerManager_Webservice
{
    public class DatalaagSoccerManager
    {
        private String strApplicationName = "DataAccessLayer";

        private SqlConnection cnSoccer;
        private SqlDataAdapter adpSoccer = new SqlDataAdapter();
        private SqlCommand cmdSoccer;
        private DataSet dsSoccer = new DataSet();

        private SqlTransaction sqlTransaction;

        public String ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SoccerManager"].ConnectionString;
            }
        }

        public void CreateConnection()
        {
            cnSoccer = new SqlConnection(ConnectionString);
        }
        public DatalaagSoccerManager()
        {
            CreateConnection();
        }
        private void Prepare_StoredProcedureCall(String strStoredProcedure)
        {
            cmdSoccer = new SqlCommand(strStoredProcedure, cnSoccer);
            cmdSoccer.CommandType = CommandType.StoredProcedure;

            adpSoccer = new SqlDataAdapter(cmdSoccer);

            dsSoccer = new DataSet();


            cnSoccer.Open();

            sqlTransaction = cnSoccer.BeginTransaction();
            cmdSoccer.Transaction = sqlTransaction;

        }

        private void Finish_StoredProcedureCall()
        {
            if (cnSoccer.State == ConnectionState.Open)
                cnSoccer.Close();
        }
        public bool AddSpelerGegevens(String voornaam, String naam, String team)
        {
            bool bStatus = false;
            try
            {
                Prepare_StoredProcedureCall("AddSpelerGegevens");

                cmdSoccer.Parameters.AddWithValue("voornaam", voornaam);
                cmdSoccer.Parameters.AddWithValue("naam", naam);
                cmdSoccer.Parameters.AddWithValue("team", team);


                cmdSoccer.ExecuteNonQuery();

                sqlTransaction.Commit();
                bStatus = true;
            }

            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                throw;

            }

            Finish_StoredProcedureCall();
            return bStatus;
        }
    }
}