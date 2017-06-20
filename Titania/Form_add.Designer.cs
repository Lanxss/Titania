namespace Titania
{
    partial class Form_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_err = new System.Windows.Forms.Label();
            this.bt_val = new System.Windows.Forms.Button();
            this.tbx_desc = new System.Windows.Forms.TextBox();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_path = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbx_path);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_cancel);
            this.panel2.Controls.Add(this.lbl_err);
            this.panel2.Controls.Add(this.bt_val);
            this.panel2.Controls.Add(this.tbx_desc);
            this.panel2.Controls.Add(this.tbx_nom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 45);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(378, 236);
            this.panel2.TabIndex = 11;
            // 
            // lbl_err
            // 
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_err.Location = new System.Drawing.Point(0, 165);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(377, 31);
            this.lbl_err.TabIndex = 8;
            this.lbl_err.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_val
            // 
            this.bt_val.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_val.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_val.Location = new System.Drawing.Point(251, 203);
            this.bt_val.Name = "bt_val";
            this.bt_val.Size = new System.Drawing.Size(111, 23);
            this.bt_val.TabIndex = 7;
            this.bt_val.Tag = "";
            this.bt_val.Text = "Valider";
            this.bt_val.UseVisualStyleBackColor = true;
            this.bt_val.Click += new System.EventHandler(this.bt_val_Click);
            // 
            // tbx_desc
            // 
            this.tbx_desc.Location = new System.Drawing.Point(149, 52);
            this.tbx_desc.Multiline = true;
            this.tbx_desc.Name = "tbx_desc";
            this.tbx_desc.Size = new System.Drawing.Size(172, 72);
            this.tbx_desc.TabIndex = 6;
            // 
            // tbx_nom
            // 
            this.tbx_nom.Location = new System.Drawing.Point(149, 26);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(172, 20);
            this.tbx_nom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(48, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(95, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // bt_cancel
            // 
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_cancel.Location = new System.Drawing.Point(14, 203);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(111, 23);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Tag = "";
            this.bt_cancel.Text = "Annuler";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chemin du projet :";
            // 
            // tbx_path
            // 
            this.tbx_path.Location = new System.Drawing.Point(149, 135);
            this.tbx_path.Name = "tbx_path";
            this.tbx_path.ReadOnly = true;
            this.tbx_path.Size = new System.Drawing.Size(172, 20);
            this.tbx_path.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Titania.Properties.Resources._32_FOLDER;
            this.pictureBox1.Location = new System.Drawing.Point(327, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ajouter un projet :";
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un projet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Button bt_val;
        private System.Windows.Forms.TextBox tbx_desc;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}