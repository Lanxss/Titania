namespace Titania
{
    partial class Form_titania
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_titania));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_infoproj = new System.Windows.Forms.Panel();
            this.lb_descproj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dtcreation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_nomproj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pan_infoproj.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.connexionToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click_1);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pan_infoproj);
            this.splitContainer1.Size = new System.Drawing.Size(895, 534);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(294, 530);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // pan_infoproj
            // 
            this.pan_infoproj.BackColor = System.Drawing.Color.White;
            this.pan_infoproj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_infoproj.Controls.Add(this.lb_descproj);
            this.pan_infoproj.Controls.Add(this.label4);
            this.pan_infoproj.Controls.Add(this.lb_dtcreation);
            this.pan_infoproj.Controls.Add(this.label3);
            this.pan_infoproj.Controls.Add(this.lb_nomproj);
            this.pan_infoproj.Controls.Add(this.label1);
            this.pan_infoproj.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_infoproj.Location = new System.Drawing.Point(0, 0);
            this.pan_infoproj.Name = "pan_infoproj";
            this.pan_infoproj.Size = new System.Drawing.Size(589, 148);
            this.pan_infoproj.TabIndex = 0;
            this.pan_infoproj.Visible = false;
            // 
            // lb_descproj
            // 
            this.lb_descproj.AutoSize = true;
            this.lb_descproj.Location = new System.Drawing.Point(120, 104);
            this.lb_descproj.MinimumSize = new System.Drawing.Size(50, 0);
            this.lb_descproj.Name = "lb_descproj";
            this.lb_descproj.Size = new System.Drawing.Size(50, 13);
            this.lb_descproj.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description :";
            // 
            // lb_dtcreation
            // 
            this.lb_dtcreation.AutoSize = true;
            this.lb_dtcreation.Location = new System.Drawing.Point(120, 68);
            this.lb_dtcreation.MinimumSize = new System.Drawing.Size(50, 0);
            this.lb_dtcreation.Name = "lb_dtcreation";
            this.lb_dtcreation.Size = new System.Drawing.Size(50, 13);
            this.lb_dtcreation.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date de création :";
            // 
            // lb_nomproj
            // 
            this.lb_nomproj.AutoSize = true;
            this.lb_nomproj.Location = new System.Drawing.Point(120, 32);
            this.lb_nomproj.MinimumSize = new System.Drawing.Size(50, 0);
            this.lb_nomproj.Name = "lb_nomproj";
            this.lb_nomproj.Size = new System.Drawing.Size(50, 13);
            this.lb_nomproj.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom du projet : ";
            // 
            // Form_titania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_titania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titania";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Titania_FormClosed);
            this.Load += new System.EventHandler(this.Form_titania_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pan_infoproj.ResumeLayout(false);
            this.pan_infoproj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.Panel pan_infoproj;
        private System.Windows.Forms.Label lb_descproj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_dtcreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_nomproj;
        private System.Windows.Forms.Label label1;
    }
}

