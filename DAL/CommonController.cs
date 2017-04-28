using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommonController
    {

        private static CommonController Instance = new CommonController();

        public static CommonController GetControllerInstance()
        {
            return Instance;
        }

        /*
        public static IList<object[]> GetLoginBdd()
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT login_user, passwd_user FROM public.user"));
        }

        public static IList<object[]> GetAdressEnt()
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT adresse, ville, cp FROM entreprise;"));
        }
        */

    }
}