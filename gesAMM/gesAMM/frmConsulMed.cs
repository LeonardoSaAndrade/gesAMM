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
    public partial class frmConsulMed : Form
    {
        public frmConsulMed()
        {
            InitializeComponent();
        }


        private void frmConsulMed_Load(object sender, EventArgs e)
        {
            bd.Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_listeMedsValid", bd.Connexion);
            SqlDataReader allData = maRequete.ExecuteReader();



            // exécuter la procedure stockée dans un curseur
            while (allData.Read())
            {
                string depotLegal = allData.GetValue(0).ToString();
                string nomCommercial = allData.GetValue(1).ToString();
                string codeFamille = allData.GetValue(2).ToString();



                ListViewItem ligne = new ListViewItem();



                ligne.Text = depotLegal;
                ligne.SubItems.Add(nomCommercial);
                ligne.SubItems.Add(codeFamille.ToString());



                lvMed.Items.Add(ligne);



            }
        }

        private void lvWorkflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Connexion.Open();
            lvWorkflow.Items.Clear();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_ListEtapes", bd.Connexion);
            SqlDataReader allData = maRequete.ExecuteReader();



            // exécuter la procedure stockée dans un curseur
            while (allData.Read())
            {
                DateTime dateDecision = DateTime.Parse(allData.GetValue(0).ToString());
                int numEtape = int.Parse(allData.GetValue(1).ToString());
                int idDecision = int.Parse(allData.GetValue(2).ToString());



                ListViewItem ligne = new ListViewItem();



                ligne.Text = dateDecision.ToString();
                ligne.SubItems.Add(numEtape.ToString());
                ligne.SubItems.Add(idDecision.ToString());
                


                lvWorkflow.Items.Add(ligne);


            }

            bd.Connexion.Close();
        }
    }
}
