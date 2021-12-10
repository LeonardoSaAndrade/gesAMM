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
    public partial class ConsultationWorkflowEtapesMedicament : Form
    {
        public ConsultationWorkflowEtapesMedicament()
        {
            InitializeComponent();
        }

        private void ConsultationWorkflowEtapesMedicament_Load(object sender, EventArgs e)
        {
            foreach (Medicament medicament in Globale.medicament.Values)
                cbMedicamentWorkflow.Items.Add(medicament.getDepotLegal());
        }

        private void cbMedicamentWorkflow_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(Workflow workflow in Globale.medicament[cbMedicamentWorkflow.Text].GetLesEtapes())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = workflow.getNumEtapeWorkflow().ToString();
                ligne.SubItems.Add("libelle");
                ligne.SubItems.Add(workflow.getDateDecisionWorkflow().ToString());
                ligne.SubItems.Add("libelle decision");
                ligne.SubItems.Add("norme");// héritage (get type() = typeof("nom du type"))
                ligne.SubItems.Add("date norme");

                lvEtape.Items.Add(ligne);
            }
        }
    }
}
