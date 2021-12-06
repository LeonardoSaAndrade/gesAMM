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
    public partial class frmMajEtape : Form
    {
        public frmMajEtape()
        {
            InitializeComponent();
        }

        private void frmMajEtape_Load(object sender, EventArgs e)
        {
            foreach(EtapeNormee uneEtapeNormee in Globale.lesEtapesNormee)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = uneEtapeNormee.getNum().ToString();
                ligne.SubItems.Add(uneEtapeNormee.getNorme());
                ligne.SubItems.Add(uneEtapeNormee.getDateNorme().ToString().Substring(0,10));

                lvEtapeNormee.Items.Add(ligne);
            }

            btUpdate.Enabled = false;
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btUpdate.Enabled = true;
            tbMajNorme.Text = lvEtapeNormee.SelectedItems.ToString();
        }
    }
}
