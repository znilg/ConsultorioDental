using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class ExamComplementario
    {
        public int IdExamComplementario { get; set; }
        public TipoExamCompl? TipoExamCompl { get; set; }
        public string? Imagen { get; set; }
        public string? Detalle { get; set; }
        public List<ExamComplementario>? ExamenesComplementarios { get; set; }
    }
}
