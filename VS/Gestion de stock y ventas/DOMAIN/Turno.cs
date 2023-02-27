using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public decimal Caja_inicial { get; set; }
        public Nullable<DateTime> Fecha_de_inicio { get; set; }
        public Nullable<DateTime> Fecha_de_cierre { get; set; }
    }
}
