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
    public sealed class VentaAdapter :IEntityAdapter<Venta>
    {
        #region Singleton
        private readonly static VentaAdapter _instance = new VentaAdapter();

        public static VentaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private VentaAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Venta Adapt(object[] values)
        {
            return new Venta
            {
                IdVenta = int.Parse(values[(int)Colums.IdVenta].ToString()),
                cliente = Factory.Current.GetClienteRepository().GetOne(int.Parse(values[(int)Colums.DniCliente].ToString())),
                tipo_De_Pago = Factory.Current.GetTipo_de_PagoRepository().GetOne(int.Parse(values[(int)Colums.IdTipo_de_pago].ToString())),
                Fecha_de_Venta = DateTime.Parse(values[(int)Colums.Fecha_de_venta].ToString()),
                Total = decimal.Parse(values[(int)Colums.Total].ToString())
            };
        }
        private enum Colums
        {
            IdVenta,
            DniCliente,
            IdTipo_de_pago,
            Fecha_de_venta,
            Total
        }
    }

}
