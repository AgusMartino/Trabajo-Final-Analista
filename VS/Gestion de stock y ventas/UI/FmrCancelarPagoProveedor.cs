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
    public partial class FmrCancelarPagoProveedor : Form, IPagoProveedorSeleccionadoLisener
    {
        Pago_Proveedor Pago_Proveedor = new Pago_Proveedor();
        public FmrCancelarPagoProveedor()
        {
            InitializeComponent();
        }

        public void PagoProveedorSeleccionado(Pago_Proveedor pago_Proveedor)
        {
            //Obteniendo Pago de Proveedor
            this.Pago_Proveedor.IdPagoProveedor = pago_Proveedor.IdPagoProveedor;
            this.Pago_Proveedor.proveedor = pago_Proveedor.proveedor;
            this.Pago_Proveedor.Monto_adeudado = pago_Proveedor.Monto_adeudado;
            this.Pago_Proveedor.Monto_pagado = pago_Proveedor.Monto_pagado;
            this.Pago_Proveedor.Total = pago_Proveedor.Total;
            this.Pago_Proveedor.Fecha_Pago = pago_Proveedor.Fecha_Pago;
            TxtProveedor.Text = pago_Proveedor.proveedor.Nombre;
            TxtDeudaAnterior.Text = pago_Proveedor.Monto_adeudado.ToString();
            TxtPagado.Text = pago_Proveedor.Monto_pagado.ToString();
            TxtTotalApagar.Text = pago_Proveedor.Total.ToString();
            DtmfechaDePago.Value = pago_Proveedor.Fecha_Pago;
            //Obteniendo Oredenes de compra Relacionadas al Pago de Proveedor
            this.Pago_Proveedor.Orden_De_Compras = (List<Orden_de_Compra>)Orden_de_compraService.Current.GetOrdenesDeCompra((int)pago_Proveedor.IdPagoProveedor);
            decimal subtotal = 0;
            foreach (var item in this.Pago_Proveedor.Orden_De_Compras)
            {
                DtgOrdenDeCompra.Rows.Add(item.IdOrden_de_compra, item.materiaPrima.Nombre, item.Cantidad, item.Subtotal);
                subtotal = item.Subtotal + subtotal;
            }
            TxtSubtotal.Text = subtotal.ToString();
        }

        private void BtnBuscarPagoProveedor_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Pagos de Proveedor
            FmrListarPagoProveedores F = new FmrListarPagoProveedores(this);
            F.Show();
        }

        private void BtnCancelarPago_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando de seleccion de Pago de proveedor
                if (Pago_Proveedor.IdPagoProveedor != null)
                {
                    //Cancelando Pago del Proveedor
                    Pago_proveedorService.Current.delete(Pago_Proveedor);
                    DtgOrdenDeCompra.Rows.Clear();
                    TxtDeudaAnterior.Text = "";
                    TxtPagado.Text = "";
                    TxtProveedor.Text = "";
                    TxtSubtotal.Text = "";
                    TxtTotalApagar.Text = "";
                    DtmfechaDePago.Value = DateTime.Now;
                    MessageBox.Show($"Pago de proveedor Cancelado".Traducir());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un pago de proveedor".Traducir());
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
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            BtnBuscarPagoProveedor.Text = BtnBuscarPagoProveedor.Text.Traducir();
            BtnCancelarPago.Text = BtnCancelarPago.Text.Traducir();
        }

        private void FmrCancelarPagoProveedor_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("90", helpProvider1, this);
            TraducirForm();
        }
    }
}
