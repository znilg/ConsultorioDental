using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Tratamiento
    {
        public int IdTratamiento { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public string OrganoDentario { get; set; }
        public string Estatus { get; set; }
        public string Procedimiento { get; set; }
        public int Costo { get; set; }
        public int Anticipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaUltimaVisita { get; set; }
    }
}
