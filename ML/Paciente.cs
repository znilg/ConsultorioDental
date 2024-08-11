using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ML
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public HistoriaClinica? HistoriaClinica { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Nombre { get; set; }

        [Display(Name = "ApellidoPaterno")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? ApellidoPaterno { get; set; }

        [Display(Name = "ApellidoMaterno")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? ApellidoMaterno { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Genero { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Campo requerido")]
        public int? Edad { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Direccion { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Telefono { get; set; }

        [Display(Name = "Ocupacion")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Ocupacion { get; set; }
        public List<object>? Pacientes { get; set; }
    }
}
