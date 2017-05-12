using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_login
    {
        public static void setBLLContext()
        {
            DAL.SessionManager.SetSessionContext("37.59.36.109", 5432, "titania", "root", true, @"C:\titania.log");
        }
    }
}
