using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections;

namespace Titania
{
    public partial class Form_titania : Form
    {
        public Form_titania()
        {
            InitializeComponent();
        }

        private void Titania_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Quitte l'application
            System.Windows.Forms.Application.Exit();
            Environment.Exit(Environment.ExitCode);
        }

        private void Form_titania_Load(object sender, EventArgs e)
        {

            // Connexion au serveur 
            try
            {
                BLL.BLL_login.setBLLContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la connexion : " + ex.Message);
                throw;
            }

            // Si pas d'identifiant enregistré => demande d'identification
            if (Properties.Settings.Default["login"].ToString().Equals(""))
            {
                Form_log frm_log = new Form_log("");
                frm_log.ShowDialog(this);
                return;
            }
            else
            {
                IList<object[]> o_ligne_user = BLL.CommonController.ConnexionUser(Properties.Settings.Default["login"].ToString(), Properties.Settings.Default["mdp"].ToString());

                Console.WriteLine("Connexion automatique : " + o_ligne_user[0][0]);

                if (o_ligne_user[0][0].ToString().Equals("False"))
                {
                    Form_log frm_log = new Form_log("Erreur d'identification");
                    frm_log.ShowDialog(this);
                    return;
                }

                loadProject();
            }

        }

        // Chargement des logins de l'utilisateur
        private void loadProject()
        {
            IList<object[]> o_ligne_projet = BLL.CommonController.Getproject(Properties.Settings.Default["login"].ToString());
			String url = "";

            foreach (var projet in o_ligne_projet)
            {
				url = projet[4].ToString();


					
                // createTreeFolder(projet[4].ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string html = reader.ReadToEnd();
                        Regex regex = new Regex(GetDirectoryListingRegexForUrl(url));
                        MatchCollection matches = regex.Matches(html);

						if (url[url.Length - 1] == '/')
							url = url.Substring(0, url.Length - 1);;

						TreeNode treeNode = new TreeNode(url.Substring(url.LastIndexOf("/") + 1));

						if (matches.Count > 0)
                        {
							foreach (Match match in matches)
                            {
								
								try
								{
									treeNode.Nodes.Add(createTreeFolder(treeNode, match));
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message);
								}

								/*
								if (match.Success && match.Groups["name"].ToString().Equals("Description") == false
									&& match.Groups["name"].ToString().Equals("Parent Directory") == false)
                                {
									treeNode.Nodes.Add(match.Groups["name"].ToString());
								}*/
							}
                        }

						treeView1.Nodes.Add(treeNode);
					}
				}

                Console.ReadLine();

                /*
                try
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(projet[4].ToString(), "success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
               
            }
            Console.WriteLine("Projet : " + o_ligne_projet[0][3]);
            Console.WriteLine("Projet : " + o_ligne_projet[1][4]);

		} // Fin loadProject

		private TreeNode createTreeFolder(TreeNode treeNode, Match match)
		{
			String name = "";
			Console.WriteLine(match.Success);
			if (match.Success && match.Groups["name"].ToString().Equals("Description") == false
				&& match.Groups["name"].ToString().Equals("Parent Directory") == false)
			{
				name = match.Groups["name"].ToString();
				Console.WriteLine(name);

				if (name.IndexOf('/') == -1)
					treeNode.Nodes.Add(name);
				else
				{
					createTreeFolder(treeNode, match);
				}
			}

			return treeNode;
		}


		public static string GetDirectoryListingRegexForUrl(string url)
        {
                return "<a href=\".*\">(?<name>.*)</a>";
            
            throw new NotSupportedException();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            System.Windows.Forms.Application.Exit();
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Déconnexion de l'utilisateur, suppression des identifiants par défaut
            Properties.Settings.Default["login"] = "";
            Properties.Settings.Default["mdp"] = "";

            Properties.Settings.Default.Save();

            Form_log frm_log = new Form_log("");
            frm_log.ShowDialog(this);
        }

        // Option ajouter
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowserDialog.SelectedPath;
                String folder = path;

                try
                {
                    treeView1.Nodes.Add(createTreeFolderLocal(path));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        // Créer une arborescence à partir d'un chemin local
        private TreeNode createTreeFolderLocal(String path)
        {
            String folder = new DirectoryInfo(path).Name;
            TreeNode treeNode = new TreeNode(folder);


            foreach (var file in Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories))
            {
                if (Path.HasExtension(file))
                {
                    treeNode.Nodes.Add(Path.GetFileName(file));
                }
                else
                {
                    TreeNode treeNode_child = new TreeNode(file);

                    treeNode.Nodes.Add(createTreeFolderLocal(file));

                }
            }

            return treeNode;
        }
	

		private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouterToolStripMenuItem_Click(sender, e);
        }
    }
}
