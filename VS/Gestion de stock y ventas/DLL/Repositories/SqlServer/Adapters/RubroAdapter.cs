using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class RubroAdapter : IEntityAdapter<Rubro>
    {
        #region Singleton
        private readonly static RubroAdapter _instance = new RubroAdapter();

        public static RubroAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private RubroAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Rubro Adapt(object[] values)
        {
            return new Rubro()
            {
                IdRubro = int.Parse(values[(int)Columns.id].ToString()),
                Codigo_Rubro = values[(int)Columns.CodigoRubro].ToString(),
                Nombre = values[(int)Columns.Nombre].ToString()
            };
        }
        private enum Columns
        {
            id,
            CodigoRubro,
            Nombre
        }
    }

}
