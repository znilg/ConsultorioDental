using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class TipoExamCompl
    {
        public int IdTipoExamCompl { get; set; }
        public string? Tipo { get; set; }
        public List<TipoExamCompl>? TiposExamenesCompls { get; set; }
    }
}
