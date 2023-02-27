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
    public partial class FmrAltaProducto : Form, IRubroSeleccionadoLisener, IMateriaPrimaSeleccionadoLisener
    {
        MateriaPrima materiaPrima = new MateriaPrima();
        Producto producto = new Producto();
        Rubro rubro = new Rubro();
        public FmrAltaProducto()
        {
            InitializeComponent();
        }
        public void RubroSeleccionado(Rubro rubro)
        {
            //Obtiene el rubro seleccionado
            this.rubro = RubroService.Current.GetOneCode(rubro.Codigo_Rubro);
            TxtRubro.Text = rubro.Nombre;
            TxtRubro.Enabled = false;
        }

        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima)
        {
            //Obtiene Materia Prima seleccionada
            this.materiaPrima = MateriaPrimaService.Current.GetOneCode(materiaPrima.Codigo);
            TxtNombreMateriaPrima.Text = materiaPrima.Nombre;
        }

        private void BtnSeleccionarRubro_Click(object sender, EventArgs e)
        {
            //Muestra Lista de Rubros
            FmrListarRubros F = new FmrListarRubros(this);
            F.Show();
        }

        private void BtnSeleccionarMateriaPrima_Click(object sender, EventArgs e)
        {
            //Muestra Lista de Materias Primas
            FmrListarMateriaPrima F = new FmrListarMateriaPrima(this);
            F.Show();
        }

        private void BtnAgregarComponente_Click(object sender, EventArgs e)
        {
            try
            {
                if (materiaPrima.IdMateriaPrima == null)
                {
                    MessageBox.Show("Debe seleccionar Una Materia Prima".Traducir());
                }
                else
                {
                    //Agrega Materia prima seleccionada como componente del nuevo Producto
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
                    DtgComponente.Rows.Add(materiaPrima.Codigo, materiaPrima.Nombre, materiaPrima.Cantidad, materiaPrima.unidad_de_medida.Unidad_de_medida, materiaPrima.Costo);
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

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                //Validando si el producto contiene componentes
                if (producto.CantidadDeComponentes > 0)
                {
                    //Creando Producto
                    producto.Nombre = TxtNombre.Text;
                    producto.CodigoProducto = TxtCodigoProducto.Text;
                    producto.rubro = this.rubro;
                    producto.Precio = decimal.Parse(TxtPrecio.Text);
                    decimal costo = 0;
                    foreach (var Componente in producto.Componentes)
                    {
                        costo += Componente.Costo;
                    }
                    producto.Costo = costo;
                    validador = ProductoService.Current.ValidacionString(producto.CodigoProducto);
                    if (validador == true)
                    {
                        MessageBox.Show("El codigo ya existe".Traducir());
                    }
                    else
                    {
                        ProductoService.Current.insert(producto);
                        TxtNombre.Text = "";
                        TxtRubro.Text = "";
                        TxtPrecio.Text = "";
                        TxtCodigoProducto.Text = "";
                        DtgComponente.Rows.Clear();
                        MessageBox.Show("Producto dado de alta".Traducir());
                    }
                }
                else
                {
                    MessageBox.Show("El producto debe tener un componente".Traducir());
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
                //Removiendo Componente de Producto
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

        private void FmrAltaProducto_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("40", helpProvider1, this);
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
            BtnCrearProducto.Text = BtnCrearProducto.Text.Traducir();
            BtnRemoverComponente.Text = BtnRemoverComponente.Text.Traducir();
            BtnSeleccionarMateriaPrima.Text = BtnSeleccionarMateriaPrima.Text.Traducir();
            BtnSeleccionarRubro.Text = BtnSeleccionarRubro.Text.Traducir();
            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
        }
    }
}
