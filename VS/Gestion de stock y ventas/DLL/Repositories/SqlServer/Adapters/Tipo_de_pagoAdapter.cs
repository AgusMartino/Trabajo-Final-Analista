using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters 
{
    public sealed class Tipo_de_pagoAdapter : IEntityAdapter<Tipo_de_pago>
    {
        #region Singleton
        private readonly static Tipo_de_pagoAdapter _instance = new Tipo_de_pagoAdapter();

        public static Tipo_de_pagoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Tipo_de_pagoAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Tipo_de_pago Adapt(object[] values)
        {
            return new Tipo_de_pago
            {
                IdTipo_de_pago = int.Parse(values[(int)Columns.IdTipo_de_pago].ToString()),
                nombre = values[(int)Columns.Tipo_de_pago].ToString()
            };
        }

        private enum Columns
        {
            IdTipo_de_pago,
            Tipo_de_pago
        }
    }

}
