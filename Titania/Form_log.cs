using System;
using System.Windows.Forms;

namespace Titania
{
    public partial class Form_log : Form
    {
        public Form_log()
        {
            InitializeComponent();
            this.ControlBox = false; // Supprime les boutons du cadre
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default["login"] = tbx_login.Text.Trim();
            Properties.Settings.Default["mdp"] = tbx_mdp.Text.Trim();

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void Form_log_Load(object sender, EventArgs e)
        {


            tbx_login.Text = Properties.Settings.Default["login"].ToString();
            tbx_mdp.Text = Properties.Settings.Default["mdp"].ToString();

        }

        private void tbx_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Passe au champs suivant
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tbx_mdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_connexion_Click(null, null);
            }
        }
    }
}
