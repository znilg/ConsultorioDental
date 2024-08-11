using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AnteNoPatoPer
    {
        public int IdAnteNoPatoPers { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public int? IdAntePers { get; set; }

        public virtual AntePer? IdAntePersNavigation { get; set; }
        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
