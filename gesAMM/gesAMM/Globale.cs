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
        public static Dictionary<int, Famille> famille ;
        public static Dictionary<string, Medicament> medicament ;
        public static List<Etape> etape ;
        public static List<Decision> decision ;  
        public static SqlConnection cnx;
    }
}