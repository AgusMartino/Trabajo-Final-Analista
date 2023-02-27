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
    public partial class FmrModificarProducto : Form, IProductoSeleccionadoLisener, IRubroSeleccionadoLisener, IMateriaPrimaSeleccionadoLisener
    {
        Producto producto = new Producto();
        MateriaPrima materiaPrima = new MateriaPrima();
        Rubro rubro = new Rubro();
        public FmrModificarProducto()
        {
            InitializeComponent();
        }

        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima)
        {
            //Obteniendo Materia prima seleccionado
            this.materiaPrima = MateriaPrimaService.Current.GetOneCode(materiaPrima.Codigo);
            this.TxtNombreMateriaPrima.Text = materiaPrima.Nombre;
            this.materiaPrima.unidad_de_medida = materiaPrima.unidad_de_medida;
        }

        public void ProductoSeleccionado(Producto producto)
        {
            //Obteniendo Producto Seleccionado
            this.producto = ProductoService.Current.GetOneCode(producto.CodigoProducto);
            TxtCodigoProducto.Text = producto.CodigoProducto;
            TxtCodigoProducto.Enabled = false;
            TxtNombre.Text = producto.Nombre;
            TxtPrecio.Text = producto.Precio.ToString();
            TxtRubro.Text = producto.rubro.Nombre;
            //Obteniendo Componentes del Producto
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            materiaPrimas = ProductoService.Current.GetMateriaPrimas(producto);
            for (int i = 0; i <= materiaPrimas.Count -1; i++)
            {
                materiaPrimas[i].Costo = materiaPrimas[i].Cantidad * materiaPrimas[i].Costo;
                DtgComponente.Rows.Add(materiaPrimas[i].Codigo, materiaPrimas[i].Nombre, materiaPrimas[i].Cantidad, materiaPrimas[i].unidad_de_medida, materiaPrimas[i].Costo);
                this.producto.Add(materiaPrimas[i]);
            }
        }

        public void RubroSeleccionado(Rubro rubro)
        {
            //Obteniendo Rubro seleccionado
            this.rubro = RubroService.Current.GetOneCode(rubro.Codigo_Rubro);
            TxtRubro.Text = rubro.Nombre;
        }

        private void BtnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Productos
            FmrListarProducto F = new FmrListarProducto(this);
            F.Show();
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(producto.IdProducto == null)
                {
                    MessageBox.Show("Debe seleccionar un producto".Traducir());
                }
                else
                {
                    //Modificando Producto
                    producto.rubro = this.rubro;
                    producto.CodigoProducto = TxtCodigoProducto.Text;
                    producto.Nombre = TxtNombre.Text;
                    producto.Precio = decimal.Parse(TxtPrecio.Text);
                    decimal costo = 0;
                    foreach (var Componente in producto.Componentes)
                    {
                        costo += Componente.Costo;
                    }
                    producto.Costo = costo;
                    ProductoService.Current.update(producto);
                    TxtNombre.Text = "";
                    TxtRubro.Text = "";
                    TxtPrecio.Text = "";
                    TxtCodigoProducto.Text = "";
                    DtgComponente.Rows.Clear();
                    MessageBox.Show($"Producto modificado".Traducir());
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

        private void BtnRemoverComponente_Click(object sender, EventArgs e)
        {
            try
            {
                //Removiendo Componente de listado de componentes del Producto
                int i = DtgComponente.CurrentRow.Index;
                MateriaPrima materiaPrima = new MateriaPrima();
                materiaPrima.Codigo = DtgComponente[0, i].Value.ToString();
                for (int c = 0; c <= producto.Componentes.Count - 1; c++)
                {
                    if (materiaPrima.Codigo == producto.Componentes[c].Codigo)
                    {
                        this.producto.Remove(producto.Componentes[c]);
                        DtgComponente.Rows.RemoveAt(i);
                    }
                }
                MessageBox.Show("Componente Removido".Traducir());
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

        private void BtnAgregarComponente_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtNombreMateriaPrima.Text == null)
                {
                    MessageBox.Show("Debe seleccionar una Materia Prima".Traducir());
                }
                else
                {
                    //Agregando componente a listado de componentes del Producto
                    materiaPrima.Cantidad = decimal.Parse(TxtCantidad.Text);
                    materiaPrima.Costo = materiaPrima.Cantidad * materiaPrima.Costo;
                    producto.Add(
                    new MateriaPrima()
                    {
                        IdMateriaPrima = this.materiaPrima.IdMateriaPrima,
                        Codigo = this.materiaPrima.Codigo,
                        Nombre = this.materiaPrima.Nombre,
                        Costo = this.materiaPrima.Costo,
                        Cantidad = this.materiaPrima.Cantidad,
                        unidad_de_medida = this.materiaPrima.unidad_de_medida
                    }
                    );
                    DtgComponente.Rows.Add(materiaPrima.Codigo, materiaPrima.Nombre, materiaPrima.Cantidad, materiaPrima.Costo);
                    TxtNombreMateriaPrima.Text = "";
                    TxtCantidad.Text = "";
                    MessageBox.Show("Componente Agregado".Traducir());
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

        private void BtnSeleccionarMateriaPrima_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Materias Primas
            FmrListarMateriaPrima F = new FmrListarMateriaPrima(this);
            F.Show();
        }

        private void FmrModificarProducto_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("340", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label8.Text = label8.Text.Traducir();
            BtnAgregarComponente.Text = BtnAgregarComponente.Text.Traducir();
            BtnModificarProducto.Text = BtnModificarProducto.Text.Traducir();
            BtnRemoverComponente.Text = BtnRemoverComponente.Text.Traducir();
            BtnSeleccionarMateriaPrima.Text = BtnSeleccionarMateriaPrima.Text.Traducir();
            BtnSeleccionarProducto.Text = BtnSeleccionarProducto.Text.Traducir();
            BtnSeleccionarRubro.Text = BtnSeleccionarRubro.Text.Traducir();
            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
        }

        private void BtnSeleccionarRubro_Click(object sender, EventArgs e)
        {
            FmrListarRubros F = new FmrListarRubros(this);
            F.Show();
        }
    }
}
