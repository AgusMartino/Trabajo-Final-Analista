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
    public partial class FmrCancelarPagoServicio : Form, IPagoServicioSeleciconadoLisener
    {
        Pago_Servicio Pago_Servicio = new Pago_Servicio();
        public FmrCancelarPagoServicio()
        {
            InitializeComponent();
        }

        public void PagoServicioSeleccionado(Pago_Servicio pago_Servicio)
        {
            //Obteniendo Pago de servicio
            this.Pago_Servicio.IdPagoServicio = pago_Servicio.IdPagoServicio;
            this.Pago_Servicio.servicio = pago_Servicio.servicio;
            this.Pago_Servicio.MontoPagado = pago_Servicio.MontoPagado;
            this.Pago_Servicio.Fecha_Pago = pago_Servicio.Fecha_Pago;
            DtgPagoServicio.Rows.Add(pago_Servicio.IdPagoServicio, pago_Servicio.servicio.CodigoServicio, pago_Servicio.servicio.Nombre, pago_Servicio.MontoPagado, pago_Servicio.Fecha_Pago);
        }

        private void BtnBuscarPagoServicio_Click(object sender, EventArgs e)
        {
            // Mostranndo Listado de Pagos de Servicio
            FmrListarPagoServicio F = new FmrListarPagoServicio(this);
            F.Show();
        }

        private void BtnCancelarPago_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando seleccion de Pago de servicio
                if(Pago_Servicio.IdPagoServicio != null)
                {
                    //Cancelando Pago de servicio
                    Pago_servicioService.Current.delete(Pago_Servicio);
                    DtgPagoServicio.Rows.Clear();
                    MessageBox.Show($"Pago de servicio cancelado");
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Pago de servicio");
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

        private void FmrCancelarPagoServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("100", helpProvider1, this);
            TraducirForm();
        }
        
        private void TraducirForm()
        {
            BtnBuscarPagoServicio.Text = BtnBuscarPagoServicio.Text.Traducir();
            BtnCancelarPago.Text = BtnCancelarPago.Text.Traducir();
        }
    }
}
