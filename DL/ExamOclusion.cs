using System;
using System.Collections.Generic;

namespace DL
{
    public partial class ExamOclusion
    {
        public int IdExamOclusion { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public int? IdTipoMordida { get; set; }
        public string? TipoDenticion { get; set; }
        public string? Erupcion { get; set; }
        public string? PlanoTerminalL { get; set; }
        public string? PlanoTerminalR { get; set; }
        public string? ClasAnguloL { get; set; }
        public string? ClasAnguloR { get; set; }
        public string? RelaCanL { get; set; }
        public string? RelaCanR { get; set; }
        public string? RelaAnt { get; set; }
        public string? LineaMedia { get; set; }
        public string? Apinamiento { get; set; }
        public string? Diastemas { get; set; }
        public string? Tremas { get; set; }
        public string? VersDentarias { get; set; }
        public string? AlteraFormNumEstru { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
        public virtual TipoMordidum? IdTipoMordidaNavigation { get; set; }
    }
}
