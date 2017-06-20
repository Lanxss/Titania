using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace BLL
{
    public class Uti
    {
        // Convertie une chaine en MD5
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static bool checkUrlFolder(string url)
        {
            bool f_check = true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                }
            }
            catch (WebException)
            {
                f_check = false;
                return false;
            }

            return f_check;
        }

        // Créer le dossier souhaité si il n'existe pas
        public static string createFolderServ(string url)
        {
            string w_rep = "";
            try
            {
                string folder_create = "";
                if (url.IndexOf(BLL.BLL_login.url_serv) != -1)
                {
                    folder_create = url.Substring(url.IndexOf(BLL.BLL_login.url_serv) + BLL.BLL_login.url_serv.Length + 1);
                    using (var client = new SshClient("37.59.36.109", "root", "c.+Ywu{7yj)qQb1h"))
                    {
                        client.Connect();
                        client.RunCommand("mkdir /var/www/html/" + folder_create);
                        client.Disconnect();
                    }
                }
                else
                {
                    w_rep = "Erreur lors de la récupération du nom du dossier projet";
                    Console.WriteLine(w_rep);
                    return w_rep;
                }
            }
            catch (WebException)
            {
                w_rep = "Erreur : pas de dossier associé au projet => création";
                Console.WriteLine(w_rep);
                return w_rep;
            }

            return w_rep;
        } // Fin createFolderServ

        // Créer le dossier souhaité si il n'existe pas
        public static string sendFile(string folder, string path)
        {
            string w_rep = "";
            string file = path.Substring(path.LastIndexOf("\\") + 1);
            try
            {
                var client = new SftpClient("37.59.36.109", 22, "root", "c.+Ywu{7yj)qQb1h");
                client.Connect();
                if (client.IsConnected)
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    if (fs != null)
                    {
                        //If you have a folder located at sftp://ftp.example.com/share
                        //then you can add this like:
                        client.UploadFile(fs, "/var/www/html/" + folder + "/" + file, null);
                        client.Disconnect();
                        client.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                w_rep = "Erreur à l'envoie du fichier '" + file + "'";
                return w_rep;
            }


            return w_rep;
        } // Fin sendFile

        public static string UploadFileToFTP(string source)
        {
            string err = "";

            try
            {
                string filename = Path.GetFileName(source);
                string ftpfullpath = "ftp://ftp.37.59.36.109:22/root/";
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential("root", "c.+Ywu{7yj)qQb1h");
                // Port 22
               
                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                // FileStream fs = File.OpenRead(source);
                source = "D:\\testfolder\\testfile.txt";
                FileStream fs = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
            }
            catch (Exception ex)
            {
                err = "Erreur lors de l'envoi des fichiers : " + ex.Message;
                return err;
            }

            return err;
        }

    }
}
