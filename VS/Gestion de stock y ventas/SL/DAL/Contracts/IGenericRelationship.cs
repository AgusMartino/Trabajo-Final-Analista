using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    public interface IGenericRelationship<T, U>
    {
        /// <summary>
        /// Relacion entre T y U
        /// </summary>
        /// <param name="obj1">T</param>
        /// <param name="obj2">U</param>
        void Join(T obj1, U obj2);
        /// <summary>
        /// Obteniendo Listado de U
        /// </summary>
        /// <param name="obj">T</param>
        /// <returns>Listado de U</returns>
        List<U> Get(T obj);
        /// <summary>
        /// Obteniendo Listado de T
        /// </summary>
        /// <param name="obj">U</param>
        /// <returns>Listado de T</returns>
        List<T> GetPermisos(U obj);
        /// <summary>
        /// Eliminando Relacion
        /// </summary>
        /// <param name="obj">U</param>
        void DeleteJoin(U obj);
    }
}
