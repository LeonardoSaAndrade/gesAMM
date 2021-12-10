using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    public class Workflow
    {
        public static List<Workflow> lesWorkflow = new List<Workflow>();

        private string depotLegaleWorkflow;
        private DateTime dateDecisionWorkflow;
        private int numEtapeWorkflow;
        private int idDecisionWorkflow;

        public Workflow(string depotLegaleWorkflow, DateTime dateDecision, int etape, int decision)
        {
            this.depotLegaleWorkflow = depotLegaleWorkflow;
            this.dateDecisionWorkflow = dateDecision;
            this.numEtapeWorkflow = etape;
            this.idDecisionWorkflow = decision;
        }

        public string getDepotLegaleWorkflow() { return this.depotLegaleWorkflow; }
        public DateTime getDateDecisionWorkflow() { return this.dateDecisionWorkflow; }
        public int getNumEtapeWorkflow() { return this.numEtapeWorkflow; }
        public int getIdDecisionWorkfow() { return this.idDecisionWorkflow; }
    }
}
