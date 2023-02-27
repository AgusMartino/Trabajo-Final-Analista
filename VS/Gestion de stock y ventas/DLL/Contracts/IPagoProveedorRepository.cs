using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IPagoProveedorRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Obtenienndo Monnto adeudado
        /// </summary>
        /// <param name="id">identificador de T</param>
        /// <returns>T</returns>
        T GetMontoAdeudado(int id);
        /// <summary>
        /// Obteniedo identificadot de T
        /// </summary>
        /// <param name="dateTime">Fecha de registro de T</param>
        /// <returns></returns>
        T GetPago_proveedorId(DateTime dateTime);
        /// <summary>
        /// Listando T entre fechas
        /// </summary>
        /// <param name="dateTimeInicio">Fecha de inicio</param>
        /// <param name="dateTimeFin">Fecha de fin</param>
        /// <returns>Listado de T</returns>
        IEnumerable<T> GetPagosEntreFecha(DateTime dateTimeInicio, DateTime dateTimeFin);
    }
}
