using System;
using System.Collections.Generic;

namespace DL
{
    public partial class ExamComplementario
    {
        public int IdExamComplementario { get; set; }
        public int? IdHistoriaClinica { get; set; }
        public int? IdTipoExamCompl { get; set; }
        public string? Imagen { get; set; }
        public string? Detalle { get; set; }

        public virtual HistoriaClinica? IdHistoriaClinicaNavigation { get; set; }
        public virtual TipoExamCompl? IdTipoExamComplNavigation { get; set; }
    }
}
