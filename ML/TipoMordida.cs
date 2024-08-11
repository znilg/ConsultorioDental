using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class TipoMordida
    {
        public int IdTipoMordida { get; set; }
        public string? Tipo { get; set; }
        public List<TipoMordida>? TiposMordidas { get; set; }
    }
}
