using System;
using System.Collections.Generic;

namespace DL
{
    public partial class TipoMordidum
    {
        public TipoMordidum()
        {
            ExamOclusions = new HashSet<ExamOclusion>();
        }

        public int IdTipoMordida { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<ExamOclusion> ExamOclusions { get; set; }
    }
}
