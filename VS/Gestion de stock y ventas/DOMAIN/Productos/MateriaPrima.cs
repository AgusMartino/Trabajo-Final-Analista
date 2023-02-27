using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Productos
{

    public class MateriaPrima : MateriaPrimaProducto
    {
        public Nullable<int> IdMateriaPrima { get; set; }
        public Unidad_De_Medida unidad_de_medida { get; set; }
        public new string Nombre { get; set; }


        public override int CantidadDeComponentes => 0;

        public override void Add(MateriaPrimaProducto component)
        {
            throw new NotImplementedException("No se puede agregar elementos en una Materia Prima.");
        }

        public override void Remove(MateriaPrimaProducto componet)
        {
            throw new NotImplementedException("No se puede quitar elementos en una Materia Prima.");
        }
    }
}

