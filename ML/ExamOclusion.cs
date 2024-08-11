using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class ExamOclusion
    {
        public int IdExamOclusion { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public TipoMordida TipoMordida { get; set; }
        public string TipoDenticion { get; set; }
        public string Erupcion { get; set; }
        public string PlanoTerminal_L { get; set; }
        public string PlanoTerminal_R { get; set; }
        public string ClasAngulo_L { get; set; }
        public string ClasAngulo_R { get; set; }
        public string RelaCan_L { get; set; }
        public string RelaCan_R { get; set; }
        public string RelaAnt { get; set; }
        public string LineaMedia { get; set; }
        public bool Apinamiento { get; set; }
        public bool Diastemas { get; set; }
        public bool Tremas { get; set; }
        public string VersDentarias { get; set; }
        public string AlteraFormNumEstru { get; set; }
    }
}
