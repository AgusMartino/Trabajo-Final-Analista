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
    public partial class FmrModificarProveedor : Form, IProveedorSeleccionadoLisener
    {
        Proveedor proveedor = new Proveedor();
        public FmrModificarProveedor()
        {
            InitializeComponent();
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if(proveedor.Cuit == null)
                {
                    MessageBox.Show("Debe seleccionar un proveedor".Traducir());
                }
                else
                {
                    //Modificando Proveedor
                    proveedor.Cuit = Int64.Parse(TxtCuit.Text);
                    proveedor.Nombre = TxtNombre.Text;
                    ProveedorService.Current.update(proveedor);
                    TxtNombre.Text = "";
                    TxtCuit.Text = "";
                    MessageBox.Show($"Proveedor modificado".Traducir());
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

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Proveedores
            FmrListarProveedor F = new FmrListarProveedor(this);
            F.Show();
        }

        public void ProveedorSeleccionado(Proveedor proveedor)
        {
            //Obteniendo Proveedor Seleccionado
            TxtCuit.Text = proveedor.Cuit.ToString();
            TxtCuit.Enabled = false;
            TxtNombre.Text = proveedor.Nombre;
        }

        private void FmrModificarProveedor_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("370", helpProvider1, this);
            TraducirForm();
        }
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnBuscarProveedor.Text = BtnBuscarProveedor.Text.Traducir();
            BtnModificarProveedor.Text = BtnModificarProveedor.Text.Traducir();
        }
    }

}
