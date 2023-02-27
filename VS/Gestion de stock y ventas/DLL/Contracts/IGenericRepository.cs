using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Registrando T
        /// </summary>
        /// <param name="obj">T</param>
        void insert(T obj);
        /// <summary>
        /// Eliminando T
        /// </summary>
        /// <param name="obj">T</param>
        void delete(T obj);
        /// <summary>
        /// Actualizando T
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
        /// Obteniendo T
        /// </summary>
        /// <param name="code">identificador de T</param>
        /// <returns>T</returns>
        T GetOneCode(string code);
        T GetOneDni(int Dni);
        /// <summary>
        /// Listando T
        /// </summary>
        /// <returns>Listando de T</returns>
        IEnumerable<T> GetAll();
        IEnumerable<string> ValidacionString();
        IEnumerable<int> ValidacionInt();

        void Savechanges();

        void import(DataTable dt);
    }
}
