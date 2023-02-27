using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IPagoServicioSeleciconadoLisener
    {
        public void PagoServicioSeleccionado(Pago_Servicio pago_Servicio);
    }
}
