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
using SL.Services.Extensions;

namespace UI
{
    public partial class FmrAltaEmpleado : Form
    {
        Empleado empleado;
        DataSet dts;
        public FmrAltaEmpleado()
        {
            InitializeComponent();
        }

        private void FmrAltaEmpleado_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("20", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label10.Text = label10.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label8.Text = label8.Text.Traducir();
            label9.Text = label9.Text.Traducir();
            BtnCrearEmpleado.Text = BtnCrearEmpleado.Text.Traducir();
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                if (TxtDni.Text == null)
                {
                    MessageBox.Show("El Dni no esta Completo".Traducir());
                }
                else
                {
                    //Crea un nuevo Empleado
                    empleado = new Empleado();
                    empleado.Apellido = TxtApellido.Text;
                    empleado.Nombre = TxtNombre.Text;
                    empleado.Dni = int.Parse(TxtDni.Text);
                    empleado.Fecha_nacimiento = DtmFecha_de_nacimiento.Value;
                    empleado.Direccion = TxtDireccion.Text;
                    validador = EmpleadoService.Current.ValidacionInt((int)empleado.Dni);
                    if(validador == true)
                    {
                        MessageBox.Show("El Dni ya existe".Traducir());
                    }
                    else
                    {
                        EmpleadoService.Current.insert(empleado);
                        TxtNombre.Text = "";
                        TxtDni.Text = "";
                        TxtDireccion.Text = "";
                        TxtApellido.Text = "";
                        DtmFecha_de_nacimiento.Value = DateTime.Now;
                        MessageBox.Show("Empleado dado de alta".Traducir());
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

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Dni");
            lista.Add("Nombre");
            lista.Add("Apellido");
            lista.Add("Direccion");
            lista.Add("Fecha de nacimiento");
            ExcelService.Current.ExportExcel(lista);
        }

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            dts = new DataSet();
            dts = ExcelService.Current.ImportExcel(DtgImport, TxtPathArchivo);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            DtgImport.DataSource = dts.Tables[0];
        }
    }
}
