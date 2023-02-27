using DOMAIN.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Lisener
{
    public interface IMateriaPrimaSeleccionadoLisener
    {
        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima);
    }
}
