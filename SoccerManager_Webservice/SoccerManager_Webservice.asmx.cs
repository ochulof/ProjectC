using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Web.Services.Protocols;
using System.Configuration;

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

        private DatalaagSoccerManager DataAccess;
        
        
        public SoccerManager_Webservice()
        {
            try
            {
                
                DataAccess = new DatalaagSoccerManager();
            }
            catch (Exception ex)
            {
               
                throw (ex);
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
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

                throw (ex);
            }

        }
    }
}
