using BLL.Services;
using DOMAIN;
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
    public partial class FmrRealizarVenta : Form, IClienteSeleccionadoLisener, IProductoSeleccionadoLisener 
    {
        List<Tipo_de_pago> tipo_De_Pagos = new List<Tipo_de_pago>();
        Cliente cliente = new Cliente();
        Producto producto = new Producto();
        Venta venta = new Venta();
        public FmrRealizarVenta()
        {
            InitializeComponent();
        }

        public void clienteSeleccionado(Cliente cliente)
        {
            //Obteniendo Cliente Seleccionado
            this.cliente = ClienteService.Current.GetOneDni((int)cliente.Dni);
            TxtCliente.Text = cliente.Apellido + " " + cliente.Nombre;
        }
        public void ProductoSeleccionado(Producto producto)
        {
            //Obteniendo Producto seleccionado
            this.producto = ProductoService.Current.GetOneCode(producto.CodigoProducto);
            TxtProducto.Text = producto.Nombre;
        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Clientes
            FmrListarCliente F = new FmrListarCliente(this);
            F.Show();
        }

        private void BtnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Productos
            FmrListarProducto F = new FmrListarProducto(this);
            F.Show();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtProducto.Text == null)
                {
                    MessageBox.Show("Debe seleccionar un producto".Traducir());
                }
                else
                {
                    //Agregando Producto a Orden de venta
                    venta.Add(new Orden_de_Venta
                    {
                        producto = this.producto,
                        Cantidad = decimal.Parse(TxtCantidad.Text),
                        Subtotal = decimal.Parse(TxtCantidad.Text) * this.producto.Precio
                    });
                    DtgOrdenVenta.Rows.Add(producto.CodigoProducto, producto.Nombre, producto.Cantidad, producto.Cantidad * producto.Precio);
                    //Calculando Total
                    decimal total = 0;
                    foreach (var item in venta.Orden_De_Ventas)
                    {
                        total = item.Subtotal + total;
                    }
                    TxtTotal.Text = total.ToString();
                    TxtProducto.Text = "";
                    TxtCantidad.Text = "";
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void FmrRealizarVenta_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("440", helpProvider1, this);
            TraducirForm();
            //Listando Tipos de pagos
            tipo_De_Pagos = (List<Tipo_de_pago>)Tipo_de_pagoService.Current.GetAll();
            CmbMetodoPago.DataSource = tipo_De_Pagos;
            CmbMetodoPago.DisplayMember = "nombre";
        }

        private void BtnRemoverproducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Remover Prodcuto de la lista de orden de venta
                int i = DtgOrdenVenta.CurrentRow.Index;
                Producto producto = new Producto();
                producto.IdProducto = int.Parse(DtgOrdenVenta[0, i].Value.ToString());
                for (int c = 0; c <= venta.Orden_De_Ventas.Count - 1; c++)
                {
                    if (producto.IdProducto == venta.Orden_De_Ventas[c].producto.IdProducto)
                    {
                        this.venta.Remove(venta.Orden_De_Ventas[c]);
                        DtgOrdenVenta.Rows.RemoveAt(i);
                    }
                }
                //Calculo Total
                decimal value = 0;
                foreach (var item in venta.Orden_De_Ventas)
                {
                    value = item.Subtotal + value;
                }
                TxtTotal.Text = value.ToString();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (TurnoIniciadoCache.IdTurno == null)
                {
                    MessageBox.Show("Tiene que iniciar un turno".Traducir());
                }
                else
                {
                    //Ingresando Venta
                    venta.tipo_De_Pago = (Tipo_de_pago)CmbMetodoPago.SelectedItem;
                    venta.cliente = cliente;
                    venta.Fecha_de_Venta = DateTime.Now;
                    venta.Total = decimal.Parse(TxtTotal.Text);
                    VentaService.Current.insert(venta);
                    TxtCantidad.Text = "";
                    TxtCliente.Text = "";
                    TxtProducto.Text = "";
                    TxtTotal.Text = "";
                    DtgOrdenVenta.Rows.Clear();
                    MessageBox.Show("Venta Realizada".Traducir());

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
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            BtnAgregarProducto.Text = BtnAgregarProducto.Text.Traducir();
            BtnRealizarVenta.Text = BtnRealizarVenta.Text.Traducir();
            BtnRemoverproducto.Text = BtnRemoverproducto.Text.Traducir();
            BtnSeleccionarCliente.Text = BtnSeleccionarCliente.Text.Traducir();
            BtnSeleccionarProducto.Text = BtnSeleccionarProducto.Text.Traducir();
        }
    }
}
