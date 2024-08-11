using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class AnteHeredoFam
    {
        public int IdAnteHeredoFam { get; set; }
        public AnteFam? AnteFam { get; set; }
        public bool CheckBox { get; set; }
        public string? Comentario { get; set; }
        public List<AnteHeredoFam>? AntesHeredoFams { get; set; }
    }
}
