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
    public partial class FmrCancelarVenta : Form, IVentaSeleccionadoLisener
    {
        Venta venta = new Venta();
        List<Orden_de_Venta> orden_De_Ventas = new List<Orden_de_Venta>();
        public FmrCancelarVenta()
        {
            InitializeComponent();
        }

        public void VentaSeleccionado(Venta venta)
        {
            //Obteniendo Vennta seleccionada
            this.venta = venta;
            TxtCodigoVenta.Text = venta.IdVenta.ToString();
            TxtCliente.Text = venta.cliente.Apellido + " " + venta.cliente.Nombre;
            TxtFechadeVenta.Text = venta.Fecha_de_Venta.ToString();
            TxtPrecio.Text = venta.Total.ToString();
            this.venta.Orden_De_Ventas = (List<Orden_de_Venta>)Orden_de_ventaService.Current.GetOrdenes((int)venta.IdVenta);
            foreach (var item in this.venta.Orden_De_Ventas)
            {
                DtgVenta.Rows.Add(item.producto.IdProducto, item.producto.Nombre, item.Cantidad, item.Subtotal);
            }
        }

        private void BtnSeleccionarVenta_Click(object sender, EventArgs e)
        {
            //MOstrando Lista de ventas
            FmrListarVentas F = new FmrListarVentas(this);
            F.Show();
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (TurnoIniciadoCache.IdTurno == null)
                {
                    //UIException
                    MessageBox.Show("Tiene que iniciar un turno".Traducir());
                }
                if (venta.IdVenta == null)
                {
                    MessageBox.Show("Debe Seleccionar una Venta".Traducir());
                }
                else
                {
                    //Cancelando Venta
                    VentaService.Current.delete(venta);
                    DtgVenta.Rows.Clear();
                    TxtCliente.Text = "";
                    TxtCodigoVenta.Text = "";
                    TxtFechadeVenta.Text = "";
                    TxtPrecio.Text = "";
                    MessageBox.Show($"Venta cancelada".Traducir());
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

        private void FmrCancelarVenta_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("110", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            BtnCancelarVenta.Text = BtnCancelarVenta.Text.Traducir();
            BtnSeleccionarVenta.Text = BtnSeleccionarVenta.Text.Traducir();
        }
    }
}
