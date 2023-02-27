using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IGenericRelationship<T, U>
    {
        /// <summary>
        /// Relacionando T con U
        /// </summary>
        /// <param name="obj1">T</param>
        /// <param name="obj2">U</param>
        void Join(T obj1, U obj2);
        /// <summary>
        /// Obteniendo Relaciones de U con T
        /// </summary>
        /// <param name="obj">T</param>
        /// <returns>Listado de relaciones de U</returns>
        List<U> GetFamilia(T obj);
        /// <summary>
        /// Obteniendo listado de relaciones de T con U
        /// </summary>
        /// <param name="obj">U</param>
        /// <returns>Listado de T</returns>
        List<T> GetComponentes(U obj);
        /// <summary>
        /// Eliminanado Relacion de U
        /// </summary>
        /// <param name="obj">U</param>
        void DeleteJoin(U obj);
    }
}
