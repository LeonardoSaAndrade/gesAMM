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
        public static Dictionary<int, Famille> famille = new Dictionary<int, Famille>();
        public static Dictionary<string, Medicament> medicament = new Dictionary<string, Medicament>();
        public static List<Etape> etape = new List<Etape>() ;
        public static List<Decision> decision = new List<Decision>() ;  
    }
}