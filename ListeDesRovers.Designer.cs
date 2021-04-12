
namespace wifiBot
{
    partial class ListeDesRovers
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
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(176, 335);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(138, 42);
            this.buttonSupprimer.TabIndex = 0;
            this.buttonSupprimer.TabStop = false;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(492, 335);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(138, 42);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.TabStop = false;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // ListeDesRovers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonSupprimer);
            this.Name = "ListeDesRovers";
            this.Text = "Liste des rovers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}