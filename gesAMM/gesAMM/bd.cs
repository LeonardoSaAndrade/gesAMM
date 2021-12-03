using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace gesAMM
{
    public static class bd
    {
        private static string Connexionstring = @"Data Source=BTS2020-29\SQLEXPRESS;Initial Catalog=db_gsam;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);
        public static void lireLesEtapesNormes()
        {

            //objet SQLCommand pour définir la procédure stockée à utiliser
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_listEtapeNormee", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int numEtapeNormee = (int)resultat["ETP_NUM"];
                string libelleEtape = resultat["ETP_libelle"].ToString();
                string libelleEtapeNormee = resultat["ETP_NORME"].ToString();
                DateTime DateNormee = (DateTime)resultat["ETP_DATE_NORME"];

                new EtapeNormee(numEtapeNormee,libelleEtape,libelleEtapeNormee, DateNormee);
            }
            Connexion.Close();
        }

        public static void lireLesEtape()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_listEtape", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int numEtape = (int)resultat["ETP_NUM"];
                string libelleEtape = resultat["ETP_libelle"].ToString();

                new Etape(numEtape, libelleEtape);
            }
            Connexion.Close();
        }

        public static void lireLesMedicaments()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_listMedicament", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string codeMed = resultat["MED_DEPOTLEGAL"].ToString();
                string nomComMed = resultat["MED_NOMCOMMERCIAL"].ToString();
                string famCode = resultat["FAM_CODE"].ToString();
                string medCompo = resultat["MED_COMPOSITION"].ToString();
                string medEffet = resultat["MED_EFFETS"].ToString();
                string medContreInd = resultat["MED_CONTREINDIC"].ToString();
                string medAmm = resultat["MED_AMM"].ToString();
                int etape = (int)resultat["ETP_NUM"];

            }
            Connexion.Close();
        }


    }
}
