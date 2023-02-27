using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IVentaRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Obteniendo identificador de T
        /// </summary>
        /// <param name="dateTime">Fecha de registro de T</param>
        /// <returns>T</returns>
        T GetId(DateTime dateTime);
        /// <summary>
        /// Obteniedo Listado de T entre fechas 
        /// </summary>
        /// <param name="DateTimeInicio">Fecha de inicio</param>
        /// <param name="DateTimeFin">Fecha de fin</param>
        /// <returns>Listado de T</returns>
        IEnumerable<T> GetVentasEntreFechas(DateTime DateTimeInicio, DateTime DateTimeFin);
    }
}
