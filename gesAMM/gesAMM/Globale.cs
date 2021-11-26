using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gesAMM
{
    class Globale
    {
        Dictionary<int, Famille> famille = new Dictionary<int, Famille>();
        Dictionary<string, Medicament> medicament = new Dictionary<string, Medicament>();
        public static SqlConnection cnx;

    }
}