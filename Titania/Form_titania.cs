using System;
using System.Windows.Forms;

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
        }

        private void Form_titania_Load(object sender, EventArgs e)
        {

            // Si pas d'identifiant enregistré => demande d'identification
            if(Properties.Settings.Default["login"].ToString() == "")
            {
                Form_log frm_log = new Form_log();
                frm_log.ShowDialog(this);
                return;
            }

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

            Form_log frm_log = new Form_log();
            frm_log.ShowDialog(this);
        }


        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(folderBrowserDialog.SelectedPath);
            }
        }
    }
}
