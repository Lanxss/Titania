using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLL_login
    {
        public static string url_serv = "37.59.36.109";

        public static void setBLLContext()
        {   
            DAL.SessionManager.SetSessionContext(url_serv, 5432, "titania", "", true, @"D:\titania.log");

            // Test de récupération de données du serveur
            /*
            foreach (var item in CommonController.GetUser())
            {
                System.Console.WriteLine(item[1]);
            }
            */           
        }
    }
}
