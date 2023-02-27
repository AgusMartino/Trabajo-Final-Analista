using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMAIN;
using BLL.Services;
using UI.Lisener;
using SL.Services.Extensions;

namespace UI
{
    public partial class FmrModificarEmpleado : Form, IEmpleadoSeleccionadoLisener
    {
        private Empleado empleado = new Empleado();
        public FmrModificarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleado.Dni == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado".Traducir()); ;
                }
                else
                {
                    //Modificando Empleado
                    empleado.Nombre = TxtNombre.Text;
                    empleado.Apellido = TxtApellido.Text;
                    empleado.Direccion = TxtDireccion.Text;
                    empleado.Dni = int.Parse(TxtDni.Text);
                    empleado.Fecha_nacimiento = DtmFecha_de_nacimiento.Value;
                    EmpleadoService.Current.update(empleado);
                    TxtApellido.Text = "";
                    TxtDireccion.Text = "";
                    TxtDni.Text = "";
                    TxtNombre.Text = "";
                    DtmFecha_de_nacimiento.Value = DateTime.Now;
                    MessageBox.Show($"Empleado modificado".Traducir());
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

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Empleado
            FmrListarEmpleado F = new FmrListarEmpleado(this);
            F.Show();
        }

        public void EmpleadoSeleccionado(Empleado empleado)
        {
            //Obteniendo Empleado seleccionado
            TxtNombre.Text = empleado.Nombre;
            TxtApellido.Text = empleado.Apellido;
            TxtDireccion.Text = empleado.Direccion;
            TxtDni.Text = empleado.Dni.ToString();
            TxtDni.Enabled = false;
            DtmFecha_de_nacimiento.Value = empleado.Fecha_nacimiento;
        }

        private void FmrModificarEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("320", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            BtnBuscarEmpleado.Text = BtnBuscarEmpleado.Text.Traducir();
            BtnModificarEmpleado.Text = BtnModificarEmpleado.Text.Traducir();
        }
    }
}
