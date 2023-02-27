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
    public sealed class Movimiento_cajaAdapter : IEntityAdapter<Movimiento_Caja>
    {
        #region Singleton
        private readonly static Movimiento_cajaAdapter _instance = new Movimiento_cajaAdapter();

        public static Movimiento_cajaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Movimiento_cajaAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion 
        public Movimiento_Caja Adapt(object[] values)
        {
            return new Movimiento_Caja
            {
                IdMovimiento_caja = int.Parse(values[(int)Columns.IdMovimiento_caja].ToString()),
                cantidad = decimal.Parse(values[(int)Columns.Cantidad].ToString()),
                tipo_De_Movimiento = Factory.Current.GetTipo_de_movimientoRepository().GetOne(int.Parse(values[(int)Columns.IdTipo_movimiento].ToString())),
                tipo_De_Pago = Factory.Current.GetTipo_de_PagoRepository().GetOne(int.Parse(values[(int)Columns.IdTipo_movimiento].ToString())),
                Fecha_de_movimiento = DateTime.Parse(values[(int)Columns.Fecha_de_movimiento].ToString())
            };
        }
        private enum Columns
        {
            IdMovimiento_caja,
            Cantidad,
            IdTipo_movimiento,
            IdTipo_de_pago,
            Fecha_de_movimiento
        }
    }

}
