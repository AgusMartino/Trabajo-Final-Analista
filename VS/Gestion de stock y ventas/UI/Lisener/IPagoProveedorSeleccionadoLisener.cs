using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IPagoProveedorSeleccionadoLisener
    {
        public void PagoProveedorSeleccionado(Pago_Proveedor pago_Proveedor);
    }
}
