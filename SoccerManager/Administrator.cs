using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoccerManager
{
    static class Administrator
    {

        public static Boolean logged = true;

        public static void logIn()
        {
            logged = true;
        }

        public static void logOut()
        {
            logged = false;
        }

        public static Boolean loggedIn()
        {
            if (logged == true)
                return true;
            else
                return false;
        }
       

    }
}
