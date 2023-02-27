using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IGenericBusinessLogic<T> where T : class, new()
    {
        /// <summary>
        /// ingresar objeto
        /// </summary>
        /// <param name="obj">Objeto a registrar</param>
        void insert(T obj);
        /// <summary>
        /// eliminar objeto
        /// </summary>
        /// <param name="obj">Objeto a eliminar</param>
        void delete(T obj);
        /// <summary>
        /// Actualizar objeto
        /// </summary>
        /// <param name="obj">Objeto a actualizar</param>
        void update(T obj);
        /// <summary>
        /// Obtener Objeto
        /// </summary>
        /// <param name="id">identificador del objeto a obtener</param>
        /// <returns>Objeto con el id parametrizado</returns>
        T GetOne(int id);
        /// <summary>
        /// Obtener Objeto
        /// </summary>
        /// <param name="code">identificador del objeto a obtener</param>
        /// <returns>Objeto con el id parametrizado</returns>
        T GetOneCode(string code);
        T GetOneDni(int Dni);
        /// <summary>
        /// Listar todos los registros 
        /// </summary>
        /// <returns>Lista de registros</returns>
        IEnumerable<T> GetAll();
        Boolean ValidacionString(string code);
        Boolean ValidacionInt(int Dni);
        void importMassive(DataTable dt);


    }
}
