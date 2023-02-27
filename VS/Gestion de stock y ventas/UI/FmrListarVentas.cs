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
    public partial class FmrListarVentas : Form
    {
        public IVentaSeleccionadoLisener ventaSeleccionadoLisener;
        public FmrListarVentas(IVentaSeleccionadoLisener ventaSeleccionadoLisener)
        {
            InitializeComponent();
            this.ventaSeleccionadoLisener = ventaSeleccionadoLisener;
        }

        private void BtnSeleccionarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Ventas
                Venta venta = new Venta();
                int i = DtgVentas.CurrentRow.Index;
                venta.IdVenta = int.Parse(DtgVentas[0, i].Value.ToString());
                venta.cliente = ClienteService.Current.GetOne(int.Parse(DtgVentas[1, i].Value.ToString()));
                venta.tipo_De_Pago = Tipo_de_pagoService.Current.GetOne(int.Parse(DtgVentas[3, i].Value.ToString()));
                venta.Fecha_de_Venta = DateTime.Parse(DtgVentas[5, i].Value.ToString());
                venta.Total = decimal.Parse(DtgVentas[6, i].Value.ToString());
                ventaSeleccionadoLisener.VentaSeleccionado(venta);
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

        private void FmrListarVentas_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("290", helpProvider1, this);
            try
            {
                //Listando Ventas Del dia de Hoy
                List<Venta> ventas = new List<Venta>();
                DateTime FechaInicio = DateTime.Today;
                DateTime FechaFin = FechaInicio.AddHours(24);
                ventas = (List<Venta>)VentaService.Current.GetVentasEntreFechas(FechaInicio, FechaFin);
                foreach (var item in ventas)
                {
                    DtgVentas.Rows.Add(item.IdVenta, item.cliente.Dni, item.tipo_De_Pago.IdTipo_de_pago, item.tipo_De_Pago.nombre, item.Fecha_de_Venta, item.Total);
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
            try
            {
                TraducirForm();
                DtgVentas.Rows.Clear();
                //Listando Ventas
                List<Venta> ventas = new List<Venta>();
                DateTime FechaInicio = Convert.ToDateTime(DtmInicio);
                DateTime FechaFin = Convert.ToDateTime(DtmFin);
                ventas = (List<Venta>)VentaService.Current.GetVentasEntreFechas(FechaInicio, FechaFin);
                foreach (var item in ventas)
                {
                    DtgVentas.Rows.Add(item.IdVenta, item.cliente.Dni, item.tipo_De_Pago.IdTipo_de_pago, item.tipo_De_Pago.nombre, item.Fecha_de_Venta, item.Total);
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
            BtnSeleccionarVenta.Text = BtnSeleccionarVenta.Text.Traducir();
        }
    }
}
