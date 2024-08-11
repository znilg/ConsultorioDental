using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AntePersPato
    {
        public int IdAntePersPato { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public int? IdAntePato { get; set; }
        public string? Respuesta { get; set; }

        public virtual AntePato? IdAntePatoNavigation { get; set; }
        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
