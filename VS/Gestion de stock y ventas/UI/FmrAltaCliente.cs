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

namespace UI
{
    public partial class FmrAltaCliente : Form
    {
        Cliente cliente;
        DataSet dts;
        public FmrAltaCliente()
        {
            InitializeComponent();
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
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
                    //Crea un nuevo Cliente
                    cliente = new Cliente();
                    cliente.Nombre = TxtNombre.Text;
                    cliente.Apellido = TxtApellido.Text;
                    cliente.Dni = int.Parse(TxtDni.Text);
                    cliente.Fecha_Nacimiento = DtmFecha_de_nacimiento.Value;
                    cliente.Direccion = TxtDireccion.Text;
                    validador = ClienteService.Current.ValidacionInt((int)cliente.Dni);
                    if (validador == true)
                    {
                        MessageBox.Show("El Dni ya existe".Traducir());
                    }
                    else
                    {
                        ClienteService.Current.insert(cliente);
                        TxtApellido.Text = "";
                        TxtDireccion.Text = "";
                        TxtDni.Text = "";
                        TxtNombre.Text = "";
                        DtmFecha_de_nacimiento.Value = DateTime.Now;
                        MessageBox.Show("Cliente dado de alta".Traducir());
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

        private void FmrAltaCliente_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("10", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            BtnCrearCliente.Text = BtnCrearCliente.Text.Traducir();
        }

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Nombre");
            lista.Add("Apellido");
            lista.Add("Fecha de nacimiento");
            lista.Add("Direccion");
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
