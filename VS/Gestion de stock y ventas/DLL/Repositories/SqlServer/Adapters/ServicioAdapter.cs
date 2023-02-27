using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class ServicioAdapter : IEntityAdapter<Servicio>
    {
        #region Singleton
        private readonly static ServicioAdapter _instance = new ServicioAdapter();

        public static ServicioAdapter Current
        {
            get
            {
                return _instance;
            }
        }


        private ServicioAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Servicio Adapt(object[] values)
        {
            return new Servicio()
            {
                IdServicio = int.Parse(values[(int)Columnns.id].ToString()),
                CodigoServicio = values[(int)Columnns.CodigoServicio].ToString(),
                Nombre = values[(int)Columnns.Nombre].ToString()
            };
        }
        private enum Columnns
        {
            id,
            CodigoServicio,
            Nombre
        }


    }

}
