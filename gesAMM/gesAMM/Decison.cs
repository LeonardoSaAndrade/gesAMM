using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gesAMM
{
    class Decision
    {
        private int id;
        private string libelle;

        public void Decision(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int getId() { return this.id; }
        public string getLibelle() { return this.libelle; }
    }
}
