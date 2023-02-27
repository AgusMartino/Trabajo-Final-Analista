using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Movimiento_Caja
    {
        public int IdMovimiento_caja { get; set; }
        public decimal cantidad { get; set; }
        public Tipo_de_pago tipo_De_Pago { get; set; }
        public Tipo_de_movimiento tipo_De_Movimiento { get; set; }
        public DateTime Fecha_de_movimiento { get; set; }
    }
}
