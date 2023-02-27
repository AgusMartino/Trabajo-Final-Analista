using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    public interface IEntityAdapter<T>
    {
        /// <summary>
        /// Adaptando Valores
        /// </summary>
        /// <param name="values">Valores</param>
        /// <returns>Objeto</returns>
        T Adapt(object[] values);
    }
}
