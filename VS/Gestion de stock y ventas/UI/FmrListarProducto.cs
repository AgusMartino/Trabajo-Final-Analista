using BLL.Services;
using DOMAIN.Productos;
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
    public partial class FmrListarProducto : Form
    {
        List<Producto> productos = new List<Producto>();
        public IProductoSeleccionadoLisener productoSeleccionadoLisener;

        public FmrListarProducto(IProductoSeleccionadoLisener productoSeleccionadoLisener)
        {
            InitializeComponent();
            this.productoSeleccionadoLisener = productoSeleccionadoLisener;
        }

        private void BtnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Producto
                Producto producto = new Producto();
                int i = DtgProductos.CurrentRow.Index;
                producto.rubro = RubroService.Current.GetOneCode(DtgProductos[0, i].Value.ToString());
                producto.CodigoProducto = DtgProductos[1, i].Value.ToString();
                producto.Nombre = DtgProductos[2, i].Value.ToString();
                producto.Precio = decimal.Parse(DtgProductos[3, i].Value.ToString());
                producto.Costo = decimal.Parse(DtgProductos[4, i].Value.ToString());
                productoSeleccionadoLisener.ProductoSeleccionado(producto);
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

        private void FmrListarProducto_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("230", helpProvider1, this);
            BtnSeleccionarProducto.Text = BtnSeleccionarProducto.Text.Traducir();
            try
            {
                //Listando Productos
                Producto producto = new Producto();
                productos = (List<Producto>)ProductoService.Current.GetAll();
                //DtgProductos.DataSource = productos;
                for (int c = 0; c <= productos.Count - 1; c++)
                {
                    producto = productos[c];
                    DtgProductos.Rows.Add(producto.rubro.Codigo_Rubro, producto.CodigoProducto, producto.Nombre, producto.Precio, producto.Costo);
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
    }
}
