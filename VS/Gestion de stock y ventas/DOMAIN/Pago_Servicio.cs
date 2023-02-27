using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Pago_Servicio
    {
        public Nullable<int> IdPagoServicio { get; set; }
        public Servicio servicio { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime Fecha_Pago { get; set; }
    }
}
