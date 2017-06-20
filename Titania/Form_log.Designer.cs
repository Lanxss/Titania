namespace Titania
{
    partial class Form_log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_err = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.tbx_mdp = new System.Windows.Forms.TextBox();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_err);
            this.panel2.Controls.Add(this.btn_connexion);
            this.panel2.Controls.Add(this.tbx_mdp);
            this.panel2.Controls.Add(this.tbx_login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(27, 34);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(338, 144);
            this.panel2.TabIndex = 10;
            // 
            // lbl_err
            // 
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_err.Location = new System.Drawing.Point(3, 105);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(338, 31);
            this.lbl_err.TabIndex = 8;
            this.lbl_err.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_connexion
            // 
            this.btn_connexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_connexion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_connexion.Location = new System.Drawing.Point(148, 79);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(111, 23);
            this.btn_connexion.TabIndex = 7;
            this.btn_connexion.Tag = "";
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // tbx_mdp
            // 
            this.tbx_mdp.Location = new System.Drawing.Point(148, 53);
            this.tbx_mdp.Name = "tbx_mdp";
            this.tbx_mdp.PasswordChar = '*';
            this.tbx_mdp.Size = new System.Drawing.Size(111, 20);
            this.tbx_mdp.TabIndex = 6;
            this.tbx_mdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_mdp_KeyDown);
            // 
            // tbx_login
            // 
            this.tbx_login.Location = new System.Drawing.Point(148, 27);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(111, 20);
            this.tbx_login.TabIndex = 5;
            this.tbx_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_login_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(88, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login :";
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 210);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.Form_log_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.TextBox tbx_mdp;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}