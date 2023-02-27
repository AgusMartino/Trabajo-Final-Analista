using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IProductoSeleccionadoLisener
    {
        public void ProductoSeleccionado(Producto producto);
    }
}
