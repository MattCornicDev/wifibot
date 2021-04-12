
namespace wifiBot
{
    partial class ajouterConfig
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
            this.labelNomDuRover = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomDuRover
            // 
            this.labelNomDuRover.AutoSize = true;
            this.labelNomDuRover.Location = new System.Drawing.Point(151, 99);
            this.labelNomDuRover.Name = "labelNomDuRover";
            this.labelNomDuRover.Size = new System.Drawing.Size(114, 20);
            this.labelNomDuRover.TabIndex = 0;
            this.labelNomDuRover.Text = "Nom du Rover ";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(335, 96);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(207, 26);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresse IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Format IP v4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port TCP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "de 15015 à 15020";
            // 
            // buttonValider
            // 
            this.buttonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonValider.Location = new System.Drawing.Point(189, 354);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(133, 38);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(432, 354);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(133, 38);
            this.buttonAnnuler.TabIndex = 7;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // ajouterConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNomDuRover);
            this.Name = "ajouterConfig";
            this.Text = "Ajouter une configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomDuRover;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}