using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IPagosRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Listando T entre fechas
        /// </summary>
        /// <param name="dateTimeInicio">fecha de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns>Listado de T</returns>
        IEnumerable<T> GetPagoEntreFecha(DateTime dateTimeInicio, DateTime dateTimeFin);
    }
}
