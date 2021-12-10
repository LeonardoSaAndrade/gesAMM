using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace gesAMM
{
    public static class BD
    {
        private static string connectionString = @"Data Source=BTS2020-24\SQLEXPRESS;Initial Catalog=GSB_gesAMM2;Integrated Security=True;MultipleActiveResultSets=True";
        public static SqlConnection connection = new SqlConnection(connectionString);

        public static void recupMecicaments()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("prc_recup_med",connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string depotLegal = reader.GetValue(0).ToString();
                string nomCommercial = reader.GetValue(1).ToString();
                string composition = reader.GetValue(2).ToString();
                string effets = reader.GetValue(3).ToString();
                string contreIndicatif = reader.GetValue(4).ToString();
                string codeFamille = reader.GetValue(5).ToString();
                int dernierEtape = int.Parse(reader.GetValue(7).ToString());

                Medicament medicament = new Medicament(depotLegal, nomCommercial, composition, effets, contreIndicatif,dernierEtape, codeFamille);
                Globale.medicament.Add(medicament.getDepotLegal(), medicament);
            }
            connection.Close();
            foreach (Medicament medicament in Globale.medicament.Values)
            {
                recupWorkflow(medicament);
            }
        }
        public static void recupWorkflow(Medicament medicament)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("prc_recup_workflow", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10);
            parameter.Value = medicament.getDepotLegal();
            command.Parameters.Add(parameter);
            SqlDataReader reader = command.ExecuteReader();

            List<Workflow> lesEtapes = new List<Workflow>();

            while (reader.Read())
            {
                DateTime dateDecision = DateTime.Parse(reader.GetValue(0).ToString());
                int numEtape = int.Parse(reader.GetValue(1).ToString());
                int idDecision = int.Parse(reader.GetValue(2).ToString());
                
                Workflow workflow = new Workflow(medicament.getDepotLegal(), dateDecision, numEtape, idDecision);
                lesEtapes.Add(workflow);
            }
            medicament.setLesEtapes(lesEtapes);
            connection.Close();
        }
    }
}
