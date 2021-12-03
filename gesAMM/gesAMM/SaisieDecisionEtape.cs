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
    public partial class SaisieDecisionEtape : Form
    {
        public SaisieDecisionEtape()
        {
            InitializeComponent();
        }

        private void SaisieDecisionEtape_Load(object sender, EventArgs e)
        {
            foreach(Medicament medicament in Globale )
            cbMedicament.Items.Add()
        }

        private void btValiderMedicament_Click(object sender, EventArgs e)
        {
            int derniereEtape = cbMedicament
        }
    }
}
