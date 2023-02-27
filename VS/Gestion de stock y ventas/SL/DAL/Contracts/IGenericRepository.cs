using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Registrando T
        /// </summary>
        /// <param name="obj">T</param>
        void Insert(T obj);
        /// <summary>
        /// Eliminando T
        /// </summary>
        /// <param name="id">identificador de T</param>
        void Delete(int id);
        /// <summary>
        /// Actulizando T
        /// </summary>
        /// <param name="obj">T</param>
        void Update(T obj);
        /// <summary>
        /// Obteniendo T
        /// </summary>
        /// <param name="id">Identificador de T</param>
        /// <returns>T</returns>
        T GetOne(int id);
        /// <summary>
        /// Listando Registros de T
        /// </summary>
        /// <returns>listado de T</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Obteniedo identificador de  T
        /// </summary>
        /// <param name="Nombre">nombre de T</param>
        /// <returns>T</returns>
        T GetId(string Nombre);

    }
}
