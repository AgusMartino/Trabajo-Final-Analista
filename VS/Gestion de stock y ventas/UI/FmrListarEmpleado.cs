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
    public partial class FmrListarEmpleado : Form
    {
        private IEmpleadoSeleccionadoLisener empleadoSeleccionadoLisener;
        public FmrListarEmpleado(IEmpleadoSeleccionadoLisener empleadoSeleccionadoLisener)
        {
            
            InitializeComponent();
            this.empleadoSeleccionadoLisener = empleadoSeleccionadoLisener;
        }

        private void FmrListarEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("180", helpProvider1, this);
            TraducirForm();
            try
            {
                //Listando Empleados
                List<Empleado> empleados = new List<Empleado>();
                empleados = (List<Empleado>)EmpleadoService.Current.GetAll();
                foreach (var item in empleados)
                {
                    DtgEmpleados.Rows.Add(item.Dni, item.Nombre, item.Apellido, item.Fecha_nacimiento, item.Direccion);
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

        private void BtnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Empleado
                Empleado empleado = new Empleado();
                int i = DtgEmpleados.CurrentRow.Index;
                empleado.Dni = int.Parse(DtgEmpleados[0, i].Value.ToString());
                empleado.Nombre = DtgEmpleados[1, i].Value.ToString();
                empleado.Apellido = DtgEmpleados[2, i].Value.ToString();
                empleado.Fecha_nacimiento = DateTime.Parse(DtgEmpleados[3, i].Value.ToString());
                empleado.Direccion = DtgEmpleados[4, i].Value.ToString();
                empleadoSeleccionadoLisener.EmpleadoSeleccionado(empleado);
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
        private void TraducirForm()
        {
            BtnSeleccionarEmpleado.Text = BtnSeleccionarEmpleado.Text.Traducir();
        }
    }
}
