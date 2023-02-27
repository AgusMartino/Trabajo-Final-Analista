using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Orden_de_Venta
    {
        public int IdOrden_de_venta { get; set; }
        public Venta venta { get; set; }
        public Producto producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }

    }
}
