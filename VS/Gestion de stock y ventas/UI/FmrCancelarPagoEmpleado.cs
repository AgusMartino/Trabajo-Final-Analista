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
    public partial class FmrCancelarPagoEmpleado : Form, IPagoEmpleadoSeleccionaLisener
    {
        public Pago_Empleado Pago_Empleado = new Pago_Empleado();
        public FmrCancelarPagoEmpleado()
        {
            InitializeComponent();
        }

        public void PagoEmpleadoSeleccionado(Pago_Empleado pago_Empleado)
        {
            //Obteniendo Pago de Empleado
            this.Pago_Empleado.IdPagoEmpleado = pago_Empleado.IdPagoEmpleado;
            this.Pago_Empleado.Empleado = pago_Empleado.Empleado;
            this.Pago_Empleado.MontoPagado = pago_Empleado.MontoPagado;
            this.Pago_Empleado.Fecha_Pago = pago_Empleado.Fecha_Pago;
            DtgPagoEmpleado.Rows.Add(pago_Empleado.IdPagoEmpleado, pago_Empleado.Empleado.Dni, pago_Empleado.Empleado.Nombre, pago_Empleado.MontoPagado, pago_Empleado.Fecha_Pago);
        }

        private void BtnBuscarPago_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Pagos de empleado
            FmrListarPagoEmpleado F = new FmrListarPagoEmpleado(this);
            F.Show();
        }

        private void BtnCancelarPago_Click(object sender, EventArgs e)
        {
            try
            {
                //Cancelando Pago de Empleado
                if(Pago_Empleado.IdPagoEmpleado != null)
                {
                    Pago_empleadoService.Current.delete(Pago_Empleado);
                    DtgPagoEmpleado.Rows.Clear();
                    MessageBox.Show($"Pago de empleado cancelado");
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Pago de Empleado");
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

        private void FmrCancelarPagoEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("80", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            BtnBuscarPago.Text = BtnBuscarPago.Text.Traducir();
            BtnCancelarPago.Text = BtnCancelarPago.Text.Traducir();
        }
    }
}
