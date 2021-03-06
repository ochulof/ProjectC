﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Web.Services.Protocols;
using System.Configuration;
using Logging;
namespace SoccerManager_Webservice
{
    /// <summary>
    /// Summary description for SoccerManager_Webservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SoccerManager_Webservice : System.Web.Services.WebService
    {
        private String strAppName = "SoccerManager Service";
        private Logging.Logging LoggingService;
        private DatalaagSoccerManager DataAccess;
        
        
        public SoccerManager_Webservice()
        {
            try
            {
                LoggingService = new Logging.Logging(ConfigurationManager.AppSettings["LoggingPath"] + "WebService.log");
                DataAccess = new DatalaagSoccerManager();
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex.Message);
                throw (ex);
            }
        }

      

        [WebMethod]
        public bool AddSpelerGegevens(String voornaam, String naam, String team)
        {
            try
            {    
                return DataAccess.AddSpelerGegevens(voornaam, naam, team);
                
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool AddTeamGegevens(String naam, String verantwoordelijke, String straat_nr, string postcode, string plaats, string telefoon, string email)
        {
            try
            {
                return DataAccess.AddTeamGegevens(naam,verantwoordelijke,straat_nr,postcode,plaats,telefoon,email);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool AddTeamNaam(String naam)
        {
            try
            {

                return DataAccess.AddTeamNaam(naam);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool AddNieuweWedstrijd(String team1, String team2, String terrein, String poule, String datum, String uur, String scheidsrechter,String opmerking)
        {
            try
            {

                return DataAccess.AddNieuweWedstrijd(team1, team2, terrein, poule, datum, uur, scheidsrechter, opmerking);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public DataSet SelectTeamNaam()
        {
            try{
          
                return DataAccess.SelectTeamNaam();
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
          
        }

        [WebMethod]
        public DataSet SelectSpelerGegevens()
        {
            try
            {

                return DataAccess.SelectSpelerGegevens();
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }

        }

        [WebMethod]
        public DataSet SelectTeamGegevens(string naam)
        {
            try
            {

                return DataAccess.SelectTeamGegevens(naam);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }

        }

        [WebMethod]
        public DataSet SelectTeamNaamPerPoule(string poule)
        {
            try
            {
                return DataAccess.SelectTeamNaamPerPoule(poule);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }

        }


        [WebMethod]
        public DataSet SelectWedstrijden(string gespeeld)
        {
            try
            {
                return DataAccess.SelectWedstrijden(gespeeld);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }

        }

        [WebMethod]
        public DataSet SelectKlassement(String poule)
        {
            try
            {

                return DataAccess.SelectKlassement(poule);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }

        }

        [WebMethod]
        public bool UpdateTeamGelijk(String team, int doel_gemaakt, int doel_tegen)
        {
            try
            {

                return DataAccess.UpdateTeamGelijk(team,doel_gemaakt,doel_tegen);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

         [WebMethod]
        public bool UpdateTeamGewonnen(String team, int doel_gemaakt, int doel_tegen)
        {
            try
            {

                return DataAccess.UpdateTeamGewonnen(team,doel_gemaakt,doel_tegen);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool UpdateTeamVerloren(String team, int doel_gemaakt, int doel_tegen)
        {
            try
            {

                return DataAccess.UpdateTeamVerloren(team,doel_gemaakt,doel_tegen);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool UpdateWedstrijden(String match_id, int goals1, int goals2, String opmerking)
        {
            try
            {

                return DataAccess.UpdateWedstrijden(match_id,goals1,goals2,opmerking);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool UpdateFinaleWedstrijden(String match_id, String team1, String team2, String uur)
        {
            try
            {

                return DataAccess.UpdateFinaleWedstrijden(match_id, team1, team2, uur);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }

        [WebMethod]
        public bool UpdateSpelers(String naam, String voornaam, int goals, int geel, int rood)
        {
            try
            {

                return DataAccess.UpdateSpelers(naam,voornaam,goals,geel,rood);
            }
            catch (Exception ex)
            {
                LoggingService.WriteLine(strAppName, ex);
                throw (ex);
            }
        }
    }
}
