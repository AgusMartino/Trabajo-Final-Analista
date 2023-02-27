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
    public partial class FmrListarPagoServicio : Form
    {
        public IPagoServicioSeleciconadoLisener pagoServicioSeleciconado;
        public FmrListarPagoServicio(IPagoServicioSeleciconadoLisener pagoServicioSeleciconado)
        {
            InitializeComponent();
            this.pagoServicioSeleciconado = pagoServicioSeleciconado;
        }

        private void BtnSeleccionarPagoServicio_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapenando Pago servicio
                Pago_Servicio pago_Servicio = new Pago_Servicio();
                int i = DtgPagoServicio.CurrentRow.Index;
                pago_Servicio.IdPagoServicio = int.Parse(DtgPagoServicio[0, i].Value.ToString());
                pago_Servicio.servicio = ServicioService.Current.GetOneCode(DtgPagoServicio[1, i].Value.ToString());
                pago_Servicio.MontoPagado = decimal.Parse(DtgPagoServicio[3, i].Value.ToString());
                pago_Servicio.Fecha_Pago = DateTime.Parse(DtgPagoServicio[4, i].Value.ToString());
                pagoServicioSeleciconado.PagoServicioSeleccionado(pago_Servicio);
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

        private void FmrListarPagoServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("220", helpProvider1, this);
            TraducirForm();
            try
            {
                //Listando Pago servicio
                List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
                Pago_Servicio pago_Servicio = new Pago_Servicio();
                DateTime dateTimeInicio = DateTime.Today;
                DateTime dateTimeFin = dateTimeInicio.AddHours(24);
                pago_Servicios = (List<Pago_Servicio>)Pago_servicioService.Current.GetPagoEntreFechas(dateTimeInicio, dateTimeFin);
                foreach (var item in pago_Servicios)
                {
                    DtgPagoServicio.Rows.Add(item.IdPagoServicio, item.servicio.CodigoServicio, item.servicio.Nombre, item.MontoPagado, item.Fecha_Pago);
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
            BtnSeleccionarPagoServicio.Text = BtnSeleccionarPagoServicio.Text.Traducir();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pago_Servicio> pago_Servicios = new List<Pago_Servicio>();
                DateTime dateTimeInicio = DtmInicio.Value;
                DateTime dateTimeFin = DtmFin.Value;
                pago_Servicios = (List<Pago_Servicio>)Pago_empleadoService.Current.GetPagoEntreFechas(dateTimeInicio, dateTimeFin);
                DtgPagoServicio.Rows.Clear();
                foreach (var item in pago_Servicios)
                {
                    DtgPagoServicio.Rows.Add(item.IdPagoServicio, item.servicio.CodigoServicio, item.servicio.Nombre, item.MontoPagado, item.Fecha_Pago);
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
    }
}
