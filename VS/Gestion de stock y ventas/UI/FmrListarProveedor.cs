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
    public partial class FmrListarProveedor : Form
    {
        public IProveedorSeleccionadoLisener proveedorSeleccionadoLisener;
        public FmrListarProveedor(IProveedorSeleccionadoLisener proveedorSeleccionadoLisener)
        {
            InitializeComponent();
            this.proveedorSeleccionadoLisener = proveedorSeleccionadoLisener;
        }

        private void FmrListarProveedor_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("240", helpProvider1, this);
            BtnSeleccionarProveedor.Text = BtnSeleccionarProveedor.Text.Traducir();
            try
            {
                //Listando Proveedores
                List<Proveedor> proveedores = new List<Proveedor>();
                proveedores = (List<Proveedor>)ProveedorService.Current.GetAll();
                foreach (var item in proveedores)
                {
                    DtgProveedor.Rows.Add(item.Cuit, item.Nombre);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString()); ;
            }            
        }

        private void BtnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapendo proveedor
                Proveedor proveedor = new Proveedor();
                int i = DtgProveedor.CurrentRow.Index;
                proveedor.Cuit = Int64.Parse(DtgProveedor[0, i].Value.ToString());
                proveedor.Nombre = DtgProveedor[1, i].Value.ToString();
                proveedorSeleccionadoLisener.ProveedorSeleccionado(proveedor);
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
    }
}
