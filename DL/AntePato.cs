using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AntePato
    {
        public AntePato()
        {
            AntePersPatos = new HashSet<AntePersPato>();
        }

        public int IdAntePato { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<AntePersPato> AntePersPatos { get; set; }
    }
}
