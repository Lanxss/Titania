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

        public static IList<object[]> ConnexionUser(String login, String mdp)
        {
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM check_login('" + login + "', '" + mdp + "')"));
        }

        public static IList<object[]> getIdUser(String login)
        {
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM return_iduser('" + login + "')"));
        }

        public static IList<object[]> GetUser()
        {
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM public.user"));
        }

        // Retourne les projets associés à l'utilisateur
        public static IList<object[]> Getproject(string login)
        {
            // 0 : idUser, 1 : Id du projet, 2 : Nom du projet, 3 : Date de création du projet, 4 : Chemin du dossier du projet
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM association_project('" 
                + login + "') as f(id BIGINT, id_projet INTEGER, name VARCHAR, date_creation DATE, repo_src VARCHAR);"));
        }

        // Retourne la description d'un projet
        public static string GetDescprojet(int id_projet)
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM getdesc('" + id_projet + "')"))[0][0].ToString();
        }

        // Ajoute un projet
        public static IList<object[]> CreateProjet(string name, string desc, int iduser)
        {
            Console.WriteLine("Nom : " + name + " desc " + desc + " iduser " + iduser);
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM create_project('"+ name + "', '" + desc + "', '" + iduser + "')"));
        }

    }
}