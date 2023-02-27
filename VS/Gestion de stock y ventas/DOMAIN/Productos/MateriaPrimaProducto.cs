using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Productos
{
    public abstract class MateriaPrimaProducto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public MateriaPrimaProducto()
        {

        }
        public abstract void Add(MateriaPrimaProducto component);
        public abstract void Remove(MateriaPrimaProducto componet);
        public abstract int CantidadDeComponentes { get; }

    }
}
