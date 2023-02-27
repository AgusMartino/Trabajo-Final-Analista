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
    public sealed class Pago_proveedorAdapter : IEntityAdapter<Pago_Proveedor>
    {
        #region Singleton
        private readonly static Pago_proveedorAdapter _instance = new Pago_proveedorAdapter();

        public static Pago_proveedorAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private Pago_proveedorAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion
        public Pago_Proveedor Adapt(object[] values)
        {
            return new Pago_Proveedor
            {
                IdPagoProveedor = int.Parse(values[(int)Colums.IdPagoProveedor].ToString()),
                proveedor = Factory.Current.GetProveedorRepository().GetOne(int.Parse(values[(int)Colums.IdProveedor].ToString())),
                Fecha_Pago = DateTime.Parse(values[(int)Colums.Fecha_de_pago].ToString()),
                Total = decimal.Parse(values[(int)Colums.Total].ToString()),
                Monto_pagado = decimal.Parse(values[(int)Colums.MontoPagado].ToString()),
                Monto_adeudado = decimal.Parse(values[(int)Colums.MontoAdeudado].ToString())
            };
        }
        private enum Colums
        {
            IdPagoProveedor,
            IdProveedor,
            Fecha_de_pago,
            Total,
            MontoPagado,
            MontoAdeudado
        }
    }

}
