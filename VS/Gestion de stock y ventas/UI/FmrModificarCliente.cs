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
    public partial class FmrModificarCliente : Form, IClienteSeleccionadoLisener
    {
        Cliente cliente = new Cliente();
        public FmrModificarCliente()
        {
            InitializeComponent();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Dni == null)
                {
                    MessageBox.Show("Debe seleccionar un Cliente".Traducir());
                }
                else
                {
                    //Modificando Cliente
                    cliente.Dni = int.Parse(TxtDni.Text);
                    cliente.Apellido = TxtApellido.Text;
                    cliente.Fecha_Nacimiento = DtmFecha_de_nacimiento.Value;
                    cliente.Nombre = TxtNombre.Text;
                    cliente.Direccion = TxtDireccion.Text;
                    ClienteService.Current.update(cliente);
                    TxtApellido.Text = "";
                    TxtDireccion.Text = "";
                    TxtDni.Text = "";
                    TxtNombre.Text = "";
                    DtmFecha_de_nacimiento.Value = DateTime.Now;
                    MessageBox.Show($"Cliente modificado".Traducir());
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

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Clientes
            FmrListarCliente F = new FmrListarCliente(this);
            F.Show();
        }

        private void FmrModificarCliente_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("310", helpProvider1, this);
            TraducirForm();
        }

        public void clienteSeleccionado(Cliente cliente)
        {
            //Obteniendo Cliente
            TxtApellido.Text = cliente.Apellido;
            TxtDni.Text = cliente.Dni.ToString();
            TxtDni.Enabled = false;
            DtmFecha_de_nacimiento.Value = (DateTime)cliente.Fecha_Nacimiento;
            TxtNombre.Text = cliente.Nombre;
            TxtDireccion.Text = cliente.Direccion;
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            BtnBuscarCliente.Text = BtnBuscarCliente.Text.Traducir();
            BtnModificarCliente.Text = BtnModificarCliente.Text.Traducir();
        }
    }
}
