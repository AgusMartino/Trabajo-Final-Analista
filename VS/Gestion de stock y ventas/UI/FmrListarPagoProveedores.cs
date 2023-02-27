using BLL.Services;
using DOMAIN;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Lisener;

namespace UI
{
    public partial class FmrListarPagoProveedores : Form
    {
        public IPagoProveedorSeleccionadoLisener pagoProveedorSeleccionado;
        public FmrListarPagoProveedores(IPagoProveedorSeleccionadoLisener pagoProveedorSeleccionado)
        {
            InitializeComponent();
            this.pagoProveedorSeleccionado = pagoProveedorSeleccionado;
        }

        private void BtnSeleccionarPagoProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapenando Pago Proveedor
                Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
                int i = DtgPagoProveedor.CurrentRow.Index;
                pago_Proveedor.IdPagoProveedor = int.Parse(DtgPagoProveedor[0, i].Value.ToString());
                pago_Proveedor.proveedor = ProveedorService.Current.GetOne(int.Parse(DtgPagoProveedor[1, i].Value.ToString()));
                pago_Proveedor.Monto_pagado = decimal.Parse(DtgPagoProveedor[3, i].Value.ToString());
                pago_Proveedor.Monto_adeudado = decimal.Parse(DtgPagoProveedor[4, i].Value.ToString());
                pago_Proveedor.Total = decimal.Parse(DtgPagoProveedor[5, i].Value.ToString());
                pago_Proveedor.Fecha_Pago = DateTime.Parse(DtgPagoProveedor[6, i].Value.ToString());
                pagoProveedorSeleccionado.PagoProveedorSeleccionado(pago_Proveedor);
                this.Hide();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }            
        }

        private void FmrListarPagoProveedores_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("210", helpProvider1, this);
            try
            {
                //Listando Pagos de Proveedor del dia de Hoy
                List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
                DateTime FechaInicio = DateTime.Today;
                DateTime FechaFin = FechaInicio.AddHours(24);
                pago_Proveedors = (List<Pago_Proveedor>)Pago_proveedorService.Current.GetPagoEntreFechas(FechaInicio, FechaFin);
                for (int i = 0; i <= pago_Proveedors.Count - 1; i++)
                {
                    Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
                    pago_Proveedor = pago_Proveedors[i];
                    DtgPagoProveedor.Rows.Add(pago_Proveedor.IdPagoProveedor, pago_Proveedor.proveedor.Cuit, pago_Proveedor.proveedor.Nombre, pago_Proveedor.Monto_pagado, pago_Proveedor.Monto_adeudado, pago_Proveedor.Total, pago_Proveedor.Fecha_Pago);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }          
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TraducirForm();
            try
            {
                //Listando Pagos de Proveedor de las fechas selecioonadas
                List<Pago_Proveedor> pago_Proveedors = new List<Pago_Proveedor>();
                DateTime FechaInicio = Convert.ToDateTime(DtmInicio);
                DateTime FechaFin = Convert.ToDateTime(DtmFin);
                pago_Proveedors = (List<Pago_Proveedor>)Pago_proveedorService.Current.GetPagoEntreFechas(FechaInicio, FechaFin);
                for (int i = 0; i <= pago_Proveedors.Count - 1; i++)
                {
                    Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
                    pago_Proveedor = pago_Proveedors[i];
                    DtgPagoProveedor.Rows.Add(pago_Proveedor.IdPagoProveedor, pago_Proveedor.proveedor.Cuit, pago_Proveedor.proveedor.Nombre, pago_Proveedor.Monto_pagado, pago_Proveedor.Monto_adeudado, pago_Proveedor.Total, pago_Proveedor.Fecha_Pago);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnBuscar.Text = BtnBuscar.Text.Traducir();
            BtnSeleccionarPagoProveedor.Text = BtnSeleccionarPagoProveedor.Text.Traducir();
        }
    }
}
