using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class Etape
    {
        private int num;
        private string libelle;


        public Etape(int num, string libelle)
        {
            this.num = num;
            this.libelle = libelle;
        }

        public int getNum() { return this.num; }
        public string getLibelle() { return this.libelle; }
    }
}
