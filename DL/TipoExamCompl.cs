using System;
using System.Collections.Generic;

namespace DL
{
    public partial class TipoExamCompl
    {
        public TipoExamCompl()
        {
            ExamComplementarios = new HashSet<ExamComplementario>();
        }

        public int IdTipoExamCompl { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<ExamComplementario> ExamComplementarios { get; set; }
    }
}
