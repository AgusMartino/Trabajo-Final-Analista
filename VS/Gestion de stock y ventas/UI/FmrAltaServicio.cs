using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DOMAIN;
using SL.Services.Extensions;

namespace UI
{
    public partial class FmrAltaServicio : Form
    {
        private Servicio servicio;
        DataSet Dts;
        public FmrAltaServicio()
        {
            InitializeComponent();
        }

        private void BtnCrearServicio_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                if (TxtCodigoServicio.Text == null)
                {
                    MessageBox.Show("Debe Tener un Codigo de Servicio".Traducir());
                }
                else
                {
                    //Creando Servicio
                    servicio = new Servicio();
                    servicio.CodigoServicio = TxtCodigoServicio.Text;
                    servicio.Nombre = TxtNombre.Text;
                    validador = ServicioService.Current.ValidacionString(servicio.CodigoServicio);
                    if (validador == true)
                    {
                        MessageBox.Show("El codigo ya existe".Traducir());
                    }
                    else
                    {
                        ServicioService.Current.insert(servicio);
                        TxtCodigoServicio.Text = "";
                        TxtNombre.Text = "";
                        MessageBox.Show("Servicio dado de alta".Traducir());
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

        private void FmrAltaServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("60", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnCrearServicio.Text = BtnCrearServicio.Text.Traducir();
        }

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("CodigoServicio");
            lista.Add("Nombre");
            ExcelService.Current.ExportExcel(lista);
        }

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            Dts = new DataSet();
            Dts = ExcelService.Current.ImportExcel(DtgImport, TxtPathArchivo);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            DtgImport.DataSource = Dts.Tables[0];
        }
    }
}
