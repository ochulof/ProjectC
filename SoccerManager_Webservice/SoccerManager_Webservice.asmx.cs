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
                //Dim addresses As New AddressDB()
                return DataAccess.AddSpelerGegevens(voornaam, naam, team);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
