using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IVentaSeleccionadoLisener
    {
        public void VentaSeleccionado(Venta venta);
    }
}
