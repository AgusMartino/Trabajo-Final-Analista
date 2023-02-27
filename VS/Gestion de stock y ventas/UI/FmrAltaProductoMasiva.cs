using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FmrAltaProductoMasiva : Form
    {
        DataSet dtsProducto;
        DataSet dtsComponente;
        public FmrAltaProductoMasiva()
        {
            InitializeComponent();
        }

        private void btnExportarArchivoProducto_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Nombre");
            lista.Add("CodigoProducto");
            lista.Add("Precio");
            lista.Add("CodigoRubro");
            ExcelService.Current.ExportExcel(lista);
        }

        private void BtnImportarArchivoProducto_Click(object sender, EventArgs e)
        {
            dtsProducto = new DataSet();
            ExcelService.Current.ImportExcel(DtgImportProducto, TxtPathArchivoProducto);
        }

        private void btnMostrarDatosProducto_Click(object sender, EventArgs e)
        {
            DtgImportProducto.DataSource = dtsProducto.Tables[0];
        }

        private void BtnExportarArchivoComponentes_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("CodigoMateriaPrima");
            lista.Add("CodigoProducto");
            lista.Add("Cantidad");
            ExcelService.Current.ExportExcel(lista);
        }

        private void BtnImportarArchivoComponentes_Click(object sender, EventArgs e)
        {
            dtsComponente = new DataSet();
            dtsComponente = ExcelService.Current.ImportExcel(DtgImportComponentes, TxtPathArchivoProducto);
        }

        private void BtnMostrarDatosComponentes_Click(object sender, EventArgs e)
        {
            DtgImportComponentes.DataSource = dtsComponente.Tables[0];
        }
    }
}
