using DLL.Contracts;
using DLL.Factories;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories.SqlServer.Adapters
{

    public sealed class Orden_de_ventaAdapter : IEntityAdapter<Orden_de_Venta>
    {
        #region Singleton
        private readonly static Orden_de_ventaAdapter _instance = new Orden_de_ventaAdapter();

        public static Orden_de_ventaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Orden_de_ventaAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public Orden_de_Venta Adapt(object[] values)
        {
            return new Orden_de_Venta
            {
                IdOrden_de_venta = int.Parse(values[(int)Colums.Idorden_de_venta].ToString()),
                venta = Factory.Current.GetVentaRepository().GetOne(int.Parse(values[(int)Colums.IdVenta].ToString())),
                producto = Factory.Current.GetProductoRepository().GetOne(int.Parse(values[(int)Colums.IdProducto].ToString())),
                Cantidad = decimal.Parse(values[(int)Colums.Cantidad].ToString()),
                Subtotal = decimal.Parse(values[(int)Colums.Subtotal].ToString())
            };
        }
        private enum Colums
        {
            Idorden_de_venta,
            IdVenta,
            IdProducto,
            Cantidad,
            Subtotal
        }
    }

}
