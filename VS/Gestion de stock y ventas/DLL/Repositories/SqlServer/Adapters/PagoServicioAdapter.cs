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
    public sealed class PagoServicioAdapter : IEntityAdapter<Pago_Servicio>
    {
        #region Singleton
        private readonly static PagoServicioAdapter _instance = new PagoServicioAdapter();

        public static PagoServicioAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PagoServicioAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion 

        public Pago_Servicio Adapt(object[] values)
        {
            return new Pago_Servicio
            {
                IdPagoServicio = int.Parse(values[(int)Columns.IdPagoServicio].ToString()),
                servicio = Factory.Current.GetServicioRepository().GetOne(int.Parse(values[(int)Columns.Servicio].ToString())),
                MontoPagado = decimal.Parse(values[(int)Columns.Monto_Pagado].ToString()),
                Fecha_Pago = DateTime.Parse(values[(int)Columns.Fecha_de_Pago].ToString())
            };
        }
        private enum Columns
        {
            IdPagoServicio,
            Servicio,
            Monto_Pagado,
            Fecha_de_Pago
        }
    }

}
