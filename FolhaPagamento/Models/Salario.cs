using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Salario
    {
        public int SalarioID { get; set; }
        public int QtdeHoraNormal { get; set; }
        public int QtdeHoraExtra { get; set; }
        public float VlrHoraNormal { get; set; }
        public float VlrHoraExtra { get; set; }
        public float VlrInss { get; set; }
        public float VlrIR { get; set; }
        public float SalarioBruto { get; set; }
        public float SalarioLiquido { get; set; }
        public DateTime MesReferencia { get; set; }
        public int AnoReferencia { get; set; }

    }
}
