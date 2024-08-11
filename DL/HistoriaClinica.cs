using System;
using System.Collections.Generic;

namespace DL
{
    public partial class HistoriaClinica
    {
        public HistoriaClinica()
        {
            AnteHeredoFams = new HashSet<AnteHeredoFam>();
            AnteNoPatoPers = new HashSet<AnteNoPatoPer>();
            AntePersPatos = new HashSet<AntePersPato>();
            ExamComplementarios = new HashSet<ExamComplementario>();
            ExamIntrabucals = new HashSet<ExamIntrabucal>();
            ExamOclusions = new HashSet<ExamOclusion>();
            Exploracions = new HashSet<Exploracion>();
            Pacientes = new HashSet<Paciente>();
            Tratamientos = new HashSet<Tratamiento>();
        }

        public int IdHistoriaClinica { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Motivo { get; set; }
        public string? Consentimiento { get; set; }

        public virtual ICollection<AnteHeredoFam> AnteHeredoFams { get; set; }
        public virtual ICollection<AnteNoPatoPer> AnteNoPatoPers { get; set; }
        public virtual ICollection<AntePersPato> AntePersPatos { get; set; }
        public virtual ICollection<ExamComplementario> ExamComplementarios { get; set; }
        public virtual ICollection<ExamIntrabucal> ExamIntrabucals { get; set; }
        public virtual ICollection<ExamOclusion> ExamOclusions { get; set; }
        public virtual ICollection<Exploracion> Exploracions { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
