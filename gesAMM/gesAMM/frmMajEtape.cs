using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gesAMM
{
    public partial class frmMajEtape : Form
    {
        public frmMajEtape()
        {
            InitializeComponent();
        }
        private void chargerHistorique()
        {
            lvhistorique.Items.Clear();



            bd.Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_listHistorique", bd.Connexion);
            maRequete.CommandType = CommandType.StoredProcedure;






            SqlDataReader allData = maRequete.ExecuteReader();




            while (allData.Read())
            {
                ListViewItem ligne = new ListViewItem();




                ligne.Text = allData.GetValue(0).ToString();
                ligne.SubItems.Add(allData.GetValue(1).ToString());
                ligne.SubItems.Add(allData.GetValue(2).ToString());
                ligne.SubItems.Add(allData.GetValue(3).ToString());
                ligne.SubItems.Add(allData.GetValue(4).ToString());
                ligne.SubItems.Add(allData.GetValue(5).ToString());
                ligne.SubItems.Add(allData.GetValue(6).ToString());




                lvhistorique.Items.Add(ligne);
            }
            bd.Connexion.Close();
        }
        private void chargerListe()
        {
            foreach (EtapeNormee uneEtapeNormee in Globale.lesEtapesNormee)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = uneEtapeNormee.getNum().ToString();
                ligne.SubItems.Add(uneEtapeNormee.getNorme());
                ligne.SubItems.Add(uneEtapeNormee.getDateNorme().ToString().Substring(0, 10));

                lvEtapeNormee.Items.Add(ligne);
            }
        }
        private void frmMajEtape_Load(object sender, EventArgs e)
        {

            chargerListe();
            chargerHistorique();
            btUpdate.Enabled = false;

        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btUpdate.Enabled = true;
            if (lvEtapeNormee.SelectedIndices.Count <= 0)
            {
                return;
            }
            int idx = lvEtapeNormee.SelectedIndices[0];



            if (idx >= 0)
            {
                string norm = lvEtapeNormee.Items[idx].SubItems[1].Text;
                string date = lvEtapeNormee.Items[idx].SubItems[2].Text;



                tbMajNorme.Text = norm;
                tbMajDate.Text = date;

            }
           

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            if (tbMajNorme.Text != string.Empty && tbMajDate.Text != string.Empty)
            {
                try
                {
                    int idx = lvEtapeNormee.SelectedIndices[0];
                    int id = int.Parse(lvEtapeNormee.Items[idx].SubItems[0].Text);
                    if (bd.ModifierEtapeNorme(id,tbMajNorme.Text,DateTime.Parse(tbMajDate.Text)))
                    {
                        MessageBox.Show("L'étape a bien été mise à jour");
                        lvEtapeNormee.Items.Clear();
                        chargerListe();
                        chargerHistorique();

                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la mise à jour de l'etape");
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur");
                }
            }
            else
            {
                MessageBox.Show("Erreur, il faut renseigner tous les champs");
            }
        }
    }
}
