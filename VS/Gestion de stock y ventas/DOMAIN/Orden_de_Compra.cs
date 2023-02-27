using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Orden_de_Compra
    {
        public int IdOrden_de_compra { get; set; }
        public Pago_Proveedor Pago_Proveedor { get; set; }
        public MateriaPrima materiaPrima { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; } 

    }
}
