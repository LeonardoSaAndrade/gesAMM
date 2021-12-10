using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Globale.cnx = new System.Data.SqlClient.SqlConnection();
            //Globale.cnx.ConnectionString = @"Data Source=BTS2020-24\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
            //Globale.cnx.Open();

            BD.recupMecicaments();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationWorkflowEtapesMedicament newFrm = new ConsultationWorkflowEtapesMedicament();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
    }
}
