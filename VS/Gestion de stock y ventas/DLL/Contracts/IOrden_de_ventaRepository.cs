using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IOrden_de_ventaRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Listando T
        /// </summary>
        /// <param name="id">identificador de T</param>
        /// <returns>T</returns>
        IEnumerable<T> GetOrdenes(int id);
    }
}
