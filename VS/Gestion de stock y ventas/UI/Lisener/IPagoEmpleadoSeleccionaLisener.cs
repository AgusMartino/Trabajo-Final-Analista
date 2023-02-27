using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IPagoEmpleadoSeleccionaLisener
    {
        public void PagoEmpleadoSeleccionado(Pago_Empleado pago_Empleado);
    }
}
