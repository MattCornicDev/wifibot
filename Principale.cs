using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wifiBot
{
    public partial class Principale : Form
    {
        public Principale()
        {
            InitializeComponent();
        }

       

        private void ajouterUneConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouterConfig ajouterConfig = new ajouterConfig();
            ajouterConfig.ShowDialog();
        }

        private void supprimerUneConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListeDesRovers ListeDesrovers = new ListeDesRovers();
            ListeDesrovers.ShowDialog();
        }

        private void sélectionnerUnRoverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSelectionnerUnRover SelectionnerUnRover = new FormSelectionnerUnRover();
            SelectionnerUnRover.ShowDialog();
        }

        private void piloterLeRoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PiloterUnRover piloterUnRover = new PiloterUnRover();
            piloterUnRover.ShowDialog();
        }
    }
}
