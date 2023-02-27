using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface ITurnoRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Obteniendo identificador de T
        /// </summary>
        /// <param name="dateTime">Fecha de registro de T</param>
        /// <returns>T</returns>
        T GetTurno(DateTime dateTime);
    }
}
