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
    public partial class FmrListarMateriaPrima : Form
    {
        public IMateriaPrimaSeleccionadoLisener materiaPrimaSeleccionado;
        public FmrListarMateriaPrima(IMateriaPrimaSeleccionadoLisener materiaPrimaSeleccionado)
        {
            InitializeComponent();
            this.materiaPrimaSeleccionado = materiaPrimaSeleccionado;
        }

        private void BtnSeleccionaMateriaPrima_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Materia Prima
                MateriaPrima materiaPrima = new MateriaPrima();
                int i = DtgMateriaPrima.CurrentRow.Index;
                materiaPrima.unidad_de_medida = Unidad_de_medidaService.Current.GetOne(int.Parse(DtgMateriaPrima[1, 0].Value.ToString()));
                materiaPrima.Codigo = DtgMateriaPrima[0, i].Value.ToString();
                materiaPrima.Nombre = DtgMateriaPrima[2, i].Value.ToString();
                materiaPrima.Costo = decimal.Parse(DtgMateriaPrima[3, i].Value.ToString());
                materiaPrimaSeleccionado.MateriaPrimaSeleccionada(materiaPrima);
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

        private void FmrListarMateriaPrima_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("190", helpProvider1, this);
            TraducirForm();
            try
            {
                //Listando Materias Primas
                MateriaPrima materiaPrima = new MateriaPrima();
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                materiaPrimas = (List<MateriaPrima>)MateriaPrimaService.Current.GetAll();
                for (int c = 0; c <= materiaPrimas.Count - 1; c++)
                {
                    materiaPrima = materiaPrimas[c];
                    DtgMateriaPrima.Rows.Add(materiaPrima.Codigo, materiaPrima.unidad_de_medida.idUnindad_de_medida, materiaPrima.Nombre, materiaPrima.Costo);
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
            BtnSeleccionaMateriaPrima.Text = BtnSeleccionaMateriaPrima.Text.Traducir();
        }
    }
}
