
namespace wifiBot
{
    partial class PiloterUnRover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiloterUnRover));
            this.buttonReculer = new System.Windows.Forms.Button();
            this.buttonAvancer = new System.Windows.Forms.Button();
            this.buttonDroite = new System.Windows.Forms.Button();
            this.buttonGauche = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReculer
            // 
            this.buttonReculer.Image = ((System.Drawing.Image)(resources.GetObject("buttonReculer.Image")));
            this.buttonReculer.Location = new System.Drawing.Point(430, 302);
            this.buttonReculer.Name = "buttonReculer";
            this.buttonReculer.Size = new System.Drawing.Size(115, 109);
            this.buttonReculer.TabIndex = 0;
            this.buttonReculer.UseVisualStyleBackColor = true;
            // 
            // buttonAvancer
            // 
            this.buttonAvancer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAvancer.Image")));
            this.buttonAvancer.Location = new System.Drawing.Point(432, 45);
            this.buttonAvancer.Name = "buttonAvancer";
            this.buttonAvancer.Size = new System.Drawing.Size(107, 107);
            this.buttonAvancer.TabIndex = 1;
            this.buttonAvancer.UseVisualStyleBackColor = true;
            // 
            // buttonDroite
            // 
            this.buttonDroite.Image = ((System.Drawing.Image)(resources.GetObject("buttonDroite.Image")));
            this.buttonDroite.Location = new System.Drawing.Point(634, 176);
            this.buttonDroite.Name = "buttonDroite";
            this.buttonDroite.Size = new System.Drawing.Size(108, 107);
            this.buttonDroite.TabIndex = 2;
            this.buttonDroite.UseVisualStyleBackColor = true;
            // 
            // buttonGauche
            // 
            this.buttonGauche.Image = ((System.Drawing.Image)(resources.GetObject("buttonGauche.Image")));
            this.buttonGauche.Location = new System.Drawing.Point(247, 176);
            this.buttonGauche.Name = "buttonGauche";
            this.buttonGauche.Size = new System.Drawing.Size(108, 110);
            this.buttonGauche.TabIndex = 3;
            this.buttonGauche.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.Location = new System.Drawing.Point(432, 176);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(109, 107);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // PiloterUnRover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGauche);
            this.Controls.Add(this.buttonDroite);
            this.Controls.Add(this.buttonAvancer);
            this.Controls.Add(this.buttonReculer);
            this.Name = "PiloterUnRover";
            this.Text = "Piloter un rover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReculer;
        private System.Windows.Forms.Button buttonAvancer;
        private System.Windows.Forms.Button buttonDroite;
        private System.Windows.Forms.Button buttonGauche;
        private System.Windows.Forms.Button buttonStop;
    }
}