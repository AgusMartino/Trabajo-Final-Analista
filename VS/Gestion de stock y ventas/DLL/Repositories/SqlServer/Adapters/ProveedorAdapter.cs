using DLL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class ProveedorAdapter : IEntityAdapter<Proveedor>
    {
        #region Singleton
        private readonly static ProveedorAdapter _instance = new ProveedorAdapter();

        public static ProveedorAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ProveedorAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Proveedor Adapt(object[] values)
        {
            return new Proveedor()
            {
                IdProveedor = int.Parse(values[(int)Columns.id].ToString()),
                Cuit = Int64.Parse(values[(int)Columns.Cuit].ToString()),
                Nombre = values[(int)Columns.Nombre].ToString()
            };
        }
        private enum Columns
        {
            id,
            Cuit,
            Nombre
        }
    }

}
