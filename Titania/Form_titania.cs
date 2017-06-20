using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using Modele;
using Renci.SshNet;

namespace Titania
{
    public partial class Form_titania : Form
    {
        public  List<Projet> lst_projets;

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
                this.Show();

            }
        }

        // Chargement des logins de l'utilisateur
        private void loadProject()
        {
            lst_projets = new List<Projet>();

            IList<object[]> o_ligne_projet = BLL.CommonController.Getproject(Properties.Settings.Default["login"].ToString());
			String url = "";

            foreach (var projet in o_ligne_projet)
            {

                string w_desc = BLL.CommonController.GetDescprojet((int)projet[1]);

                lst_projets.Add(new Projet((int)projet[1], projet[2].ToString(), w_desc, (DateTime)projet[3]));


                url = projet[4].ToString();
				
                // Vérification du dossier sur le serveur
                if (BLL.Uti.checkUrlFolder(url) == false)
                {
                    string w_rep = BLL.Uti.createFolderServ(url);
                    if (w_rep != "")
                    {
                        MessageBox.Show(w_rep);
                        return;
                    }
                }

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

                        // Affiche les fichiers contenu dans le projet
						if (matches.Count > 0)
                        {
							foreach (Match match in matches)
                            {
								
								try
								{
                                    createTreeFolder(treeNode, match);

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
            }

		} // Fin loadProject

        private TreeNode createTreeFolder(TreeNode treeNode, Match match)
		{
			String name = "";

			if (match.Success && match.Groups["name"].ToString().Equals("Description") == false
				&& match.Groups["name"].ToString().Equals("Parent Directory") == false)
			{
				name = match.Groups["name"].ToString();

				if (name.IndexOf('/') == -1)
					treeNode.Nodes.Add(name);
				else
				{
                    /* Contenu sous dossier ...
                    createTreeFolder(treeNode, match);
                    */
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
            Form_add frm_add = new Form_add();
            frm_add.ShowDialog(this);
            return;
        }

        // Clic sur l'arborescence
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index_first = e.Node.Index;

            // Clic sur un noeud enfant
            if (e.Node.Level != 0)
                index_first = e.Node.Parent.Index;

            pan_infoproj.Visible = true;
            lb_nomproj.Text = lst_projets[index_first].getName();
            lb_dtcreation.Text = lst_projets[index_first].getDatecreation().ToString().Split(' ')[0];
            lb_descproj.Text = lst_projets[index_first].getDesc();
            

        } // Fin treeView1_AfterSelect

        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_add frm_add = new Form_add();
            frm_add.ShowDialog(this);
            return;
        }
    }
}
