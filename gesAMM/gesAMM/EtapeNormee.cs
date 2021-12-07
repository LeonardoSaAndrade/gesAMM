using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class EtapeNormee : Etape
    {
        private string Norme;
        private DateTime dateNorme;


        public EtapeNormee(int num, string libelle,string norme, DateTime dateNorme) : base(num,libelle)
        {
            this.dateNorme = dateNorme;
            this.Norme = norme;
            Globale.lesEtapesNormee.Add(this);
        }


        public DateTime getDateNorme() { return this.dateNorme; }
        public string getNorme() { return this.Norme; }

        public void setDateNorme(DateTime ladate) { this.dateNorme = ladate; }

        public void setNorme(string lanorme) { this.Norme = lanorme; }

    }
}
