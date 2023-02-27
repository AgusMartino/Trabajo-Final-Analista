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
    public partial class FmrModificarMateriaPrima : Form , IMateriaPrimaSeleccionadoLisener
    {
        MateriaPrima materiaPrima = new MateriaPrima();
        public FmrModificarMateriaPrima()
        {
            InitializeComponent();
        }

        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima)
        {
            //Obteniendo Materia Prima
            this.materiaPrima = MateriaPrimaService.Current.GetOneCode(materiaPrima.Codigo);
            TxtCodigoMateriaPrima.Text = materiaPrima.Codigo;
            TxtCodigoMateriaPrima.Enabled = false;
            TxtCosto.Text = materiaPrima.Costo.ToString();
            TxtNombre.Text = materiaPrima.Nombre;
        }

        private void BtnBuscarMateriaPrima_Click(object sender, EventArgs e)
        {
            //Mostrando Lista de Materias Primas
            FmrListarMateriaPrima F = new FmrListarMateriaPrima(this);
            F.Show();
        }

        private void BtnModificarMateriaPrima_Click(object sender, EventArgs e)
        {
            try
            {
                if(materiaPrima.IdMateriaPrima == null)
                {
                    MessageBox.Show("Debe seleccionar una materia prima".Traducir());
                }
                else
                {
                    //Modificando Materia Prima
                    materiaPrima.Codigo = TxtCodigoMateriaPrima.Text;
                    materiaPrima.Costo = decimal.Parse(TxtCosto.Text);
                    materiaPrima.Nombre = TxtNombre.Text;
                    MateriaPrimaService.Current.update(materiaPrima);
                    TxtNombre.Text = "";
                    TxtCosto.Text = "";
                    TxtCodigoMateriaPrima.Text = "";
                    MessageBox.Show($"Materia prima modificada".Traducir());
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

        private void FmrModificarMateriaPrima_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("330", helpProvider1, this);
            TraducirForm();
        }
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            BtnBuscarMateriaPrima.Text = BtnBuscarMateriaPrima.Text.Traducir();
            BtnModificarMateriaPrima.Text = BtnModificarMateriaPrima.Text.Traducir();
        }
    }
}
