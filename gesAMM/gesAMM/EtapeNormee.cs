using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class EtapeNormee : Etape
    {
        private string norme;
        private DateTime dateNorme;

        public EtapeNormee(int num, string libelle, string norme, DateTime dateNorme) : base(num,libelle)
        {
            this.norme = norme;
            this.dateNorme = dateNorme;
        }

        public string getNorme() { return this.norme; }
        public DateTime getDateNorme() { return this.dateNorme; }

    }
}
