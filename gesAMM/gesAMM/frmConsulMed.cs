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
    public partial class frmConsulMed : Form
    {
        public frmConsulMed()
        {
            InitializeComponent();
        }

        private void chargerListeMed()
        {
            foreach (string code in Globale.medicament.Keys)
            {
                ListViewItem ligne = new ListViewItem();

                Medicament unMedicament = Globale.medicament[code];

                ligne.Text = unMedicament.getDepotLegal();
                ligne.SubItems.Add(unMedicament.getNomCommercial());

                lvMed.Items.Add(ligne);
            }
        }

        private void frmConsulMed_Load(object sender, EventArgs e)
        {
            chargerListeMed();
        }

        private void lvWorkflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (EtapeNormee uneEtapeNormee in Globale.lesEtapesNormee)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = uneEtapeNormee.getNum().ToString();
                ligne.SubItems.Add(uneEtapeNormee.getNorme());
                ligne.SubItems.Add(uneEtapeNormee.getDateNorme().ToString().Substring(0, 10));

                lvWorkflow.Items.Add(ligne);
            }
        }
    }
}
