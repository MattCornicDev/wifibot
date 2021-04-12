
namespace wifiBot
{
    partial class Principale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerUnRoversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerUnRoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerUnRoverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.piloterUnRoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piloterLeRoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utiliserLaSynthèseVocaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerUnRoversToolStripMenuItem,
            this.sélectionnerUnRoverToolStripMenuItem,
            this.piloterUnRoverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerUnRoversToolStripMenuItem
            // 
            this.gérerUnRoversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneConfigurationToolStripMenuItem});
            this.gérerUnRoversToolStripMenuItem.Name = "gérerUnRoversToolStripMenuItem";
            this.gérerUnRoversToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.gérerUnRoversToolStripMenuItem.Text = "Configuration";
            // 
            // ajouterUneConfigurationToolStripMenuItem
            // 
            this.ajouterUneConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneConfigurationToolStripMenuItem1,
            this.supprimerUneConfigurationToolStripMenuItem1});
            this.ajouterUneConfigurationToolStripMenuItem.Name = "ajouterUneConfigurationToolStripMenuItem";
            this.ajouterUneConfigurationToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.ajouterUneConfigurationToolStripMenuItem.Text = "Gérer les rovers";
            // 
            // ajouterUneConfigurationToolStripMenuItem1
            // 
            this.ajouterUneConfigurationToolStripMenuItem1.Name = "ajouterUneConfigurationToolStripMenuItem1";
            this.ajouterUneConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(340, 34);
            this.ajouterUneConfigurationToolStripMenuItem1.Text = "Ajouter une configuration";
            this.ajouterUneConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneConfigurationToolStripMenuItem1_Click);
            // 
            // supprimerUneConfigurationToolStripMenuItem1
            // 
            this.supprimerUneConfigurationToolStripMenuItem1.Name = "supprimerUneConfigurationToolStripMenuItem1";
            this.supprimerUneConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(340, 34);
            this.supprimerUneConfigurationToolStripMenuItem1.Text = "supprimer une configuration";
            this.supprimerUneConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.supprimerUneConfigurationToolStripMenuItem1_Click);
            // 
            // sélectionnerUnRoverToolStripMenuItem
            // 
            this.sélectionnerUnRoverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sélectionnerUnRoverToolStripMenuItem1});
            this.sélectionnerUnRoverToolStripMenuItem.Name = "sélectionnerUnRoverToolStripMenuItem";
            this.sélectionnerUnRoverToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.sélectionnerUnRoverToolStripMenuItem.Text = "Sélectionner";
            // 
            // sélectionnerUnRoverToolStripMenuItem1
            // 
            this.sélectionnerUnRoverToolStripMenuItem1.Name = "sélectionnerUnRoverToolStripMenuItem1";
            this.sélectionnerUnRoverToolStripMenuItem1.Size = new System.Drawing.Size(281, 34);
            this.sélectionnerUnRoverToolStripMenuItem1.Text = "Sélectionner un rover";
            this.sélectionnerUnRoverToolStripMenuItem1.Click += new System.EventHandler(this.sélectionnerUnRoverToolStripMenuItem1_Click);
            // 
            // piloterUnRoverToolStripMenuItem
            // 
            this.piloterUnRoverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piloterLeRoverToolStripMenuItem,
            this.utiliserLaSynthèseVocaleToolStripMenuItem1});
            this.piloterUnRoverToolStripMenuItem.Name = "piloterUnRoverToolStripMenuItem";
            this.piloterUnRoverToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.piloterUnRoverToolStripMenuItem.Text = "Piloter";
            // 
            // piloterLeRoverToolStripMenuItem
            // 
            this.piloterLeRoverToolStripMenuItem.Name = "piloterLeRoverToolStripMenuItem";
            this.piloterLeRoverToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.piloterLeRoverToolStripMenuItem.Text = "Piloter le rover";
            this.piloterLeRoverToolStripMenuItem.Click += new System.EventHandler(this.piloterLeRoverToolStripMenuItem_Click);
            // 
            // utiliserLaSynthèseVocaleToolStripMenuItem1
            // 
            this.utiliserLaSynthèseVocaleToolStripMenuItem1.Name = "utiliserLaSynthèseVocaleToolStripMenuItem1";
            this.utiliserLaSynthèseVocaleToolStripMenuItem1.Size = new System.Drawing.Size(314, 34);
            this.utiliserLaSynthèseVocaleToolStripMenuItem1.Text = "Utiliser la synthèse vocale";
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principale";
            this.Text = "Principale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerUnRoversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerUnRoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piloterUnRoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneConfigurationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneConfigurationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerUnRoverToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem piloterLeRoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utiliserLaSynthèseVocaleToolStripMenuItem1;
    }
}

