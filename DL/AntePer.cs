using System;
using System.Collections.Generic;

namespace DL
{
    public partial class AntePer
    {
        public AntePer()
        {
            AnteNoPatoPers = new HashSet<AnteNoPatoPer>();
        }

        public int IdAntePers { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<AnteNoPatoPer> AnteNoPatoPers { get; set; }
    }
}
