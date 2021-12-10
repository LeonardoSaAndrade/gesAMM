using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    public class Medicament
    {
        private string depotLegal;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private int derniereEtape;
        private string codeFamille;
        List<Workflow> lesEtapes;

        public Medicament(string depotLegal, string nomCommercial, string composition, string effets, string contreIndications, int derniereEtape, string codeFamille)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.derniereEtape = derniereEtape;
            this.codeFamille = codeFamille;
        }

        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getComposition() { return this.composition; }
        public string getEffets() { return this.effets; }
        public string getContreIndications() { return this.contreIndications; }
        public int getDerniereEtape() { return this.derniereEtape; }
        public string getCodeFamille() { return this.codeFamille; }
        public List<Workflow> GetLesEtapes() { return this.lesEtapes; }

        public void setLesEtapes(List<Workflow> workflows) { this.lesEtapes = workflows; }
    }
}