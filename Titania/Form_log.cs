using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Titania
{
    public partial class Form_log : Form
    {
        public Form_log(string w_msg)
        {
            InitializeComponent();
            lbl_err.Text = w_msg;
            this.ControlBox = false; // Supprime les boutons du cadre
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            lbl_err.Text = "";

            String login = tbx_login.Text.Trim();
            String mdp = tbx_mdp.Text.Trim();

            if (login == "" || mdp == "")
            {
                lbl_err.Text = "Veuillez renseigner le login et le mot de passe !";
                return;
            }

            mdp = BLL.Uti.MD5Hash(mdp);

            System.Console.WriteLine(mdp);

            IList<object[]> o_ligne_user = BLL.CommonController.ConnexionUser(login, mdp);

            if (o_ligne_user[0][0].ToString().Equals("True"))
            {
                Properties.Settings.Default["login"] = login;
                Properties.Settings.Default["mdp"] = mdp;

                Properties.Settings.Default.Save();

                this.Close();
            }
            else
            {
                lbl_err.Text = "Identifiant incorrect !";
            }
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
