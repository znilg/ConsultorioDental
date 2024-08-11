using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AnteFam
    {
        public AnteFam()
        {
            AnteHeredoFams = new HashSet<AnteHeredoFam>();
        }

        public int IdAnteFam { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<AnteHeredoFam> AnteHeredoFams { get; set; }
    }
}
