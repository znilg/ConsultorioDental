using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class AnteFam
    {
        public int IdAnteFam { get; set; }
        public string? Nombre { get; set; }
        public List<AnteFam>? AntesFam { get; set; }
    }
}
