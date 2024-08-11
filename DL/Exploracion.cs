using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Exploracion
    {
        public int IdExploracion { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public string? Temperatura { get; set; }
        public string? Ta { get; set; }
        public string? Fr { get; set; }
        public string? Fc { get; set; }
        public string? AspcPac { get; set; }
        public string? LabiosComisuras { get; set; }
        public string? Atm { get; set; }
        public string? RegionHyT { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
