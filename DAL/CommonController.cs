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

        // Effectue la connexion du login (retourne True ou False)
        public static IList<object[]> ConnexionUser(String login, String mdp)
        {
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM check_login('" + login + "', '" + mdp + "')"));
        }

        // Récupère l'id de l'utilisateur
        public static IList<object[]> getIdUser(String login)
        {
            return DAL.SessionManager.ExecuteQuery(
                String.Format("SELECT * FROM return_iduser('" + login + "')"));
        }

        // Retourne tous les utilisateurs
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

        // Retourne la description d'un projet
        public static IList<object[]> GetDateModifProjet(int id_projet)
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM last_revision_project('" + id_projet 
                + "') as f(id_projet INTEGER, date_revision DATE, max INTEGER);"));
        }

        // Retourne le src d'un projet
        public static IList<object[]> GetSrcProjet(int id_projet)
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM repo_project WHERE id_projet = '" + id_projet + "';"));
        }

        // Retourne la liste des collaborateurs du projet
        public static IList<object[]> GetCollabProjet(int id_projet)
        {
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM collaborateur(" + id_projet + ") as f(login_user CHAR(25))"));
        }

        // Ajoute un projet
        public static IList<object[]> CreateProjet(string name, string desc, int iduser)
        {
            Console.WriteLine("Nom : " + name + " desc " + desc + " iduser " + iduser);
            return DAL.SessionManager.ExecuteQuery(String.Format("SELECT * FROM create_project('"+ name + "', '" + desc + "', '" + iduser + "')"));
        }

    }
}