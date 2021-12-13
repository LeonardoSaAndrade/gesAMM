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
    }
}
