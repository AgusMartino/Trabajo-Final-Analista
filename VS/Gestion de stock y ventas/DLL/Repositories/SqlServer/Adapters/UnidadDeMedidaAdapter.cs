using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{
    public sealed class UnidadDeMedidaAdapter : IEntityAdapter<Unidad_De_Medida>
    {
        #region Singleton
        private readonly static UnidadDeMedidaAdapter _instance = new UnidadDeMedidaAdapter();

        public static UnidadDeMedidaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private UnidadDeMedidaAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Unidad_De_Medida Adapt(object[] values)
        {
            return new Unidad_De_Medida
            {
                idUnindad_de_medida = int.Parse(values[(int)Columns.IdUnidadDeMedida].ToString()),
                Unidad_de_medida = values[(int)Columns.UnidadDeMedida].ToString()
            };
        }
        private enum Columns
        {
            IdUnidadDeMedida,
            UnidadDeMedida
        }
    }

}
