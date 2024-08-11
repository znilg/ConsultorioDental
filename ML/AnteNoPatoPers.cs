using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class AnteNoPatoPers
    {
        public int IdAnteNoPatoPers { get; set; }
        public AntePers? AntePers { get; set; }
        public bool CheckBoxAnteNoPatoPers { get; set; }
        public List<AnteNoPatoPers>? AntesNoPatosPers { get; set; }
    }
}
