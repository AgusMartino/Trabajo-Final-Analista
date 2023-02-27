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
    public partial class FmrGestionInventario : Form, IMateriaPrimaSeleccionadoLisener
    {
        MateriaPrima materiaPrima = new MateriaPrima();
        public FmrGestionInventario()
        {
            InitializeComponent();
        }

        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima)
        {
            //Obteniendo Materia Prima Seleccionada
            this.materiaPrima.IdMateriaPrima = materiaPrima.IdMateriaPrima;
            this.materiaPrima.Nombre = materiaPrima.Nombre;
            this.materiaPrima.Codigo = materiaPrima.Codigo;
            TxtMateriaPrima.Text = materiaPrima.Nombre;
        }

        private void BtnSeleccionarMateriaPrima_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Materias Primas
            FmrListarMateriaPrima F = new FmrListarMateriaPrima(this);
            F.Show();
        }

        private void BtnIngresarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (materiaPrima.IdMateriaPrima == null)
                {
                    MessageBox.Show("Debe seleccionar una Materia Prima".Traducir());
                }
                else
                {
                    if (TxtCantidad.Text == null)
                    {
                        MessageBox.Show("Debe colocar una cantidad".Traducir());
                    }
                    else
                    {
                        //Ingresando cantidad de Materia prima en Inventario
                        Inventario inventario = new Inventario();
                        inventario.materiaPrima = this.materiaPrima;
                        inventario.Cantidad = int.Parse(TxtCantidad.Text) * 1;
                        InventarioService.Current.update(inventario);
                        TxtCantidad.Text = "";
                        TxtMateriaPrima.Text = "";
                        MessageBox.Show($"Ingreso de Materia Prima exitoso".Traducir());
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

        private void BtnEgresarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (materiaPrima.IdMateriaPrima == null)
                {
                    MessageBox.Show("Debe seleccionar una Materia Prima".Traducir());
                }
                else
                {
                    if (TxtCantidad.Text == null)
                    {
                        MessageBox.Show("Debe colocar una cantidad".Traducir());
                    }
                    else
                    {
                        //Egresando cantidad de Materia prima en Inventario
                        Inventario inventario = new Inventario();
                        inventario.materiaPrima = this.materiaPrima;
                        inventario.Cantidad = int.Parse(TxtCantidad.Text) * -1;
                        InventarioService.Current.update(inventario);
                        TxtCantidad.Text = "";
                        TxtMateriaPrima.Text = "";
                        MessageBox.Show($"Egreso de Materia Prima exitoso".Traducir());
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

        private void FmrGestionInventario_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("140", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            BtnEgresarInventario.Text = BtnEgresarInventario.Text.Traducir();
            BtnIngresarInventario.Text = BtnIngresarInventario.Text.Traducir();
            BtnSeleccionarMateriaPrima.Text = BtnSeleccionarMateriaPrima.Text.Traducir();
        }
    }
}
