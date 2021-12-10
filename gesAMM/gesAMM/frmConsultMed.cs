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
using System.Data;

namespace gesAMM
{
    public partial class frmConsultMed : Form
    {
        public frmConsultMed()
        {
            InitializeComponent();
        }

        private void lvConsulMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetailMedFam.Items.Clear();
            if (lvConsulMed.SelectedIndices.Count <= 0)
            {
                return;
            }
            int idx = lvConsulMed.SelectedIndices[0]; if (idx >= 0)
            {
                string codeFam = lvConsulMed.SelectedItems[0].Text.ToString(); bd.Connexion.Open();
                SqlCommand maRequete = new SqlCommand("prc_medicament_famille", bd.Connexion);
                maRequete.CommandType = CommandType.StoredProcedure; // Ajouter les parameters à la procédure stockée
                SqlParameter paramFamCode = new SqlParameter("@fam_code", SqlDbType.VarChar, 5);
                paramFamCode.Value = codeFam; maRequete.Parameters.Add(paramFamCode); SqlDataReader allData = maRequete.ExecuteReader();
                while (allData.Read())
                {
                    ListViewItem ligne = new ListViewItem(); ligne.Text = allData.GetValue(0).ToString();
                    ligne.SubItems.Add(allData.GetValue(1).ToString());
                    ligne.SubItems.Add(allData.GetValue(2).ToString());
                    ligne.SubItems.Add(allData.GetValue(3).ToString());
                    ligne.SubItems.Add(allData.GetValue(4).ToString());
                    ligne.SubItems.Add(allData.GetValue(5).ToString());
                    ligne.SubItems.Add(allData.GetValue(6).ToString());
                    ligne.SubItems.Add(allData.GetValue(7).ToString());
                    lvDetailMedFam.Items.Add(ligne);
                }
                bd.Connexion.Close();
            }
        }

        private void frmConsultMed_Load(object sender, EventArgs e)
        {
            // foreach sur la classe faite dans bd
            foreach (Famille laFamille in Globale.lesFamilles)
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = laFamille.getCode().ToString();
                ligne.SubItems.Add(laFamille.getLibelle());

                int nbMedocs = 0;

                // appel la procédure 
                bd.Connexion.Open();
                SqlCommand maRequete = new SqlCommand("prc_medicament_famille", bd.Connexion);
                maRequete.CommandType = CommandType.StoredProcedure;

                // Ajouter les parametres à la procédure stockée, 
                SqlParameter paramFamCode = new SqlParameter("@fam_code", SqlDbType.VarChar, 5);
                paramFamCode.Value = laFamille.getCode().ToString();

                // on affiche le nombre de medicaments par famille
                maRequete.Parameters.Add(paramFamCode);
                SqlDataReader allData = maRequete.ExecuteReader();

                // lire la procédure
                while (allData.Read())
                {
                    nbMedocs++; //compte le nombre de médicaments
                }
                //affiche dans la listView
                ligne.SubItems.Add(nbMedocs.ToString());
                bd.Connexion.Close();

                lvConsulMed.Items.Add(ligne);
            }
        }
    

    
    }
}
