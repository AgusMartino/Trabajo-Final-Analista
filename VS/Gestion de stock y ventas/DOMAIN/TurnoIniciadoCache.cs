using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public static class TurnoIniciadoCache
    {
        public static Nullable<int> IdTurno { get; set; }
        public static Nullable<decimal> Caja_inicial { get; set; }
        public static Nullable<DateTime> Fecha_de_inicio { get; set; }
        public static Nullable<DateTime> Fecha_de_cierre { get; set; }
    }
}
