using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Tratamiento
    {
        public int IdTratamiento { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public string? OrganoDentario { get; set; }
        public string? Estatus { get; set; }
        public string? Procedimiento { get; set; }
        public int? Costo { get; set; }
        public int? Anticipo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaUltimaVisita { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
