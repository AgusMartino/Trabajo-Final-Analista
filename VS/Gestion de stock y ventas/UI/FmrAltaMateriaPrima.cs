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
    public partial class FmrAltaMateriaPrima : Form
    {
        List<Unidad_De_Medida> unidad_De_Medidas = new List<Unidad_De_Medida>();
        DataSet dts;
        public FmrAltaMateriaPrima()
        {
            InitializeComponent();
        }

        private void BtnAltaMateriaPrima_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                if(TxtCodigoMateriaPrima.Text == null)
                {
                    MessageBox.Show("Codigo de Materia Prima Faltante".Traducir());
                }
                //Crear Materia Prima
                MateriaPrima materiaPrima = new MateriaPrima();
                materiaPrima.Codigo = TxtCodigoMateriaPrima.Text;
                materiaPrima.Costo = decimal.Parse(TxtCosto.Text);
                materiaPrima.Nombre = TxtNombre.Text;
                materiaPrima.unidad_de_medida = (Unidad_De_Medida)cmbunidadDeMedida.SelectedItem;
                validador = MateriaPrimaService.Current.ValidacionString(materiaPrima.Codigo);
                if(validador == true)
                {
                    MessageBox.Show("El Codigo ya existe".Traducir());
                }
                else
                {
                    MateriaPrimaService.Current.insert(materiaPrima);
                    TxtCodigoMateriaPrima.Text = "";
                    TxtCosto.Text = "";
                    TxtNombre.Text = "";
                    cmbunidadDeMedida.SelectedItem = 0;
                    MessageBox.Show("Materia Prima dada de alta".Traducir());
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

        private void FmrAltaMateriaPrima_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("30", helpProvider1, this);
            try
            {
                //Listando Unidades de Medida
                unidad_De_Medidas = (List<Unidad_De_Medida>)Unidad_de_medidaService.Current.GetAll();
                cmbunidadDeMedida.DataSource = unidad_De_Medidas;
                cmbunidadDeMedida.DisplayMember = "Unidad_de_medida";
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                Console.WriteLine(ex);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
        private void Traducir()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            BtnAltaMateriaPrima.Text = BtnAltaMateriaPrima.Text.Traducir();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("CodigoMateriaPrima");
            lista.Add("Nombre");
            lista.Add("UnidadDeMedida");
            lista.Add("Costo");
            ExcelService.Current.ExportExcel(lista);

        }

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            dts = new DataSet();
            dts = ExcelService.Current.ImportExcel(DtgImport, TxtPathArchivo);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            DtgImport.DataSource = dts.Tables[0];
        }
    }
}
