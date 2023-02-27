using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Contracts
{
    public interface IGenericBusinessLogic<T> where T : class, new()
    {
        /// <summary>
        /// Registrando T
        /// </summary>
        /// <param name="obj">T</param>
        void insert(T obj);
        /// <summary>
        /// Elimnando T
        /// </summary>
        /// <param name="obj">T</param>
        void delete(T obj);
        /// <summary>
        /// Actulizando T
        /// </summary>
        /// <param name="obj">T</param>
        void update(T obj);
        /// <summary>
        /// Obteniendo T
        /// </summary>
        /// <param name="id">identificador de T</param>
        /// <returns>T</returns>
        T GetOne(int id);
        /// <summary>
        /// Listando Registros de T
        /// </summary>
        /// <returns>T</returns>
        IEnumerable<T> GetAll();

    }
}
