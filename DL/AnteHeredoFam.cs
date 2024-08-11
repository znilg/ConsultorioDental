using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AnteHeredoFam
    {
        public int IdAnteHeredoFam { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public int? IdAnteFam { get; set; }
        public string? Comentario { get; set; }

        public virtual AnteFam? IdAnteFamNavigation { get; set; }
        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
