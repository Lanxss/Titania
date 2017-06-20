using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titania
{
    public partial class Form_add : Form
    {
        public Form_add()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbx_path.Text = folderBrowserDialog.SelectedPath;
            
        }

        // Sélection du dossier du projet
        private string createProjet(string nom, string desc, string path)
        {
            string w_ret = "";
            string namefolder = path.Substring(path.LastIndexOf("\\") + 1);
            string urlfolder = "http://37.59.36.109/" + namefolder;

            try
            {
                // Vérification du dossier sur le serveur
                if (BLL.Uti.checkUrlFolder(urlfolder) == false)
                {
                    string w_rep = BLL.Uti.createFolderServ(urlfolder);
                    if (w_rep != "")
                        return w_rep;
                }

                // Parcours du contenu du dossier par l'envoie des fichiers
                foreach (var file in Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories))
                {
                    if (Path.HasExtension(file))
                    {
                        BLL.Uti.sendFile(namefolder, Path.GetFullPath(file));
                    }
                }

            }
            catch (Exception ex)
            {
                w_ret = ex.Message;
                MessageBox.Show(ex.Message);
                return w_ret;
            }

            BLL.CommonController.CreateProjet(nom, desc, urlfolder);

            return w_ret;

        } // Fin create projet

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_val_Click(object sender, EventArgs e)
        {
            lbl_err.Text = "";

            string nom = tbx_nom.Text.Trim();
            string desc = tbx_desc.Text.Trim();
            string path = tbx_path.Text.Trim();

            if (nom == "" || desc == "" || path == "")
            {
                lbl_err.Text = "Veuillez renseigner tous les champs !";
                return;
            }

            createProjet(nom, desc, path);
            this.Close();
        }
    }
}
