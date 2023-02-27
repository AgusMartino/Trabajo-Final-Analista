using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DOMAIN;
using SL.Services.Extensions;
using UI.Lisener;

namespace UI
{
    public partial class FmrListarCliente : Form
    {
        private IClienteSeleccionadoLisener seleccionadoLisener;
        public FmrListarCliente(IClienteSeleccionadoLisener seleccionadoLisener)
        {
            InitializeComponent();
            this.seleccionadoLisener = seleccionadoLisener;
        }

        private void FmrListarCliente_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("170", helpProvider1, this);
            TraducirForm();
            try
            {
                //Listando clientes
                List<Cliente> clientes = new List<Cliente>();
                clientes = (List<Cliente>)ClienteService.Current.GetAll();
                foreach (var item in clientes)
                {
                    DtgClientes.Rows.Add(item.Dni, item.Nombre, item.Apellido, item.Fecha_Nacimiento, item.Direccion);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void DtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Cliente
                Cliente cliente = new Cliente();
                int i = DtgClientes.CurrentRow.Index;
                cliente.Dni = int.Parse(DtgClientes[0, i].Value.ToString());
                cliente.Nombre = DtgClientes[1, i].Value.ToString();
                cliente.Apellido = DtgClientes[2, i].Value.ToString();
                cliente.Fecha_Nacimiento = Convert.ToDateTime(DtgClientes[3, i].Value);
                cliente.Direccion = DtgClientes[4, i].Value.ToString();
                seleccionadoLisener.clienteSeleccionado(cliente);
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
            BtnSeleccionarCliente.Text = BtnSeleccionarCliente.Text.Traducir();
        }
    }
}
