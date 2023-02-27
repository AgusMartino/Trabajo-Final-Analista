using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Venta
    {
        public Nullable<int> IdVenta { get; set; }
        public Cliente cliente { get; set; }
        public Tipo_de_pago tipo_De_Pago { get; set; }
        public DateTime Fecha_de_Venta { get; set; }
        public decimal Total { get; set; }

        public List<Orden_de_Venta> Orden_De_Ventas = new List<Orden_de_Venta>();

        public void Add(Orden_de_Venta component)
        {
            Orden_De_Ventas.Add(component);
        }

        public void Remove(Orden_de_Venta componet)
        {
            Orden_De_Ventas.Remove(componet);
        }

    }
}
