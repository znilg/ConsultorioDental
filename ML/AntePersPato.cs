using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class AntePersPato
    {
        public int IdAntePersPato { get; set; }
        public AntePato? AntePato { get; set; }
        public string? Respuesta { get; set; }
        public bool CheckBoxAntePersPato { get; set; }
        public List<AntePersPato>? AntesPersPatos { get; set; }
    }
}
