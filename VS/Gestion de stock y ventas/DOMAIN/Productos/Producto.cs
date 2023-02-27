using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Productos
{
    public class Producto : MateriaPrimaProducto
    {
        public Nullable<int> IdProducto { get; set; }
        public Rubro rubro { get; set; }
        public string CodigoProducto { get; set; }
        public new string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }


        public override int CantidadDeComponentes => Componentes.Count;

        public List<MateriaPrimaProducto> Componentes = new List<MateriaPrimaProducto>();

        public Producto()
        {

        }

        public override void Add(MateriaPrimaProducto component)
        {
            Componentes.Add(component);
        }

        public override void Remove(MateriaPrimaProducto componet)
        {
            Componentes.Remove(componet);
        }
    }
}
