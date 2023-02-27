using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Contracts
{
    public interface IEntityAdapter<T>
    {
        /// <summary>
        /// Adaptando Objeto
        /// </summary>
        /// <param name="values">Valores a adaptar</param>
        /// <returns>Objeto</returns>
        T Adapt(object[] values);
    }
}
