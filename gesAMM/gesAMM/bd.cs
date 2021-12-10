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
        private static string Connexionstring = @"Data Source=BTS2020-32\SQLEXPRESS;Initial Catalog=db_gsam;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);
        //public static void lireLesEtapesNormes()
        //{

        //    //objet SQLCommand pour définir la procédure stockée à utiliser
        //    Connexion.Open();
        //    SqlCommand commande = new SqlCommand("prc_listEtapeNormee", Connexion);
        //    commande.CommandType = CommandType.StoredProcedure;
        //    SqlDataReader resultat = commande.ExecuteReader();

        //    while (resultat.Read())
        //    {
        //        int numEtapeNormee = (int)resultat["ETP_NUM"];
        //        string libelleEtape = resultat["ETP_libelle"].ToString();
        //        string libelleEtapeNormee = resultat["ETP_NORME"].ToString();
        //        DateTime DateNormee = (DateTime)resultat["ETP_DATE_NORME"];

        //        new EtapeNormee(numEtapeNormee,libelleEtape,libelleEtapeNormee, DateNormee);
        //    }
        //    Connexion.Close();
        //}

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

        public static void lireFamille()
        {
            Connexion.Open();
            // appel de la procédure pour récupérer les familles 
            SqlCommand commande = new SqlCommand("prc_listeFamille", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string code = (string)resultat["FAM_CODE"];
                string libelleFamile = resultat["FAM_LIBELLE"].ToString();
                int nbMedi = (int)resultat["nbMediAMM"];

                new Famille(code, libelleFamile, nbMedi);   
            }
            Connexion.Close();

                   
        }

        public static void lireAllFamiles()
        {
            Connexion.Open();
            // on appel la procédure 
            SqlCommand commande = new SqlCommand("prc_select_med_fam", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {   // on récupère les données de la procédure 
                string numFamille = (string)resultat["FAM_CODE"];
                string libelleFamille = resultat["FAM_LIBELLE"].ToString();
                int NombreMedicament = 0;

                Famille laFamille = new Famille(numFamille, libelleFamille, NombreMedicament);
                Globale.lesFamilles.Add(laFamille);
            }
            Connexion.Close();

        }
    }
}
