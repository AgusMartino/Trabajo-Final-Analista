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
using SL.Services.Extensions;

namespace UI
{
    public partial class FmrAltaRubro : Form
    {
        private Rubro rubro;
        DataSet dts;
        public FmrAltaRubro()
        {
            InitializeComponent();
        }

        private void BtnCrearRubro_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                if (TxtCodigoRubro.Text == null)
                {
                    MessageBox.Show("Debe Tener un Codigo de Rubro".Traducir());
                }
                else
                {
                    //Creando Rubro
                    rubro = new Rubro();
                    rubro.Codigo_Rubro = TxtCodigoRubro.Text;
                    rubro.Nombre = TxtNombre.Text;
                    validador = RubroService.Current.ValidacionString(rubro.Codigo_Rubro);
                    if (validador == true)
                    {
                        MessageBox.Show("El codigo ya existe".Traducir());
                    }
                    else
                    {

                        RubroService.Current.insert(rubro);
                        TxtCodigoRubro.Text = "";
                        TxtNombre.Text = "";
                        MessageBox.Show("Rubro dado de alta".Traducir());
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

        private void FmrAltaRubro_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("50", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnCrearRubro.Text = BtnCrearRubro.Text.Traducir();
        }

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            dts = new DataSet();
            dts = ExcelService.Current.ImportExcel(DtgImport, TxtPathArchivo);
        }

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Codigo Rubro");
            lista.Add("Nombre");
            ExcelService.Current.ExportExcel(lista);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            DtgImport.DataSource = dts.Tables[0];
        }
    }
}
