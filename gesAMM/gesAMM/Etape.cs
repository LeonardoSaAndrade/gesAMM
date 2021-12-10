using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    public class Etape
    {
        public static List<Etape> lesEtapes = new List<Etape>();
        private List<EtapeNormee> lesEtapesNormees;
        private int numEtape;
        private string libelleEtape;

        public Etape(int num, string libelle)
        {
            this.numEtape = num;
            this.libelleEtape = libelle;
            this.lesEtapesNormees = new List<EtapeNormee>();
        }

        public int getNumEtape() { return this.numEtape; }
        public string getLibelleEtape() { return this.libelleEtape; }
    }
}
