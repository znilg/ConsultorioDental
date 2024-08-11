using System;
using System.Collections.Generic;

namespace DL
{
    public partial class ExamIntrabucal
    {
        public int IdExamIntrabucal { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public string? Carrillos { get; set; }
        public string? Mucosa { get; set; }
        public string? Encia { get; set; }
        public string? Lengua { get; set; }
        public string? Paladar { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
    }
}
