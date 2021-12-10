using System;
using System.Windows.Forms;
using static gesAMM.bd;

namespace gesAMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMajEtape newFrm = new frmMajEtape();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lireLesEtapesNormes();
            lireAllFamiles();
            lireLesEtapesNormes();
            lireLesMedicaments();
            lireLesEtape();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutMed newFrm = new frmAjoutMed();
            newFrm.MdiParent = this;
            newFrm.Show();

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultMed newFrm = new frmConsultMed();
            newFrm.MdiParent = this;
            newFrm.Show();

        }
    }
}
