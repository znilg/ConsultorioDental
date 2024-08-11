using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ML
{
    public class HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public DateTime Fecha { get { return DateTime.Now; } set { this.Fecha = value; } }

        [Display(Name = "Motivo")]
        [Required(ErrorMessage = "Campo requerido")]
        public string? Motivo { get; set; }
        public string? Consentimiento { get; set; }
        public Paciente? Paciente { get; set; }
        public AnteHeredoFam? AnteHeredoFam { get; set; }
        public AnteNoPatoPers? AnteNoPatoPers { get; set; }
        public Exploracion? Exploracion { get; set; }
        public AntePersPato? AntePersPato { get; set; }
        public ExamIntrabucal? ExamIntrabucal { get; set; }
        public ExamOclusion? ExamOclusion { get; set; }
        public ExamComplementario? ExamComplementario { get; set; }
        public Tratamiento? Tratamiento { get; set; }
        public List<object>? HistoriasClinicas { get; set; }
    }
}