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
    public partial class FmrPagoServicio : Form, IServicioSeleccionadoLisener
    {
        Servicio servicio = new Servicio();
        public FmrPagoServicio()
        {
            InitializeComponent();
        }

        public void ServicioSeleccionado(Servicio servicio)
        {
            //Obteniendo Servicios
            this.servicio = ServicioService.Current.GetOneCode(servicio.CodigoServicio);
            TxtServicio.Text = servicio.Nombre;
        }

        private void BtnSeleccioarServicio_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Servicios
            FmrListarServicio F = new FmrListarServicio(this);
            F.Show();
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(servicio.CodigoServicio == null)
                {
                    MessageBox.Show("Debe seleccionar un servicio");
                }
                else
                {
                    //Ingresando Pago de Servicio
                    Pago_Servicio pago_Servicio = new Pago_Servicio();
                    pago_Servicio.servicio = servicio;
                    pago_Servicio.MontoPagado = decimal.Parse(TxtMotoAPagar.Text);
                    pago_Servicio.Fecha_Pago = DateTime.Now;
                    Pago_servicioService.Current.insert(pago_Servicio);
                    MessageBox.Show($"Pago de servicio realizado");
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

        private void FmrPagoServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("420", helpProvider1, this);
            TraducirForm();
        }
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            BtnRealizarVenta.Text = BtnRealizarVenta.Text.Traducir();
            BtnSeleccioarServicio.Text = BtnSeleccioarServicio.Text.Traducir();
        }
    }
}
