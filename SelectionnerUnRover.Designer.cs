
namespace wifiBot
{
    partial class FormSelectionnerUnRover
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(192, 291);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(120, 38);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(431, 291);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 38);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormSelectionnerUnRover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Name = "FormSelectionnerUnRover";
            this.Text = "Selectionner un rover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}