using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public MateriaPrima materiaPrima { get; set; }
        public decimal Cantidad { get; set; }
    }
}
