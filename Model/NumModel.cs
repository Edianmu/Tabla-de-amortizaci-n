using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaAmortizacion.Model
{
    public class NumModel
    {
        public string? Nombre { get; set; }
        public string? Identificacion { get; set; }
        public int Edad { get; set; }

        public decimal? Monto { get; set; }
        public decimal? Tasa { get; set; }
        public int? Plazos { get; set; }
        public decimal? Aval { get; set; }

        public decimal Cuota { get; set; }

    }
}
