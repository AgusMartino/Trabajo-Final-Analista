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
    public partial class FmrPagoEmpleado : Form , IEmpleadoSeleccionadoLisener
    {
        Empleado empleado = new Empleado();
        public FmrPagoEmpleado()
        {
            InitializeComponent();
        }

        public void EmpleadoSeleccionado(Empleado empleado)
        {
            //Obteniendo Empleado
            this.empleado = EmpleadoService.Current.GetOneDni((int)empleado.Dni);
            TxtSeleccionarEmpleado.Text = empleado.Nombre + " " + empleado.Apellido;
        }

        private void BtnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Empleados
            FmrListarEmpleado F = new FmrListarEmpleado(this);
            F.Show();
        }

        private void BtnRealizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtMotoAPagar.Text == null)
                {
                    MessageBox.Show("Debe colocar un monto".Traducir());
                }
                else
                {
                    if (empleado.Dni == null)
                    {
                        MessageBox.Show("Debe seleccionar un empleado".Traducir());
                    }
                    else
                    {
                        //Ingresando Pago de Empleado
                        Pago_Empleado pago_Empleado = new Pago_Empleado();
                        pago_Empleado.Empleado = empleado;
                        pago_Empleado.MontoPagado = decimal.Parse(TxtMotoAPagar.Text);
                        pago_Empleado.Fecha_Pago = DateTime.Now;
                        Pago_empleadoService.Current.insert(pago_Empleado);
                        MessageBox.Show($"Pago de empleado realizado".Traducir());
                    }
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

        private void FmrPagoEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("400", helpProvider1, this);
            TraducirForm();
        }
        private void TraducirForm()
        {
            label2.Text = label2.Text.Traducir();
            BtnRealizarPago.Text = BtnRealizarPago.Text.Traducir();
            BtnSeleccionarEmpleado.Text = BtnSeleccionarEmpleado.Text.Traducir();
        }
    }
}
