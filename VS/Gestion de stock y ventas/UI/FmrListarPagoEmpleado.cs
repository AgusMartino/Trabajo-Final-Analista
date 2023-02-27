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
    public partial class FmrListarPagoEmpleado : Form
    {
        public IPagoEmpleadoSeleccionaLisener pagoEmpleadoseleccionadoLisener;
        public FmrListarPagoEmpleado(IPagoEmpleadoSeleccionaLisener pagoEmpleadoseleccionadoLisener)
        {
            InitializeComponent();
            this.pagoEmpleadoseleccionadoLisener = pagoEmpleadoseleccionadoLisener;
        }

        private void BtnSeleccionarPagoEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Pago Empleado
                Pago_Empleado pago_Empleado = new Pago_Empleado();
                int i = DtgPagoEmpleado.CurrentRow.Index;
                pago_Empleado.IdPagoEmpleado = int.Parse(DtgPagoEmpleado[0, i].Value.ToString());
                pago_Empleado.Empleado = EmpleadoService.Current.GetOne(int.Parse(DtgPagoEmpleado[1, i].Value.ToString()));
                pago_Empleado.MontoPagado = decimal.Parse(DtgPagoEmpleado[3, i].Value.ToString());
                pago_Empleado.Fecha_Pago = DateTime.Parse(DtgPagoEmpleado[4, i].Value.ToString());
                pagoEmpleadoseleccionadoLisener.PagoEmpleadoSeleccionado(pago_Empleado);
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

        private void FmrListarPagoEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("200", helpProvider1, this);
            try
            {
                //Listando Pagos de Empleados Del dia de Hoy
                Pago_Empleado pago_Empleado = new Pago_Empleado();
                List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
                DateTime FechaInicio = DateTime.Today;
                DateTime FechaFin = FechaInicio.AddHours(24);
                pago_Empleados = (List<Pago_Empleado>)Pago_empleadoService.Current.GetPagoEntreFechas(FechaInicio, FechaFin);
                foreach (var item in pago_Empleados)
                {
                    DtgPagoEmpleado.Rows.Add(item.IdPagoEmpleado, item.Empleado.Dni ,item.Empleado.Nombre, item.MontoPagado, item.Fecha_Pago);
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
                //Listando Pagos de Empleados De los dias Seleccionados
                Pago_Empleado pago_Empleado = new Pago_Empleado();
                List<Pago_Empleado> pago_Empleados = new List<Pago_Empleado>();
                DateTime FechaInicio = Convert.ToDateTime(DtmInicio);
                DateTime FechaFin = Convert.ToDateTime(DtmFin);
                pago_Empleados = (List<Pago_Empleado>)Pago_empleadoService.Current.GetPagoEntreFechas(FechaInicio, FechaFin);
                foreach (var item in pago_Empleados)
                {
                    DtgPagoEmpleado.Rows.Add(item.IdPagoEmpleado, item.Empleado.Dni, item.Empleado.Nombre, item.MontoPagado, item.Fecha_Pago);
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
            BtnSeleccionarPagoEmpleado.Text = BtnSeleccionarPagoEmpleado.Text.Traducir();
        }
    }
}
