using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Genero { get; set; }
        public int? Edad { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Ocupacion { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
