using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca03.Models
{
    public class Oprema
    {
        public int id { get; set; } 
        public DateTime DatumZaprimanja { get; set; }
        public string Zaprimio { get; set; }
        public string IzvorFinanciranja { get; set; }
        public string NazivProjekta { get; set; }
        public string VrstaOpreme { get; set; }
        public string NazivOpreme { get; set; }
        public string OpisOpreme { get; set; }

    }
}
