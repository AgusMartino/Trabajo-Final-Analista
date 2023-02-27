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
    public sealed class Orden_de_compraAdapter : IEntityAdapter<Orden_de_Compra>
    {
        #region Singleton
        private readonly static Orden_de_compraAdapter _instance = new Orden_de_compraAdapter();

        public static Orden_de_compraAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Orden_de_compraAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Orden_de_Compra Adapt(object[] values)
        {
            return new Orden_de_Compra
            {
                IdOrden_de_compra = int.Parse(values[(int)Columns.IdOrden_de_compra].ToString()),
                Pago_Proveedor = Factory.Current.GetPago_proveedorRepository().GetOne(int.Parse(values[(int)Columns.IdPago_proveedor].ToString())),
                materiaPrima = Factory.Current.GetMateriaPrimaRepository().GetOne(int.Parse(values[(int)Columns.IdMateriaPrima].ToString())),
                Cantidad = decimal.Parse(values[(int)Columns.Cantidad].ToString()),
                Subtotal = decimal.Parse(values[(int)Columns.Subtotal].ToString())
            };
        }
        private enum Columns
        {
            IdOrden_de_compra,
            IdPago_proveedor,
            IdMateriaPrima,
            Cantidad,
            Subtotal
        }
    }

}
