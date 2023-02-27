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
    public sealed class PagoEmpleadoAdapter : IEntityAdapter<Pago_Empleado>
    {
        #region Singleton
        private readonly static PagoEmpleadoAdapter _instance = new PagoEmpleadoAdapter();

        public static PagoEmpleadoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PagoEmpleadoAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Pago_Empleado Adapt(object[] values)
        {
            return new Pago_Empleado
            {
                IdPagoEmpleado = int.Parse(values[(int)Columns.IdPagoEmpleado].ToString()),
                Empleado = Factory.Current.GetEmpleadoRepository().GetOne(int.Parse(values[(int)Columns.Empleado].ToString())),
                MontoPagado = decimal.Parse(values[(int)Columns.Monto_pagado].ToString()),
                Fecha_Pago = DateTime.Parse(values[(int)Columns.Fecha_de_pago].ToString())
            };
        }
        private enum Columns
        {
            IdPagoEmpleado,
            Empleado,
            Monto_pagado,
            Fecha_de_pago
        }
    }

}
