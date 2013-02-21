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

        public bool AddTeamGegevens(String naam, String verantwoordelijke, String straat_nr, string postcode, string plaats, string telefoon, string email)
        {
            bool bStatus = false;
            try
            {
                Prepare_StoredProcedureCall("AddTeamGegevens");
                cmdSoccer.Parameters.AddWithValue("naam", naam);
                cmdSoccer.Parameters.AddWithValue("verantwoordelijke",verantwoordelijke);
                cmdSoccer.Parameters.AddWithValue("straat_nr", straat_nr);
                cmdSoccer.Parameters.AddWithValue("postcode", postcode);
                cmdSoccer.Parameters.AddWithValue("plaats", plaats);
                cmdSoccer.Parameters.AddWithValue("telefoon", telefoon);
                cmdSoccer.Parameters.AddWithValue("email", email);
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
        public bool AddTeamNaam(String naam)
        {
            bool bStatus = false;
            try
            {
                Prepare_StoredProcedureCall("AddTeamNaam");
                cmdSoccer.Parameters.AddWithValue("naam", naam);
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

        public bool AddNieuweWedstrijd(String team1, String team2, String terrein, String poule, String datum, String uur, String scheidsrechter, String opmerking)
        {
            bool bStatus = false;
            try
            {
                Prepare_StoredProcedureCall("AddNieuweWedstrijd");
                cmdSoccer.Parameters.AddWithValue("team1", team1);
                cmdSoccer.Parameters.AddWithValue("team2", team2);
                cmdSoccer.Parameters.AddWithValue("terrein", terrein);
                cmdSoccer.Parameters.AddWithValue("poule", poule);
                cmdSoccer.Parameters.AddWithValue("datum", datum);
                cmdSoccer.Parameters.AddWithValue("uur", uur);
                cmdSoccer.Parameters.AddWithValue("scheidsrechter", scheidsrechter);
                cmdSoccer.Parameters.AddWithValue("opmerking", opmerking);

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

        public DataSet SelectTeamNaam()
        {
            try
            {
                Prepare_StoredProcedureCall("SelectTeamNaam");
                adpSoccer.Fill(dsSoccer);
                sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {

                if (sqlTransaction != null)
                    sqlTransaction.Rollback();

                dsSoccer = null;
                //Add additional logging
                
                throw;
            }


            // Close connection
            try
            {
                Finish_StoredProcedureCall();
            }
            catch (SqlException ex)
            {
                dsSoccer = null;
                throw;
            }

            return dsSoccer;
        }

        public DataSet SelectSpelerGegevens()
        {
            try
            {
                Prepare_StoredProcedureCall("SelectSpelerGegevens");
                adpSoccer.Fill(dsSoccer);
                sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {

                if (sqlTransaction != null)
                    sqlTransaction.Rollback();

                dsSoccer = null;
                //Add additional logging

                throw;
            }


            // Close connection
            try
            {
                Finish_StoredProcedureCall();
            }
            catch (SqlException ex)
            {
                dsSoccer = null;
                throw;
            }

            return dsSoccer;
        }

        public DataSet SelectTeamGegevens(string naam)
        {
            try
            {
                Prepare_StoredProcedureCall("SelectTeamGegevens");
                cmdSoccer.Parameters.AddWithValue("naam", naam);
                //  cmdSoccer.ExecuteNonQuery();
                adpSoccer = new SqlDataAdapter(cmdSoccer);
                adpSoccer.Fill(dsSoccer);
                sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {

                if (sqlTransaction != null)
                    sqlTransaction.Rollback();

                dsSoccer = null;
                //Add additional logging

                throw;
            }


            // Close connection
            try
            {
                Finish_StoredProcedureCall();
            }
            catch (SqlException ex)
            {
                dsSoccer = null;
                throw;
            }

            return dsSoccer;
        }

        public DataSet SelectTeamNaamPerPoule(string poule)
        {
            try
            {
                Prepare_StoredProcedureCall("SelectTeamNaamPerPoule");
                cmdSoccer.Parameters.AddWithValue("poule", poule);
              //  cmdSoccer.ExecuteNonQuery();
                adpSoccer = new SqlDataAdapter(cmdSoccer);

                

                adpSoccer.Fill(dsSoccer);
                sqlTransaction.Commit();
                
            }
            catch (SqlException ex)
            {

                if (sqlTransaction != null)
                    sqlTransaction.Rollback();

                dsSoccer = null;
                //Add additional logging

                throw;
            }


            // Close connection
            try
            {
                Finish_StoredProcedureCall();
            }
            catch (SqlException ex)
            {
                dsSoccer = null;
                throw;
            }

            return dsSoccer;
        }

        public DataSet SelectWedstrijden(string gespeeld)
        {
            try
            {
                Prepare_StoredProcedureCall("SelectWedstrijden");
                cmdSoccer.Parameters.AddWithValue("gespeeld", gespeeld);
                //  cmdSoccer.ExecuteNonQuery();
                adpSoccer = new SqlDataAdapter(cmdSoccer);



                adpSoccer.Fill(dsSoccer);
                sqlTransaction.Commit();

            }
            catch (SqlException ex)
            {

                if (sqlTransaction != null)
                    sqlTransaction.Rollback();

                dsSoccer = null;
                //Add additional logging

                throw;
            }


            // Close connection
            try
            {
                Finish_StoredProcedureCall();
            }
            catch (SqlException ex)
            {
                dsSoccer = null;
                throw;
            }

            return dsSoccer;
        }
    }
}