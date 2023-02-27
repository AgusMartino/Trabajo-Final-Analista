using System;
using System.Collections.Generic;

namespace DOMAIN
{
    public class Pago_Proveedor
    {
        public Nullable<int> IdPagoProveedor { get; set; }
        public Proveedor proveedor { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Total { get; set; }
        public decimal Monto_pagado { get; set; }
        public decimal Monto_adeudado { get; set; }

        public List<Orden_de_Compra> Orden_De_Compras = new List<Orden_de_Compra>();
        public void Add(Orden_de_Compra component)
        {
            Orden_De_Compras.Add(component);
        }
        public void Remove(Orden_de_Compra componet)
        {
            Orden_De_Compras.Remove(componet);
        }


    }
}
