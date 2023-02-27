using DLL.Factories;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class InventarioAdapter
    {
        #region Singleton
        private readonly static InventarioAdapter _instance = new InventarioAdapter();

        public static InventarioAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private InventarioAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Inventario Adapt(object[] values)
        {
            return new Inventario 
            {
                IdInventario = int.Parse(values[(int)Columns.IdInventario].ToString()),
                materiaPrima = Factory.Current.GetMateriaPrimaRepository().GetOne(int.Parse(values[(int)Columns.MateriaPrima].ToString())),
                Cantidad = int.Parse(values[(int)Columns.Cantidad].ToString())
            };
        }

        private enum Columns
        {
            IdInventario,
            MateriaPrima,
            Cantidad
        }
    }

}
