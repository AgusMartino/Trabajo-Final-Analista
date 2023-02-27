using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Pago_Empleado
    {
        public Nullable<int> IdPagoEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime Fecha_Pago { get; set; }
    }
}
