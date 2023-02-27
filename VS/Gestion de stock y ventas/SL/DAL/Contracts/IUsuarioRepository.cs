using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    public interface IUsuarioRepository<T> : IGenericRepository<T>
    {
        /// <summary>
        /// Login de T
        /// </summary>
        /// <param name="obj">T</param>
        /// <returns>T</returns>
        T Login(T obj);
        /// <summary>
        /// Actulizando Contraseña de T
        /// </summary>
        /// <param name="obj">T</param>
        void Cambiar_contraseña(T obj);
    }
}
