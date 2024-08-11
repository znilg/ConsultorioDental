using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Exploracion
    {
        public int IdExploracion { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public string Temperatura { get; set; }
        public string TA { get; set; }
        public string FR { get; set; }
        public string FC { get; set; }
        public string AspcPac { get; set; }
        public string  LabiosComisuras { get; set; }
        public string ATM { get; set; }
        public string RegionHyT { get; set; }
    }
}
